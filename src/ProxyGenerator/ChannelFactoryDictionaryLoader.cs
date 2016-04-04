using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeywell.Security.Framework.Utility
{
    public class ChannelFactoryDictionaryLoader<T>
    {
        // static holder for instance, need to use lambda to construct since constructor private
        private static readonly Lazy<ChannelFactoryDictionaryLoader<T>> _instance
            = new Lazy<ChannelFactoryDictionaryLoader<T>>(() => new ChannelFactoryDictionaryLoader<T>());

        public ChannelFactoryDictionaryCreator<T> _endpointDictionary = null;

        // private to ChannelFactoryDictionaryLoader direct instantiation.
        private ChannelFactoryDictionaryLoader()
        {

            //Gets the ChannelFactoryDictionary
            _endpointDictionary = new ChannelFactoryDictionaryCreator<T>();

        }

        // accessor for instance
        public static ChannelFactoryDictionaryLoader<T> Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
