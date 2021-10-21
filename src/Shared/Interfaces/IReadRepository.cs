using System.Collections.Generic;
using Gama.ATM.Shared.Entities;

namespace Gama.ATM.Shared.Interfaces
{
    /// <summary>
    /// Interface para determinar comportamentos de consulta a base de dados
    /// </summary>
    public interface IReadRepository<TEntity> where TEntity : Entity
    {
        public List<TEntity> GetAll();
    }
}