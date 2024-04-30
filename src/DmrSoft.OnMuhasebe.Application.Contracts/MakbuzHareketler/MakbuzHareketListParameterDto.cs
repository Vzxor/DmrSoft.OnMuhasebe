using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Makbuzlar;
using OpenIddict.Abstractions;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.MakbuzHareketler;

public class MakbuzHareketListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public Guid EntityId { get; set; }
    public OdemeTuru OdemeTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}