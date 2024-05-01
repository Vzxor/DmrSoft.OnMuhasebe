using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Faturalar;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Stoklar;

public class StokHareketListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public FaturaHareketTuru? HareketTuru { get; set; }
    public Guid EntityId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}