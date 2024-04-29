using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.CommonDtos;

public class CodeParameterDto : IDurum, IEntityDto
{
    public bool Durum { get; set; }
}