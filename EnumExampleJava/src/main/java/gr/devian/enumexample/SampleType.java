package gr.devian.enumexample;

public enum SampleType implements EnumWithValue<Integer> {
    TOTAL_DMA(1),
    HARD_WIRED_CABLE(2),
    TOTAL_DMA_AND_HARD_WIRED_CABLE(3),
    STATION_TOTALS_ONLY(4);

    public static SampleType getByValue(final Integer value) {
        return EnumUtils.getEnumByValue(SampleType.class, value);
    }

    public static SampleType getByStringValue(final String value) {
        return EnumUtils.getEnumByStringValue(SampleType.class, value);
    }

    private final int value;

    SampleType(final int value) {
        this.value = value;
    }

    @Override
    public Integer getValue() {
        return value;
    }

    @Override
    public String getStringValue() {
        return Integer.toString(value);
    }
}
