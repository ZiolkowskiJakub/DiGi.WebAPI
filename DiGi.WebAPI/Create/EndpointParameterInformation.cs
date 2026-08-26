using DiGi.WebAPI.Classes;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Reflection;

namespace DiGi.WebAPI
{
    public static partial class Create
    {
        /// <summary>
        /// Extracts parameter metadata from a <see cref="ParameterDescriptor"/> instance.
        /// </summary>
        /// <param name="parameterDescriptor">The parameter descriptor to extract metadata from.</param>
        /// <returns>A new <see cref="EndpointParameterInformation"/> instance, or null if the parameter descriptor is null.</returns>
        public static EndpointParameterInformation? EndpointParameterInformation(this ParameterDescriptor? parameterDescriptor)
        {
            if (parameterDescriptor is null)
            {
                return null;
            }

            string name = parameterDescriptor.Name;
            string source = parameterDescriptor.BindingInfo?.BindingSource?.DisplayName ?? "ModelBinding";

            Type parameterType = parameterDescriptor.ParameterType;
            string typeName = parameterType?.Name ?? "Unknown";

            bool isNullable = false;
            bool hasDefaultValue = false;

            if (parameterDescriptor is ControllerParameterDescriptor controllerParameterDescriptor)
            {
                ParameterInfo parameterInfo = controllerParameterDescriptor.ParameterInfo;
                hasDefaultValue = parameterInfo.HasDefaultValue;

                if (parameterType is not null)
                {
                    if (Nullable.GetUnderlyingType(parameterType) != null)
                    {
                        isNullable = true;
                    }
                    else if (!parameterType.IsValueType)
                    {
                        NullabilityInfoContext nullabilityInfoContext = new();
                        NullabilityInfo nullabilityInfo = nullabilityInfoContext.Create(parameterInfo);
                        isNullable = nullabilityInfo.ReadState == NullabilityState.Nullable;
                    }
                }
            }
            else if (parameterType is not null && Nullable.GetUnderlyingType(parameterType) != null)
            {
                isNullable = true;
            }

            return new EndpointParameterInformation(name, source, typeName, isNullable, hasDefaultValue);
        }
    }
}
