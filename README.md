# api-key-authentication-examples

There are two method to make the api secure with api key approach. 

- Using attribute (It is implemented.)
- Using middleware (It is not implemented, it is almost same as attribute)

## Using attribute
You can define a custom attirubte like `ApiKeyAttribute` in our example, then you can protect endpoints using this attribute over endpoints. 
To see example, you can inspect `SecurePointController`

## Using Middleware

```c#
public class ApiKeyMiddleware
{
    public ApiKeyMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext context)
    {
        //follow same validations in ApiKeyAuthAttribute.cs
        await _next(context);_
    }
}

```

### Configure
You can use middleware in method `Configure` following:

```c#

public void Configure(IApplicationBuilder app, IWebHostEnvironemt env)
{
    //...
    app.UseMiddleware<>(ApiKeyMiddleware);
    //...
}
```

Note: If you wish, you can use the middleware for some endpoints. 