package gr.devian.enumexample;

public enum ExclusionType implements EnumWithValue<String> {
    DISTRIBUTOR("Distributor"),
    MARKET("Market"),
    MOBILE("Mobile"),
    COMPUTER("Computer");

    public static ExclusionType getByValue(final String value) {
        return EnumUtils.getEnumByValue(ExclusionType.class, value);
    }

    private final String value;

    ExclusionType(final String value) {
        this.value = value;
    }

    @Override
    public String getValue() {
        return value;
    }

    @Override
    public String getStringValue() {
        return value;
    }
}
