using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.BankaHesaplar;

public class BankaHesapCodeParameterDto:IEntityDto,IDurum
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}