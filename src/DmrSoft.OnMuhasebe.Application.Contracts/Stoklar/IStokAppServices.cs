using DmrSoft.OnMuhasebe.CommonDtos;
using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Stoklar;

public interface IStokAppServices : ICrudAppService<SelectStokDto, ListStokDto, StokListParameterDto, CreateStokDto,
    UpdateStokDto, CodeParameterDto>
{
}