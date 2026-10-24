namespace Game.Shared;

public class Greeter {
    private readonly string _prefix;

    public Greeter(string prefix) {
        _prefix = prefix;
    }

    public string Greet(string name) {
        return _prefix + ", " + name + "!";
    }
}