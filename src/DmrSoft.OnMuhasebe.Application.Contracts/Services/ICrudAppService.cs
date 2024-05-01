using System;
using Volo.Abp.Application.Services;

namespace DmrSoft.OnMuhasebe.Services;

//Select  List   listparameter  create  Update sorgularinda Kullanilacak Crud islemi
public interface
    ICrudAppService<TGetOutputDto, TGetListOutputDto, in TGetListInput, in TCreateInput, in TUpdateInput> :
    IReadOnlyAppService<TGetOutputDto, TGetListOutputDto, Guid, TGetListInput>,
    ICreateAppService<TGetOutputDto, TCreateInput>,
    IUpdateAppService<TGetOutputDto, Guid, TUpdateInput>
{
}

public interface
    ICrudAppService<TGetOutputDto, TGetListOutputDto, in TGetListInput, in TCreateInput, in TUpdateInput,
        TGetCodeInput> : 
    ICrudAppService<TGetOutputDto, TGetListOutputDto,  TGetListInput,  TCreateInput,  TUpdateInput>,
    IDeleteAppService<Guid>,
    ICodeAppService<TGetCodeInput>
{
    
} 