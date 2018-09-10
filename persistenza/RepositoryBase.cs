using System;
using System.Collections.Generic;
using System.Data;

namespace AutotrasportiFantini.persistenza
{
    abstract class RepositoryBase<TEntity, TId>
    {
        protected IDbConnection connection;

        public RepositoryBase(IDbConnection connection)
        {
            this.connection = connection;
        }

        public abstract TId crea(TEntity oggetto);
        public abstract List<TEntity> elencaTutti();
        public abstract TEntity getById(TId id);
        public abstract Boolean aggiorna(TEntity oggetto);

        public abstract void elimina(TId id);
    }
}
