using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeywell.Security.Framework.Utility
{
    public class ContractEndPointMapLoader
    {
        //static holder for Contract-Endpoint map created from config file.
        private static readonly Lazy<ContractEndPointMapLoader> _instance
           = new Lazy<ContractEndPointMapLoader>(() => new ContractEndPointMapLoader());

        public IDictionary<string, string> ContractEndpointMapping = new Dictionary<string, string>();

        private ContractEndPointMapLoader()
        {
            ContractEndpointMapping = (ConfigurationManager.GetSection("ContractEndpointMapping") as System.Collections.Hashtable)
                 .Cast<System.Collections.DictionaryEntry>()
                 .ToDictionary(n => n.Key.ToString(), n => n.Value.ToString());
        }
         // accessor for instance
        public static ContractEndPointMapLoader Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }

    
}
