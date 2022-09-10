namespace EnumExample;

public class SampleType : Enum, EnumWithValue<int>
{
    public static readonly SampleType TOTAL_DMA = new(nameof(TOTAL_DMA), 1);
    public static readonly SampleType HARD_WIRED_CABLE = new(nameof(HARD_WIRED_CABLE), 2);
    public static readonly SampleType TOTAL_DMA_AND_HARD_WIRED_CABLE = new(nameof(TOTAL_DMA_AND_HARD_WIRED_CABLE), 3);
    public static readonly SampleType STATION_TOTALS_ONLY = new(nameof(STATION_TOTALS_ONLY), 4);

    public int Value { get; }

    public SampleType(string name, int value) : base(name)
    {
        Value = value;
    }

    public string StringValue => $"{Value}";
}