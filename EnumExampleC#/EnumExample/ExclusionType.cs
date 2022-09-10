namespace EnumExample;

public class ExclusionType : Enum, EnumWithValue<string>
{
    public static readonly ExclusionType DISTRIBUTOR = new(nameof(DISTRIBUTOR), "Distributor");
    public static readonly ExclusionType MARKET = new(nameof(MARKET), "Market");
    public static readonly ExclusionType MOBILE = new(nameof(MOBILE), "Mobile");
    public static readonly ExclusionType COMPUTER = new(nameof(COMPUTER), "Computer");

    public string Value { get; }

    public ExclusionType(string name, string value) : base(name)
    {
        Value = value;
    }

    public string StringValue => Value;
}