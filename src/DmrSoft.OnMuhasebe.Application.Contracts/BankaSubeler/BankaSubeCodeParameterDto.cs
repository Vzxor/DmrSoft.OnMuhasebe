using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.BankaSubeler;

public class BankaSubeCodeParameterDto : IEntityDto, IDurum
{
    public Guid BankaId { get; set; }
    public bool Durum { get; set; }
}