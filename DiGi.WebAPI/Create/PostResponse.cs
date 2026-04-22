using DiGi.WebAPI.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        public static async Task<PostResponse<T?>> PostResponse<T>(this HttpContent httpContent, CancellationToken cancellationToken = default)
        {
            if (httpContent is null)
            {
                return new PostResponse<T?>(true, true);
            }

            Type type = typeof(T);

            Serilog.Modify.Log("Response value type: {TypeName}", type.Name);

            if (type == typeof(string))
            {
                Serilog.Modify.Log("Converting string");

                string content = await httpContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                return new PostResponse<T?>(true, true, (T)(object)content);
            }
            else if (type.IsPrimitive)
            {
                Serilog.Modify.Log("Converting primitive");

                string content = await httpContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                if (!Core.Query.TryConvert(content, out T? result))
                {
                    return new PostResponse<T?>(true, true);
                }

                return new PostResponse<T?>(true, true, result);
            }
            else if (typeof(Core.Interfaces.ISerializableObject).IsAssignableFrom(type))
            {
                Serilog.Modify.Log("Converting SerializableObject");

                string json = await httpContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                Core.Interfaces.ISerializableObject? serializableObject = Core.Convert.ToDiGi<Core.Interfaces.ISerializableObject>(json)?.FirstOrDefault();
                if (serializableObject is T result)
                {
                    return new PostResponse<T?>(true, true, result);
                }

                return new PostResponse<T?>(true, true);
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                Serilog.Modify.Log("Converting enumerable");

                Type[] genericTypes = type.GetGenericArguments();
                if (genericTypes != null && genericTypes.Length == 1)
                {
                    Type genericType = genericTypes[0];

                    if (typeof(Core.Interfaces.ISerializableObject).IsAssignableFrom(genericType))
                    {
                        string json = await httpContent.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        List<Core.Interfaces.ISerializableObject>? serializableObjects = Core.Convert.ToDiGi<Core.Interfaces.ISerializableObject>(json);
                        if (serializableObjects is not null)
                        {
                            IList? list = Core.Create.List(genericType);
                            if (list != null)
                            {
                                foreach (Core.Interfaces.ISerializableObject serializableObject in serializableObjects)
                                {
                                    if (genericType.IsAssignableFrom(serializableObject.GetType()))
                                    {
                                        list.Add(serializableObject);
                                    }
                                }

                                if (Activator.CreateInstance(typeof(T), list) is T result)
                                {
                                    return new PostResponse<T?>(true, true, result);
                                }
                            }
                        }
                    }
                }
            }

            try
            {
                Serilog.Modify.Log("Converting from directly json");

                T? result = await httpContent.ReadFromJsonAsync<T>(new JsonSerializerOptions { PropertyNameCaseInsensitive = true }, cancellationToken).ConfigureAwait(false);
                return new PostResponse<T?>(true, true, result);
            }
            catch
            {
            }

            return new PostResponse<T?>(true, true);
        }
    }
}