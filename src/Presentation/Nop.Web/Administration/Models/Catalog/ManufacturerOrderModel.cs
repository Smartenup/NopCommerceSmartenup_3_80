using Nop.Core.Domain.Directory;
using Nop.Web.Framework;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Nop.Admin.Models.Catalog
{
    public partial class ManufacturerModel : BaseNopEntityModel, ILocalizedModel<ManufacturerLocalizedModel>
    {
        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.ManufacturingOrderId")]
        [UIHint("Int32Nullable")]
        public int? ManufacturingOrderId { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.DaysLessDeliveryDates")]
        [UIHint("Int32Nullable")]
        public int? DaysLessDeliveryDates { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SaleRepresentativeFirstName")]
        [AllowHtml]
        public string SaleRepresentativeFirstName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SaleRepresentativeLastName")]
        [AllowHtml]
        public string SaleRepresentativeLastName { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SaleRepresentativeEmail")]
        [AllowHtml]
        public string SaleRepresentativeEmail { get; set; }


        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.CountryId")]
        [AllowHtml]
        public int? CountryId { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.StateProvinceId")]
        [AllowHtml]
        public int? StateProvinceId { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.City")]
        [AllowHtml]
        public string City { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.ZipPostalCode")]
        [AllowHtml]
        public string ZipPostalCode { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Address")]
        [AllowHtml]
        public string Address { get; set; }

        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AddressNumber")]
        [AllowHtml]
        public string AddressNumber { get; set; }


        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AddressComplement")]
        [AllowHtml]
        public string AddressComplement { get; set; }


        [NopResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PhoneNumber")]
        [AllowHtml]
        public string PhoneNumber { get; set; }


    }
}