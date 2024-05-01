using DmrSoft.OnMuhasebe.Services;

namespace DmrSoft.OnMuhasebe.Makbuzlar;

public interface IMakbuzAppServices : ICrudAppService<SelectMakbuzDto, ListMakbuzDto, MakbuzListParameterDto,
    CreateMakbuzDto, UpdateMakbuzDto, MakbuzNoParameterDto>
{
}