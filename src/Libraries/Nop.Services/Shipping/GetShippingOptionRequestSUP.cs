using Nop.Core.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.Shipping
{
    public partial class GetShippingOptionRequest
    {
        private bool _isOrderBasead = false;

        /// <summary>
        /// Means that the Shipping rate is basead in the placed order
        /// </summary>
        public bool IsOrderBasead
        {
            get { return _isOrderBasead; }
            set { _isOrderBasead = value; }
        }

        /// <summary>
        /// Gets or sets a shipping method name
        /// </summary>
        public string ShippingMethod { get; set; }

        /// <summary>
        /// Gets or sets the system name of shipping rate computation method
        /// </summary>
        public string ShippingRateComputationMethodSystemName { get; set; }
        
        /// <summary>
        /// Gest or set the order placed
        /// </summary>
        public Order Order { get; set; }


        public partial class PackageItem
        {
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="sci">Shopping cart item</param>
            /// <param name="qty">Override "Quantity" property of shopping cart item</param>
            public PackageItem(OrderItem orderItem, int? qty = null)
            {
                this.OrderItem = orderItem;
                this.OverriddenQuantity = qty;
            }


            /// <summary>
            /// Shopping cart item
            /// </summary>
            public OrderItem OrderItem { get; set; }


            public int GetQuantityByOrder()
            {
                if (OverriddenQuantity.HasValue)
                    return OverriddenQuantity.Value;

                return OrderItem.Quantity;
            }
        }
    }
}
