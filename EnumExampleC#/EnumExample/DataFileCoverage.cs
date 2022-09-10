namespace EnumExample;

public class DataFileCoverage : Enum, EnumWithValue<List<String>>
{
    public static readonly DataFileCoverage LOCAL = new(nameof(LOCAL), "NSI", "NHSI", "NSIBLK", "NSIHSP", "SVIP", "NSIX", "NSIT", "NSIBLKT", "NSIBHSP",
        "NSIOLYT", "LC");

    public static readonly DataFileCoverage NATIONAL = new(nameof(NATIONAL), "NTI", "NSS", "NHI");

    public List<string> Value { get; }

    public DataFileCoverage(string name, params string[] value) : base(name)
    {
        Value = value.ToList();
    }

    public string StringValue => String.Join(", ", Value);
}