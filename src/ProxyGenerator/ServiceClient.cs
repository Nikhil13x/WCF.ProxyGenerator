using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Configuration;

namespace WCF.ProxyGenerator
{

    public class ServiceClient<T> : ClientBase<T> where T : class
    {
        private bool _disposed = false;
        public ServiceClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }
        public T Proxy
        {
            get
            {
                return this.Channel;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (this.State == CommunicationState.Faulted)
                    {
                        base.Abort();
                    }
                    else
                    {
                        try
                        {
                            base.Close();
                        }
                        catch
                        {
                            base.Abort();
                        }
                    }
                    _disposed = true;
                }
            }
        }
    }
}