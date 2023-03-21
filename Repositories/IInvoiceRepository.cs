using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crop_Deal_Web_API.Repository
{
    public interface IInvoiceRepository<TEntity> where TEntity : class

    {
        #region Funtion Declaration
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> ViewInvoices();
        Task<TEntity> Edit(TEntity entity);
        Task<TEntity> Add(TEntity entity);
        Task Delete(int id);
        Task Save();
        #endregion

    }
}
