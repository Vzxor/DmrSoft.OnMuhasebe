using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.BankaHesaplar;

public class BankaHesapListParameterDto:PagedResultRequestDto,IEntityDto,IDurum
{
    public BankaHesapTuru? HesapTuru { get; set; }
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}