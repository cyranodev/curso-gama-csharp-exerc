using System;
using System.Collections.Generic;
using Gama.ATM.Shared.Interfaces;

namespace Gama.ATM.Queries
{
    public class ReadWithdrawalsQuery : IDisposable
    {
        private readonly IReadRepository<Takeout> _repository;
        private bool disposedValue;

        public ReadWithdrawalsQuery(IReadRepository<Takeout> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public List<Takeout> ReadAll()
        {
            return _repository.GetAll();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged
        // resources ~WriteWithdrawQuery() { // Não altere este código. Coloque o código de limpeza
        // no método 'Dispose(bool disposing)' Dispose(disposing: false); }
    }
}