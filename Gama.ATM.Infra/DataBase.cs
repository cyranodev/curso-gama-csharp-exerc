using System.Collections.Generic;

namespace Gama.ATM.Infra
{
    internal class DataBase<TEntity>
    {
        public DataBase()
        {
            DB_Table = new List<TEntity>();
        }

        private List<TEntity> DB_Table { get; init; }

        internal List<TEntity> GetAll()
        {
            return DB_Table;
        }

        internal bool Save(TEntity entity)
        {
            DB_Table.Add(entity);
            return true;
        }
    }
}