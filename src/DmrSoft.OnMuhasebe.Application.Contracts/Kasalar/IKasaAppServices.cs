using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Kasalar;

public interface IKasaAppServices : ICrudAppService<SelectKasaDto, ListKasaDto, KasaListParameterDto, CreateKasaDto,
    UpdateKasaDto, KasaCodeParameterDto>
{
}