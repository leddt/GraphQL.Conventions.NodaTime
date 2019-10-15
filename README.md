# GraphQL.Conventions.NodaTime

This package provides an extension method on `GraphQLEngine` that will map [NodaTime][1]'s types to their corresponding graph type implementations, provided by [GraphQL.NodaTime][2].

## Installation

```
Install-Package GraphQL.Conventions.NodaTime
```

or

```
dotnet add package GraphQL.Conventions.NodaTime
```

## Usage

Simply call the extension method as part of your `GraphQLEngine` registration. For example:

```csharp
services.AddSingleton(provider => new GraphQLEngine()
    .RegisterNodaTimeScalars() // <-- Add this line
    .BuildSchema(typeof(SchemaDefinition<YourSchema.Query, YourSchema.Mutation>)));
```

[1]: https://nodatime.org/
[2]: https://github.com/shoooe/graphql-nodatime
