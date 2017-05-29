using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OOODERP.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    ChannelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.ChannelID);
                });

            migrationBuilder.CreateTable(
                name: "Classification1",
                columns: table => new
                {
                    Classification1ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassificationDescription = table.Column<string>(nullable: true),
                    ClassificationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification1", x => x.Classification1ID);
                });

            migrationBuilder.CreateTable(
                name: "Classification2",
                columns: table => new
                {
                    Classification2ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassificationDescription = table.Column<string>(nullable: true),
                    ClassificationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification2", x => x.Classification2ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCode = table.Column<string>(maxLength: 2, nullable: false),
                    CountryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "CreditCheckStatus",
                columns: table => new
                {
                    CreditCheckStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreditCheckStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCheckStatus", x => x.CreditCheckStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    DeviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceMake = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<string>(nullable: true),
                    Identifier1 = table.Column<string>(nullable: true),
                    Indentfier2 = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.DeviceID);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DivisionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    InvoiceStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceStatusDescription = table.Column<string>(nullable: true),
                    InvoiceStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.InvoiceStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ItemBrand",
                columns: table => new
                {
                    ItemBrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemBrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBrand", x => x.ItemBrandID);
                });

            migrationBuilder.CreateTable(
                name: "ItemDimensionUnit",
                columns: table => new
                {
                    ItemDimensionUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemDimensionUnitDescription = table.Column<string>(nullable: true),
                    ItemDimensionUnitSymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDimensionUnit", x => x.ItemDimensionUnitID);
                });

            migrationBuilder.CreateTable(
                name: "ItemStatus",
                columns: table => new
                {
                    ItemStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemStatusDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatus", x => x.ItemStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnitOfMeasure",
                columns: table => new
                {
                    ItemUnitOfMeasureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemUnitOfMeasureDescription = table.Column<string>(nullable: true),
                    ItemUnitOfMeasureSymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnitOfMeasure", x => x.ItemUnitOfMeasureID);
                });

            migrationBuilder.CreateTable(
                name: "ItemVolumeUnit",
                columns: table => new
                {
                    ItemVolumeUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VolumeUnitDescription = table.Column<string>(nullable: true),
                    VolumeUnitSymbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVolumeUnit", x => x.ItemVolumeUnitID);
                });

            migrationBuilder.CreateTable(
                name: "ItemWeightUnit",
                columns: table => new
                {
                    ItemWeightUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemWeightSymbol = table.Column<string>(nullable: true),
                    ItemWeightUnitDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemWeightUnit", x => x.ItemWeightUnitID);
                });

            migrationBuilder.CreateTable(
                name: "JobRole",
                columns: table => new
                {
                    JobRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobDescription = table.Column<string>(nullable: true),
                    JobRoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRole", x => x.JobRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageCode = table.Column<string>(maxLength: 2, nullable: false),
                    LanguageName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "MakeBuyGoods",
                columns: table => new
                {
                    MakeBuyGoodsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SourceOfGoods = table.Column<string>(nullable: true),
                    SourceOfGoodsDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeBuyGoods", x => x.MakeBuyGoodsID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Method = table.Column<string>(nullable: true),
                    MethodDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerm",
                columns: table => new
                {
                    PaymentTermID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOfDays = table.Column<int>(nullable: false),
                    Terms = table.Column<string>(nullable: true),
                    TermsDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerm", x => x.PaymentTermID);
                });

            migrationBuilder.CreateTable(
                name: "PriceRuleApplication",
                columns: table => new
                {
                    PriceRuleApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriceRuleApplicationDescription = table.Column<string>(nullable: true),
                    PriceRuleApplicationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRuleApplication", x => x.PriceRuleApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderStatus",
                columns: table => new
                {
                    SalesOrderStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalesOrderStatusDescription = table.Column<string>(nullable: true),
                    SalesOrderStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderStatus", x => x.SalesOrderStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompany",
                columns: table => new
                {
                    ClientCompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientCompanyName = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompany", x => x.ClientCompanyID);
                    table.ForeignKey(
                        name: "FK_ClientCompany_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCompany_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryCity",
                columns: table => new
                {
                    CountryCityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCity", x => x.CountryCityID);
                    table.ForeignKey(
                        name: "FK_CountryCity_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryCurrency",
                columns: table => new
                {
                    CountryCurrencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    CurrencyCode = table.Column<string>(maxLength: 3, nullable: false),
                    CurrencyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCurrency", x => x.CountryCurrencyID);
                    table.ForeignKey(
                        name: "FK_CountryCurrency_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxCode",
                columns: table => new
                {
                    TaxCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    TaxCodeDescription = table.Column<string>(nullable: true),
                    TaxCodeName = table.Column<string>(maxLength: 40, nullable: true),
                    TaxRate = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxCode", x => x.TaxCodeID);
                    table.ForeignKey(
                        name: "FK_TaxCode_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BarCodeNumber = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DivisionID = table.Column<int>(nullable: false),
                    GrossWeight = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    ItemBrandID = table.Column<int>(nullable: false),
                    ItemDimensionUnitID = table.Column<int>(nullable: false),
                    ItemStatusID = table.Column<int>(nullable: false),
                    ItemTypeID = table.Column<int>(nullable: false),
                    ItemUnitOfMeasureID = table.Column<int>(nullable: false),
                    ItemVolumeUnitID = table.Column<int>(nullable: false),
                    ItemWeightUnitID = table.Column<int>(nullable: false),
                    Length = table.Column<float>(nullable: false),
                    NetWeight = table.Column<float>(nullable: false),
                    NumberOfPiecesInItem = table.Column<int>(nullable: false),
                    VolumeSize = table.Column<float>(nullable: false),
                    Width = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Item_Division_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Division",
                        principalColumn: "DivisionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemBrand_ItemBrandID",
                        column: x => x.ItemBrandID,
                        principalTable: "ItemBrand",
                        principalColumn: "ItemBrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemDimensionUnit_ItemDimensionUnitID",
                        column: x => x.ItemDimensionUnitID,
                        principalTable: "ItemDimensionUnit",
                        principalColumn: "ItemDimensionUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemStatus_ItemStatusID",
                        column: x => x.ItemStatusID,
                        principalTable: "ItemStatus",
                        principalColumn: "ItemStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemType_ItemTypeID",
                        column: x => x.ItemTypeID,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemUnitOfMeasure_ItemUnitOfMeasureID",
                        column: x => x.ItemUnitOfMeasureID,
                        principalTable: "ItemUnitOfMeasure",
                        principalColumn: "ItemUnitOfMeasureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemVolumeUnit_ItemVolumeUnitID",
                        column: x => x.ItemVolumeUnitID,
                        principalTable: "ItemVolumeUnit",
                        principalColumn: "ItemVolumeUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_ItemWeightUnit_ItemWeightUnitID",
                        column: x => x.ItemWeightUnitID,
                        principalTable: "ItemWeightUnit",
                        principalColumn: "ItemWeightUnitID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    PersonnelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    JobRoleID = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    NationalIdentification = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.PersonnelID);
                    table.ForeignKey(
                        name: "FK_Personnel_JobRole_JobRoleID",
                        column: x => x.JobRoleID,
                        principalTable: "JobRole",
                        principalColumn: "JobRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceRuleType",
                columns: table => new
                {
                    PriceRuleTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriceRuleApplicationID = table.Column<int>(nullable: false),
                    PriceRuleExpression = table.Column<string>(nullable: true),
                    PriceRuleTypeCode = table.Column<string>(nullable: true),
                    PriceRuleTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRuleType", x => x.PriceRuleTypeID);
                    table.ForeignKey(
                        name: "FK_PriceRuleType_PriceRuleApplication_PriceRuleApplicationID",
                        column: x => x.PriceRuleApplicationID,
                        principalTable: "PriceRuleApplication",
                        principalColumn: "PriceRuleApplicationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompanyPlant",
                columns: table => new
                {
                    ClientCompanyPlantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientCompanyID = table.Column<int>(nullable: false),
                    PlantName = table.Column<string>(nullable: true),
                    PlantNameDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompanyPlant", x => x.ClientCompanyPlantID);
                    table.ForeignKey(
                        name: "FK_ClientCompanyPlant_ClientCompany_ClientCompanyID",
                        column: x => x.ClientCompanyID,
                        principalTable: "ClientCompany",
                        principalColumn: "ClientCompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    BankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankBranch = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    CountryCityID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    IBANNumber = table.Column<string>(nullable: true),
                    NameOfBank = table.Column<string>(nullable: true),
                    PhysicalAddress1 = table.Column<string>(nullable: true),
                    PhysicalAddress2 = table.Column<string>(nullable: true),
                    PostalAddress = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    SwiftCode = table.Column<string>(maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.BankID);
                    table.ForeignKey(
                        name: "FK_Bank_CountryCity_CountryCityID",
                        column: x => x.CountryCityID,
                        principalTable: "CountryCity",
                        principalColumn: "CountryCityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bank_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CountryCityRegion1",
                columns: table => new
                {
                    CountryCityRegion1ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCityID = table.Column<int>(nullable: false),
                    Region1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCityRegion1", x => x.CountryCityRegion1ID);
                    table.ForeignKey(
                        name: "FK_CountryCityRegion1_CountryCity_CountryCityID",
                        column: x => x.CountryCityID,
                        principalTable: "CountryCity",
                        principalColumn: "CountryCityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryCityRegion2",
                columns: table => new
                {
                    CountryCityRegion2ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCityID = table.Column<int>(nullable: false),
                    Region2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCityRegion2", x => x.CountryCityRegion2ID);
                    table.ForeignKey(
                        name: "FK_CountryCityRegion2_CountryCity_CountryCityID",
                        column: x => x.CountryCityID,
                        principalTable: "CountryCity",
                        principalColumn: "CountryCityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxBasicConfiguration",
                columns: table => new
                {
                    TaxBasicConfigurationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TaxApplicationOrder = table.Column<int>(nullable: false),
                    TaxCodeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxBasicConfiguration", x => x.TaxBasicConfigurationID);
                    table.ForeignKey(
                        name: "FK_TaxBasicConfiguration_TaxCode_TaxCodeID",
                        column: x => x.TaxCodeID,
                        principalTable: "TaxCode",
                        principalColumn: "TaxCodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxProfile",
                columns: table => new
                {
                    TaxProfileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasicTax = table.Column<bool>(nullable: false),
                    JurisdictionTax = table.Column<bool>(nullable: false),
                    ProfileName = table.Column<string>(nullable: true),
                    TaxCodeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxProfile", x => x.TaxProfileID);
                    table.ForeignKey(
                        name: "FK_TaxProfile_TaxCode_TaxCodeID",
                        column: x => x.TaxCodeID,
                        principalTable: "TaxCode",
                        principalColumn: "TaxCodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDescription",
                columns: table => new
                {
                    ItemDescriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemFullDescription = table.Column<string>(nullable: true),
                    ItemID = table.Column<int>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDescription", x => x.ItemDescriptionID);
                    table.ForeignKey(
                        name: "FK_ItemDescription_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemDescription_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTaxCode",
                columns: table => new
                {
                    ItemTaxCodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    TaxCodeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTaxCode", x => x.ItemTaxCodeID);
                    table.ForeignKey(
                        name: "FK_ItemTaxCode_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemTaxCode_TaxCode_TaxCodeID",
                        column: x => x.TaxCodeID,
                        principalTable: "TaxCode",
                        principalColumn: "TaxCodeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegacyItem",
                columns: table => new
                {
                    LegacyItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientCompanyID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    LegacyItemCode = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegacyItem", x => x.LegacyItemID);
                    table.ForeignKey(
                        name: "FK_LegacyItem_ClientCompany_ClientCompanyID",
                        column: x => x.ClientCompanyID,
                        principalTable: "ClientCompany",
                        principalColumn: "ClientCompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LegacyItem_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
                columns: table => new
                {
                    SaleItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    ItemUnitOfMeasureID = table.Column<int>(nullable: false),
                    NumberOfPieces = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItem", x => x.SaleItemID);
                    table.ForeignKey(
                        name: "FK_SaleItem_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItem_ItemUnitOfMeasure_ItemUnitOfMeasureID",
                        column: x => x.ItemUnitOfMeasureID,
                        principalTable: "ItemUnitOfMeasure",
                        principalColumn: "ItemUnitOfMeasureID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrganization",
                columns: table => new
                {
                    SalesOrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonnelID = table.Column<int>(nullable: false),
                    SalesOrganizationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrganization", x => x.SalesOrganizationID);
                    table.ForeignKey(
                        name: "FK_SalesOrganization_Personnel_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PasswordString = table.Column<string>(nullable: true),
                    PersonnelID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_Personnel_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriceRule",
                columns: table => new
                {
                    PriceRuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiscountQuantity = table.Column<decimal>(nullable: false),
                    DiscountRate = table.Column<decimal>(nullable: false),
                    DiscountValue = table.Column<decimal>(nullable: false),
                    EffectiveDate = table.Column<DateTime>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    MarkAsExpired = table.Column<bool>(nullable: false),
                    PriceRuleApplication1Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleApplication2Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleDescription = table.Column<string>(nullable: true),
                    PriceRuleExclusion1Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleExclusion2Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleQualification1Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleQualification2Expression = table.Column<string>(maxLength: 100, nullable: true),
                    PriceRuleTypeID = table.Column<int>(nullable: false),
                    SampleGoodsQuantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRule", x => x.PriceRuleID);
                    table.ForeignKey(
                        name: "FK_PriceRule_PriceRuleType_PriceRuleTypeID",
                        column: x => x.PriceRuleTypeID,
                        principalTable: "PriceRuleType",
                        principalColumn: "PriceRuleTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemClientCompanyPlant",
                columns: table => new
                {
                    ItemClientCompanyPlantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABCClassification = table.Column<string>(nullable: true),
                    ClientCompanyPlantID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ItemStatusID = table.Column<int>(nullable: false),
                    MakeBuyGoodsID = table.Column<int>(nullable: false),
                    ReorderLevelQuantity = table.Column<decimal>(nullable: false),
                    SafetyStockQuantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemClientCompanyPlant", x => x.ItemClientCompanyPlantID);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlant_ClientCompanyPlant_ClientCompanyPlantID",
                        column: x => x.ClientCompanyPlantID,
                        principalTable: "ClientCompanyPlant",
                        principalColumn: "ClientCompanyPlantID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlant_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlant_ItemStatus_ItemStatusID",
                        column: x => x.ItemStatusID,
                        principalTable: "ItemStatus",
                        principalColumn: "ItemStatusID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlant_MakeBuyGoods_MakeBuyGoodsID",
                        column: x => x.MakeBuyGoodsID,
                        principalTable: "MakeBuyGoods",
                        principalColumn: "MakeBuyGoodsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Classification1ID = table.Column<int>(nullable: false),
                    Classification2ID = table.Column<int>(nullable: false),
                    CountryCityID = table.Column<int>(nullable: false),
                    CountryCityRegion1ID = table.Column<int>(nullable: false),
                    CountryCityRegion2ID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    Fax1 = table.Column<string>(nullable: true),
                    Fax2 = table.Column<string>(nullable: true),
                    LanguageID = table.Column<int>(nullable: false),
                    Mobile1 = table.Column<string>(nullable: false),
                    Mobile2 = table.Column<string>(nullable: true),
                    PhysicalAddress1 = table.Column<string>(nullable: false),
                    PhysicalAddress2 = table.Column<string>(nullable: true),
                    PostalAddress1 = table.Column<string>(nullable: false),
                    PostalAddress2 = table.Column<string>(nullable: true),
                    PostalCode1 = table.Column<string>(nullable: true),
                    PostalCode2 = table.Column<string>(nullable: true),
                    TaxNumber1 = table.Column<string>(nullable: true),
                    TaxNumber2 = table.Column<string>(nullable: true),
                    Telephone1 = table.Column<string>(nullable: false),
                    Telephone2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Classification1_Classification1ID",
                        column: x => x.Classification1ID,
                        principalTable: "Classification1",
                        principalColumn: "Classification1ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_Classification2_Classification2ID",
                        column: x => x.Classification2ID,
                        principalTable: "Classification2",
                        principalColumn: "Classification2ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_CountryCity_CountryCityID",
                        column: x => x.CountryCityID,
                        principalTable: "CountryCity",
                        principalColumn: "CountryCityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_CountryCityRegion1_CountryCityRegion1ID",
                        column: x => x.CountryCityRegion1ID,
                        principalTable: "CountryCityRegion1",
                        principalColumn: "CountryCityRegion1ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customer_CountryCityRegion2_CountryCityRegion2ID",
                        column: x => x.CountryCityRegion2ID,
                        principalTable: "CountryCityRegion2",
                        principalColumn: "CountryCityRegion2ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customer_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Customer_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxJurisdiction",
                columns: table => new
                {
                    TaxJurisdictionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCityID = table.Column<int>(nullable: false),
                    CountryCityRegion1ID = table.Column<int>(nullable: false),
                    CountryCityRegion2ID = table.Column<int>(nullable: false),
                    TaxCodeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxJurisdiction", x => x.TaxJurisdictionID);
                    table.ForeignKey(
                        name: "FK_TaxJurisdiction_CountryCity_CountryCityID",
                        column: x => x.CountryCityID,
                        principalTable: "CountryCity",
                        principalColumn: "CountryCityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxJurisdiction_CountryCityRegion1_CountryCityRegion1ID",
                        column: x => x.CountryCityRegion1ID,
                        principalTable: "CountryCityRegion1",
                        principalColumn: "CountryCityRegion1ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TaxJurisdiction_CountryCityRegion2_CountryCityRegion2ID",
                        column: x => x.CountryCityRegion2ID,
                        principalTable: "CountryCityRegion2",
                        principalColumn: "CountryCityRegion2ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TaxJurisdiction_TaxCode_TaxCodeID",
                        column: x => x.TaxCodeID,
                        principalTable: "TaxCode",
                        principalColumn: "TaxCodeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ItemPhoto",
                columns: table => new
                {
                    ItemPhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemID = table.Column<int>(nullable: false),
                    Photo = table.Column<byte>(nullable: false),
                    SaleItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPhoto", x => x.ItemPhotoID);
                    table.ForeignKey(
                        name: "FK_ItemPhoto_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPhoto_SaleItem_SaleItemID",
                        column: x => x.SaleItemID,
                        principalTable: "SaleItem",
                        principalColumn: "SaleItemID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SaleItemPrice",
                columns: table => new
                {
                    SaleItemPriceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PriceEffectivityDate = table.Column<DateTime>(nullable: false),
                    PriceExpiryDate = table.Column<DateTime>(nullable: false),
                    SaleItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemPrice", x => x.SaleItemPriceID);
                    table.ForeignKey(
                        name: "FK_SaleItemPrice_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemPrice_SaleItem_SaleItemID",
                        column: x => x.SaleItemID,
                        principalTable: "SaleItem",
                        principalColumn: "SaleItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDeviceAssignment",
                columns: table => new
                {
                    UserDeviceAssignmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeviceAssignment", x => x.UserDeviceAssignmentID);
                    table.ForeignKey(
                        name: "FK_UserDeviceAssignment_Device_DeviceID",
                        column: x => x.DeviceID,
                        principalTable: "Device",
                        principalColumn: "DeviceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDeviceAssignment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemClientCompanyPlantStorageLocation",
                columns: table => new
                {
                    ItemClientCompanyPlantStorageLocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemClientCompanyPlantID = table.Column<int>(nullable: false),
                    StorageBinDescription = table.Column<string>(nullable: true),
                    StorageBinName = table.Column<string>(maxLength: 40, nullable: true),
                    StorageLocationDescription = table.Column<string>(nullable: true),
                    StorageLocationName = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemClientCompanyPlantStorageLocation", x => x.ItemClientCompanyPlantStorageLocationID);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlantStorageLocation_ItemClientCompanyPlant_ItemClientCompanyPlantID",
                        column: x => x.ItemClientCompanyPlantID,
                        principalTable: "ItemClientCompanyPlant",
                        principalColumn: "ItemClientCompanyPlantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompanyCustomer",
                columns: table => new
                {
                    ClientCompanyCustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountIDAtCustomer = table.Column<string>(nullable: true),
                    ClientCompanyID = table.Column<int>(nullable: false),
                    ContactPersonAtCustomer = table.Column<string>(nullable: true),
                    CustomerID = table.Column<int>(nullable: false),
                    PaymentTermID = table.Column<int>(nullable: false),
                    PersonnelID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompanyCustomer", x => x.ClientCompanyCustomerID);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomer_ClientCompany_ClientCompanyID",
                        column: x => x.ClientCompanyID,
                        principalTable: "ClientCompany",
                        principalColumn: "ClientCompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomer_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomer_PaymentTerm_PaymentTermID",
                        column: x => x.PaymentTermID,
                        principalTable: "PaymentTerm",
                        principalColumn: "PaymentTermID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomer_Personnel_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBank",
                columns: table => new
                {
                    CustomerBankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankAccountName = table.Column<string>(nullable: false),
                    BankAccountNumber = table.Column<string>(nullable: true),
                    BankID = table.Column<int>(nullable: false),
                    CountryCurrencyID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    SpecialInstructions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBank", x => x.CustomerBankID);
                    table.ForeignKey(
                        name: "FK_CustomerBank_Bank_BankID",
                        column: x => x.BankID,
                        principalTable: "Bank",
                        principalColumn: "BankID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBank_CountryCurrency_CountryCurrencyID",
                        column: x => x.CountryCurrencyID,
                        principalTable: "CountryCurrency",
                        principalColumn: "CountryCurrencyID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomerBank_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ItemClientCompanyPlantStorageLocationCurrentStock",
                columns: table => new
                {
                    ItemClientCompanyPlantStorageLocationCurrentStockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AllocatedStock = table.Column<decimal>(nullable: false),
                    AvailableStock = table.Column<decimal>(nullable: false),
                    ItemClientCompanyPlantStorageLocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemClientCompanyPlantStorageLocationCurrentStock", x => x.ItemClientCompanyPlantStorageLocationCurrentStockID);
                    table.ForeignKey(
                        name: "FK_ItemClientCompanyPlantStorageLocationCurrentStock_ItemClientCompanyPlantStorageLocation_ItemClientCompanyPlantStorageLocation",
                        column: x => x.ItemClientCompanyPlantStorageLocationID,
                        principalTable: "ItemClientCompanyPlantStorageLocation",
                        principalColumn: "ItemClientCompanyPlantStorageLocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserItemClientCompanyPlantStorageLocation",
                columns: table => new
                {
                    UserItemClientCompanyPlantStorageLocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemClientCompanyPlantStorageLocationID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItemClientCompanyPlantStorageLocation", x => x.UserItemClientCompanyPlantStorageLocationID);
                    table.ForeignKey(
                        name: "FK_UserItemClientCompanyPlantStorageLocation_ItemClientCompanyPlantStorageLocation_ItemClientCompanyPlantStorageLocationID",
                        column: x => x.ItemClientCompanyPlantStorageLocationID,
                        principalTable: "ItemClientCompanyPlantStorageLocation",
                        principalColumn: "ItemClientCompanyPlantStorageLocationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserItemClientCompanyPlantStorageLocation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompanyCustomerCreditLimit",
                columns: table => new
                {
                    ClientCompanyCustomerCreditLimitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientCompanyCustomerID = table.Column<int>(nullable: false),
                    CreditCheckStatusID = table.Column<int>(nullable: false),
                    CreditLimitAmount = table.Column<decimal>(nullable: false),
                    CreditLimitTolerance = table.Column<decimal>(nullable: false),
                    OrderCreditLimitAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompanyCustomerCreditLimit", x => x.ClientCompanyCustomerCreditLimitID);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomerCreditLimit_ClientCompanyCustomer_ClientCompanyCustomerID",
                        column: x => x.ClientCompanyCustomerID,
                        principalTable: "ClientCompanyCustomer",
                        principalColumn: "ClientCompanyCustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomerCreditLimit_CreditCheckStatus_CreditCheckStatusID",
                        column: x => x.CreditCheckStatusID,
                        principalTable: "CreditCheckStatus",
                        principalColumn: "CreditCheckStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientCompanyCustomerTaxException",
                columns: table => new
                {
                    ClientCompanyCustomerTaxExceptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientCompanyCustomerID = table.Column<int>(nullable: false),
                    TaxProfileID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCompanyCustomerTaxException", x => x.ClientCompanyCustomerTaxExceptionID);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomerTaxException_ClientCompanyCustomer_ClientCompanyCustomerID",
                        column: x => x.ClientCompanyCustomerID,
                        principalTable: "ClientCompanyCustomer",
                        principalColumn: "ClientCompanyCustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientCompanyCustomerTaxException_TaxProfile_TaxProfileID",
                        column: x => x.TaxProfileID,
                        principalTable: "TaxProfile",
                        principalColumn: "TaxProfileID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCustomerSalesOrganization",
                columns: table => new
                {
                    CompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelID = table.Column<int>(nullable: false),
                    ClientCompanyCustomerID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    DivisionID = table.Column<int>(nullable: false),
                    PaymentTermID = table.Column<int>(nullable: false),
                    PersonnelID = table.Column<int>(nullable: false),
                    SalesOrganizationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCustomerSalesOrganization", x => x.CompanyCustomerSalesOrganizationID);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_Channel_ChannelID",
                        column: x => x.ChannelID,
                        principalTable: "Channel",
                        principalColumn: "ChannelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_ClientCompanyCustomer_ClientCompanyCustomerID",
                        column: x => x.ClientCompanyCustomerID,
                        principalTable: "ClientCompanyCustomer",
                        principalColumn: "ClientCompanyCustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_Division_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Division",
                        principalColumn: "DivisionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_PaymentTerm_PaymentTermID",
                        column: x => x.PaymentTermID,
                        principalTable: "PaymentTerm",
                        principalColumn: "PaymentTermID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_Personnel_PersonnelID",
                        column: x => x.PersonnelID,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganization_SalesOrganization_SalesOrganizationID",
                        column: x => x.SalesOrganizationID,
                        principalTable: "SalesOrganization",
                        principalColumn: "SalesOrganizationID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCustomerSalesOrganizationCreditLimit",
                columns: table => new
                {
                    CompanyCustomerSalesOrganizationCreditLimitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    CreditCheckStatusID = table.Column<int>(nullable: false),
                    CreditLimitAmount = table.Column<decimal>(nullable: false),
                    CreditLimitTolerance = table.Column<decimal>(nullable: false),
                    OrderCreditLimitAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCustomerSalesOrganizationCreditLimit", x => x.CompanyCustomerSalesOrganizationCreditLimitID);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganizationCreditLimit_CompanyCustomerSalesOrganization_CompanyCustomerSalesOrganizationID",
                        column: x => x.CompanyCustomerSalesOrganizationID,
                        principalTable: "CompanyCustomerSalesOrganization",
                        principalColumn: "CompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCustomerSalesOrganizationCreditLimit_CreditCheckStatus_CreditCheckStatusID",
                        column: x => x.CreditCheckStatusID,
                        principalTable: "CreditCheckStatus",
                        principalColumn: "CreditCheckStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItemCompanyCustomerSalesOrganization",
                columns: table => new
                {
                    SaleItemCompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    ItemClientCompanyPlantID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: true),
                    SaleItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemCompanyCustomerSalesOrganization", x => x.SaleItemCompanyCustomerSalesOrganizationID);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganization_CompanyCustomerSalesOrganization_CompanyCustomerSalesOrganizationID",
                        column: x => x.CompanyCustomerSalesOrganizationID,
                        principalTable: "CompanyCustomerSalesOrganization",
                        principalColumn: "CompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganization_ItemClientCompanyPlant_ItemClientCompanyPlantID",
                        column: x => x.ItemClientCompanyPlantID,
                        principalTable: "ItemClientCompanyPlant",
                        principalColumn: "ItemClientCompanyPlantID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganization_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganization_SaleItem_SaleItemID",
                        column: x => x.SaleItemID,
                        principalTable: "SaleItem",
                        principalColumn: "SaleItemID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderHeader",
                columns: table => new
                {
                    SalesOrderHeaderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    CustomerBalance = table.Column<decimal>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    DeviceIdentification = table.Column<string>(maxLength: 40, nullable: true),
                    DeviceSalesOrderHeaderID = table.Column<int>(nullable: false),
                    IMEINumber = table.Column<string>(maxLength: 40, nullable: true),
                    InvoiceGrossValue = table.Column<decimal>(nullable: false),
                    InvoiceLevelDiscount = table.Column<decimal>(nullable: false),
                    InvoiceTax = table.Column<decimal>(nullable: false),
                    ItemQuantityDiscount = table.Column<decimal>(nullable: false),
                    ItemSampleQuantity = table.Column<decimal>(nullable: false),
                    ItemValueDiscount = table.Column<decimal>(nullable: false),
                    NetInvoiceValue = table.Column<decimal>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    SalesOrderStatusID = table.Column<int>(nullable: false),
                    TotalDiscount = table.Column<decimal>(nullable: false),
                    UploadStatus = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderHeader", x => x.SalesOrderHeaderID);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_CompanyCustomerSalesOrganization_CompanyCustomerSalesOrganizationID",
                        column: x => x.CompanyCustomerSalesOrganizationID,
                        principalTable: "CompanyCustomerSalesOrganization",
                        principalColumn: "CompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_SalesOrderStatus_SalesOrderStatusID",
                        column: x => x.SalesOrderStatusID,
                        principalTable: "SalesOrderStatus",
                        principalColumn: "SalesOrderStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderHeader_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SaleItemCompanyCustomerSalesOrganizationTaxException",
                columns: table => new
                {
                    SaleItemCompanyCustomerSalesOrganizationTaxExceptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SaleItemCompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    TaxProfileID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemCompanyCustomerSalesOrganizationTaxException", x => x.SaleItemCompanyCustomerSalesOrganizationTaxExceptionID);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganizationTaxException_SaleItemCompanyCustomerSalesOrganization_SaleItemCompanyCustomerSalesOrg",
                        column: x => x.SaleItemCompanyCustomerSalesOrganizationID,
                        principalTable: "SaleItemCompanyCustomerSalesOrganization",
                        principalColumn: "SaleItemCompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemCompanyCustomerSalesOrganizationTaxException_TaxProfile_TaxProfileID",
                        column: x => x.TaxProfileID,
                        principalTable: "TaxProfile",
                        principalColumn: "TaxProfileID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderInvoice",
                columns: table => new
                {
                    SalesOrderInvoiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeviceSalesOrderHeaderID = table.Column<int>(nullable: false),
                    DeviceSalesOrderInvoiceID = table.Column<int>(nullable: false),
                    InvoiceAmount = table.Column<decimal>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    InvoiceStatusID = table.Column<int>(nullable: false),
                    SalesOrderHeaderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderInvoice", x => x.SalesOrderInvoiceID);
                    table.ForeignKey(
                        name: "FK_SalesOrderInvoice_InvoiceStatus_InvoiceStatusID",
                        column: x => x.InvoiceStatusID,
                        principalTable: "InvoiceStatus",
                        principalColumn: "InvoiceStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderInvoice_SalesOrderHeader_SalesOrderHeaderID",
                        column: x => x.SalesOrderHeaderID,
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderHeaderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLine",
                columns: table => new
                {
                    SalesOrderLineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvailableStock = table.Column<decimal>(nullable: false),
                    DeviceIdentification = table.Column<string>(maxLength: 40, nullable: true),
                    DeviceSalesOrderHeaderID = table.Column<int>(nullable: false),
                    DeviceSalesOrderLineID = table.Column<int>(nullable: false),
                    IMEINumber = table.Column<string>(maxLength: 40, nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    ItemDiscount = table.Column<decimal>(nullable: false),
                    ItemGrossValue = table.Column<decimal>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ItemNetValue = table.Column<decimal>(nullable: false),
                    ItemTax = table.Column<decimal>(nullable: false),
                    ItemUnitOfMeasureID = table.Column<int>(nullable: false),
                    ManualPrice = table.Column<decimal>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderedQuantity = table.Column<decimal>(nullable: false),
                    OriginalOrderQuantity = table.Column<decimal>(nullable: false),
                    SaleItemCompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    SalesOrderHeaderID = table.Column<int>(nullable: false),
                    ShippedQuantity = table.Column<decimal>(nullable: false),
                    SuggestedSellingQuantity = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLine", x => x.SalesOrderLineID);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_ItemUnitOfMeasure_ItemUnitOfMeasureID",
                        column: x => x.ItemUnitOfMeasureID,
                        principalTable: "ItemUnitOfMeasure",
                        principalColumn: "ItemUnitOfMeasureID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_SaleItemCompanyCustomerSalesOrganization_SaleItemCompanyCustomerSalesOrganizationID",
                        column: x => x.SaleItemCompanyCustomerSalesOrganizationID,
                        principalTable: "SaleItemCompanyCustomerSalesOrganization",
                        principalColumn: "SaleItemCompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_SalesOrderHeader_SalesOrderHeaderID",
                        column: x => x.SalesOrderHeaderID,
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderHeaderID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderLine_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderInvoicePayment",
                columns: table => new
                {
                    SalesOrderInvoicePaymentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountPaid = table.Column<decimal>(nullable: false),
                    DeviceSalesOrderInvoiceID = table.Column<int>(nullable: false),
                    DeviceSalesOrderInvoicePaymentID = table.Column<int>(nullable: false),
                    PaymentMethodID = table.Column<decimal>(nullable: false),
                    PaymentMethodID1 = table.Column<int>(nullable: true),
                    ReferenceNumberOrComment = table.Column<string>(maxLength: 40, nullable: false),
                    SalesOrderInvoiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderInvoicePayment", x => x.SalesOrderInvoicePaymentID);
                    table.ForeignKey(
                        name: "FK_SalesOrderInvoicePayment_PaymentMethod_PaymentMethodID1",
                        column: x => x.PaymentMethodID1,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesOrderInvoicePayment_SalesOrderInvoice_SalesOrderInvoiceID",
                        column: x => x.SalesOrderInvoiceID,
                        principalTable: "SalesOrderInvoice",
                        principalColumn: "SalesOrderInvoiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLineAdjustment",
                columns: table => new
                {
                    SalesOrderLineAdjustmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdjustmentAmount = table.Column<decimal>(nullable: false),
                    AdjustmentExpression = table.Column<string>(nullable: true),
                    AdjustmentQuantity = table.Column<decimal>(nullable: false),
                    DeviceSalesOrderHeaderID = table.Column<int>(nullable: false),
                    DeviceSalesOrderLineAdjustmentID = table.Column<int>(nullable: false),
                    DeviceSalesOrderLineID = table.Column<int>(nullable: false),
                    FreeOrSampleItemUnitPrice = table.Column<decimal>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    PriceRuleDescription = table.Column<string>(nullable: true),
                    PriceRuleID = table.Column<int>(nullable: false),
                    SaleItemCompanyCustomerSalesOrganizationID = table.Column<int>(nullable: false),
                    SalesOrderHeaderID = table.Column<int>(nullable: false),
                    SalesOrderLineID = table.Column<int>(nullable: false),
                    SampleQuantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLineAdjustment", x => x.SalesOrderLineAdjustmentID);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineAdjustment_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineAdjustment_PriceRule_PriceRuleID",
                        column: x => x.PriceRuleID,
                        principalTable: "PriceRule",
                        principalColumn: "PriceRuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineAdjustment_SaleItemCompanyCustomerSalesOrganization_SaleItemCompanyCustomerSalesOrganizationID",
                        column: x => x.SaleItemCompanyCustomerSalesOrganizationID,
                        principalTable: "SaleItemCompanyCustomerSalesOrganization",
                        principalColumn: "SaleItemCompanyCustomerSalesOrganizationID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineAdjustment_SalesOrderHeader_SalesOrderHeaderID",
                        column: x => x.SalesOrderHeaderID,
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderHeaderID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineAdjustment_SalesOrderLine_SalesOrderLineID",
                        column: x => x.SalesOrderLineID,
                        principalTable: "SalesOrderLine",
                        principalColumn: "SalesOrderLineID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLineTaxBreakDown",
                columns: table => new
                {
                    SalesOrderLineTaxBreakDownID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasicTaxOnly = table.Column<double>(nullable: false),
                    ClientCustomerJurisdictionTaxExceptionTotal = table.Column<double>(nullable: false),
                    ClientCustomerTaxExceptionTotal = table.Column<double>(nullable: false),
                    ClientCustomerTaxRegimeBasicDataTotal = table.Column<double>(nullable: false),
                    DeviceSalesOrderHeaderID = table.Column<int>(nullable: false),
                    DeviceSalesOrderLineID = table.Column<int>(nullable: false),
                    DeviceSalesOrderLineTaxBreakDownID = table.Column<int>(nullable: false),
                    SaleItemJurisdictionTaxExceptionTotal = table.Column<double>(nullable: false),
                    SaleItemTaxExceptionTotal = table.Column<double>(nullable: false),
                    SaleItemTaxRegimeBasicDataTotal = table.Column<double>(nullable: false),
                    SalesOrderHeaderID = table.Column<int>(nullable: false),
                    SalesOrderLineID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLineTaxBreakDown", x => x.SalesOrderLineTaxBreakDownID);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineTaxBreakDown_SalesOrderHeader_SalesOrderHeaderID",
                        column: x => x.SalesOrderHeaderID,
                        principalTable: "SalesOrderHeader",
                        principalColumn: "SalesOrderHeaderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderLineTaxBreakDown_SalesOrderLine_SalesOrderLineID",
                        column: x => x.SalesOrderLineID,
                        principalTable: "SalesOrderLine",
                        principalColumn: "SalesOrderLineID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CountryCityID",
                table: "Bank",
                column: "CountryCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CountryID",
                table: "Bank",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompany_ClientID",
                table: "ClientCompany",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompany_CountryID",
                table: "ClientCompany",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomer_CustomerID",
                table: "ClientCompanyCustomer",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomer_PaymentTermID",
                table: "ClientCompanyCustomer",
                column: "PaymentTermID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomer_PersonnelID",
                table: "ClientCompanyCustomer",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomer",
                table: "ClientCompanyCustomer",
                columns: new[] { "ClientCompanyID", "CustomerID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomerCreditLimit_ClientCompanyCustomerID",
                table: "ClientCompanyCustomerCreditLimit",
                column: "ClientCompanyCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomerCreditLimit_CreditCheckStatusID",
                table: "ClientCompanyCustomerCreditLimit",
                column: "CreditCheckStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyCustomerTaxException_TaxProfileID",
                table: "ClientCompanyCustomerTaxException",
                column: "TaxProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTaxException",
                table: "ClientCompanyCustomerTaxException",
                columns: new[] { "ClientCompanyCustomerID", "TaxProfileID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyPlant_ClientCompanyID",
                table: "ClientCompanyPlant",
                column: "ClientCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_ChannelID",
                table: "CompanyCustomerSalesOrganization",
                column: "ChannelID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_CountryID",
                table: "CompanyCustomerSalesOrganization",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_DivisionID",
                table: "CompanyCustomerSalesOrganization",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_PaymentTermID",
                table: "CompanyCustomerSalesOrganization",
                column: "PaymentTermID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_PersonnelID",
                table: "CompanyCustomerSalesOrganization",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganization_SalesOrganizationID",
                table: "CompanyCustomerSalesOrganization",
                column: "SalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSalesOrganizationDivisionChannel",
                table: "CompanyCustomerSalesOrganization",
                columns: new[] { "ClientCompanyCustomerID", "SalesOrganizationID", "DivisionID", "ChannelID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganizationCreditLimit_CompanyCustomerSalesOrganizationID",
                table: "CompanyCustomerSalesOrganizationCreditLimit",
                column: "CompanyCustomerSalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomerSalesOrganizationCreditLimit_CreditCheckStatusID",
                table: "CompanyCustomerSalesOrganizationCreditLimit",
                column: "CreditCheckStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCity_CountryID",
                table: "CountryCity",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCityRegion1_CountryCityID",
                table: "CountryCityRegion1",
                column: "CountryCityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCityRegion2_CountryCityID",
                table: "CountryCityRegion2",
                column: "CountryCityID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCurrency_CountryID",
                table: "CountryCurrency",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Classification1ID",
                table: "Customer",
                column: "Classification1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Classification2ID",
                table: "Customer",
                column: "Classification2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CountryCityID",
                table: "Customer",
                column: "CountryCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CountryCityRegion1ID",
                table: "Customer",
                column: "CountryCityRegion1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CountryCityRegion2ID",
                table: "Customer",
                column: "CountryCityRegion2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CountryID",
                table: "Customer",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_LanguageID",
                table: "Customer",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBank_BankID",
                table: "CustomerBank",
                column: "BankID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBank_CountryCurrencyID",
                table: "CustomerBank",
                column: "CountryCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerIDBankIDCountryCurrency",
                table: "CustomerBank",
                columns: new[] { "CustomerID", "BankID", "CountryCurrencyID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_DivisionID",
                table: "Item",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemBrandID",
                table: "Item",
                column: "ItemBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemDimensionUnitID",
                table: "Item",
                column: "ItemDimensionUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemStatusID",
                table: "Item",
                column: "ItemStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTypeID",
                table: "Item",
                column: "ItemTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemUnitOfMeasureID",
                table: "Item",
                column: "ItemUnitOfMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemVolumeUnitID",
                table: "Item",
                column: "ItemVolumeUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemWeightUnitID",
                table: "Item",
                column: "ItemWeightUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemClientCompanyPlant_ClientCompanyPlantID",
                table: "ItemClientCompanyPlant",
                column: "ClientCompanyPlantID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemClientCompanyPlant_ItemStatusID",
                table: "ItemClientCompanyPlant",
                column: "ItemStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemClientCompanyPlant_MakeBuyGoodsID",
                table: "ItemClientCompanyPlant",
                column: "MakeBuyGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemClientCompanyPlant",
                table: "ItemClientCompanyPlant",
                columns: new[] { "ItemID", "ClientCompanyPlantID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPlantStorageBin",
                table: "ItemClientCompanyPlantStorageLocation",
                columns: new[] { "ItemClientCompanyPlantID", "StorageLocationName", "StorageBinName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemClientCompanyPlantStorageLocationCurrentStock_ItemClientCompanyPlantStorageLocationID",
                table: "ItemClientCompanyPlantStorageLocationCurrentStock",
                column: "ItemClientCompanyPlantStorageLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDescription_ItemID",
                table: "ItemDescription",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDescription_LanguageID",
                table: "ItemDescription",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPhoto_ItemID",
                table: "ItemPhoto",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPhoto_SaleItemID",
                table: "ItemPhoto",
                column: "SaleItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPhoto",
                table: "ItemPhoto",
                columns: new[] { "ItemPhotoID", "ItemID", "SaleItemID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemTaxCode_ItemID",
                table: "ItemTaxCode",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTaxCode_TaxCodeID",
                table: "ItemTaxCode",
                column: "TaxCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_LegacyItem_ItemID",
                table: "LegacyItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCompanyLegacyItemCode",
                table: "LegacyItem",
                columns: new[] { "ClientCompanyID", "LegacyItemCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_JobRoleID",
                table: "Personnel",
                column: "JobRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_PriceRuleDatesExpression",
                table: "PriceRule",
                columns: new[] { "PriceRuleTypeID", "EffectiveDate", "ExpiryDate", "PriceRuleQualification1Expression", "PriceRuleQualification2Expression", "PriceRuleApplication1Expression", "PriceRuleApplication2Expression", "PriceRuleExclusion1Expression", "PriceRuleExclusion2Expression" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PriceRuleType_PriceRuleApplicationID",
                table: "PriceRuleType",
                column: "PriceRuleApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_ItemID",
                table: "SaleItem",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_ItemUnitOfMeasureID",
                table: "SaleItem",
                column: "ItemUnitOfMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemCompanyCustomerSalesOrganization_CompanyCustomerSalesOrganizationID",
                table: "SaleItemCompanyCustomerSalesOrganization",
                column: "CompanyCustomerSalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemCompanyCustomerSalesOrganization_ItemClientCompanyPlantID",
                table: "SaleItemCompanyCustomerSalesOrganization",
                column: "ItemClientCompanyPlantID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemCompanyCustomerSalesOrganization_ItemID",
                table: "SaleItemCompanyCustomerSalesOrganization",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemSalesOrganizationPlant",
                table: "SaleItemCompanyCustomerSalesOrganization",
                columns: new[] { "SaleItemID", "CompanyCustomerSalesOrganizationID", "ItemClientCompanyPlantID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemCompanyCustomerSalesOrganizationTaxException_TaxProfileID",
                table: "SaleItemCompanyCustomerSalesOrganizationTaxException",
                column: "TaxProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemSalesOrgTaxProfile",
                table: "SaleItemCompanyCustomerSalesOrganizationTaxException",
                columns: new[] { "SaleItemCompanyCustomerSalesOrganizationID", "TaxProfileID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemPrice_CountryID",
                table: "SaleItemPrice",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemIDCountryID",
                table: "SaleItemPrice",
                columns: new[] { "SaleItemID", "CountryID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CompanyCustomerSalesOrganizationID",
                table: "SalesOrderHeader",
                column: "CompanyCustomerSalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_CustomerID",
                table: "SalesOrderHeader",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_SalesOrderStatusID",
                table: "SalesOrderHeader",
                column: "SalesOrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeader_UserID",
                table: "SalesOrderHeader",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderHeaderOrganizationUserHardwareId",
                table: "SalesOrderHeader",
                columns: new[] { "DeviceSalesOrderHeaderID", "CompanyCustomerSalesOrganizationID", "UserID", "DeviceIdentification", "IMEINumber", "OrderDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderInvoice_InvoiceStatusID",
                table: "SalesOrderInvoice",
                column: "InvoiceStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderInvoice_SalesOrderHeaderID",
                table: "SalesOrderInvoice",
                column: "SalesOrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderInvoicePayment_PaymentMethodID1",
                table: "SalesOrderInvoicePayment",
                column: "PaymentMethodID1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoicePaymentReference",
                table: "SalesOrderInvoicePayment",
                column: "ReferenceNumberOrComment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderInvoicePayment_SalesOrderInvoiceID",
                table: "SalesOrderInvoicePayment",
                column: "SalesOrderInvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_ItemID",
                table: "SalesOrderLine",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_ItemUnitOfMeasureID",
                table: "SalesOrderLine",
                column: "ItemUnitOfMeasureID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_SaleItemCompanyCustomerSalesOrganizationID",
                table: "SalesOrderLine",
                column: "SaleItemCompanyCustomerSalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_SalesOrderHeaderID",
                table: "SalesOrderLine",
                column: "SalesOrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLine_UserID",
                table: "SalesOrderLine",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineOrganizationItemUserDevice",
                table: "SalesOrderLine",
                columns: new[] { "DeviceSalesOrderLineID", "SalesOrderHeaderID", "DeviceSalesOrderHeaderID", "ItemID", "UserID", "DeviceIdentification", "IMEINumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustment_ItemID",
                table: "SalesOrderLineAdjustment",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustment_PriceRuleID",
                table: "SalesOrderLineAdjustment",
                column: "PriceRuleID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustment_SaleItemCompanyCustomerSalesOrganizationID",
                table: "SalesOrderLineAdjustment",
                column: "SaleItemCompanyCustomerSalesOrganizationID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustment_SalesOrderHeaderID",
                table: "SalesOrderLineAdjustment",
                column: "SalesOrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustment_SalesOrderLineID",
                table: "SalesOrderLineAdjustment",
                column: "SalesOrderLineID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineAdjustmentOrganizationItemUserDevice",
                table: "SalesOrderLineAdjustment",
                columns: new[] { "DeviceSalesOrderLineAdjustmentID", "SalesOrderHeaderID", "DeviceSalesOrderHeaderID", "SalesOrderLineID", "DeviceSalesOrderLineID", "PriceRuleID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineTaxBreakDown_SalesOrderHeaderID",
                table: "SalesOrderLineTaxBreakDown",
                column: "SalesOrderHeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLineTaxBreakDown_SalesOrderLineID",
                table: "SalesOrderLineTaxBreakDown",
                column: "SalesOrderLineID");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrganization_PersonnelID",
                table: "SalesOrganization",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxApplicationOrder",
                table: "TaxBasicConfiguration",
                column: "TaxApplicationOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxBasicConfiguration_TaxCodeID",
                table: "TaxBasicConfiguration",
                column: "TaxCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryTaxCode",
                table: "TaxCode",
                columns: new[] { "CountryID", "TaxCodeName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxJurisdiction_CountryCityRegion1ID",
                table: "TaxJurisdiction",
                column: "CountryCityRegion1ID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxJurisdiction_CountryCityRegion2ID",
                table: "TaxJurisdiction",
                column: "CountryCityRegion2ID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxJurisdiction_TaxCodeID",
                table: "TaxJurisdiction",
                column: "TaxCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Jurisdiction_Country_Region1_Region2",
                table: "TaxJurisdiction",
                columns: new[] { "CountryCityID", "CountryCityRegion1ID", "CountryCityRegion2ID", "TaxCodeID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaxProfile_TaxCodeID",
                table: "TaxProfile",
                column: "TaxCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonnelID",
                table: "User",
                column: "PersonnelID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDeviceAssignment_DeviceID",
                table: "UserDeviceAssignment",
                column: "DeviceID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeviceAssignment_UserID",
                table: "UserDeviceAssignment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserItemClientCompanyPlantStorageLocation_ItemClientCompanyPlantStorageLocationID",
                table: "UserItemClientCompanyPlantStorageLocation",
                column: "ItemClientCompanyPlantStorageLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_UserItemClientCompanyPlantStorageLocation_UserID",
                table: "UserItemClientCompanyPlantStorageLocation",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientCompanyCustomerCreditLimit");

            migrationBuilder.DropTable(
                name: "ClientCompanyCustomerTaxException");

            migrationBuilder.DropTable(
                name: "CompanyCustomerSalesOrganizationCreditLimit");

            migrationBuilder.DropTable(
                name: "CustomerBank");

            migrationBuilder.DropTable(
                name: "ItemClientCompanyPlantStorageLocationCurrentStock");

            migrationBuilder.DropTable(
                name: "ItemDescription");

            migrationBuilder.DropTable(
                name: "ItemPhoto");

            migrationBuilder.DropTable(
                name: "ItemTaxCode");

            migrationBuilder.DropTable(
                name: "LegacyItem");

            migrationBuilder.DropTable(
                name: "SaleItemCompanyCustomerSalesOrganizationTaxException");

            migrationBuilder.DropTable(
                name: "SaleItemPrice");

            migrationBuilder.DropTable(
                name: "SalesOrderInvoicePayment");

            migrationBuilder.DropTable(
                name: "SalesOrderLineAdjustment");

            migrationBuilder.DropTable(
                name: "SalesOrderLineTaxBreakDown");

            migrationBuilder.DropTable(
                name: "TaxBasicConfiguration");

            migrationBuilder.DropTable(
                name: "TaxJurisdiction");

            migrationBuilder.DropTable(
                name: "UserDeviceAssignment");

            migrationBuilder.DropTable(
                name: "UserItemClientCompanyPlantStorageLocation");

            migrationBuilder.DropTable(
                name: "CreditCheckStatus");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "CountryCurrency");

            migrationBuilder.DropTable(
                name: "TaxProfile");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "SalesOrderInvoice");

            migrationBuilder.DropTable(
                name: "PriceRule");

            migrationBuilder.DropTable(
                name: "SalesOrderLine");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "ItemClientCompanyPlantStorageLocation");

            migrationBuilder.DropTable(
                name: "TaxCode");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropTable(
                name: "PriceRuleType");

            migrationBuilder.DropTable(
                name: "SaleItemCompanyCustomerSalesOrganization");

            migrationBuilder.DropTable(
                name: "SalesOrderHeader");

            migrationBuilder.DropTable(
                name: "PriceRuleApplication");

            migrationBuilder.DropTable(
                name: "ItemClientCompanyPlant");

            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropTable(
                name: "CompanyCustomerSalesOrganization");

            migrationBuilder.DropTable(
                name: "SalesOrderStatus");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ClientCompanyPlant");

            migrationBuilder.DropTable(
                name: "MakeBuyGoods");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "ClientCompanyCustomer");

            migrationBuilder.DropTable(
                name: "SalesOrganization");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "ItemBrand");

            migrationBuilder.DropTable(
                name: "ItemDimensionUnit");

            migrationBuilder.DropTable(
                name: "ItemStatus");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "ItemUnitOfMeasure");

            migrationBuilder.DropTable(
                name: "ItemVolumeUnit");

            migrationBuilder.DropTable(
                name: "ItemWeightUnit");

            migrationBuilder.DropTable(
                name: "ClientCompany");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "PaymentTerm");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Classification1");

            migrationBuilder.DropTable(
                name: "Classification2");

            migrationBuilder.DropTable(
                name: "CountryCityRegion1");

            migrationBuilder.DropTable(
                name: "CountryCityRegion2");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "JobRole");

            migrationBuilder.DropTable(
                name: "CountryCity");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
