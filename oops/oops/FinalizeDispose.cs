using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops
{
    public class FinalizeDispose : IDisposable
    {
        private bool _disposed = false;

        public FinalizeDispose()
        {
            // allocate or initialize an unmanaged resource
            Console.WriteLine("Unmanaged resource allocated.");
        }
        // Implementing Dispose method from IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // free any other managed objects here.
                    Console.WriteLine("Free other managed objects.");
                }
                // free unmanaged resource released.
                _disposed = true;
            }
        }
        ~FinalizeDispose()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called. ");
        }
    }
}
