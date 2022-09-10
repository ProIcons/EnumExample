package gr.devian.enumexample;

import java.util.Arrays;
import java.util.List;
import java.util.Objects;
import java.util.function.Function;

public class EnumUtils {
    public static <T extends Enum<T> & EnumWithValue<V>, V> T getEnumByValue(final Class<T> enumClass, final V value) {
        return Arrays
            .stream(enumClass.getEnumConstants())
            .filter(x -> x.compare(value))
            .findFirst()
            .orElse(null);
    }

    public static <T extends Enum<T> & EnumWithValue<List<V>>, V> T getEnumByValueInList(final Class<T> enumClass, final V value) {
        return Arrays
            .stream(enumClass.getEnumConstants())
            .filter(x -> x.getValue().contains(value))
            .findFirst()
            .orElse(null);
    }

    public static <T extends Enum<T> & EnumWithValue<?>> T getEnumByStringValue(final Class<T> enumClass, final String value) {
        return Arrays
            .stream(enumClass.getEnumConstants())
            .filter(x -> Objects.equals(x.getStringValue().toLowerCase(), value.toLowerCase()))
            .findFirst()
            .orElse(null);
    }

    public static <T extends Enum<T> & EnumWithValue<List<?>>> T getEnumByStringValueInList(final Class<T> enumClass, final String value) {
        return Arrays
            .stream(enumClass.getEnumConstants())
            .filter(x -> Arrays.asList(x.getStringValue().split(", ")).contains(value))
            .findFirst()
            .orElse(null);
    }
}

