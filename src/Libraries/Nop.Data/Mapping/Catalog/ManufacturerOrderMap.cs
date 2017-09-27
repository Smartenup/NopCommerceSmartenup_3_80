using Nop.Core.Domain.Catalog;

namespace Nop.Data.Mapping.Catalog
{
    public partial class ManufacturerMap : NopEntityTypeConfiguration<Manufacturer>
    {

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected override void PostInitialize()
        {
            Property(a => a.ManufacturingOrderId).IsRequired();

            Property(a => a.SaleRepresentativeFirstName).IsRequired().HasMaxLength(400);

            Property(a => a.SaleRepresentativeLastName).IsRequired().HasMaxLength(400);

            Property(a => a.SaleRepresentativeEmail).IsRequired().HasMaxLength(1000);

            Property(a => a.CountryId).IsOptional();

            Property(a => a.StateProvinceId).IsOptional();

            Property(a => a.City).IsOptional();

            Property(a => a.ZipPostalCode).IsOptional();

            Property(a => a.Address).IsOptional();

            Property(a => a.AddressNumber).IsOptional();

            Property(a => a.AddressComplement).IsOptional();

            Property(a => a.PhoneNumber).IsRequired();

            HasOptional(a => a.Country)
                .WithMany()
                .HasForeignKey(a => a.CountryId).WillCascadeOnDelete(false);

            HasOptional(a => a.StateProvince)
                .WithMany()
                .HasForeignKey(a => a.StateProvinceId).WillCascadeOnDelete(false);

        }
    }
}
