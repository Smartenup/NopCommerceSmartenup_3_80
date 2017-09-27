using Nop.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Shipping
{
    public partial interface IShippingRateComputationMethod : IPlugin
    {

        /// <summary>
        ///  Gets available shipping options
        /// </summary>
        /// <param name="getShippingOptionRequest">A request of product for getting shipping options</param>
        /// <returns>Represents a response of getting shipping rate options</returns>
        GetShippingOptionResponse GetShippingOptions(GetShippingOptionProductRequest getShippingOptionProductRequest);
    }
}
