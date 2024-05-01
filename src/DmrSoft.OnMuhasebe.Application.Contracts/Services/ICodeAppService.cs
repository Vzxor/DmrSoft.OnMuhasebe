using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DmrSoft.OnMuhasebe.Services;

public interface ICodeAppService<in TGetCodeInput>:IApplicationService
{
    Task<string> GetCodeAsync(TGetCodeInput input);
}