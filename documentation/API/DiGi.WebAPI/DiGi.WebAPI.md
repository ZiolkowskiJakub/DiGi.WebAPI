#### [DiGi\.WebAPI](DiGi.WebAPI.Overview.md 'DiGi\.WebAPI\.Overview')

## DiGi\.WebAPI Namespace
### Classes

<a name='DiGi.WebAPI.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.WebAPI.Create.ControllerInformation(thisSystem.Reflection.TypeInfo)'></a>

## Create\.ControllerInformation\(this TypeInfo\) Method

Extracts controller metadata from a [System\.Reflection\.TypeInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.typeinfo 'System\.Reflection\.TypeInfo') instance\.

```csharp
public static DiGi.WebAPI.Classes.ControllerInformation? ControllerInformation(this System.Reflection.TypeInfo? typeInfo);
```
#### Parameters

<a name='DiGi.WebAPI.Create.ControllerInformation(thisSystem.Reflection.TypeInfo).typeInfo'></a>

`typeInfo` [System\.Reflection\.TypeInfo](https://learn.microsoft.com/en-us/dotnet/api/system.reflection.typeinfo 'System\.Reflection\.TypeInfo')

The type information of the controller\.

#### Returns
[ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation')  
A [ControllerInformation\(this TypeInfo\)](DiGi.WebAPI.md#DiGi.WebAPI.Create.ControllerInformation(thisSystem.Reflection.TypeInfo) 'DiGi\.WebAPI\.Create\.ControllerInformation\(this System\.Reflection\.TypeInfo\)') instance with the controller metadata, or null if the type info is null\.

<a name='DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken)'></a>

## Create\.PostResponse\<T\>\(this HttpContent, CancellationToken\) Method

Deserializes HTTP response content into the specified type with intelligent type detection\.

```csharp
public static System.Threading.Tasks.Task<DiGi.WebAPI.Classes.PostResponse<T?>> PostResponse<T>(this System.Net.Http.HttpContent httpContent, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Type parameters

<a name='DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken).T'></a>

`T`

The target type to deserialize into\.
#### Parameters

<a name='DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken).httpContent'></a>

`httpContent` [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')

The HTTP content to deserialize\.

<a name='DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to cancel the operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[DiGi\.WebAPI\.Classes\.PostResponse&lt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[T](DiGi.WebAPI.md#DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken).T 'DiGi\.WebAPI\.Create\.PostResponse\<T\>\(this System\.Net\.Http\.HttpContent, System\.Threading\.CancellationToken\)\.T')[&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A [PostResponse&lt;T&gt;\(this HttpContent, CancellationToken\)](DiGi.WebAPI.md#DiGi.WebAPI.Create.PostResponse_T_(thisSystem.Net.Http.HttpContent,System.Threading.CancellationToken) 'DiGi\.WebAPI\.Create\.PostResponse\<T\>\(this System\.Net\.Http\.HttpContent, System\.Threading\.CancellationToken\)') containing the deserialized result\.

<a name='DiGi.WebAPI.Create.UrlBuilder(thisstring)'></a>

## Create\.UrlBuilder\(this string\) Method

Parses a URL string and creates a [UrlBuilder\(this string\)](DiGi.WebAPI.md#DiGi.WebAPI.Create.UrlBuilder(thisstring) 'DiGi\.WebAPI\.Create\.UrlBuilder\(this string\)') with the base URL and query parameters\.

```csharp
public static DiGi.WebAPI.Classes.UrlBuilder? UrlBuilder(this string url);
```
#### Parameters

<a name='DiGi.WebAPI.Create.UrlBuilder(thisstring).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URL string to parse\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
A [UrlBuilder\(this string\)](DiGi.WebAPI.md#DiGi.WebAPI.Create.UrlBuilder(thisstring) 'DiGi\.WebAPI\.Create\.UrlBuilder\(this string\)') instance, or null if the URL is null or whitespace\.

<a name='DiGi.WebAPI.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.WebAPI.Modify.PostAsync(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.PostAsync\(this HttpClient, string, HttpContent, PostOptions\) Method

Performs an HTTP POST operation without requesting the response result\.

```csharp
public static System.Threading.Tasks.Task<DiGi.WebAPI.Classes.PostResponse> PostAsync(this System.Net.Http.HttpClient httpClient, string? requestUri, System.Net.Http.HttpContent? httpContent, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.WebAPI.Modify.PostAsync(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client to use for the request\.

<a name='DiGi.WebAPI.Modify.PostAsync(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).requestUri'></a>

`requestUri` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URI to send the request to\.

<a name='DiGi.WebAPI.Modify.PostAsync(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).httpContent'></a>

`httpContent` [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')

The HTTP content to send in the request body\.

<a name='DiGi.WebAPI.Modify.PostAsync(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[PostResponse](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse 'DiGi\.WebAPI\.Classes\.PostResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A [PostResponse](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse 'DiGi\.WebAPI\.Classes\.PostResponse') indicating the success or failure of the operation\.

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.PostAsync\<T\>\(this HttpClient, string, HttpContent, PostOptions\) Method

Performs an HTTP POST operation and deserializes the response into the specified type\.

```csharp
public static System.Threading.Tasks.Task<DiGi.WebAPI.Classes.PostResponse<T?>> PostAsync<T>(this System.Net.Http.HttpClient httpClient, string? requestUri, System.Net.Http.HttpContent? httpContent, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Type parameters

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).T'></a>

`T`

The type of the response result\.
#### Parameters

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client to use for the request\.

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).requestUri'></a>

`requestUri` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URI to send the request to\.

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).httpContent'></a>

`httpContent` [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')

The HTTP content to send in the request body\.

<a name='DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[DiGi\.WebAPI\.Classes\.PostResponse&lt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[T](DiGi.WebAPI.md#DiGi.WebAPI.Modify.PostAsync_T_(thisSystem.Net.Http.HttpClient,string,System.Net.Http.HttpContent,DiGi.WebAPI.Classes.PostOptions).T 'DiGi\.WebAPI\.Modify\.PostAsync\<T\>\(this System\.Net\.Http\.HttpClient, string, System\.Net\.Http\.HttpContent, DiGi\.WebAPI\.Classes\.PostOptions\)\.T')[&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A [PostResponse&lt;T&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') containing the deserialized result or failure information\.

<a name='DiGi.WebAPI.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Query\.GetAsync\<T\>\(this HttpClient, string, PostOptions\) Method

Performs an HTTP GET operation and deserializes the response into the specified type\.

[PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions') and [PostResponse&lt;T&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') are shared by the GET and POST helpers - [Delay](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions.Delay 'DiGi\.WebAPI\.Classes\.PostOptions\.Delay') bounds the request and [RequestResult](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions.RequestResult 'DiGi\.WebAPI\.Classes\.PostOptions\.RequestResult') controls whether the response body is materialised.

```csharp
public static System.Threading.Tasks.Task<DiGi.WebAPI.Classes.PostResponse<T?>> GetAsync<T>(this System.Net.Http.HttpClient? httpClient, string? requestUri, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Type parameters

<a name='DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions).T'></a>

`T`

The type of the response result\.
#### Parameters

<a name='DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client to use for the request\.

<a name='DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions).requestUri'></a>

`requestUri` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URI to send the request to\.

<a name='DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the GET operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[DiGi\.WebAPI\.Classes\.PostResponse&lt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[T](DiGi.WebAPI.md#DiGi.WebAPI.Query.GetAsync_T_(thisSystem.Net.Http.HttpClient,string,DiGi.WebAPI.Classes.PostOptions).T 'DiGi\.WebAPI\.Query\.GetAsync\<T\>\(this System\.Net\.Http\.HttpClient, string, DiGi\.WebAPI\.Classes\.PostOptions\)\.T')[&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A [PostResponse&lt;T&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') containing the deserialized result or failure information\.

<a name='DiGi.WebAPI.Query.Path_TControllerBase_(string)'></a>

## Query\.Path\<TControllerBase\>\(string\) Method

Combines the controller route and method route into a full path\.

```csharp
public static string? Path<TControllerBase>(string? methodName)
    where TControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase;
```
#### Type parameters

<a name='DiGi.WebAPI.Query.Path_TControllerBase_(string).TControllerBase'></a>

`TControllerBase`

The type of the controller base\.
#### Parameters

<a name='DiGi.WebAPI.Query.Path_TControllerBase_(string).methodName'></a>

`methodName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the method to include in the path\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The combined route path, or null if the controller route is not available\.

<a name='DiGi.WebAPI.Query.Route_TControllerBase_()'></a>

## Query\.Route\<TControllerBase\>\(\) Method

Retrieves the route template from the controller base type\.

```csharp
public static string? Route<TControllerBase>()
    where TControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase;
```
#### Type parameters

<a name='DiGi.WebAPI.Query.Route_TControllerBase_().TControllerBase'></a>

`TControllerBase`

The type of the controller base\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The route template string, or null if no route is configured\.

<a name='DiGi.WebAPI.Query.Route_TControllerBase_(string)'></a>

## Query\.Route\<TControllerBase\>\(string\) Method

Retrieves the route template for a specific method on the controller\.

```csharp
public static string? Route<TControllerBase>(string methodName)
    where TControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase;
```
#### Type parameters

<a name='DiGi.WebAPI.Query.Route_TControllerBase_(string).TControllerBase'></a>

`TControllerBase`

The type of the controller base\.
#### Parameters

<a name='DiGi.WebAPI.Query.Route_TControllerBase_(string).methodName'></a>

`methodName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the method to retrieve the route for\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The method route template, or empty string if no route is found\.