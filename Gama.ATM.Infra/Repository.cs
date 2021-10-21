using System.Collections.Generic;
using Gama.ATM.Shared.Entities;
using Gama.ATM.Shared.Interfaces;

namespace Gama.ATM.Infra
{
    public class Repository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity> where TEntity : Entity
    {
        public Repository()
        {
            _db = new DataBase<TEntity>();
        }

        private DataBase<TEntity> _db { get; }

        public List<TEntity> GetAll() => _db.GetAll();

        public bool Write(TEntity entity) => _db.Save(entity);
    }
}