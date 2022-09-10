namespace EnumExample;

public interface EnumWithValue
{
    string StringValue { get; }
}

public interface EnumWithValue<T> : EnumWithValue
{
    T Value { get; }

    bool Compare(T value) => Equals(Value, value);
}