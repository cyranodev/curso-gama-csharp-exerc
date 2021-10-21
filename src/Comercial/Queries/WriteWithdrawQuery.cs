using System;
using Gama.ATM.Shared.Interfaces;

namespace Gama.ATM.Queries
{
    public class WriteWithdrawQuery : IDisposable
    {
        private readonly IWriteRepository<Takeout> _repository;
        private bool disposedValue;

        public WriteWithdrawQuery(IWriteRepository<Takeout> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public bool Write(Takeout takeout)
        {
            _repository.Write(takeout);

            return true;
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