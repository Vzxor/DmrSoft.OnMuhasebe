using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Makbuzlar;

public class MakbuzListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public MakbuzTuru MAkbuzturu { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}