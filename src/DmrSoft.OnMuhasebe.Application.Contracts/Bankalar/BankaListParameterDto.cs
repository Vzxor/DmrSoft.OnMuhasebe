using DmrSoft.OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace DmrSoft.OnMuhasebe.Bankalar;

public class BankaListParameterDto:PagedResultRequestDto,IEntityDto,IDurum
{
    public bool Durum { get; set; }
}