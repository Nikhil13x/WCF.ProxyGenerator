using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Honeywell.Security.Framework.Utility
{
    public class ChannelFactoryDictionaryCreator<T>
    {
        //Dictionary to hold the ChannelFactory per Contract type passed
        public Dictionary<string, ChannelFactory<T>> ChannelFactoryDictionary = null;

        public ChannelFactory<T> _channelFactory;

        public ChannelFactoryDictionaryCreator()
        {
            ChannelFactoryDictionary = new Dictionary<string, ChannelFactory<T>>();

            //foreach (var entry in ContractEndPointMapLoader.Instance.ContractEndpointMapping)
            //{
            //    if (entry.Value == typeof(T).Name)
            //    {
            //        _channelFactory = new ChannelFactory<T>(entry.Key);
            //        ChannelFactoryDictionary.Add(entry.Key, _channelFactory);
            //    }
            //}         
        }

    }
}
