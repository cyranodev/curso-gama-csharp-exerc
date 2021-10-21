using Gama.ATM.Shared.Entities;

namespace Gama.ATM.Shared.Interfaces
{
    /// <summary>
    /// Interface para determinar comportamentos de consulta a base de dados
    /// </summary>
    public interface IWriteRepository<TEntity> where TEntity : Entity
    {
        public bool Write(TEntity entity);
    }
}