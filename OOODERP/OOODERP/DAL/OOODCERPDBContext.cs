using Microsoft.EntityFrameworkCore;
using OOODERP.Models;

namespace OOODERP.DAL
{
    public class OOODCERPDBContext : DbContext
    {
        public OOODCERPDBContext(DbContextOptions<OOODCERPDBContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<ClientCompanyCustomer>()
                .HasIndex(p => new { p.ClientCompanyID, p.CustomerID })
                .HasName("IX_ClientCompanyCustomer")
                .IsUnique(true);
            modelbuilder.Entity<ClientCompanyCustomerTaxException>()
                .HasIndex(p => new { p.ClientCompanyCustomerID, p.TaxProfileID })
                .HasName("IX_CustomerTaxException")
                .IsUnique(true);
            modelbuilder.Entity<CompanyCustomerSalesOrganization>()
                .HasIndex(p => new { p.ClientCompanyCustomerID, p.SalesOrganizationID, p.DivisionID, p.ChannelID })
                .HasName("IX_CustomerSalesOrganizationDivisionChannel")
                .IsUnique(true);
            modelbuilder.Entity<CustomerBank>()
                .HasIndex(p => new { p.CustomerID, p.BankID, p.CountryCurrencyID })
                .HasName("IX_CustomerIDBankIDCountryCurrency")
                .IsUnique(true);
            modelbuilder.Entity<ItemClientCompanyPlant>()
                .HasIndex(p => new { p.ItemID, p.ClientCompanyPlantID })
                .HasName("IX_ItemClientCompanyPlant")
                .IsUnique(true);
            modelbuilder.Entity<ItemClientCompanyPlantStorageLocation>()
                .HasIndex(p => new { p.ItemClientCompanyPlantID, p.StorageLocationName, p.StorageBinName })
                .HasName("IX_ItemPlantStorageBin")
                .IsUnique(true);
            modelbuilder.Entity<ItemPhoto>()
                .HasIndex(p => new { p.ItemPhotoID, p.ItemID, p.SaleItemID })
                .HasName("IX_ItemPhoto")
                .IsUnique(true);
            modelbuilder.Entity<LegacyItem>()
                .HasIndex(p => new { p.ClientCompanyID, p.LegacyItemCode })
                .HasName("IX_ClientCompanyLegacyItemCode")
                .IsUnique(true);
            modelbuilder.Entity<PriceRule>()
                .HasIndex(p => new { p.PriceRuleTypeID, p.EffectiveDate, p.ExpiryDate, p.PriceRuleQualification1Expression, p.PriceRuleQualification2Expression, p.PriceRuleApplication1Expression, p.PriceRuleApplication2Expression, p.PriceRuleExclusion1Expression, p.PriceRuleExclusion2Expression })
                .HasName("IX_PriceRuleDatesExpression")
                .IsUnique(true);
            modelbuilder.Entity<SaleItemCompanyCustomerSalesOrganization>()
                .HasIndex(p => new { p.SaleItemID, p.CompanyCustomerSalesOrganizationID, p.ItemClientCompanyPlantID })
                .HasName("IX_SaleItemSalesOrganizationPlant")
                .IsUnique(true);
            modelbuilder.Entity<SaleItemCompanyCustomerSalesOrganizationTaxException>()
                .HasIndex(p => new { p.SaleItemCompanyCustomerSalesOrganizationID, p.TaxProfileID })
                .HasName("IX_SaleItemSalesOrgTaxProfile")
                .IsUnique(true);
            modelbuilder.Entity<SaleItemPrice>()
                .HasIndex(p => new { p.SaleItemID, p.CountryID, })
                .HasName("IX_SaleItemIDCountryID")
                .IsUnique(true);
            modelbuilder.Entity<SalesOrderHeader>()
                .HasIndex(p => new { p.DeviceSalesOrderHeaderID, p.CompanyCustomerSalesOrganizationID, p.UserID, p.DeviceIdentification, p.IMEINumber, p.OrderDate })
                .HasName("IX_SalesOrderHeaderOrganizationUserHardwareId")
                .IsUnique(true);
            modelbuilder.Entity<SalesOrderInvoicePayment>()
                .HasIndex(p => p.ReferenceNumberOrComment)
                .HasName("IX_InvoicePaymentReference")
                .IsUnique(true);
            modelbuilder.Entity<SalesOrderLine>()
                .HasIndex(p => new { p.DeviceSalesOrderLineID, p.SalesOrderHeaderID, p.DeviceSalesOrderHeaderID, p.ItemID, p.UserID, p.DeviceIdentification, p.IMEINumber })
                .HasName("IX_SalesOrderLineOrganizationItemUserDevice")
                .IsUnique(true);
            modelbuilder.Entity<SalesOrderLineAdjustment>()
                .HasIndex(p => new { p.DeviceSalesOrderLineAdjustmentID, p.SalesOrderHeaderID, p.DeviceSalesOrderHeaderID, p.SalesOrderLineID, p.DeviceSalesOrderLineID, p.PriceRuleID })
                .HasName("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice")
                .IsUnique(true);
            modelbuilder.Entity<TaxBasicConfiguration>()
                .HasIndex(p => p.TaxApplicationOrder)
                .HasName("IX_TaxApplicationOrder")
                .IsUnique(true);
            modelbuilder.Entity<TaxCode>()
                .HasIndex(p => new { p.CountryID, p.TaxCodeName })
                .HasName("IX_CountryTaxCode")
                .IsUnique(true);
            modelbuilder.Entity<TaxJurisdiction>()
                .HasIndex(p => new { p.CountryCityID, p.CountryCityRegion1ID, p.CountryCityRegion2ID ,p.TaxCodeID })
                .HasName("IX_Jurisdiction_Country_Region1_Region2")
                .IsUnique(true);
            modelbuilder.Entity<User>()
                .HasIndex(p => p.UserName)
                .IsUnique(true);

        }
        public DbSet<OOODERP.Models.Client> Client { get; set; }
    }
}