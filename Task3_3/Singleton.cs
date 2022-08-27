namespace Task3_3;

public class Singleton
{
    private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());
    public static Singleton Instance => Lazy.Value;
    public Guid Guid { get; }

    private Singleton()
    {
        Guid = Guid.NewGuid();
    }
}