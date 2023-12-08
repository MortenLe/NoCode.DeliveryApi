﻿using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace Kjac.NoCode.DeliveryApi.Models.Dtos;

internal abstract class DtoBase
{
    [Column("id")]
    [PrimaryKeyColumn(AutoIncrement = true)]
    public int Id { get; set; }

    [Column(Name = "key")]
    [NullSetting(NullSetting = NullSettings.NotNull)]
    public Guid Key { get; set; }

    [Column(Name = "name")]
    [NullSetting(NullSetting = NullSettings.NotNull)]
    [Length(50)]
    public string Name { get; set; } = null!;

    [Column(Name = "alias")]
    [NullSetting(NullSetting = NullSettings.NotNull)]
    [Length(60)]
    public string Alias { get; set; } = null!;

    [Column(Name = "primitive")]
    [NullSetting(NullSetting = NullSettings.NotNull)]
    [Length(20)]
    public string PrimitiveFieldType { get; set; } = null!;

    [Column(Name = "fieldName")]
    [NullSetting(NullSetting = NullSettings.NotNull)]
    [Length(20)]
    public string IndexFieldName { get; set; } = null!;
}