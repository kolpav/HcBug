## Reproduction

`ASPNETCORE_ENVIRONMENT="Development" dotnet run`

Then try to load schema or hit the endpoint in any way

`curl http://localhost:5000/graphql`

```
System.ArgumentException: The root type `Query` has already been registered. (Parameter 'operation')
```

## Fix

`ASPNETCORE_ENVIRONMENT="Production" dotnet run`
