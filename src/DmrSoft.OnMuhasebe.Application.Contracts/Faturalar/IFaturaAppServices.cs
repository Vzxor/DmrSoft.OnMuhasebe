using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Faturalar;

public interface IFaturaAppServices : ICrudAppService<SelectFaturaDto, ListFaturaDto, FaturaListParameterDto,
    CreateFaturaDto, UpdateFaturaDto, FaturaNoParameterDto>
{
}