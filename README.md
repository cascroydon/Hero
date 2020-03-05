# Hero

This example shows how to use an extension method to extend the `string` class and create a new instance of the `Hero` class with the name of the given string. You use it by calling `CreateHero` as if it were a method belonging to the `string` class itself.

```csharp
  Hero h = "AnyString".CreateHero();
```
