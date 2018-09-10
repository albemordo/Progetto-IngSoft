﻿using System.Collections.Generic;

namespace AutotrasportiFantini.persistenza
{
    interface IPersistenzaCRUD<TEntity, TId>
    {
        bool aggiorna(TEntity oggetto);
        TId crea(TEntity oggetto);
        List<TEntity> elencaTutti();
        void elimina(TId id);
        TEntity getById(TId id);
    }
}