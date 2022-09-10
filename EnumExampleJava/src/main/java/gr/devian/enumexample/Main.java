package gr.devian.enumexample;

public class Main {

    public static void main(String[] args) {
        System.out.printf(
            "%s: %d:%s - %s%n\tGetByValue Equality: %s%n\tvalueOf Equality: %s%n",
            ExclusionType.class.getSimpleName(),
            ExclusionType.MARKET.ordinal(),
            ExclusionType.MARKET.name(),
            ExclusionType.MARKET.getValue(),
            ExclusionType.MARKET == ExclusionType.getByValue("Market"),
            ExclusionType.valueOf(ExclusionType.class, "MARKET") == ExclusionType.MARKET
        );

        System.out.printf(
            "%s: %d:%s%n",
            DataFileCoverage.class.getSimpleName(),
            EnumUtils.getEnumByValueInList(DataFileCoverage.class, "SVIP").ordinal(),
            EnumUtils.getEnumByValueInList(DataFileCoverage.class, "SVIP").name()
        );

        System.out.printf(
            "%s: %d:%s%n",
            DataFileCoverage.class.getSimpleName(),
            EnumUtils.getEnumByValueInList(DataFileCoverage.class, "NSS").ordinal(),
            EnumUtils.getEnumByValueInList(DataFileCoverage.class, "NSS").name()
        );


        System.out.printf(
            "%s: (%d=%d):(%s=%s)%n",
            SampleType.class.getSimpleName(),
            EnumUtils.getEnumByStringValue(SampleType.class, "1").ordinal(),
            EnumUtils.getEnumByValue(SampleType.class, 1).ordinal(),
            EnumUtils.getEnumByStringValue(SampleType.class, "1").name(),
            EnumUtils.getEnumByValue(SampleType.class, 1).name()
        );
    }

}
