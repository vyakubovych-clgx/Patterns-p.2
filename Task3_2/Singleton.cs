using System.Xml.Linq;

namespace Task3_2;

public class Singleton
{
    private static Singleton _instance;
    private static object _lockObject = new();
    public Guid Guid { get; }

    private Singleton()
    {
        Guid = Guid.NewGuid();
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    _instance ??= new Singleton();
                }
            }
            return _instance;
        }
    }
}