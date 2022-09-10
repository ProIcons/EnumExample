using EnumExample;

Console.WriteLine($"{nameof(ExclusionType)}: {ExclusionType.MARKET.Ordinal}:{ExclusionType.MARKET.Name} - {ExclusionType.MARKET.Value}");
Console.WriteLine($"\tGetByValue Equality: {ExclusionType.MARKET == EnumUtils.GetEnumByValue<ExclusionType, string>("Market")}");
Console.WriteLine($"\tValueOf Equality: {ExclusionType.ValueOf<ExclusionType>("MARKET") == ExclusionType.MARKET}");


Console.WriteLine($"{nameof(DataFileCoverage)}: {EnumUtils.GetEnumByValueInList<DataFileCoverage, string>("SVIP").Ordinal}:" +
                  $"{EnumUtils.GetEnumByValueInList<DataFileCoverage, string>("SVIP").Name}");

Console.WriteLine($"{nameof(DataFileCoverage)}: {EnumUtils.GetEnumByValueInList<DataFileCoverage, string>("NSS").Ordinal}:" +
                  $"{EnumUtils.GetEnumByValueInList<DataFileCoverage, string>("NSS").Name}");


Console.WriteLine($"{nameof(SampleType)}: ({EnumUtils.GetEnumByValue<SampleType, int>(1).Ordinal}=" +
                  $"{EnumUtils.GetEnumByStringValue<SampleType>("1").Ordinal}):" +
                  $"({EnumUtils.GetEnumByValue<SampleType, int>(1).Name}=" +
                  $"{EnumUtils.GetEnumByStringValue<SampleType>("1").Name}):");