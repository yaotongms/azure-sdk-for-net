# Try DyanmicJson!

Thank you so much for trying out the new DynamicJson type!  Our goal is to make protocol methods on Azure SDK clients easy to use.

## Sample project structure

In this project you'll find:
- Program.cs
- MockClient.cs

### MockClient

This is a simple client type with two protocol methods: `GetValue` and `SetValue`.
Like standard protocol methods, they take `RequestContent` and `RequestContext` as input parameters and return `Reponse` as the return value.

### Program.cs

This has a short example that shows how to use the Azure.Core TestFramework's `MockTransport` to load the client with `MockResponse` values.
The client will return these responses in order when any client method is called.

It also shows how to take the `Response` returned from a method and get its content as a `dynamic` value.

## DynamicJson

Once you have a `dynamic` JSON value from calling `Response.Content.ToDynamic()`, you can treat it like an Azure SDK model type.

For example, you can get a JSON property like any C# property:

```
dynamic value = response.Content.ToDynamic();
string name = value.Name;
```

`DynamicJson` is mutable, so you can set a property as well:

```
dynamic value = response.Content.ToDynamic();
value.Name = "New Name";
```
