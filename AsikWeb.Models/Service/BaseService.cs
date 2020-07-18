using AsikWeb.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsikWeb.Models.Service
{
    public abstract class BaseService : IDisposable
    {
        protected ASIK_PGWEB_Context Contexto { get; set; }
        protected bool DisposeContext = true;

        #region Metodos de clase

        public void UseContext(ASIK_PGWEB_Context contexto)
        {
            Contexto = contexto;
            DisposeContext = false;
        }

        #endregion

        #region IDisposable Support

        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }
                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.
                disposedValue = true;
            }
        }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
