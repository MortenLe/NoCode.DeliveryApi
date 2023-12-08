﻿using System.Runtime.Serialization;
using Kjac.NoCode.DeliveryApi.Models;

namespace Kjac.NoCode.DeliveryApi.ViewModels;

[DataContract]
public abstract class ItemViewModelBase
{
    [DataMember(Name = "key")]
    public required Guid Key { get; init; }

    [DataMember(Name = "name")]
    public required string Name { get; init; }

    [DataMember(Name = "alias")]
    public required string Alias { get; init; }

    [DataMember(Name = "fieldName")]
    public required string FieldName { get; init; }

    [DataMember(Name = "primitiveFieldType")]
    public required PrimitiveFieldType PrimitiveFieldType { get; init; }
}