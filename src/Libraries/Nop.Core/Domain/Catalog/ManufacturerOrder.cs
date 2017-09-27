using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Seo;
using Nop.Core.Domain.Stores;

namespace Nop.Core.Domain.Catalog
{
    /// <summary>
    /// Represents the manufacturer's fields used to Manufacturing Order System
    /// </summary>
    public partial class Manufacturer : BaseEntity, ILocalizedEntity, ISlugSupported, IAclSupported, IStoreMappingSupported
    {
        /// <summary>
        /// Get or set manufacturing order Id (purchase)
        /// </summary>
        public int? ManufacturingOrderId { get; set; }

        /// <summary>
        /// Day less considered in the field "Delivery Dates", when is this value is a integer
        /// </summary>
        public int? DaysLessDeliveryDates { get; set; }


        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string SaleRepresentativeFirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string SaleRepresentativeLastName { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string SaleRepresentativeEmail { get; set; }


        /// <summary>
        /// Gets or sets the country identifier
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the state/province identifier
        /// </summary>
        public int? StateProvinceId { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the zip/postal code
        /// </summary>
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address, street, avenue, alley
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the address number
        /// </summary>
        public string AddressNumber { get; set; }


        /// <summary>
        /// Gets or sets the complemnt number
        /// </summary>
        public string AddressComplement { get; set; }


        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// Gets or sets the country
        /// </summary>
        public virtual Country Country { get; set; }

        /// <summary>
        /// Gets or sets the state/province
        /// </summary>
        public virtual StateProvince StateProvince { get; set; }

        

    }
}
