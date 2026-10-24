using Game.Shared;
using RobloxCS.Types;
using RobloxCS.Types.Attributes;

namespace Game.Server;

internal class Main {
    [EntryPoint]
    internal static void Start() {
        var greeter = new Greeter("Welcome");

        PlayersService.PlayerAdded.Connect(player => {
            Console.WriteLine(greeter.Greet(player.DisplayName));
        });
    }
}