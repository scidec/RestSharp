﻿namespace RestSharp.Tests.Parameters;

public partial class ObjectParameterTests {
    sealed record CsvData<TEnumerable>([property: RequestProperty(ArrayQueryType = RequestArrayQueryType.CommaSeparated)] TEnumerable Csv) where TEnumerable : notnull;
}
