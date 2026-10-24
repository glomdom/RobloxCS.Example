using Game.Shared;
using RobloxCS.Types;
using RobloxCS.Types.Attributes;

namespace Game.Client;

internal class Main {
    [EntryPoint]
    internal static void Start() {
        var greeter = new Greeter("Hello from the client");

        Console.WriteLine(greeter.Greet(PlayersService.LocalPlayer.DisplayName));
    }
}