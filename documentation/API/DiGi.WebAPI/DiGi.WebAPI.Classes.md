#### [DiGi\.WebAPI](DiGi.WebAPI.Overview.md 'DiGi\.WebAPI\.Overview')

## DiGi\.WebAPI\.Classes Namespace
### Classes

<a name='DiGi.WebAPI.Classes.ControllerInformation'></a>

## ControllerInformation Class

Holds metadata about a controller, including its name, assembly information, and version\.

```csharp
public class ControllerInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ControllerInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(DiGi.WebAPI.Classes.ControllerInformation)'></a>

## ControllerInformation\(ControllerInformation\) Constructor

Initializes a new instance of the [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') class by copying from another instance\.

```csharp
public ControllerInformation(DiGi.WebAPI.Classes.ControllerInformation? controllerInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(DiGi.WebAPI.Classes.ControllerInformation).controllerInformation'></a>

`controllerInformation` [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation')

The [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string)'></a>

## ControllerInformation\(string, string, string, string\) Constructor

Initializes a new instance of the [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') class with the specified metadata\.

```csharp
public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The controller name\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string).assemblyName'></a>

`assemblyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the assembly containing the controller\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string).version'></a>

`version` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The assembly version\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string).informationalVersion'></a>

`informationalVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The informational version of the assembly\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(System.Text.Json.Nodes.JsonObject)'></a>

## ControllerInformation\(JsonObject\) Constructor

Initializes a new instance of the [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') class from a JSON object\.

```csharp
public ControllerInformation(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.ControllerInformation.AssemblyName'></a>

## ControllerInformation\.AssemblyName Property

Gets the name of the assembly containing the controller\.

```csharp
public string? AssemblyName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.ControllerInformation.InformationalVersion'></a>

## ControllerInformation\.InformationalVersion Property

Gets the informational version of the assembly\.

```csharp
public string? InformationalVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.ControllerInformation.Name'></a>

## ControllerInformation\.Name Property

Gets the name of the controller\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.ControllerInformation.Version'></a>

## ControllerInformation\.Version Property

Gets the version of the assembly containing the controller\.

```csharp
public string? Version { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.InformationController'></a>

## InformationController Class

Provides API endpoints for retrieving controller metadata and application version information\.

```csharp
public class InformationController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [WebAPIController](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.WebAPIController 'DiGi\.WebAPI\.Classes\.WebAPIController') → InformationController
### Constructors

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager)'></a>

## InformationController\(ApplicationPartManager\) Constructor

Initializes a new instance of the [InformationController](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.InformationController 'DiGi\.WebAPI\.Classes\.InformationController') class\.

```csharp
public InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager applicationPartManager);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager).applicationPartManager'></a>

`applicationPartManager` [Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.applicationparts.applicationpartmanager 'Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager')

The application part manager used for controller discovery\.
### Fields

<a name='DiGi.WebAPI.Classes.InformationController.applicationPartManager'></a>

## InformationController\.applicationPartManager Field

Manages application parts for controller discovery\.

```csharp
private readonly ApplicationPartManager applicationPartManager;
```

#### Field Value
[Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.applicationparts.applicationpartmanager 'Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager')
### Methods

<a name='DiGi.WebAPI.Classes.InformationController.GetControllersAsync()'></a>

## InformationController\.GetControllersAsync\(\) Method

Retrieves a list of all registered controllers in the application\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetControllersAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A JSON string containing controller information, or an empty response if no controllers are found\.

<a name='DiGi.WebAPI.Classes.InformationController.GetVersionAsync()'></a>

## InformationController\.GetVersionAsync\(\) Method

Retrieves the version of the executing assembly\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetVersionAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The assembly version as a string, or an empty response if unavailable\.

<a name='DiGi.WebAPI.Classes.Parameter'></a>

## Parameter Class

Abstract class for input parameters for endpoint\.

```csharp
public abstract class Parameter : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → Parameter
### Constructors

<a name='DiGi.WebAPI.Classes.Parameter.Parameter()'></a>

## Parameter\(\) Constructor

Initializes a new instance of the [Parameter](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.Parameter 'DiGi\.WebAPI\.Classes\.Parameter') class\.

```csharp
public Parameter();
```

<a name='DiGi.WebAPI.Classes.Parameter.Parameter(DiGi.WebAPI.Classes.Parameter)'></a>

## Parameter\(Parameter\) Constructor

Initializes a new instance of the [Parameter](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.Parameter 'DiGi\.WebAPI\.Classes\.Parameter') class by copying another instance of the same type\.

```csharp
public Parameter(DiGi.WebAPI.Classes.Parameter parameter);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.Parameter.Parameter(DiGi.WebAPI.Classes.Parameter).parameter'></a>

`parameter` [Parameter](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.Parameter 'DiGi\.WebAPI\.Classes\.Parameter')

The [Parameter](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.Parameter 'DiGi\.WebAPI\.Classes\.Parameter') instance to copy from\.

<a name='DiGi.WebAPI.Classes.Parameter.Parameter(System.Text.Json.Nodes.JsonObject)'></a>

## Parameter\(JsonObject\) Constructor

Initializes a new instance of the [Parameter](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.Parameter 'DiGi\.WebAPI\.Classes\.Parameter') class using the specified JSON object\.

```csharp
public Parameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.Parameter.Parameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') that contains the initialization data\.

<a name='DiGi.WebAPI.Classes.PostOptions'></a>

## PostOptions Class

Holds configuration options for POST operations, including delay and result request settings\.

```csharp
public class PostOptions : DiGi.Core.Classes.SerializableOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → PostOptions
### Constructors

<a name='DiGi.WebAPI.Classes.PostOptions.PostOptions()'></a>

## PostOptions\(\) Constructor

Initializes a new instance of the [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions') class\.

```csharp
public PostOptions();
```

<a name='DiGi.WebAPI.Classes.PostOptions.PostOptions(DiGi.WebAPI.Classes.PostOptions)'></a>

## PostOptions\(PostOptions\) Constructor

Initializes a new instance of the [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions') class by copying from another instance\.

```csharp
public PostOptions(DiGi.WebAPI.Classes.PostOptions? postOptions);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.PostOptions.PostOptions(DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions')

The [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions') to copy from\.

<a name='DiGi.WebAPI.Classes.PostOptions.PostOptions(System.Text.Json.Nodes.JsonObject)'></a>

## PostOptions\(JsonObject\) Constructor

Initializes a new instance of the [PostOptions](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostOptions 'DiGi\.WebAPI\.Classes\.PostOptions') class from a JSON object\.

```csharp
public PostOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.PostOptions.PostOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.PostOptions.Delay'></a>

## PostOptions\.Delay Property

Gets or sets the delay duration for the POST operation\.

This bounds a single attempt, not the whole operation - a retried request gets the full delay again.

```csharp
public System.TimeSpan Delay { get; set; }
```

#### Property Value
[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

<a name='DiGi.WebAPI.Classes.PostOptions.RequestResult'></a>

## PostOptions\.RequestResult Property

Gets or sets a value indicating whether the response result should be requested\.

```csharp
public bool RequestResult { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.PostOptions.RetryCount'></a>

## PostOptions\.RetryCount Property

Gets or sets how many additional attempts are made after a transient failure\. Zero disables retrying\.

Only transient conditions are retried - see [IsTransient\(this HttpStatusCode\)](DiGi.WebAPI.md#DiGi.WebAPI.Query.IsTransient(thisSystem.Net.HttpStatusCode) 'DiGi\.WebAPI\.Query\.IsTransient\(this System\.Net\.HttpStatusCode\)'). A response that indicates a genuine fault, such as 400 or 500, fails on the first attempt.

```csharp
public int RetryCount { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.PostOptions.RetryDelay'></a>

## PostOptions\.RetryDelay Property

Gets or sets the wait before the first retry\. The wait doubles after each further attempt\.

```csharp
public System.TimeSpan RetryDelay { get; set; }
```

#### Property Value
[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

<a name='DiGi.WebAPI.Classes.PostResponse'></a>

## PostResponse Class

Represents a non\-generic POST response with a boolean result\.

```csharp
public class PostResponse : DiGi.WebAPI.Classes.PostResponse<bool>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.WebAPI\.Classes\.PostResponse&lt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') → PostResponse
### Constructors

<a name='DiGi.WebAPI.Classes.PostResponse.PostResponse(bool)'></a>

## PostResponse\(bool\) Constructor

Initializes a new instance of the [PostResponse](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse 'DiGi\.WebAPI\.Classes\.PostResponse') class\.

```csharp
public PostResponse(bool succeeded);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.PostResponse.PostResponse(bool).succeeded'></a>

`succeeded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the operation succeeded\.

<a name='DiGi.WebAPI.Classes.PostResponse_T_'></a>

## PostResponse\<T\> Class

Represents the response from a POST operation, containing the result, success status, and whether a result was requested\.

```csharp
public class PostResponse<T>
```
#### Type parameters

<a name='DiGi.WebAPI.Classes.PostResponse_T_.T'></a>

`T`

The type of the result contained in the response\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → PostResponse\<T\>

Derived  
↳ [PostResponse](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse 'DiGi\.WebAPI\.Classes\.PostResponse')
### Constructors

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool)'></a>

## PostResponse\(bool\) Constructor

Initializes a new instance of the [PostResponse&lt;T&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') class\.

```csharp
public PostResponse(bool succeeded);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool).succeeded'></a>

`succeeded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the operation succeeded\.

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool,bool,T)'></a>

## PostResponse\(bool, bool, T\) Constructor

Initializes a new instance of the [PostResponse&lt;T&gt;](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_ 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>') class\.

```csharp
public PostResponse(bool succeeded, bool resultRequested, T? result=default(T?));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool,bool,T).succeeded'></a>

`succeeded` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the operation succeeded\.

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool,bool,T).resultRequested'></a>

`resultRequested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether a result was requested\.

<a name='DiGi.WebAPI.Classes.PostResponse_T_.PostResponse(bool,bool,T).result'></a>

`result` [T](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_.T 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>\.T')

The result of the operation\.
### Properties

<a name='DiGi.WebAPI.Classes.PostResponse_T_.Result'></a>

## PostResponse\<T\>\.Result Property

Gets the result of the POST operation\.

```csharp
public T? Result { get; }
```

#### Property Value
[T](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.PostResponse_T_.T 'DiGi\.WebAPI\.Classes\.PostResponse\<T\>\.T')

<a name='DiGi.WebAPI.Classes.PostResponse_T_.ResultRequested'></a>

## PostResponse\<T\>\.ResultRequested Property

Gets a value indicating whether a result was requested from the POST operation\.

```csharp
public bool ResultRequested { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.PostResponse_T_.Succeeded'></a>

## PostResponse\<T\>\.Succeeded Property

Gets a value indicating whether the POST operation succeeded\.

```csharp
public bool Succeeded { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.SecurityKey'></a>

## SecurityKey Class

Represents a security key with a unique identifier and creation timestamp\.

```csharp
public sealed class SecurityKey : DiGi.Core.Classes.GuidObject, DiGi.WebAPI.Interfaces.IWebAPIGuidObject, DiGi.Core.Interfaces.IGuidObject, DiGi.Core.Interfaces.IUniqueObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject, DiGi.Core.Interfaces.IObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.UniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.uniqueobject 'DiGi\.Core\.Classes\.UniqueObject') → [DiGi\.Core\.Classes\.GuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.guidobject 'DiGi\.Core\.Classes\.GuidObject') → SecurityKey

Implements [IWebAPIGuidObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIGuidObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIGuidObject'), [DiGi\.Core\.Interfaces\.IGuidObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iguidobject 'DiGi\.Core\.Interfaces\.IGuidObject'), [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject')
### Constructors

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey()'></a>

## SecurityKey\(\) Constructor

Initializes a new instance of the [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') class with a randomly generated key\.

```csharp
public SecurityKey();
```

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(DiGi.WebAPI.Classes.SecurityKey)'></a>

## SecurityKey\(SecurityKey\) Constructor

Initializes a new instance of the [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') class by copying from another instance\.

```csharp
public SecurityKey(DiGi.WebAPI.Classes.SecurityKey? securityKey);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(DiGi.WebAPI.Classes.SecurityKey).securityKey'></a>

`securityKey` [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')

The [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') to copy from\.

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(string)'></a>

## SecurityKey\(string\) Constructor

Initializes a new instance of the [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') class with the specified key value\.

```csharp
public SecurityKey(string? key);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(string).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The key value to use\.

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(System.Text.Json.Nodes.JsonObject)'></a>

## SecurityKey\(JsonObject\) Constructor

Initializes a new instance of the [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') class from a JSON object\.

```csharp
public SecurityKey(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKey.SecurityKey(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.SecurityKey.CreatedAt'></a>

## SecurityKey\.CreatedAt Property

Gets the UTC date and time when the key was created\.

```csharp
public System.DateTime CreatedAt { get; private set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.WebAPI.Classes.SecurityKey.Key'></a>

## SecurityKey\.Key Property

Gets the key value as a string\.

```csharp
public string Key { get; private set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='DiGi.WebAPI.Classes.SecurityKey.GetBytes()'></a>

## SecurityKey\.GetBytes\(\) Method

Converts the key to a byte array using ASCII encoding\.

```csharp
public byte[] GetBytes();
```

#### Returns
[System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
A byte array representation of the key\.

<a name='DiGi.WebAPI.Classes.SecurityKeyManager'></a>

## SecurityKeyManager Class

Manages a collection of [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') instances, including generation, retrieval, and removal of keys\.

```csharp
public sealed class SecurityKeyManager : DiGi.Core.Classes.SerializableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → SecurityKeyManager
### Constructors

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeyManager()'></a>

## SecurityKeyManager\(\) Constructor

Initializes a new instance of the [SecurityKeyManager](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKeyManager 'DiGi\.WebAPI\.Classes\.SecurityKeyManager') class\.

```csharp
public SecurityKeyManager();
```

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeyManager(DiGi.WebAPI.Classes.SecurityKeyManager)'></a>

## SecurityKeyManager\(SecurityKeyManager\) Constructor

Initializes a new instance of the [SecurityKeyManager](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKeyManager 'DiGi\.WebAPI\.Classes\.SecurityKeyManager') class by copying from another instance\.

```csharp
public SecurityKeyManager(DiGi.WebAPI.Classes.SecurityKeyManager securityKeyManager);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeyManager(DiGi.WebAPI.Classes.SecurityKeyManager).securityKeyManager'></a>

`securityKeyManager` [SecurityKeyManager](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKeyManager 'DiGi\.WebAPI\.Classes\.SecurityKeyManager')

The [SecurityKeyManager](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKeyManager 'DiGi\.WebAPI\.Classes\.SecurityKeyManager') to copy from\.

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeyManager(System.Text.Json.Nodes.JsonObject)'></a>

## SecurityKeyManager\(JsonObject\) Constructor

Initializes a new instance of the [SecurityKeyManager](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKeyManager 'DiGi\.WebAPI\.Classes\.SecurityKeyManager') class from a JSON object\.

```csharp
public SecurityKeyManager(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeyManager(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Fields

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.securityKeys'></a>

## SecurityKeyManager\.securityKeys Field

Stores the security keys indexed by their GUID\.

```csharp
private Dictionary<Guid,SecurityKey> securityKeys;
```

#### Field Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')
### Properties

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.SecurityKeys'></a>

## SecurityKeyManager\.SecurityKeys Property

Gets or sets the collection of security keys\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.WebAPI.Classes.SecurityKey> SecurityKeys { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.Add(DiGi.WebAPI.Classes.SecurityKey)'></a>

## SecurityKeyManager\.Add\(SecurityKey\) Method

Adds a [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') to the manager\.

```csharp
public bool Add(DiGi.WebAPI.Classes.SecurityKey? securityKey);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.Add(DiGi.WebAPI.Classes.SecurityKey).securityKey'></a>

`securityKey` [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')

The security key to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the key was added successfully; otherwise, false\.

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.Generate()'></a>

## SecurityKeyManager\.Generate\(\) Method

Generates a new unique [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey') and adds it to the manager\.

```csharp
public DiGi.WebAPI.Classes.SecurityKey Generate();
```

#### Returns
[SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')  
The newly generated [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')\.

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.GetActive(bool)'></a>

## SecurityKeyManager\.GetActive\(bool\) Method

Gets the most recently created active security key\.

```csharp
public DiGi.WebAPI.Classes.SecurityKey? GetActive(bool generate=true);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.GetActive(bool).generate'></a>

`generate` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to generate a new key if none exist\.

#### Returns
[SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey')  
The most recent [SecurityKey](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SecurityKey 'DiGi\.WebAPI\.Classes\.SecurityKey'), or null if no keys exist and generate is false\.

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.Remove(System.Guid)'></a>

## SecurityKeyManager\.Remove\(Guid\) Method

Removes a security key by its GUID\.

```csharp
public bool Remove(System.Guid guid);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SecurityKeyManager.Remove(System.Guid).guid'></a>

`guid` [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

The GUID of the security key to remove\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the key was found and removed; otherwise, false\.

<a name='DiGi.WebAPI.Classes.UrlBuilder'></a>

## UrlBuilder Class

Provides a fluent API for constructing URLs with query parameters and automatic encoding\.

```csharp
public class UrlBuilder
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → UrlBuilder
### Constructors

<a name='DiGi.WebAPI.Classes.UrlBuilder.UrlBuilder(string)'></a>

## UrlBuilder\(string\) Constructor

Initializes a new instance of the [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') class with the specified base URL\.

```csharp
public UrlBuilder(string url);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.UrlBuilder(string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The base URL to build upon\.
### Fields

<a name='DiGi.WebAPI.Classes.UrlBuilder.dictionary'></a>

## UrlBuilder\.dictionary Field

Stores the query parameters to be appended to the URL\.

A name maps to a list rather than a single value because a query string may repeat a name, which is how ASP.NET Core binds a collection parameter. The single-value overloads still hold one value per name and replace what was there.

```csharp
private readonly Dictionary<string,List<string>> dictionary;
```

#### Field Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='DiGi.WebAPI.Classes.UrlBuilder.url'></a>

## UrlBuilder\.url Field

The base URL before query parameters are added\.

```csharp
private readonly string url;
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Properties

<a name='DiGi.WebAPI.Classes.UrlBuilder.ParameterNames'></a>

## UrlBuilder\.ParameterNames Property

Gets the names of all query parameters currently added to the URL\.

```csharp
public System.Collections.Generic.IEnumerable<string> ParameterNames { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')
### Methods

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,bool)'></a>

## UrlBuilder\.AddParameter\(string, bool\) Method

Adds a boolean query parameter with automatic URL encoding\.

```csharp
public DiGi.WebAPI.Classes.UrlBuilder AddParameter(string name, bool value);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter name\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to encode\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
The [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') instance for chaining\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,double)'></a>

## UrlBuilder\.AddParameter\(string, double\) Method

Adds a double query parameter with automatic URL encoding\.

```csharp
public DiGi.WebAPI.Classes.UrlBuilder AddParameter(string name, double value);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,double).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter name\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value to encode\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
The [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') instance for chaining\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,int)'></a>

## UrlBuilder\.AddParameter\(string, int\) Method

Adds an integer query parameter with automatic URL encoding\.

```csharp
public DiGi.WebAPI.Classes.UrlBuilder AddParameter(string name, int value);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,int).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter name\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value to encode\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
The [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') instance for chaining\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,string)'></a>

## UrlBuilder\.AddParameter\(string, string\) Method

Adds a query parameter with automatic URL encoding\.

```csharp
public DiGi.WebAPI.Classes.UrlBuilder AddParameter(string name, string? value);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the query parameter\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,string).value'></a>

`value` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value of the query parameter\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
The current UrlBuilder instance\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,System.Collections.Generic.IEnumerable_int_)'></a>

## UrlBuilder\.AddParameter\(string, IEnumerable\<int\>\) Method

Adds an integer query parameter once per value, so the name repeats in the query string\.

This is how a collection reaches a `[FromQuery]` action parameter: ASP.NET Core binds `?name=1&name=2` to an `int[]`, and does not split a single comma-separated value into one. Passing no values adds nothing rather than an empty parameter, and [TryGetValue&lt;T&gt;\(string, T\)](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T) 'DiGi\.WebAPI\.Classes\.UrlBuilder\.TryGetValue\<T\>\(string, T\)') reads back only the first of them.

```csharp
public DiGi.WebAPI.Classes.UrlBuilder AddParameter(string name, System.Collections.Generic.IEnumerable<int>? values);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,System.Collections.Generic.IEnumerable_int_).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter name\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,System.Collections.Generic.IEnumerable_int_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The integer values to encode, one occurrence of the parameter each\.

#### Returns
[UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')  
The [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') instance for chaining\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.Build()'></a>

## UrlBuilder\.Build\(\) Method

Builds the final URL string\.

```csharp
public string Build();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The built URL string with query parameters\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.ToString()'></a>

## UrlBuilder\.ToString\(\) Method

Returns the built URL as a string\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The complete URL with query parameters\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T)'></a>

## UrlBuilder\.TryGetValue\<T\>\(string, T\) Method

Attempts to retrieve and convert a query parameter value to the specified type\.

A name added through [AddParameter\(string, IEnumerable&lt;int&gt;\)](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder.AddParameter(string,System.Collections.Generic.IEnumerable_int_) 'DiGi\.WebAPI\.Classes\.UrlBuilder\.AddParameter\(string, System\.Collections\.Generic\.IEnumerable\<int\>\)') holds several values; the first is the one returned.

```csharp
public bool TryGetValue<T>(string parameterName, out T? value);
```
#### Type parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T).T'></a>

`T`

The type to convert the parameter value to\.
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T).parameterName'></a>

`parameterName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the query parameter to retrieve\.

<a name='DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T).value'></a>

`value` [T](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder.TryGetValue_T_(string,T).T 'DiGi\.WebAPI\.Classes\.UrlBuilder\.TryGetValue\<T\>\(string, T\)\.T')

When this method returns, contains the converted value if found, or default\(T\) if not found\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the parameter exists and was successfully converted; otherwise, false\.
### Operators

<a name='DiGi.WebAPI.Classes.UrlBuilder.op_Implicitstring(DiGi.WebAPI.Classes.UrlBuilder)'></a>

## UrlBuilder\.implicit operator string\(UrlBuilder\) Operator

Converts the [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') to its string representation\.

```csharp
public static string? implicit operator string?(DiGi.WebAPI.Classes.UrlBuilder? urlBuilder);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.UrlBuilder.op_Implicitstring(DiGi.WebAPI.Classes.UrlBuilder).urlBuilder'></a>

`urlBuilder` [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder')

The [UrlBuilder](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.UrlBuilder 'DiGi\.WebAPI\.Classes\.UrlBuilder') instance to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The built URL string, or null if the builder is null\.

<a name='DiGi.WebAPI.Classes.WebAPIController'></a>

## WebAPIController Class

Serves as the base class for all WebAPI controllers, providing common MVC and API functionality\.

```csharp
public abstract class WebAPIController : Microsoft.AspNetCore.Mvc.ControllerBase, DiGi.WebAPI.Interfaces.IWebAPIController, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → WebAPIController

Derived  
↳ [InformationController](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.InformationController 'DiGi\.WebAPI\.Classes\.InformationController')

Implements [IWebAPIController](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIController 'DiGi\.WebAPI\.Interfaces\.IWebAPIController'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')