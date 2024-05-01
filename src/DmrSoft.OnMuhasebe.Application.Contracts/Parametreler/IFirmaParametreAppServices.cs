using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Parametreler;

public interface IFirmaParametreAppServices : ICrudAppService<SelectFirmaParametreDto, SelectFirmaParametreDto,
    FirmaParametreListParameterDto, CreateFirmaParametereDto, UpdateFirmaParametreDto>
{
}