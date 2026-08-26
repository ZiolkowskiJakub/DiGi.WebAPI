#### [DiGi\.WebAPI](DiGi.WebAPI.Overview.md 'DiGi\.WebAPI\.Overview')

## DiGi\.WebAPI\.Classes Namespace
### Classes

<a name='DiGi.WebAPI.Classes.AssemblyInformation'></a>

## AssemblyInformation Class

Holds identity and version metadata for a loaded assembly\.

```csharp
public class AssemblyInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → AssemblyInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(DiGi.WebAPI.Classes.AssemblyInformation)'></a>

## AssemblyInformation\(AssemblyInformation\) Constructor

Initializes a new instance of the [AssemblyInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.AssemblyInformation 'DiGi\.WebAPI\.Classes\.AssemblyInformation') class by copying from another instance\.

```csharp
public AssemblyInformation(DiGi.WebAPI.Classes.AssemblyInformation? assemblyInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(DiGi.WebAPI.Classes.AssemblyInformation).assemblyInformation'></a>

`assemblyInformation` [AssemblyInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.AssemblyInformation 'DiGi\.WebAPI\.Classes\.AssemblyInformation')

The [AssemblyInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.AssemblyInformation 'DiGi\.WebAPI\.Classes\.AssemblyInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool)'></a>

## AssemblyInformation\(string, string, string, string, bool\) Constructor

Initializes a new instance of the [AssemblyInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.AssemblyInformation 'DiGi\.WebAPI\.Classes\.AssemblyInformation') class\.

```csharp
public AssemblyInformation(string? name, string? fullName, string? version, string? informationalVersion, bool isDynamic);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The simple name of the assembly\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool).fullName'></a>

`fullName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The full assembly display name\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool).version'></a>

`version` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The assembly version\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool).informationalVersion'></a>

`informationalVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The assembly informational version \(e\.g\., git commit\)\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(string,string,string,string,bool).isDynamic'></a>

`isDynamic` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the assembly is dynamic\.

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(System.Text.Json.Nodes.JsonObject)'></a>

## AssemblyInformation\(JsonObject\) Constructor

Initializes a new instance of the [AssemblyInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.AssemblyInformation 'DiGi\.WebAPI\.Classes\.AssemblyInformation') class from a JSON object\.

```csharp
public AssemblyInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.AssemblyInformation.AssemblyInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.AssemblyInformation.FullName'></a>

## AssemblyInformation\.FullName Property

Gets the full assembly display name\.

```csharp
public string? FullName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.AssemblyInformation.InformationalVersion'></a>

## AssemblyInformation\.InformationalVersion Property

Gets the assembly informational version \(e\.g\., git commit\)\.

```csharp
public string? InformationalVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.AssemblyInformation.IsDynamic'></a>

## AssemblyInformation\.IsDynamic Property

Gets a value indicating whether the assembly is dynamic\.

```csharp
public bool IsDynamic { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.AssemblyInformation.Name'></a>

## AssemblyInformation\.Name Property

Gets the simple name of the assembly\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.AssemblyInformation.Version'></a>

## AssemblyInformation\.Version Property

Gets the assembly version\.

```csharp
public string? Version { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.ControllerInformation'></a>

## ControllerInformation Class

Holds metadata about a controller, including its name, assembly information, version, action count, and route prefix\.

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

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string)'></a>

## ControllerInformation\(string, string, string, string, int, string\) Constructor

Initializes a new instance of the [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') class with the specified metadata, action count, and route prefix\.

```csharp
public ControllerInformation(string? name, string? assemblyName, string? version, string? informationalVersion, int actionCount, string? routePrefix);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The controller name\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).assemblyName'></a>

`assemblyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the assembly containing the controller\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).version'></a>

`version` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The assembly version\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).informationalVersion'></a>

`informationalVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The informational version of the assembly\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).actionCount'></a>

`actionCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of registered actions on the controller\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(string,string,string,string,int,string).routePrefix'></a>

`routePrefix` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The route template prefix declared on the controller\.

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(System.Text.Json.Nodes.JsonObject)'></a>

## ControllerInformation\(JsonObject\) Constructor

Initializes a new instance of the [ControllerInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ControllerInformation 'DiGi\.WebAPI\.Classes\.ControllerInformation') class from a JSON object\.

```csharp
public ControllerInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ControllerInformation.ControllerInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.ControllerInformation.ActionCount'></a>

## ControllerInformation\.ActionCount Property

Gets the count of registered actions on the controller\.

```csharp
public int ActionCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

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

<a name='DiGi.WebAPI.Classes.ControllerInformation.RoutePrefix'></a>

## ControllerInformation\.RoutePrefix Property

Gets the route template prefix configured for the controller\.

```csharp
public string? RoutePrefix { get; }
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

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration'></a>

## DiagnosticsConfiguration Class

Holds configuration settings for protecting diagnostic endpoints via API key authorization\.

Access is denied by default. A protected endpoint is reachable only when [Enabled](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration.Enabled 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration\.Enabled') is true and the supplied key matches [Key](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration.Key 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration\.Key'), or when [Open](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration.Open 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration\.Open') explicitly waives the check.

```csharp
public class DiagnosticsConfiguration : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → DiagnosticsConfiguration

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(DiGi.WebAPI.Classes.DiagnosticsConfiguration)'></a>

## DiagnosticsConfiguration\(DiagnosticsConfiguration\) Constructor

Initializes a new instance of the [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration') class by copying from another instance\.

```csharp
public DiagnosticsConfiguration(DiGi.WebAPI.Classes.DiagnosticsConfiguration? diagnosticsConfiguration);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(DiGi.WebAPI.Classes.DiagnosticsConfiguration).diagnosticsConfiguration'></a>

`diagnosticsConfiguration` [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration')

The [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration') to copy from\.

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(string,bool,bool)'></a>

## DiagnosticsConfiguration\(string, bool, bool\) Constructor

Initializes a new instance of the [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration') class\.

The parameterless form denies every protected request, which is the intended default for an unconfigured host.

```csharp
public DiagnosticsConfiguration(string? key=null, bool enabled=false, bool open=false);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(string,bool,bool).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The secret diagnostic access token\.

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(string,bool,bool).enabled'></a>

`enabled` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether authorization enforcement is enabled\.

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(string,bool,bool).open'></a>

`open` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the key check is explicitly waived, leaving protected endpoints unauthenticated\.

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(System.Text.Json.Nodes.JsonObject)'></a>

## DiagnosticsConfiguration\(JsonObject\) Constructor

Initializes a new instance of the [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration') class from a JSON object\.

```csharp
public DiagnosticsConfiguration(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.DiagnosticsConfiguration(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.Enabled'></a>

## DiagnosticsConfiguration\.Enabled Property

Gets a value indicating whether diagnostic authorization enforcement is enabled\.

False denies every protected request; it does not open them.

```csharp
public bool Enabled { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.Key'></a>

## DiagnosticsConfiguration\.Key Property

Gets the secret diagnostic access token\.

```csharp
public string? Key { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.DiagnosticsConfiguration.Open'></a>

## DiagnosticsConfiguration\.Open Property

Gets a value indicating whether the key check is explicitly waived, leaving protected diagnostic endpoints reachable without a key\.

Intended for local development only. This is the sole setting that grants unauthenticated access to the protected tier.

```csharp
public bool Open { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.EndpointInformation'></a>

## EndpointInformation Class

Holds route, action, and parameter contract metadata for a registered API endpoint\.

```csharp
public class EndpointInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → EndpointInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(DiGi.WebAPI.Classes.EndpointInformation)'></a>

## EndpointInformation\(EndpointInformation\) Constructor

Initializes a new instance of the [EndpointInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointInformation 'DiGi\.WebAPI\.Classes\.EndpointInformation') class by copying from another instance\.

```csharp
public EndpointInformation(DiGi.WebAPI.Classes.EndpointInformation? endpointInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(DiGi.WebAPI.Classes.EndpointInformation).endpointInformation'></a>

`endpointInformation` [EndpointInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointInformation 'DiGi\.WebAPI\.Classes\.EndpointInformation')

The [EndpointInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointInformation 'DiGi\.WebAPI\.Classes\.EndpointInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_)'></a>

## EndpointInformation\(string, string, string, IEnumerable\<string\>, bool, string, IEnumerable\<EndpointParameterInformation\>\) Constructor

Initializes a new instance of the [EndpointInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointInformation 'DiGi\.WebAPI\.Classes\.EndpointInformation') class\.

```csharp
public EndpointInformation(string? controllerName, string? actionName, string? routeTemplate, System.Collections.Generic.IEnumerable<string>? httpMethods, bool isApiIgnored, string? returnTypeName, System.Collections.Generic.IEnumerable<DiGi.WebAPI.Classes.EndpointParameterInformation>? parameters);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).controllerName'></a>

`controllerName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the declaring controller\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).actionName'></a>

`actionName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the action method\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).routeTemplate'></a>

`routeTemplate` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The relative route template for the endpoint\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).httpMethods'></a>

`httpMethods` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The supported HTTP verbs \(e\.g\. GET, POST\)\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).isApiIgnored'></a>

`isApiIgnored` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the endpoint is hidden from API explorer / Swagger\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).returnTypeName'></a>

`returnTypeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The return type name of the endpoint\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(string,string,string,System.Collections.Generic.IEnumerable_string_,bool,string,System.Collections.Generic.IEnumerable_DiGi.WebAPI.Classes.EndpointParameterInformation_).parameters'></a>

`parameters` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The list of parameters accepted by the endpoint\.

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(System.Text.Json.Nodes.JsonObject)'></a>

## EndpointInformation\(JsonObject\) Constructor

Initializes a new instance of the [EndpointInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointInformation 'DiGi\.WebAPI\.Classes\.EndpointInformation') class from a JSON object\.

```csharp
public EndpointInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointInformation.EndpointInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.EndpointInformation.ActionName'></a>

## EndpointInformation\.ActionName Property

Gets the name of the action method\.

```csharp
public string? ActionName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointInformation.ControllerName'></a>

## EndpointInformation\.ControllerName Property

Gets the name of the declaring controller\.

```csharp
public string? ControllerName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointInformation.HttpMethods'></a>

## EndpointInformation\.HttpMethods Property

Gets the supported HTTP verbs \(e\.g\. GET, POST\)\.

```csharp
public System.Collections.Generic.IEnumerable<string>? HttpMethods { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.WebAPI.Classes.EndpointInformation.IsApiIgnored'></a>

## EndpointInformation\.IsApiIgnored Property

Gets a value indicating whether the endpoint is hidden from API explorer / Swagger\.

```csharp
public bool IsApiIgnored { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.EndpointInformation.Parameters'></a>

## EndpointInformation\.Parameters Property

Gets the list of parameters accepted by the endpoint\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.WebAPI.Classes.EndpointParameterInformation>? Parameters { get; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.WebAPI.Classes.EndpointInformation.ReturnTypeName'></a>

## EndpointInformation\.ReturnTypeName Property

Gets the return type name of the endpoint\.

```csharp
public string? ReturnTypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointInformation.RouteTemplate'></a>

## EndpointInformation\.RouteTemplate Property

Gets the relative route template for the endpoint\.

```csharp
public string? RouteTemplate { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation'></a>

## EndpointParameterInformation Class

Holds metadata about an action method parameter\.

```csharp
public class EndpointParameterInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → EndpointParameterInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(DiGi.WebAPI.Classes.EndpointParameterInformation)'></a>

## EndpointParameterInformation\(EndpointParameterInformation\) Constructor

Initializes a new instance of the [EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation') class by copying from another instance\.

```csharp
public EndpointParameterInformation(DiGi.WebAPI.Classes.EndpointParameterInformation? endpointParameterInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(DiGi.WebAPI.Classes.EndpointParameterInformation).endpointParameterInformation'></a>

`endpointParameterInformation` [EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation')

The [EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool)'></a>

## EndpointParameterInformation\(string, string, string, bool, bool\) Constructor

Initializes a new instance of the [EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation') class\.

```csharp
public EndpointParameterInformation(string? name, string? source, string? typeName, bool isNullable, bool hasDefaultValue);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter name\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool).source'></a>

`source` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The parameter binding source \(e\.g\., "Query", "Body", "Path"\)\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool).typeName'></a>

`typeName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The C\# type name of the parameter\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool).isNullable'></a>

`isNullable` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the parameter type is nullable\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(string,string,string,bool,bool).hasDefaultValue'></a>

`hasDefaultValue` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether the parameter has a default value\.

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(System.Text.Json.Nodes.JsonObject)'></a>

## EndpointParameterInformation\(JsonObject\) Constructor

Initializes a new instance of the [EndpointParameterInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.EndpointParameterInformation 'DiGi\.WebAPI\.Classes\.EndpointParameterInformation') class from a JSON object\.

```csharp
public EndpointParameterInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.EndpointParameterInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.HasDefaultValue'></a>

## EndpointParameterInformation\.HasDefaultValue Property

Gets a value indicating whether the parameter has a default value\.

```csharp
public bool HasDefaultValue { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.IsNullable'></a>

## EndpointParameterInformation\.IsNullable Property

Gets a value indicating whether the parameter type is nullable\.

```csharp
public bool IsNullable { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.Name'></a>

## EndpointParameterInformation\.Name Property

Gets the parameter name\.

```csharp
public string? Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.Source'></a>

## EndpointParameterInformation\.Source Property

Gets the parameter binding source \(e\.g\., "Query", "Body", "Path"\)\.

```csharp
public string? Source { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.EndpointParameterInformation.TypeName'></a>

## EndpointParameterInformation\.TypeName Property

Gets the C\# type name of the parameter\.

```csharp
public string? TypeName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.InformationController'></a>

## InformationController Class

Provides API endpoints for remote diagnosis, health checks, endpoint cataloging, assembly auditing, and system telemetry with tiered access protection\.

Protected endpoints read the access key from the `key` request header and deny by default; see [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration').

```csharp
public class InformationController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [WebAPIController](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.WebAPIController 'DiGi\.WebAPI\.Classes\.WebAPIController') → InformationController
### Constructors

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider,Microsoft.Extensions.Hosting.IHostEnvironment,DiGi.WebAPI.Classes.DiagnosticsConfiguration)'></a>

## InformationController\(ApplicationPartManager, IActionDescriptorCollectionProvider, IHostEnvironment, DiagnosticsConfiguration\) Constructor

Initializes a new instance of the [InformationController](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.InformationController 'DiGi\.WebAPI\.Classes\.InformationController') class\.

```csharp
public InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager applicationPartManager, Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider? actionDescriptorCollectionProvider=null, Microsoft.Extensions.Hosting.IHostEnvironment? hostEnvironment=null, DiGi.WebAPI.Classes.DiagnosticsConfiguration? diagnosticsConfiguration=null);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider,Microsoft.Extensions.Hosting.IHostEnvironment,DiGi.WebAPI.Classes.DiagnosticsConfiguration).applicationPartManager'></a>

`applicationPartManager` [Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.applicationparts.applicationpartmanager 'Microsoft\.AspNetCore\.Mvc\.ApplicationParts\.ApplicationPartManager')

The application part manager used for controller discovery\.

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider,Microsoft.Extensions.Hosting.IHostEnvironment,DiGi.WebAPI.Classes.DiagnosticsConfiguration).actionDescriptorCollectionProvider'></a>

`actionDescriptorCollectionProvider` [Microsoft\.AspNetCore\.Mvc\.Infrastructure\.IActionDescriptorCollectionProvider](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.infrastructure.iactiondescriptorcollectionprovider 'Microsoft\.AspNetCore\.Mvc\.Infrastructure\.IActionDescriptorCollectionProvider')

Optional action descriptor collection provider for route cataloging\.

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider,Microsoft.Extensions.Hosting.IHostEnvironment,DiGi.WebAPI.Classes.DiagnosticsConfiguration).hostEnvironment'></a>

`hostEnvironment` [Microsoft\.Extensions\.Hosting\.IHostEnvironment](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.hosting.ihostenvironment 'Microsoft\.Extensions\.Hosting\.IHostEnvironment')

Optional host environment descriptor\.

<a name='DiGi.WebAPI.Classes.InformationController.InformationController(Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager,Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider,Microsoft.Extensions.Hosting.IHostEnvironment,DiGi.WebAPI.Classes.DiagnosticsConfiguration).diagnosticsConfiguration'></a>

`diagnosticsConfiguration` [DiagnosticsConfiguration](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.DiagnosticsConfiguration 'DiGi\.WebAPI\.Classes\.DiagnosticsConfiguration')

Optional diagnostics configuration for access key validation\. When not supplied by dependency injection it is loaded from disk, which is a per\-request cost \- register it as a singleton on the host\.
### Methods

<a name='DiGi.WebAPI.Classes.InformationController.GetAssembliesAsync(string,System.Threading.CancellationToken)'></a>

## InformationController\.GetAssembliesAsync\(string, CancellationToken\) Method

Retrieves an inventory of loaded assemblies in the default assembly load context\. Requires a valid key\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAssembliesAsync(string? key=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetAssembliesAsync(string,System.Threading.CancellationToken).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Access key supplied through the `key` request header\.

<a name='DiGi.WebAPI.Classes.InformationController.GetAssembliesAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A JSON list of loaded assembly metadata\.

<a name='DiGi.WebAPI.Classes.InformationController.GetControllersAsync(string,System.Threading.CancellationToken)'></a>

## InformationController\.GetControllersAsync\(string, CancellationToken\) Method

Retrieves a list of all registered controllers in the application\. Requires a valid key\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetControllersAsync(string? key=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetControllersAsync(string,System.Threading.CancellationToken).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Access key supplied through the `key` request header\.

<a name='DiGi.WebAPI.Classes.InformationController.GetControllersAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A JSON string containing controller information, or an empty response if no controllers are found\.

<a name='DiGi.WebAPI.Classes.InformationController.GetEndpointsAsync(string,bool,string,System.Threading.CancellationToken)'></a>

## InformationController\.GetEndpointsAsync\(string, bool, string, CancellationToken\) Method

Retrieves the catalog of registered action routes and parameter contracts\. Inspecting internal routes requires a valid key\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetEndpointsAsync(string? controller, bool includeIgnored=false, string? key=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetEndpointsAsync(string,bool,string,System.Threading.CancellationToken).controller'></a>

`controller` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional controller name filter\.

<a name='DiGi.WebAPI.Classes.InformationController.GetEndpointsAsync(string,bool,string,System.Threading.CancellationToken).includeIgnored'></a>

`includeIgnored` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to include endpoints hidden from Swagger explorer\. Defaults to false for safe public exposure\.

<a name='DiGi.WebAPI.Classes.InformationController.GetEndpointsAsync(string,bool,string,System.Threading.CancellationToken).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Access key supplied through the `key` request header, required when includeignored is set to true\.

<a name='DiGi.WebAPI.Classes.InformationController.GetEndpointsAsync(string,bool,string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A JSON list of endpoint metadata\.

<a name='DiGi.WebAPI.Classes.InformationController.GetHealthAsync(System.Threading.CancellationToken)'></a>

## InformationController\.GetHealthAsync\(CancellationToken\) Method

Retrieves service health status, server UTC/local timestamps, uptime, and process ID\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetHealthAsync(System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetHealthAsync(System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The service health information\.

<a name='DiGi.WebAPI.Classes.InformationController.GetSystemAsync(string,System.Threading.CancellationToken)'></a>

## InformationController\.GetSystemAsync\(string, CancellationToken\) Method

Retrieves host system, environment, memory, and thread pool diagnostic information\. Requires a valid key\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSystemAsync(string? key=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetSystemAsync(string,System.Threading.CancellationToken).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Access key supplied through the `key` request header\.

<a name='DiGi.WebAPI.Classes.InformationController.GetSystemAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The system telemetry information\.

<a name='DiGi.WebAPI.Classes.InformationController.GetVersionAsync(string,System.Threading.CancellationToken)'></a>

## InformationController\.GetVersionAsync\(string, CancellationToken\) Method

Retrieves comprehensive version and runtime diagnostic information across the service host, WebAPI framework, and \.NET CLR\.

The source control commit hash is appended to the informational versions only for callers supplying a valid key, because it identifies the exact revision of a publicly readable repository.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetVersionAsync(string? key=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.WebAPI.Classes.InformationController.GetVersionAsync(string,System.Threading.CancellationToken).key'></a>

`key` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Optional access key supplied through the `key` request header\. When valid, commit hashes are included\.

<a name='DiGi.WebAPI.Classes.InformationController.GetVersionAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used to cancel the request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The version and runtime metadata\.

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

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation'></a>

## ServiceHealthInformation Class

Holds service health and liveness status information\.

```csharp
public class ServiceHealthInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → ServiceHealthInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(DiGi.WebAPI.Classes.ServiceHealthInformation)'></a>

## ServiceHealthInformation\(ServiceHealthInformation\) Constructor

Initializes a new instance of the [ServiceHealthInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ServiceHealthInformation 'DiGi\.WebAPI\.Classes\.ServiceHealthInformation') class by copying from another instance\.

```csharp
public ServiceHealthInformation(DiGi.WebAPI.Classes.ServiceHealthInformation? serviceHealthInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(DiGi.WebAPI.Classes.ServiceHealthInformation).serviceHealthInformation'></a>

`serviceHealthInformation` [ServiceHealthInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ServiceHealthInformation 'DiGi\.WebAPI\.Classes\.ServiceHealthInformation')

The [ServiceHealthInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ServiceHealthInformation 'DiGi\.WebAPI\.Classes\.ServiceHealthInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int)'></a>

## ServiceHealthInformation\(string, DateTime, DateTimeOffset, TimeSpan, int\) Constructor

Initializes a new instance of the [ServiceHealthInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ServiceHealthInformation 'DiGi\.WebAPI\.Classes\.ServiceHealthInformation') class\.

```csharp
public ServiceHealthInformation(string? status, System.DateTime serverTimeUtc, System.DateTimeOffset serverTimeLocal, System.TimeSpan uptime, int processId);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int).status'></a>

`status` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The health status description \(e\.g\., "Healthy"\)\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int).serverTimeUtc'></a>

`serverTimeUtc` [System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

The server current time in UTC\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int).serverTimeLocal'></a>

`serverTimeLocal` [System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

The server current local time with offset\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int).uptime'></a>

`uptime` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

The elapsed process uptime\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(string,System.DateTime,System.DateTimeOffset,System.TimeSpan,int).processId'></a>

`processId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The host process identifier\.

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(System.Text.Json.Nodes.JsonObject)'></a>

## ServiceHealthInformation\(JsonObject\) Constructor

Initializes a new instance of the [ServiceHealthInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.ServiceHealthInformation 'DiGi\.WebAPI\.Classes\.ServiceHealthInformation') class from a JSON object\.

```csharp
public ServiceHealthInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServiceHealthInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ProcessId'></a>

## ServiceHealthInformation\.ProcessId Property

Gets the host process identifier\.

```csharp
public int ProcessId { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServerTimeLocal'></a>

## ServiceHealthInformation\.ServerTimeLocal Property

Gets the server current local time with offset\.

```csharp
public System.DateTimeOffset ServerTimeLocal { get; }
```

#### Property Value
[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.ServerTimeUtc'></a>

## ServiceHealthInformation\.ServerTimeUtc Property

Gets the server current time in UTC\.

```csharp
public System.DateTime ServerTimeUtc { get; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.Status'></a>

## ServiceHealthInformation\.Status Property

Gets the health status description \(e\.g\., "Healthy"\)\.

```csharp
public string? Status { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.ServiceHealthInformation.Uptime'></a>

## ServiceHealthInformation\.Uptime Property

Gets the elapsed process uptime\.

```csharp
public System.TimeSpan Uptime { get; }
```

#### Property Value
[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')

<a name='DiGi.WebAPI.Classes.SystemInformation'></a>

## SystemInformation Class

Holds host system, environment, memory, and thread pool diagnostic information\.

```csharp
public class SystemInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → SystemInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(DiGi.WebAPI.Classes.SystemInformation)'></a>

## SystemInformation\(SystemInformation\) Constructor

Initializes a new instance of the [SystemInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SystemInformation 'DiGi\.WebAPI\.Classes\.SystemInformation') class by copying from another instance\.

```csharp
public SystemInformation(DiGi.WebAPI.Classes.SystemInformation? systemInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(DiGi.WebAPI.Classes.SystemInformation).systemInformation'></a>

`systemInformation` [SystemInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SystemInformation 'DiGi\.WebAPI\.Classes\.SystemInformation')

The [SystemInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SystemInformation 'DiGi\.WebAPI\.Classes\.SystemInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int)'></a>

## SystemInformation\(string, string, string, int, long, long, long, int, int, int, int, int\) Constructor

Initializes a new instance of the [SystemInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SystemInformation 'DiGi\.WebAPI\.Classes\.SystemInformation') class\.

```csharp
public SystemInformation(string? environmentName, string? osVersion, string? processArchitecture, int processorCount, long memoryWorkingSetBytes, long memoryPrivateBytes, long gcTotalMemoryBytes, int gcCollectionsGen0, int gcCollectionsGen1, int gcCollectionsGen2, int threadPoolAvailableWorkerThreads, int threadPoolAvailableCompletionPortThreads);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).environmentName'></a>

`environmentName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The ASP\.NET Core environment name\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).osVersion'></a>

`osVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The host operating system description\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).processArchitecture'></a>

`processArchitecture` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The process architecture \(e\.g\. X64, Arm64\)\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).processorCount'></a>

`processorCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of logical processors\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).memoryWorkingSetBytes'></a>

`memoryWorkingSetBytes` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The process working set in bytes\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).memoryPrivateBytes'></a>

`memoryPrivateBytes` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The private memory allocation in bytes\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).gcTotalMemoryBytes'></a>

`gcTotalMemoryBytes` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The GC allocated heap memory in bytes\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).gcCollectionsGen0'></a>

`gcCollectionsGen0` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The count of Gen 0 garbage collections\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).gcCollectionsGen1'></a>

`gcCollectionsGen1` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The count of Gen 1 garbage collections\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).gcCollectionsGen2'></a>

`gcCollectionsGen2` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The count of Gen 2 garbage collections\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).threadPoolAvailableWorkerThreads'></a>

`threadPoolAvailableWorkerThreads` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The count of available worker threads in the thread pool\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(string,string,string,int,long,long,long,int,int,int,int,int).threadPoolAvailableCompletionPortThreads'></a>

`threadPoolAvailableCompletionPortThreads` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The count of available asynchronous I/O completion threads in the thread pool\.

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(System.Text.Json.Nodes.JsonObject)'></a>

## SystemInformation\(JsonObject\) Constructor

Initializes a new instance of the [SystemInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.SystemInformation 'DiGi\.WebAPI\.Classes\.SystemInformation') class from a JSON object\.

```csharp
public SystemInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.SystemInformation.SystemInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.SystemInformation.EnvironmentName'></a>

## SystemInformation\.EnvironmentName Property

Gets the ASP\.NET Core environment name\.

```csharp
public string? EnvironmentName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.SystemInformation.GCCollectionsGen0'></a>

## SystemInformation\.GCCollectionsGen0 Property

Gets the count of Gen 0 garbage collections\.

```csharp
public int GCCollectionsGen0 { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.SystemInformation.GCCollectionsGen1'></a>

## SystemInformation\.GCCollectionsGen1 Property

Gets the count of Gen 1 garbage collections\.

```csharp
public int GCCollectionsGen1 { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.SystemInformation.GCCollectionsGen2'></a>

## SystemInformation\.GCCollectionsGen2 Property

Gets the count of Gen 2 garbage collections\.

```csharp
public int GCCollectionsGen2 { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.SystemInformation.GCTotalMemoryBytes'></a>

## SystemInformation\.GCTotalMemoryBytes Property

Gets the GC allocated heap memory in bytes\.

```csharp
public long GCTotalMemoryBytes { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

<a name='DiGi.WebAPI.Classes.SystemInformation.MemoryPrivateBytes'></a>

## SystemInformation\.MemoryPrivateBytes Property

Gets the private memory allocation in bytes\.

```csharp
public long MemoryPrivateBytes { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

<a name='DiGi.WebAPI.Classes.SystemInformation.MemoryWorkingSetBytes'></a>

## SystemInformation\.MemoryWorkingSetBytes Property

Gets the process working set in bytes\.

```csharp
public long MemoryWorkingSetBytes { get; }
```

#### Property Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

<a name='DiGi.WebAPI.Classes.SystemInformation.OSVersion'></a>

## SystemInformation\.OSVersion Property

Gets the host operating system description\.

```csharp
public string? OSVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.SystemInformation.ProcessArchitecture'></a>

## SystemInformation\.ProcessArchitecture Property

Gets the process architecture \(e\.g\. X64, Arm64\)\.

```csharp
public string? ProcessArchitecture { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.SystemInformation.ProcessorCount'></a>

## SystemInformation\.ProcessorCount Property

Gets the number of logical processors\.

```csharp
public int ProcessorCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.SystemInformation.ThreadPoolAvailableCompletionPortThreads'></a>

## SystemInformation\.ThreadPoolAvailableCompletionPortThreads Property

Gets the count of available asynchronous I/O completion threads in the thread pool\.

```csharp
public int ThreadPoolAvailableCompletionPortThreads { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.WebAPI.Classes.SystemInformation.ThreadPoolAvailableWorkerThreads'></a>

## SystemInformation\.ThreadPoolAvailableWorkerThreads Property

Gets the count of available worker threads in the thread pool\.

```csharp
public int ThreadPoolAvailableWorkerThreads { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

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

<a name='DiGi.WebAPI.Classes.VersionInformation'></a>

## VersionInformation Class

Holds multi\-tier version and runtime diagnostic information\.

```csharp
public class VersionInformation : DiGi.Core.Classes.SerializableObject, DiGi.WebAPI.Interfaces.IWebAPISerializableObject, DiGi.WebAPI.Interfaces.IWebAPIObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → VersionInformation

Implements [IWebAPISerializableObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPISerializableObject 'DiGi\.WebAPI\.Interfaces\.IWebAPISerializableObject'), [IWebAPIObject](DiGi.WebAPI.Interfaces.md#DiGi.WebAPI.Interfaces.IWebAPIObject 'DiGi\.WebAPI\.Interfaces\.IWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(DiGi.WebAPI.Classes.VersionInformation)'></a>

## VersionInformation\(VersionInformation\) Constructor

Initializes a new instance of the [VersionInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.VersionInformation 'DiGi\.WebAPI\.Classes\.VersionInformation') class by copying from another instance\.

```csharp
public VersionInformation(DiGi.WebAPI.Classes.VersionInformation? versionInformation);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(DiGi.WebAPI.Classes.VersionInformation).versionInformation'></a>

`versionInformation` [VersionInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.VersionInformation 'DiGi\.WebAPI\.Classes\.VersionInformation')

The [VersionInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.VersionInformation 'DiGi\.WebAPI\.Classes\.VersionInformation') to copy from\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_)'></a>

## VersionInformation\(string, string, string, string, string, string, Nullable\<DateTime\>\) Constructor

Initializes a new instance of the [VersionInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.VersionInformation 'DiGi\.WebAPI\.Classes\.VersionInformation') class\.

```csharp
public VersionInformation(string? serviceVersion, string? serviceInformationalVersion, string? webAPIVersion, string? webAPIInformationalVersion, string? runtimeVersion, string? frameworkDescription, System.Nullable<System.DateTime> startTimeUtc);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).serviceVersion'></a>

`serviceVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The host service assembly version\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).serviceInformationalVersion'></a>

`serviceInformationalVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The host service informational version \(e\.g\., git commit\)\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).webAPIVersion'></a>

`webAPIVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The WebAPI framework assembly version\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).webAPIInformationalVersion'></a>

`webAPIInformationalVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The WebAPI framework informational version\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).runtimeVersion'></a>

`runtimeVersion` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The \.NET runtime version\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).frameworkDescription'></a>

`frameworkDescription` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The platform/framework description\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(string,string,string,string,string,string,System.Nullable_System.DateTime_).startTimeUtc'></a>

`startTimeUtc` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The process start time in UTC\.

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(System.Text.Json.Nodes.JsonObject)'></a>

## VersionInformation\(JsonObject\) Constructor

Initializes a new instance of the [VersionInformation](DiGi.WebAPI.Classes.md#DiGi.WebAPI.Classes.VersionInformation 'DiGi\.WebAPI\.Classes\.VersionInformation') class from a JSON object\.

```csharp
public VersionInformation(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.WebAPI.Classes.VersionInformation.VersionInformation(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object to deserialize from\.
### Properties

<a name='DiGi.WebAPI.Classes.VersionInformation.FrameworkDescription'></a>

## VersionInformation\.FrameworkDescription Property

Gets the runtime platform and framework description\.

```csharp
public string? FrameworkDescription { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.VersionInformation.RuntimeVersion'></a>

## VersionInformation\.RuntimeVersion Property

Gets the \.NET runtime version\.

```csharp
public string? RuntimeVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.VersionInformation.ServiceInformationalVersion'></a>

## VersionInformation\.ServiceInformationalVersion Property

Gets the host service informational version \(e\.g\., git commit\)\.

```csharp
public string? ServiceInformationalVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.VersionInformation.ServiceVersion'></a>

## VersionInformation\.ServiceVersion Property

Gets the host service assembly version\.

```csharp
public string? ServiceVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.VersionInformation.StartTimeUtc'></a>

## VersionInformation\.StartTimeUtc Property

Gets the host process start time in UTC\.

```csharp
public System.Nullable<System.DateTime> StartTimeUtc { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.WebAPI.Classes.VersionInformation.WebAPIInformationalVersion'></a>

## VersionInformation\.WebAPIInformationalVersion Property

Gets the WebAPI framework informational version\.

```csharp
public string? WebAPIInformationalVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebAPI.Classes.VersionInformation.WebAPIVersion'></a>

## VersionInformation\.WebAPIVersion Property

Gets the WebAPI framework assembly version\.

```csharp
public string? WebAPIVersion { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

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