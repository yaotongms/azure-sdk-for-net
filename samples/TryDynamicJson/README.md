# Try DynamicJson

Thank you so much for trying out the new `DynamicJson` type!  Our goal is to make protocol methods on Azure SDK clients easy to use.

## Getting Started

Please sync this branch.  Open `TryDynamicJson.sln` in this directory and hit **F5** to run.

Please share any issues you find with us by [filing an issue in our repo](https://github.com/Azure/azure-sdk-for-net/issues/new/choose).


## Project structure

In this project you'll find:

- [Program.cs](TryDynamicJson/Program.cs)
- [MockClient.cs](TryDynamicJson/MockClient.cs)

### MockClient

This is a simple client type with two protocol methods: `GetValue` and `SetValue`.
Like standard protocol methods, they take `RequestContent` and `RequestContext` as input parameters and return `Response` as the return value.

### Program.cs

This has a short example that shows how to use the Azure.Core TestFramework's `MockTransport` to load the client with `MockResponse` values.
The client will return these responses in order when any client method is called.

It also shows how to take the `Response` returned from a method and get its content as a `dynamic` value.

## DynamicJson

Once you have a `dynamic` JSON value from calling `Response.Content.ToDynamic()`, you can treat it like an Azure SDK model type.

### Get a property

You can get a JSON property like any C# property:

```csharp
/// JSON is """{ Name = "name" }"""
dynamic value = response.Content.ToDynamic();
string name = value.Name;
```

### Set a property

DynamicJson is mutable, so you can set a property on it as well:

```csharp
/// JSON is """{ Name = "name" }"""
dynamic value = response.Content.ToDynamic();
value.Name = "New Name";
```

### Access a value in an array

```csharp
/// JSON is """{ Foo = [1, 2, 3] }"""
dynamic value = response.Content.ToDynamic();
int number = value.Foo[0];
```

### `foreach` over a collection property

```csharp
/// JSON is """{ Foo = [1, 2, 3] }"""
dynamic value = response.Content.ToDynamic();
foreach (int i in value.Foo)
{
  // Use `i`
}
```

### Cast a `dynamic` JSON property to a POCO type

```csharp
/// JSON is """{ Name = "name" }"""
dynamic value = response.Content.ToDynamic();
User user = (User)value;

class User
{
  public string Name { get; set; }
}
```

### Get a property with invalid characters in the name

```csharp
/// JSON is """{ $Id = "foo" }"""
dynamic value = response.Content.ToDynamic();
string id = value["$Id"];
```

### Check whether an optional property is present

```csharp
/// JSON is """{ Optional = "foo" }"""
dynamic value = response.Content.ToDynamic();
bool exists = (value.Optional != null);
```

### Set a property using anonymous types

```csharp
/// JSON is """{ Name = "name" }"""
dynamic value = response.Content.ToDynamic();
value.Address = new {
  Street = "One Microsoft Way",
  City = "Redmond"
}
```

## Learning More

- You can find draft guidance on how to use the type [here](https://github.com/Azure/azure-sdk-for-net/pull/34001).
- An example showing an existing DPG sample ported from JsonDocument to DynamicJson can be found [here](https://github.com/Azure/azure-sdk-for-net/pull/33931).
- If you want to try it outside this sample, the latest released version of DynamicJson can be found in [Azure.Core.Experimental 0.1.0-preview.24](https://www.nuget.org/packages/Azure.Core.Experimental/0.1.0-preview.24).
- Please share any issues you find with us by [filing an issue in our repo](https://github.com/Azure/azure-sdk-for-net/issues/new/choose).

And thanks so much!
