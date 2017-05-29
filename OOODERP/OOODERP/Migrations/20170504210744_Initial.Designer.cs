using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OOODERP.DAL;

namespace OOODERP.Migrations
{
    [DbContext(typeof(OOODCERPDBContext))]
    [Migration("20170504210744_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OOODERP.Models.Bank", b =>
                {
                    b.Property<int>("BankID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankBranch");

                    b.Property<string>("Comments");

                    b.Property<int>("CountryCityID");

                    b.Property<int>("CountryID");

                    b.Property<string>("IBANNumber");

                    b.Property<string>("NameOfBank");

                    b.Property<string>("PhysicalAddress1");

                    b.Property<string>("PhysicalAddress2");

                    b.Property<string>("PostalAddress");

                    b.Property<string>("PostalCode");

                    b.Property<string>("SwiftCode")
                        .HasMaxLength(11);

                    b.HasKey("BankID");

                    b.HasIndex("CountryCityID");

                    b.HasIndex("CountryID");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("OOODERP.Models.Channel", b =>
                {
                    b.Property<int>("ChannelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelName");

                    b.HasKey("ChannelID");

                    b.ToTable("Channel");
                });

            modelBuilder.Entity("OOODERP.Models.Classification1", b =>
                {
                    b.Property<int>("Classification1ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassificationDescription");

                    b.Property<string>("ClassificationName");

                    b.HasKey("Classification1ID");

                    b.ToTable("Classification1");
                });

            modelBuilder.Entity("OOODERP.Models.Classification2", b =>
                {
                    b.Property<int>("Classification2ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassificationDescription");

                    b.Property<string>("ClassificationName");

                    b.HasKey("Classification2ID");

                    b.ToTable("Classification2");
                });

            modelBuilder.Entity("OOODERP.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompany", b =>
                {
                    b.Property<int>("ClientCompanyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientCompanyName");

                    b.Property<int>("ClientID");

                    b.Property<int>("CountryID");

                    b.HasKey("ClientCompanyID");

                    b.HasIndex("ClientID");

                    b.HasIndex("CountryID");

                    b.ToTable("ClientCompany");
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomer", b =>
                {
                    b.Property<int>("ClientCompanyCustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountIDAtCustomer");

                    b.Property<int>("ClientCompanyID");

                    b.Property<string>("ContactPersonAtCustomer");

                    b.Property<int>("CustomerID");

                    b.Property<int>("PaymentTermID");

                    b.Property<int>("PersonnelID");

                    b.HasKey("ClientCompanyCustomerID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("PaymentTermID");

                    b.HasIndex("PersonnelID");

                    b.HasIndex("ClientCompanyID", "CustomerID")
                        .IsUnique()
                        .HasName("IX_ClientCompanyCustomer");

                    b.ToTable("ClientCompanyCustomer");
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomerCreditLimit", b =>
                {
                    b.Property<int>("ClientCompanyCustomerCreditLimitID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientCompanyCustomerID");

                    b.Property<int>("CreditCheckStatusID");

                    b.Property<decimal>("CreditLimitAmount");

                    b.Property<decimal>("CreditLimitTolerance");

                    b.Property<decimal>("OrderCreditLimitAmount");

                    b.HasKey("ClientCompanyCustomerCreditLimitID");

                    b.HasIndex("ClientCompanyCustomerID");

                    b.HasIndex("CreditCheckStatusID");

                    b.ToTable("ClientCompanyCustomerCreditLimit");
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomerTaxException", b =>
                {
                    b.Property<int>("ClientCompanyCustomerTaxExceptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientCompanyCustomerID");

                    b.Property<int>("TaxProfileID");

                    b.HasKey("ClientCompanyCustomerTaxExceptionID");

                    b.HasIndex("TaxProfileID");

                    b.HasIndex("ClientCompanyCustomerID", "TaxProfileID")
                        .IsUnique()
                        .HasName("IX_CustomerTaxException");

                    b.ToTable("ClientCompanyCustomerTaxException");
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyPlant", b =>
                {
                    b.Property<int>("ClientCompanyPlantID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientCompanyID");

                    b.Property<string>("PlantName");

                    b.Property<string>("PlantNameDescription");

                    b.HasKey("ClientCompanyPlantID");

                    b.HasIndex("ClientCompanyID");

                    b.ToTable("ClientCompanyPlant");
                });

            modelBuilder.Entity("OOODERP.Models.CompanyCustomerSalesOrganization", b =>
                {
                    b.Property<int>("CompanyCustomerSalesOrganizationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChannelID");

                    b.Property<int>("ClientCompanyCustomerID");

                    b.Property<int>("CountryID");

                    b.Property<int>("DivisionID");

                    b.Property<int>("PaymentTermID");

                    b.Property<int>("PersonnelID");

                    b.Property<int>("SalesOrganizationID");

                    b.HasKey("CompanyCustomerSalesOrganizationID");

                    b.HasIndex("ChannelID");

                    b.HasIndex("CountryID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("PaymentTermID");

                    b.HasIndex("PersonnelID");

                    b.HasIndex("SalesOrganizationID");

                    b.HasIndex("ClientCompanyCustomerID", "SalesOrganizationID", "DivisionID", "ChannelID")
                        .IsUnique()
                        .HasName("IX_CustomerSalesOrganizationDivisionChannel");

                    b.ToTable("CompanyCustomerSalesOrganization");
                });

            modelBuilder.Entity("OOODERP.Models.CompanyCustomerSalesOrganizationCreditLimit", b =>
                {
                    b.Property<int>("CompanyCustomerSalesOrganizationCreditLimitID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyCustomerSalesOrganizationID");

                    b.Property<int>("CreditCheckStatusID");

                    b.Property<decimal>("CreditLimitAmount");

                    b.Property<decimal>("CreditLimitTolerance");

                    b.Property<decimal>("OrderCreditLimitAmount");

                    b.HasKey("CompanyCustomerSalesOrganizationCreditLimitID");

                    b.HasIndex("CompanyCustomerSalesOrganizationID");

                    b.HasIndex("CreditCheckStatusID");

                    b.ToTable("CompanyCustomerSalesOrganizationCreditLimit");
                });

            modelBuilder.Entity("OOODERP.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("CountryName")
                        .IsRequired();

                    b.HasKey("CountryID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("OOODERP.Models.CountryCity", b =>
                {
                    b.Property<int>("CountryCityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int>("CountryID");

                    b.HasKey("CountryCityID");

                    b.HasIndex("CountryID");

                    b.ToTable("CountryCity");
                });

            modelBuilder.Entity("OOODERP.Models.CountryCityRegion1", b =>
                {
                    b.Property<int>("CountryCityRegion1ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryCityID");

                    b.Property<string>("Region1");

                    b.HasKey("CountryCityRegion1ID");

                    b.HasIndex("CountryCityID");

                    b.ToTable("CountryCityRegion1");
                });

            modelBuilder.Entity("OOODERP.Models.CountryCityRegion2", b =>
                {
                    b.Property<int>("CountryCityRegion2ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryCityID");

                    b.Property<string>("Region2");

                    b.HasKey("CountryCityRegion2ID");

                    b.HasIndex("CountryCityID");

                    b.ToTable("CountryCityRegion2");
                });

            modelBuilder.Entity("OOODERP.Models.CountryCurrency", b =>
                {
                    b.Property<int>("CountryCurrencyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("CurrencyName")
                        .IsRequired();

                    b.HasKey("CountryCurrencyID");

                    b.HasIndex("CountryID");

                    b.ToTable("CountryCurrency");
                });

            modelBuilder.Entity("OOODERP.Models.CreditCheckStatus", b =>
                {
                    b.Property<int>("CreditCheckStatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreditCheckStatusName");

                    b.HasKey("CreditCheckStatusID");

                    b.ToTable("CreditCheckStatus");
                });

            modelBuilder.Entity("OOODERP.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Classification1ID");

                    b.Property<int>("Classification2ID");

                    b.Property<int>("CountryCityID");

                    b.Property<int>("CountryCityRegion1ID");

                    b.Property<int>("CountryCityRegion2ID");

                    b.Property<int>("CountryID");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("Email1");

                    b.Property<string>("Email2");

                    b.Property<string>("Fax1");

                    b.Property<string>("Fax2");

                    b.Property<int>("LanguageID");

                    b.Property<string>("Mobile1")
                        .IsRequired();

                    b.Property<string>("Mobile2");

                    b.Property<string>("PhysicalAddress1")
                        .IsRequired();

                    b.Property<string>("PhysicalAddress2");

                    b.Property<string>("PostalAddress1")
                        .IsRequired();

                    b.Property<string>("PostalAddress2");

                    b.Property<string>("PostalCode1");

                    b.Property<string>("PostalCode2");

                    b.Property<string>("TaxNumber1");

                    b.Property<string>("TaxNumber2");

                    b.Property<string>("Telephone1")
                        .IsRequired();

                    b.Property<string>("Telephone2");

                    b.HasKey("CustomerID");

                    b.HasIndex("Classification1ID");

                    b.HasIndex("Classification2ID");

                    b.HasIndex("CountryCityID");

                    b.HasIndex("CountryCityRegion1ID");

                    b.HasIndex("CountryCityRegion2ID");

                    b.HasIndex("CountryID");

                    b.HasIndex("LanguageID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OOODERP.Models.CustomerBank", b =>
                {
                    b.Property<int>("CustomerBankID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankAccountName")
                        .IsRequired();

                    b.Property<string>("BankAccountNumber");

                    b.Property<int>("BankID");

                    b.Property<int>("CountryCurrencyID");

                    b.Property<int>("CustomerID");

                    b.Property<string>("SpecialInstructions");

                    b.HasKey("CustomerBankID");

                    b.HasIndex("BankID");

                    b.HasIndex("CountryCurrencyID");

                    b.HasIndex("CustomerID", "BankID", "CountryCurrencyID")
                        .IsUnique()
                        .HasName("IX_CustomerIDBankIDCountryCurrency");

                    b.ToTable("CustomerBank");
                });

            modelBuilder.Entity("OOODERP.Models.Device", b =>
                {
                    b.Property<int>("DeviceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceMake");

                    b.Property<string>("DeviceModel");

                    b.Property<string>("Identifier1");

                    b.Property<string>("Indentfier2");

                    b.Property<string>("ModelNumber");

                    b.Property<string>("SerialNumber");

                    b.HasKey("DeviceID");

                    b.ToTable("Device");
                });

            modelBuilder.Entity("OOODERP.Models.Division", b =>
                {
                    b.Property<int>("DivisionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DivisionName");

                    b.HasKey("DivisionID");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("OOODERP.Models.InvoiceStatus", b =>
                {
                    b.Property<int>("InvoiceStatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("InvoiceStatusDescription");

                    b.Property<string>("InvoiceStatusName");

                    b.HasKey("InvoiceStatusID");

                    b.ToTable("InvoiceStatus");
                });

            modelBuilder.Entity("OOODERP.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarCodeNumber");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("DivisionID");

                    b.Property<float>("GrossWeight");

                    b.Property<float>("Height");

                    b.Property<int>("ItemBrandID");

                    b.Property<int>("ItemDimensionUnitID");

                    b.Property<int>("ItemStatusID");

                    b.Property<int>("ItemTypeID");

                    b.Property<int>("ItemUnitOfMeasureID");

                    b.Property<int>("ItemVolumeUnitID");

                    b.Property<int>("ItemWeightUnitID");

                    b.Property<float>("Length");

                    b.Property<float>("NetWeight");

                    b.Property<int>("NumberOfPiecesInItem");

                    b.Property<float>("VolumeSize");

                    b.Property<float>("Width");

                    b.HasKey("ItemID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("ItemBrandID");

                    b.HasIndex("ItemDimensionUnitID");

                    b.HasIndex("ItemStatusID");

                    b.HasIndex("ItemTypeID");

                    b.HasIndex("ItemUnitOfMeasureID");

                    b.HasIndex("ItemVolumeUnitID");

                    b.HasIndex("ItemWeightUnitID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("OOODERP.Models.ItemBrand", b =>
                {
                    b.Property<int>("ItemBrandID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemBrandName");

                    b.HasKey("ItemBrandID");

                    b.ToTable("ItemBrand");
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlant", b =>
                {
                    b.Property<int>("ItemClientCompanyPlantID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ABCClassification");

                    b.Property<int>("ClientCompanyPlantID");

                    b.Property<int>("ItemID");

                    b.Property<int>("ItemStatusID");

                    b.Property<int>("MakeBuyGoodsID");

                    b.Property<decimal>("ReorderLevelQuantity");

                    b.Property<decimal>("SafetyStockQuantity");

                    b.HasKey("ItemClientCompanyPlantID");

                    b.HasIndex("ClientCompanyPlantID");

                    b.HasIndex("ItemStatusID");

                    b.HasIndex("MakeBuyGoodsID");

                    b.HasIndex("ItemID", "ClientCompanyPlantID")
                        .IsUnique()
                        .HasName("IX_ItemClientCompanyPlant");

                    b.ToTable("ItemClientCompanyPlant");
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlantStorageLocation", b =>
                {
                    b.Property<int>("ItemClientCompanyPlantStorageLocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemClientCompanyPlantID");

                    b.Property<string>("StorageBinDescription");

                    b.Property<string>("StorageBinName")
                        .HasMaxLength(40);

                    b.Property<string>("StorageLocationDescription");

                    b.Property<string>("StorageLocationName")
                        .HasMaxLength(40);

                    b.HasKey("ItemClientCompanyPlantStorageLocationID");

                    b.HasIndex("ItemClientCompanyPlantID", "StorageLocationName", "StorageBinName")
                        .IsUnique()
                        .HasName("IX_ItemPlantStorageBin");

                    b.ToTable("ItemClientCompanyPlantStorageLocation");
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlantStorageLocationCurrentStock", b =>
                {
                    b.Property<int>("ItemClientCompanyPlantStorageLocationCurrentStockID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AllocatedStock");

                    b.Property<decimal>("AvailableStock");

                    b.Property<int>("ItemClientCompanyPlantStorageLocationID");

                    b.HasKey("ItemClientCompanyPlantStorageLocationCurrentStockID");

                    b.HasIndex("ItemClientCompanyPlantStorageLocationID");

                    b.ToTable("ItemClientCompanyPlantStorageLocationCurrentStock");
                });

            modelBuilder.Entity("OOODERP.Models.ItemDescription", b =>
                {
                    b.Property<int>("ItemDescriptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemFullDescription");

                    b.Property<int>("ItemID");

                    b.Property<int>("LanguageID");

                    b.HasKey("ItemDescriptionID");

                    b.HasIndex("ItemID");

                    b.HasIndex("LanguageID");

                    b.ToTable("ItemDescription");
                });

            modelBuilder.Entity("OOODERP.Models.ItemDimensionUnit", b =>
                {
                    b.Property<int>("ItemDimensionUnitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemDimensionUnitDescription");

                    b.Property<string>("ItemDimensionUnitSymbol");

                    b.HasKey("ItemDimensionUnitID");

                    b.ToTable("ItemDimensionUnit");
                });

            modelBuilder.Entity("OOODERP.Models.ItemPhoto", b =>
                {
                    b.Property<int>("ItemPhotoID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemID");

                    b.Property<byte>("Photo");

                    b.Property<int>("SaleItemID");

                    b.HasKey("ItemPhotoID");

                    b.HasIndex("ItemID");

                    b.HasIndex("SaleItemID");

                    b.HasIndex("ItemPhotoID", "ItemID", "SaleItemID")
                        .IsUnique()
                        .HasName("IX_ItemPhoto");

                    b.ToTable("ItemPhoto");
                });

            modelBuilder.Entity("OOODERP.Models.ItemStatus", b =>
                {
                    b.Property<int>("ItemStatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemStatusDescription");

                    b.HasKey("ItemStatusID");

                    b.ToTable("ItemStatus");
                });

            modelBuilder.Entity("OOODERP.Models.ItemTaxCode", b =>
                {
                    b.Property<int>("ItemTaxCodeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemID");

                    b.Property<int>("TaxCodeID");

                    b.HasKey("ItemTaxCodeID");

                    b.HasIndex("ItemID");

                    b.HasIndex("TaxCodeID");

                    b.ToTable("ItemTaxCode");
                });

            modelBuilder.Entity("OOODERP.Models.ItemType", b =>
                {
                    b.Property<int>("ItemTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemTypeDescription");

                    b.HasKey("ItemTypeID");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("OOODERP.Models.ItemUnitOfMeasure", b =>
                {
                    b.Property<int>("ItemUnitOfMeasureID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemUnitOfMeasureDescription");

                    b.Property<string>("ItemUnitOfMeasureSymbol");

                    b.HasKey("ItemUnitOfMeasureID");

                    b.ToTable("ItemUnitOfMeasure");
                });

            modelBuilder.Entity("OOODERP.Models.ItemVolumeUnit", b =>
                {
                    b.Property<int>("ItemVolumeUnitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VolumeUnitDescription");

                    b.Property<string>("VolumeUnitSymbol");

                    b.HasKey("ItemVolumeUnitID");

                    b.ToTable("ItemVolumeUnit");
                });

            modelBuilder.Entity("OOODERP.Models.ItemWeightUnit", b =>
                {
                    b.Property<int>("ItemWeightUnitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemWeightSymbol");

                    b.Property<string>("ItemWeightUnitDescription");

                    b.HasKey("ItemWeightUnitID");

                    b.ToTable("ItemWeightUnit");
                });

            modelBuilder.Entity("OOODERP.Models.JobRole", b =>
                {
                    b.Property<int>("JobRoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("JobDescription");

                    b.Property<string>("JobRoleName")
                        .IsRequired();

                    b.HasKey("JobRoleID");

                    b.ToTable("JobRole");
                });

            modelBuilder.Entity("OOODERP.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("LanguageName")
                        .IsRequired();

                    b.HasKey("LanguageID");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("OOODERP.Models.LegacyItem", b =>
                {
                    b.Property<int>("LegacyItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientCompanyID");

                    b.Property<int>("ItemID");

                    b.Property<string>("LegacyItemCode")
                        .HasMaxLength(40);

                    b.HasKey("LegacyItemID");

                    b.HasIndex("ItemID");

                    b.HasIndex("ClientCompanyID", "LegacyItemCode")
                        .IsUnique()
                        .HasName("IX_ClientCompanyLegacyItemCode");

                    b.ToTable("LegacyItem");
                });

            modelBuilder.Entity("OOODERP.Models.MakeBuyGoods", b =>
                {
                    b.Property<int>("MakeBuyGoodsID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SourceOfGoods");

                    b.Property<string>("SourceOfGoodsDescription");

                    b.HasKey("MakeBuyGoodsID");

                    b.ToTable("MakeBuyGoods");
                });

            modelBuilder.Entity("OOODERP.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Method");

                    b.Property<string>("MethodDescription");

                    b.HasKey("PaymentMethodID");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("OOODERP.Models.PaymentTerm", b =>
                {
                    b.Property<int>("PaymentTermID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberOfDays");

                    b.Property<string>("Terms");

                    b.Property<string>("TermsDescription");

                    b.HasKey("PaymentTermID");

                    b.ToTable("PaymentTerm");
                });

            modelBuilder.Entity("OOODERP.Models.Personnel", b =>
                {
                    b.Property<int>("PersonnelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("JobRoleID");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MobileNumber")
                        .IsRequired();

                    b.Property<string>("NationalIdentification")
                        .IsRequired();

                    b.HasKey("PersonnelID");

                    b.HasIndex("JobRoleID");

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("OOODERP.Models.PriceRule", b =>
                {
                    b.Property<int>("PriceRuleID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("DiscountQuantity");

                    b.Property<decimal>("DiscountRate");

                    b.Property<decimal>("DiscountValue");

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<bool>("MarkAsExpired");

                    b.Property<string>("PriceRuleApplication1Expression")
                        .HasMaxLength(100);

                    b.Property<string>("PriceRuleApplication2Expression")
                        .HasMaxLength(100);

                    b.Property<string>("PriceRuleDescription");

                    b.Property<string>("PriceRuleExclusion1Expression")
                        .HasMaxLength(100);

                    b.Property<string>("PriceRuleExclusion2Expression")
                        .HasMaxLength(100);

                    b.Property<string>("PriceRuleQualification1Expression")
                        .HasMaxLength(100);

                    b.Property<string>("PriceRuleQualification2Expression")
                        .HasMaxLength(100);

                    b.Property<int>("PriceRuleTypeID");

                    b.Property<decimal>("SampleGoodsQuantity");

                    b.HasKey("PriceRuleID");

                    b.HasIndex("PriceRuleTypeID", "EffectiveDate", "ExpiryDate", "PriceRuleQualification1Expression", "PriceRuleQualification2Expression", "PriceRuleApplication1Expression", "PriceRuleApplication2Expression", "PriceRuleExclusion1Expression", "PriceRuleExclusion2Expression")
                        .IsUnique()
                        .HasName("IX_PriceRuleDatesExpression");

                    b.ToTable("PriceRule");
                });

            modelBuilder.Entity("OOODERP.Models.PriceRuleApplication", b =>
                {
                    b.Property<int>("PriceRuleApplicationID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PriceRuleApplicationDescription");

                    b.Property<string>("PriceRuleApplicationName");

                    b.HasKey("PriceRuleApplicationID");

                    b.ToTable("PriceRuleApplication");
                });

            modelBuilder.Entity("OOODERP.Models.PriceRuleType", b =>
                {
                    b.Property<int>("PriceRuleTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PriceRuleApplicationID");

                    b.Property<string>("PriceRuleExpression");

                    b.Property<string>("PriceRuleTypeCode");

                    b.Property<string>("PriceRuleTypeDescription");

                    b.HasKey("PriceRuleTypeID");

                    b.HasIndex("PriceRuleApplicationID");

                    b.ToTable("PriceRuleType");
                });

            modelBuilder.Entity("OOODERP.Models.SaleItem", b =>
                {
                    b.Property<int>("SaleItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemID");

                    b.Property<int>("ItemUnitOfMeasureID");

                    b.Property<int>("NumberOfPieces");

                    b.HasKey("SaleItemID");

                    b.HasIndex("ItemID");

                    b.HasIndex("ItemUnitOfMeasureID");

                    b.ToTable("SaleItem");
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemCompanyCustomerSalesOrganization", b =>
                {
                    b.Property<int>("SaleItemCompanyCustomerSalesOrganizationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyCustomerSalesOrganizationID");

                    b.Property<int>("ItemClientCompanyPlantID");

                    b.Property<int?>("ItemID");

                    b.Property<int>("SaleItemID");

                    b.HasKey("SaleItemCompanyCustomerSalesOrganizationID");

                    b.HasIndex("CompanyCustomerSalesOrganizationID");

                    b.HasIndex("ItemClientCompanyPlantID");

                    b.HasIndex("ItemID");

                    b.HasIndex("SaleItemID", "CompanyCustomerSalesOrganizationID", "ItemClientCompanyPlantID")
                        .IsUnique()
                        .HasName("IX_SaleItemSalesOrganizationPlant");

                    b.ToTable("SaleItemCompanyCustomerSalesOrganization");
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemCompanyCustomerSalesOrganizationTaxException", b =>
                {
                    b.Property<int>("SaleItemCompanyCustomerSalesOrganizationTaxExceptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SaleItemCompanyCustomerSalesOrganizationID");

                    b.Property<int>("TaxProfileID");

                    b.HasKey("SaleItemCompanyCustomerSalesOrganizationTaxExceptionID");

                    b.HasIndex("TaxProfileID");

                    b.HasIndex("SaleItemCompanyCustomerSalesOrganizationID", "TaxProfileID")
                        .IsUnique()
                        .HasName("IX_SaleItemSalesOrgTaxProfile");

                    b.ToTable("SaleItemCompanyCustomerSalesOrganizationTaxException");
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemPrice", b =>
                {
                    b.Property<int>("SaleItemPriceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PriceEffectivityDate");

                    b.Property<DateTime>("PriceExpiryDate");

                    b.Property<int>("SaleItemID");

                    b.HasKey("SaleItemPriceID");

                    b.HasIndex("CountryID");

                    b.HasIndex("SaleItemID", "CountryID")
                        .IsUnique()
                        .HasName("IX_SaleItemIDCountryID");

                    b.ToTable("SaleItemPrice");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderHeader", b =>
                {
                    b.Property<int>("SalesOrderHeaderID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyCustomerSalesOrganizationID");

                    b.Property<decimal>("CustomerBalance");

                    b.Property<int>("CustomerID");

                    b.Property<string>("DeviceIdentification")
                        .HasMaxLength(40);

                    b.Property<int>("DeviceSalesOrderHeaderID");

                    b.Property<string>("IMEINumber")
                        .HasMaxLength(40);

                    b.Property<decimal>("InvoiceGrossValue");

                    b.Property<decimal>("InvoiceLevelDiscount");

                    b.Property<decimal>("InvoiceTax");

                    b.Property<decimal>("ItemQuantityDiscount");

                    b.Property<decimal>("ItemSampleQuantity");

                    b.Property<decimal>("ItemValueDiscount");

                    b.Property<decimal>("NetInvoiceValue");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("SalesOrderStatusID");

                    b.Property<decimal>("TotalDiscount");

                    b.Property<string>("UploadStatus");

                    b.Property<int>("UserID");

                    b.HasKey("SalesOrderHeaderID");

                    b.HasIndex("CompanyCustomerSalesOrganizationID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SalesOrderStatusID");

                    b.HasIndex("UserID");

                    b.HasIndex("DeviceSalesOrderHeaderID", "CompanyCustomerSalesOrganizationID", "UserID", "DeviceIdentification", "IMEINumber", "OrderDate")
                        .IsUnique()
                        .HasName("IX_SalesOrderHeaderOrganizationUserHardwareId");

                    b.ToTable("SalesOrderHeader");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderInvoice", b =>
                {
                    b.Property<int>("SalesOrderInvoiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeviceSalesOrderHeaderID");

                    b.Property<int>("DeviceSalesOrderInvoiceID");

                    b.Property<decimal>("InvoiceAmount");

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<int>("InvoiceStatusID");

                    b.Property<int>("SalesOrderHeaderID");

                    b.HasKey("SalesOrderInvoiceID");

                    b.HasIndex("InvoiceStatusID");

                    b.HasIndex("SalesOrderHeaderID");

                    b.ToTable("SalesOrderInvoice");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderInvoicePayment", b =>
                {
                    b.Property<int>("SalesOrderInvoicePaymentID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AmountPaid");

                    b.Property<int>("DeviceSalesOrderInvoiceID");

                    b.Property<int>("DeviceSalesOrderInvoicePaymentID");

                    b.Property<decimal>("PaymentMethodID");

                    b.Property<int?>("PaymentMethodID1");

                    b.Property<string>("ReferenceNumberOrComment")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("SalesOrderInvoiceID");

                    b.HasKey("SalesOrderInvoicePaymentID");

                    b.HasIndex("PaymentMethodID1");

                    b.HasIndex("ReferenceNumberOrComment")
                        .IsUnique()
                        .HasName("IX_InvoicePaymentReference");

                    b.HasIndex("SalesOrderInvoiceID");

                    b.ToTable("SalesOrderInvoicePayment");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLine", b =>
                {
                    b.Property<int>("SalesOrderLineID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvailableStock");

                    b.Property<string>("DeviceIdentification")
                        .HasMaxLength(40);

                    b.Property<int>("DeviceSalesOrderHeaderID");

                    b.Property<int>("DeviceSalesOrderLineID");

                    b.Property<string>("IMEINumber")
                        .HasMaxLength(40);

                    b.Property<string>("ItemDescription");

                    b.Property<decimal>("ItemDiscount");

                    b.Property<decimal>("ItemGrossValue");

                    b.Property<int>("ItemID");

                    b.Property<decimal>("ItemNetValue");

                    b.Property<decimal>("ItemTax");

                    b.Property<int>("ItemUnitOfMeasureID");

                    b.Property<decimal>("ManualPrice");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("OrderedQuantity");

                    b.Property<decimal>("OriginalOrderQuantity");

                    b.Property<int>("SaleItemCompanyCustomerSalesOrganizationID");

                    b.Property<int>("SalesOrderHeaderID");

                    b.Property<decimal>("ShippedQuantity");

                    b.Property<decimal>("SuggestedSellingQuantity");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UserID");

                    b.HasKey("SalesOrderLineID");

                    b.HasIndex("ItemID");

                    b.HasIndex("ItemUnitOfMeasureID");

                    b.HasIndex("SaleItemCompanyCustomerSalesOrganizationID");

                    b.HasIndex("SalesOrderHeaderID");

                    b.HasIndex("UserID");

                    b.HasIndex("DeviceSalesOrderLineID", "SalesOrderHeaderID", "DeviceSalesOrderHeaderID", "ItemID", "UserID", "DeviceIdentification", "IMEINumber")
                        .IsUnique()
                        .HasName("IX_SalesOrderLineOrganizationItemUserDevice");

                    b.ToTable("SalesOrderLine");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLineAdjustment", b =>
                {
                    b.Property<int>("SalesOrderLineAdjustmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdjustmentAmount");

                    b.Property<string>("AdjustmentExpression");

                    b.Property<decimal>("AdjustmentQuantity");

                    b.Property<int>("DeviceSalesOrderHeaderID");

                    b.Property<int>("DeviceSalesOrderLineAdjustmentID");

                    b.Property<int>("DeviceSalesOrderLineID");

                    b.Property<decimal>("FreeOrSampleItemUnitPrice");

                    b.Property<int>("ItemID");

                    b.Property<string>("PriceRuleDescription");

                    b.Property<int>("PriceRuleID");

                    b.Property<int>("SaleItemCompanyCustomerSalesOrganizationID");

                    b.Property<int>("SalesOrderHeaderID");

                    b.Property<int>("SalesOrderLineID");

                    b.Property<decimal>("SampleQuantity");

                    b.HasKey("SalesOrderLineAdjustmentID");

                    b.HasIndex("ItemID");

                    b.HasIndex("PriceRuleID");

                    b.HasIndex("SaleItemCompanyCustomerSalesOrganizationID");

                    b.HasIndex("SalesOrderHeaderID");

                    b.HasIndex("SalesOrderLineID");

                    b.HasIndex("DeviceSalesOrderLineAdjustmentID", "SalesOrderHeaderID", "DeviceSalesOrderHeaderID", "SalesOrderLineID", "DeviceSalesOrderLineID", "PriceRuleID")
                        .IsUnique()
                        .HasName("IX_SalesOrderLineAdjustmentOrganizationItemUserDevice");

                    b.ToTable("SalesOrderLineAdjustment");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLineTaxBreakDown", b =>
                {
                    b.Property<int>("SalesOrderLineTaxBreakDownID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicTaxOnly");

                    b.Property<double>("ClientCustomerJurisdictionTaxExceptionTotal");

                    b.Property<double>("ClientCustomerTaxExceptionTotal");

                    b.Property<double>("ClientCustomerTaxRegimeBasicDataTotal");

                    b.Property<int>("DeviceSalesOrderHeaderID");

                    b.Property<int>("DeviceSalesOrderLineID");

                    b.Property<int>("DeviceSalesOrderLineTaxBreakDownID");

                    b.Property<double>("SaleItemJurisdictionTaxExceptionTotal");

                    b.Property<double>("SaleItemTaxExceptionTotal");

                    b.Property<double>("SaleItemTaxRegimeBasicDataTotal");

                    b.Property<int>("SalesOrderHeaderID");

                    b.Property<int>("SalesOrderLineID");

                    b.HasKey("SalesOrderLineTaxBreakDownID");

                    b.HasIndex("SalesOrderHeaderID");

                    b.HasIndex("SalesOrderLineID");

                    b.ToTable("SalesOrderLineTaxBreakDown");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderStatus", b =>
                {
                    b.Property<int>("SalesOrderStatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SalesOrderStatusDescription");

                    b.Property<string>("SalesOrderStatusName");

                    b.HasKey("SalesOrderStatusID");

                    b.ToTable("SalesOrderStatus");
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrganization", b =>
                {
                    b.Property<int>("SalesOrganizationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonnelID");

                    b.Property<string>("SalesOrganizationName");

                    b.HasKey("SalesOrganizationID");

                    b.HasIndex("PersonnelID");

                    b.ToTable("SalesOrganization");
                });

            modelBuilder.Entity("OOODERP.Models.TaxBasicConfiguration", b =>
                {
                    b.Property<int>("TaxBasicConfigurationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TaxApplicationOrder");

                    b.Property<int>("TaxCodeID");

                    b.HasKey("TaxBasicConfigurationID");

                    b.HasIndex("TaxApplicationOrder")
                        .IsUnique()
                        .HasName("IX_TaxApplicationOrder");

                    b.HasIndex("TaxCodeID");

                    b.ToTable("TaxBasicConfiguration");
                });

            modelBuilder.Entity("OOODERP.Models.TaxCode", b =>
                {
                    b.Property<int>("TaxCodeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<string>("TaxCodeDescription");

                    b.Property<string>("TaxCodeName")
                        .HasMaxLength(40);

                    b.Property<decimal>("TaxRate");

                    b.HasKey("TaxCodeID");

                    b.HasIndex("CountryID", "TaxCodeName")
                        .IsUnique()
                        .HasName("IX_CountryTaxCode");

                    b.ToTable("TaxCode");
                });

            modelBuilder.Entity("OOODERP.Models.TaxJurisdiction", b =>
                {
                    b.Property<int>("TaxJurisdictionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryCityID");

                    b.Property<int>("CountryCityRegion1ID");

                    b.Property<int>("CountryCityRegion2ID");

                    b.Property<int>("TaxCodeID");

                    b.HasKey("TaxJurisdictionID");

                    b.HasIndex("CountryCityRegion1ID");

                    b.HasIndex("CountryCityRegion2ID");

                    b.HasIndex("TaxCodeID");

                    b.HasIndex("CountryCityID", "CountryCityRegion1ID", "CountryCityRegion2ID", "TaxCodeID")
                        .IsUnique()
                        .HasName("IX_Jurisdiction_Country_Region1_Region2");

                    b.ToTable("TaxJurisdiction");
                });

            modelBuilder.Entity("OOODERP.Models.TaxProfile", b =>
                {
                    b.Property<int>("TaxProfileID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BasicTax");

                    b.Property<bool>("JurisdictionTax");

                    b.Property<string>("ProfileName");

                    b.Property<int>("TaxCodeID");

                    b.HasKey("TaxProfileID");

                    b.HasIndex("TaxCodeID");

                    b.ToTable("TaxProfile");
                });

            modelBuilder.Entity("OOODERP.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PasswordString");

                    b.Property<int>("PersonnelID");

                    b.Property<string>("UserName")
                        .HasMaxLength(100);

                    b.HasKey("UserID");

                    b.HasIndex("PersonnelID");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("OOODERP.Models.UserDeviceAssignment", b =>
                {
                    b.Property<int>("UserDeviceAssignmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DeviceID");

                    b.Property<int>("UserID");

                    b.HasKey("UserDeviceAssignmentID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("UserID");

                    b.ToTable("UserDeviceAssignment");
                });

            modelBuilder.Entity("OOODERP.Models.UserItemClientCompanyPlantStorageLocation", b =>
                {
                    b.Property<int>("UserItemClientCompanyPlantStorageLocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemClientCompanyPlantStorageLocationID");

                    b.Property<int>("UserID");

                    b.HasKey("UserItemClientCompanyPlantStorageLocationID");

                    b.HasIndex("ItemClientCompanyPlantStorageLocationID");

                    b.HasIndex("UserID");

                    b.ToTable("UserItemClientCompanyPlantStorageLocation");
                });

            modelBuilder.Entity("OOODERP.Models.Bank", b =>
                {
                    b.HasOne("OOODERP.Models.CountryCity", "CountryCity")
                        .WithMany("Banks")
                        .HasForeignKey("CountryCityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("Banks")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompany", b =>
                {
                    b.HasOne("OOODERP.Models.Client", "Client")
                        .WithMany("ClientCompanies")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("ClientCompanies")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomer", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompany", "ClientCompany")
                        .WithMany()
                        .HasForeignKey("ClientCompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.PaymentTerm", "PaymentTerm")
                        .WithMany("ClientCompanyCustomers")
                        .HasForeignKey("PaymentTermID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Personnel", "Personnel")
                        .WithMany("ClientCompanyCustomers")
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomerCreditLimit", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompanyCustomer", "ClientCompanyCustomer")
                        .WithMany("ClientCompanyCustomerCreditLimits")
                        .HasForeignKey("ClientCompanyCustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CreditCheckStatus", "CreditCheckStatus")
                        .WithMany("ClientCompanyCustomerCreditLimits")
                        .HasForeignKey("CreditCheckStatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyCustomerTaxException", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompanyCustomer", "ClientCompanyCustomer")
                        .WithMany("ClientCompanyCustomerTaxExceptions")
                        .HasForeignKey("ClientCompanyCustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.TaxProfile", "TaxProfile")
                        .WithMany("ClientCompanyCustomerTaxExceptions")
                        .HasForeignKey("TaxProfileID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ClientCompanyPlant", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompany", "ClientCompany")
                        .WithMany("ClientCompanyPlants")
                        .HasForeignKey("ClientCompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CompanyCustomerSalesOrganization", b =>
                {
                    b.HasOne("OOODERP.Models.Channel", "Channel")
                        .WithMany("CompanyCustomerSalesOrganizations")
                        .HasForeignKey("ChannelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ClientCompanyCustomer", "ClientCompanyCustomer")
                        .WithMany()
                        .HasForeignKey("ClientCompanyCustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Division", "Division")
                        .WithMany("CompanyCustomerSalesOrganizations")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.PaymentTerm", "PaymentTerm")
                        .WithMany("CompanyCustomerSalesOrganizations")
                        .HasForeignKey("PaymentTermID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrganization", "SalesOrganization")
                        .WithMany("CompanyCustomerSalesOrganizations")
                        .HasForeignKey("SalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CompanyCustomerSalesOrganizationCreditLimit", b =>
                {
                    b.HasOne("OOODERP.Models.CompanyCustomerSalesOrganization", "CompanyCustomerSalesOrganization")
                        .WithMany("CompanyCustomerSalesOrganizationCreditLimits")
                        .HasForeignKey("CompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CreditCheckStatus", "CreditCheckStatus")
                        .WithMany("CompanyCustomerSalesOrganizationCreditLimits")
                        .HasForeignKey("CreditCheckStatusID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CountryCity", b =>
                {
                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("CountryCities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CountryCityRegion1", b =>
                {
                    b.HasOne("OOODERP.Models.CountryCity", "CountryCity")
                        .WithMany("CountryCityRegion1")
                        .HasForeignKey("CountryCityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CountryCityRegion2", b =>
                {
                    b.HasOne("OOODERP.Models.CountryCity", "CountryCity")
                        .WithMany("CountryCityRegion2")
                        .HasForeignKey("CountryCityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CountryCurrency", b =>
                {
                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("CountryCurrencies")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.Customer", b =>
                {
                    b.HasOne("OOODERP.Models.Classification1", "Classification1")
                        .WithMany("Customers")
                        .HasForeignKey("Classification1ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Classification2", "Classification2")
                        .WithMany("Customers")
                        .HasForeignKey("Classification2ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCity", "CountryCity")
                        .WithMany("Customers")
                        .HasForeignKey("CountryCityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCityRegion1", "CountryCityRegion1")
                        .WithMany("Customers")
                        .HasForeignKey("CountryCityRegion1ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCityRegion2", "CountryCityRegion2")
                        .WithMany("Customers")
                        .HasForeignKey("CountryCityRegion2ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("Customers")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Language", "Language")
                        .WithMany("Customers")
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.CustomerBank", b =>
                {
                    b.HasOne("OOODERP.Models.Bank", "Bank")
                        .WithMany("CustomerBanks")
                        .HasForeignKey("BankID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCurrency", "CountryCurrency")
                        .WithMany("CustomerBanks")
                        .HasForeignKey("CountryCurrencyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Customer", "Customer")
                        .WithMany("CustomerBanks")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.Item", b =>
                {
                    b.HasOne("OOODERP.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemBrand", "ItemBrand")
                        .WithMany("Items")
                        .HasForeignKey("ItemBrandID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemDimensionUnit", "ItemDimensionUnit")
                        .WithMany("Items")
                        .HasForeignKey("ItemDimensionUnitID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemStatus", "ItemStatus")
                        .WithMany("Items")
                        .HasForeignKey("ItemStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemType", "ItemType")
                        .WithMany("Items")
                        .HasForeignKey("ItemTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemUnitOfMeasure", "ItemUnitOfMeasure")
                        .WithMany("Items")
                        .HasForeignKey("ItemUnitOfMeasureID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemVolumeUnit", "ItemVolumeUnit")
                        .WithMany("Items")
                        .HasForeignKey("ItemVolumeUnitID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemWeightUnit", "ItemWeightUnit")
                        .WithMany("Items")
                        .HasForeignKey("ItemWeightUnitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlant", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompanyPlant", "ClientCompanyPlant")
                        .WithMany()
                        .HasForeignKey("ClientCompanyPlantID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemStatus", "ItemStatus")
                        .WithMany()
                        .HasForeignKey("ItemStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.MakeBuyGoods", "MakeBuyGoods")
                        .WithMany("ItemClientCompanyPlants")
                        .HasForeignKey("MakeBuyGoodsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlantStorageLocation", b =>
                {
                    b.HasOne("OOODERP.Models.ItemClientCompanyPlant", "ItemClientCompanyPlant")
                        .WithMany("ItemClientCompanyPlantStorageLocations")
                        .HasForeignKey("ItemClientCompanyPlantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemClientCompanyPlantStorageLocationCurrentStock", b =>
                {
                    b.HasOne("OOODERP.Models.ItemClientCompanyPlantStorageLocation", "ItemClientCompanyPlantStorageLocation")
                        .WithMany("ItemClientCompanyPlantStorageLocationCurrentStocks")
                        .HasForeignKey("ItemClientCompanyPlantStorageLocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemDescription", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany("ItemDescriptions")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemPhoto", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SaleItem", "SaleItem")
                        .WithMany()
                        .HasForeignKey("SaleItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.ItemTaxCode", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany("ItemTaxCodes")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.TaxCode", "TaxCode")
                        .WithMany("ItemTaxCodes")
                        .HasForeignKey("TaxCodeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.LegacyItem", b =>
                {
                    b.HasOne("OOODERP.Models.ClientCompany", "ClientCompany")
                        .WithMany()
                        .HasForeignKey("ClientCompanyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany("LegacyItems")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.Personnel", b =>
                {
                    b.HasOne("OOODERP.Models.JobRole", "JobRole")
                        .WithMany("Personnels")
                        .HasForeignKey("JobRoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.PriceRule", b =>
                {
                    b.HasOne("OOODERP.Models.PriceRuleType", "PriceRuleType")
                        .WithMany()
                        .HasForeignKey("PriceRuleTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.PriceRuleType", b =>
                {
                    b.HasOne("OOODERP.Models.PriceRuleApplication", "PriceRuleApplication")
                        .WithMany("PriceRuleTypes")
                        .HasForeignKey("PriceRuleApplicationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SaleItem", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany("SaleItems")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemUnitOfMeasure", "ItemUnitOfMeasure")
                        .WithMany()
                        .HasForeignKey("ItemUnitOfMeasureID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemCompanyCustomerSalesOrganization", b =>
                {
                    b.HasOne("OOODERP.Models.CompanyCustomerSalesOrganization", "CompanyCustomerSalesOrganization")
                        .WithMany("SaleItemCompanyCustomerSalesOrganizations")
                        .HasForeignKey("CompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemClientCompanyPlant", "ItemClientCompanyPlant")
                        .WithMany("SaleItemCompanyCustomerSalesOrganizations")
                        .HasForeignKey("ItemClientCompanyPlantID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Item")
                        .WithMany("SaleItemCompanyCustomerSalesOrganizations")
                        .HasForeignKey("ItemID");

                    b.HasOne("OOODERP.Models.SaleItem", "SaleItem")
                        .WithMany()
                        .HasForeignKey("SaleItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemCompanyCustomerSalesOrganizationTaxException", b =>
                {
                    b.HasOne("OOODERP.Models.SaleItemCompanyCustomerSalesOrganization", "SaleItemCompanyCustomerSalesOrganization")
                        .WithMany("SaleItemCompanyCustomerSalesOrganizationTaxExceptions")
                        .HasForeignKey("SaleItemCompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.TaxProfile", "TaxProfile")
                        .WithMany()
                        .HasForeignKey("TaxProfileID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SaleItemPrice", b =>
                {
                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany("SaleItemPrices")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SaleItem", "SaleItem")
                        .WithMany("SaleItemPrices")
                        .HasForeignKey("SaleItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderHeader", b =>
                {
                    b.HasOne("OOODERP.Models.CompanyCustomerSalesOrganization", "CompanyCustomerSalesOrganization")
                        .WithMany("SalesOrders")
                        .HasForeignKey("CompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.Customer", "Customer")
                        .WithMany("SalesOrderHeaders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderStatus", "SalesOrderStatus")
                        .WithMany("SalesOrderHeaders")
                        .HasForeignKey("SalesOrderStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.User", "User")
                        .WithMany("SalesOrderHeaders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderInvoice", b =>
                {
                    b.HasOne("OOODERP.Models.InvoiceStatus", "InvoiceStatus")
                        .WithMany("SalesOrderInvoices")
                        .HasForeignKey("InvoiceStatusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderHeader", "SalesOrderHeader")
                        .WithMany("SalesOrderInvoices")
                        .HasForeignKey("SalesOrderHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderInvoicePayment", b =>
                {
                    b.HasOne("OOODERP.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("SalesOrderInvoicePayments")
                        .HasForeignKey("PaymentMethodID1");

                    b.HasOne("OOODERP.Models.SalesOrderInvoice", "SalesOrderInvoice")
                        .WithMany("SalesOrderInvoicePayments")
                        .HasForeignKey("SalesOrderInvoiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLine", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.ItemUnitOfMeasure", "ItemUnitOfMeasure")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("ItemUnitOfMeasureID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SaleItemCompanyCustomerSalesOrganization", "SaleItemCompanyCustomerSalesOrganization")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("SaleItemCompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderHeader", "SalesOrderHeader")
                        .WithMany("SalesOrderLines")
                        .HasForeignKey("SalesOrderHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLineAdjustment", b =>
                {
                    b.HasOne("OOODERP.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.PriceRule", "PriceRule")
                        .WithMany("SalesOrderLineAdjustments")
                        .HasForeignKey("PriceRuleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SaleItemCompanyCustomerSalesOrganization", "SaleItemCompanyCustomerSalesOrganization")
                        .WithMany()
                        .HasForeignKey("SaleItemCompanyCustomerSalesOrganizationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderHeader", "SalesOrderHeaders")
                        .WithMany("SalesOrderLineAdjustments")
                        .HasForeignKey("SalesOrderHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderLine", "SalesOrderLine")
                        .WithMany("SalesOrderLineAdjustments")
                        .HasForeignKey("SalesOrderLineID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrderLineTaxBreakDown", b =>
                {
                    b.HasOne("OOODERP.Models.SalesOrderHeader", "SalesOrderHeader")
                        .WithMany("SalesOrderLineTaxBreakDowns")
                        .HasForeignKey("SalesOrderHeaderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.SalesOrderLine", "SalesOrderLine")
                        .WithMany("SalesOrderLineTaxBreakDowns")
                        .HasForeignKey("SalesOrderLineID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.SalesOrganization", b =>
                {
                    b.HasOne("OOODERP.Models.Personnel", "Personnel")
                        .WithMany("SalesOrganizations")
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.TaxBasicConfiguration", b =>
                {
                    b.HasOne("OOODERP.Models.TaxCode", "TaxCode")
                        .WithMany()
                        .HasForeignKey("TaxCodeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.TaxCode", b =>
                {
                    b.HasOne("OOODERP.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.TaxJurisdiction", b =>
                {
                    b.HasOne("OOODERP.Models.CountryCity", "CountryCity")
                        .WithMany()
                        .HasForeignKey("CountryCityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCityRegion1", "CountryCityRegion1")
                        .WithMany()
                        .HasForeignKey("CountryCityRegion1ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.CountryCityRegion2", "CountryCityRegion2")
                        .WithMany()
                        .HasForeignKey("CountryCityRegion2ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.TaxCode", "TaxCode")
                        .WithMany()
                        .HasForeignKey("TaxCodeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.TaxProfile", b =>
                {
                    b.HasOne("OOODERP.Models.TaxCode", "TaxCode")
                        .WithMany("TaxProfiles")
                        .HasForeignKey("TaxCodeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.User", b =>
                {
                    b.HasOne("OOODERP.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.UserDeviceAssignment", b =>
                {
                    b.HasOne("OOODERP.Models.Device", "Device")
                        .WithMany("UserDeviceAssignments")
                        .HasForeignKey("DeviceID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.User", "User")
                        .WithMany("UserDeviceAssignments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OOODERP.Models.UserItemClientCompanyPlantStorageLocation", b =>
                {
                    b.HasOne("OOODERP.Models.ItemClientCompanyPlantStorageLocation", "ItemClientCompanyPlantStorageLocation")
                        .WithMany("UserItemClientCompanyPlantStorageLocations")
                        .HasForeignKey("ItemClientCompanyPlantStorageLocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OOODERP.Models.User", "User")
                        .WithMany("UserItemClientCompanyPlantStorageLocations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
