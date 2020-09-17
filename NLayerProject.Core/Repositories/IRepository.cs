using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        //Id' e göre getir.Get by id
        Task<TEntity> GetByIdAsync(int id);
        //Hepsini getir.Get all
        Task<IEnumerable<TEntity>> GetAllAsync();

        //find(x=> x.id=23), Girilen paremetreye göre. 
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity,bool>> predicate);

        //category.SingleOrDefaultAsync(x=>x.name="pencil")
        Task<TEntity>SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        
        Task AddAsync(TEntity entity);
        //Toplu ürün ekleme, add more than one product
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        
        void Remove(TEntity entity);
        //Toplu sil
        void RemoveRange(IEnumerable<TEntity> entity);

        TEntity Update(TEntity entity);
    }
}
