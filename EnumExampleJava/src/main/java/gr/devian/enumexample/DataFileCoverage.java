package gr.devian.enumexample;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public enum DataFileCoverage implements EnumWithValue<List<String>> {
    LOCAL("NSI", "NHSI", "NSIBLK", "NSIHSP", "SVIP", "NSIX", "NSIT", "NSIBLKT", "NSIBHSP", "NSIOLYT", "LC"),
    NATIONAL("NTI", "NSS", "NHI");

    public static DataFileCoverage getByValue(final String value) {
        return EnumUtils.getEnumByValueInList(DataFileCoverage.class, value);
    }

    private final List<String> value;

    DataFileCoverage(final String... value) {
        this.value = Arrays.stream(value).collect(Collectors.toList());
    }

    @Override
    public List<String> getValue() {
        return value;
    }

    @Override
    public String getStringValue() {
        return String.join(", ", value);
    }


    @Override
    public String toString() {
        return getStringValue();
    }
}
