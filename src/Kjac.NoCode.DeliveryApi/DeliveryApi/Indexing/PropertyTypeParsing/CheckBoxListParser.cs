﻿using Umbraco.Cms.Core.Serialization;

namespace Kjac.NoCode.DeliveryApi.DeliveryApi.Indexing.PropertyTypeParsing;

internal class CheckBoxListParser : StringArrayParser
{
    public CheckBoxListParser(IJsonSerializer jsonSerializer)
        : base(jsonSerializer)
    {
    }
}