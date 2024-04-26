using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DmrSoft.OnMuhasebe.Commons;

//Sadece Raporlamada Kullanacagiz Id Properties Yok
public interface ICommonNoKeyRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    Task<TEntity> FromSqlRawSingleAsync(string sql, params object[] parameters);
    Task<IList<TEntity>> FromSqlRawAsync(string sql, params object[] parameters);
}