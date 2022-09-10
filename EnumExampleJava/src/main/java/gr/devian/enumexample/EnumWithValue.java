package gr.devian.enumexample;

public interface EnumWithValue<T> {
    T getValue();

    String getStringValue();

    default boolean compare(final T target) {
        return getValue().equals(target);
    }
}
