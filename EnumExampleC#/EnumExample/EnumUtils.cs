namespace EnumExample;

public sealed class EnumUtils
{
    private EnumUtils()
    {
    }

    public static T GetEnumByValue<T, V>(V value) where T : Enum, EnumWithValue<V> => Enum.Values<T>()
        .FirstOrDefault(x => x.Compare(value));

    public static T GetEnumByValueInList<T, V>(V value) where T : Enum, EnumWithValue<List<V>> => Enum.Values<T>()
        .FirstOrDefault(x => x.Value.Contains(value));

    public static T GetEnumByStringValue<T>(string value) where T : Enum, EnumWithValue => Enum.Values<T>()
        .FirstOrDefault(x => x.StringValue.Equals(value));

    public static T GetEnumByStringValueInList<T>(string value) where T : Enum, EnumWithValue => Enum.Values<T>()
        .FirstOrDefault(x => x.StringValue.Split(", ").Contains(value));
}