# RobloxCS Example Project

Simple example project for [RobloxCS](https://github.com/glomdom/RobloxCS).

## Usage

1. Clone [RobloxCS](https://github.com/glomdom/RobloxCS)
2. Build it
3. Run `dotnet pack -o C:\LocalNuGet` in `RobloxCS.Types`. Optionally run `dotnet run --project ../RobloxCS.TypeGenerator` inside `RobloxCS.Types` before packing
4. Clone this example project inside the directory of where `RobloxCS.slnx` is located.
5. Run `dotnet run --project RobloxCS.CLI --` inside the example project.

You might be asking why is it so annoying to use the CLI? Well, currently RobloxCS is not in the position to be published as a user-consumable CLI, hence why you are working with bleeding-edge versions.