using System;
using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Faturalar;

public class FaturaListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public FaturaTuru FaturaTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid? DonemId { get; set; }
    public bool Durum { get; set; }
}