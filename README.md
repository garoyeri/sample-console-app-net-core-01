# SuperTool

SuperTool is a sample console application following vertical slice architecture and features command line processing superpowers.

## Build and Run

Make sure you've got .NET Core SDK 3.1 from the usual place on the Internet.

```shell
dotnet build
dotnet run -p src/SuperTool -- math -l 2 -r 3 -op add
```

## Components

This sample is built on the shoulders of the following libraries:
* [CommandLineUtils](https://natemcmaster.github.io/CommandLineUtils/index.html): processing command line arguments and executing them neatly.
* [Mediatr](https://github.com/jbogard/MediatR/wiki): low-ambition library for decoupling in-process messages
* [AutoMapper](https://automapper.org/): mapping objects onto each other
* [Microsoft.Extensions.Hosting](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.1): Generic Host for .NET Core along with all the extras

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

~~Please make sure to update tests as appropriate.~~ (no tests yet, but we'll get there)

## License
[MIT](https://choosealicense.com/licenses/mit/)