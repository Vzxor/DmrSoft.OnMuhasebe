using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Donemler;

public class DonemListParameterDto:PagedResultRequestDto,IDurum,IEntityDto
{
    public bool Durum { get; set; }
}