using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Honeywell.Security.Framework.Utility
{

    public static class ServiceProxy<T>
    {
        public static ChannelFactory<T> _channelFactory;

        public static T GetProxy(string EndPointConfiguration)
        {
            if (ChannelFactoryDictionaryLoader<T>.Instance._endpointDictionary.ChannelFactoryDictionary.ContainsKey(EndPointConfiguration))
                _channelFactory = ChannelFactoryDictionaryLoader<T>.Instance._endpointDictionary.ChannelFactoryDictionary[EndPointConfiguration];
            else
            {
                _channelFactory = new ChannelFactory<T>(EndPointConfiguration);
                ChannelFactoryDictionaryLoader<T>.Instance._endpointDictionary.ChannelFactoryDictionary.Add(EndPointConfiguration, _channelFactory);
            }

            _channelFactory = new ChannelFactory<T>(EndPointConfiguration);
            T proxy = (T)_channelFactory.CreateChannel();
            return proxy;
        }
    } 
}
