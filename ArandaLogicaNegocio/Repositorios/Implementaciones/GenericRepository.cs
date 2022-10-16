using ArandaLogicaNegocio.Dotos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;


namespace ArandaLogicaNegocio.Repositorios.Implementaciones
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ArandaContext arandaContext;

        public GenericRepository(ArandaContext arandaContext)
        {
            this.arandaContext = arandaContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            arandaContext.Set<TEntity>().Remove(entity);
            await arandaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await arandaContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await arandaContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            arandaContext.Set<TEntity>().Add(entity);
            await arandaContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            //arandaContext.Entry(entity).State = EntityState.Modified;
            arandaContext.Set<TEntity>().AddOrUpdate(entity);
            await arandaContext.SaveChangesAsync();
            return entity;
        }
    }
}
