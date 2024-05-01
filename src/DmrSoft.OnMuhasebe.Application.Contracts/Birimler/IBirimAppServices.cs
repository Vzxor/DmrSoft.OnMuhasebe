using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Birimler;

public interface IBirimAppServices : ICrudAppService<SelectBirimDto, ListBirimDto, BirimListParameterDto, CreateBirimDto,
    UpdateBirimDto, CodeParameterDto>
{
}