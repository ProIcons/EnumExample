using System.Reflection;

namespace EnumExample;

public abstract class Enum
{
    private static readonly Dictionary<Enum, int> OrdinalDict = new();
    private static readonly Dictionary<Type, bool> TypeInitialized = new();

    public static List<T> Values<T>() where T : Enum
    {
        var values = OrdinalDict.Select(x => x.Key).OfType<T>().ToList();
        if (values.Count != 0 || TypeInitialized.ContainsKey(typeof(T)))
            return values;

        TypeInitialized[typeof(T)] = true;
        values = typeof(T)
            .GetRuntimeFields()
            .Where(x => x.IsStatic)
            .Select(x => x.GetValue(null))
            .OfType<T>()
            .ToList();


        return values;
    }

    public static T ValueOf<T>(string name) where T : Enum => Values<T>().First(x => x.Name == name);

    public int Ordinal { get; }

    public string Name { get; }

    protected Enum(string name = "")
    {
        int count = OrdinalDict.Count(x => x.Key.GetType() == GetType());
        Name = name;
        Ordinal = count;
        OrdinalDict.Add(this, count);
    }

    public override string ToString()
    {
        return Name;
    }

    private bool Equals(Enum other)
    {
        return Ordinal == other.Ordinal
               && Name == other.Name;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Enum)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(GetType(), Ordinal, Name);
    }
}