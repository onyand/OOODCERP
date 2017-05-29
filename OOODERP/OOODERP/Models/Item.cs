using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOODERP.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        //public string LegacyItemCode { get; set; }
        public int ItemTypeID { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int ItemUnitOfMeasureID { get; set; }
        public virtual ItemUnitOfMeasure ItemUnitOfMeasure { get; set; }
        public int ItemStatusID { get; set; }
        public virtual ItemStatus ItemStatus { get; set; }
        public int DivisionID { get; set; }
        public virtual Division Division { get; set; }
        public int ItemBrandID { get; set; }
        public virtual ItemBrand ItemBrand { get; set; }
        public string BarCodeNumber { get; set; }
        public float GrossWeight { get; set; }
        public float NetWeight { get; set; }
        public int ItemWeightUnitID { get; set; }
        public virtual ItemWeightUnit ItemWeightUnit { get; set; }
        public float VolumeSize { get; set; }
        public int ItemVolumeUnitID { get; set; }
        public virtual ItemVolumeUnit ItemVolumeUnit { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int ItemDimensionUnitID { get; set; }
        public virtual ItemDimensionUnit ItemDimensionUnit { get; set; }
        public int NumberOfPiecesInItem { get; set; }
        private DateTime CreateDate = DateTime.Now;
        [ScaffoldColumn(false)]
        public DateTime CreationDate
        {
            get { return CreateDate; }
            set { CreateDate = value; }
        }
        public List<ItemDescription> ItemDescriptions { get; set; }
        public List<LegacyItem> LegacyItems { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public List<ItemTaxCode> ItemTaxCodes { get; set; }
        public List<SaleItemCompanyCustomerSalesOrganization> SaleItemCompanyCustomerSalesOrganizations { get; set; }
        public List<SalesOrderLine> SalesOrderLines { get; set; }

    }
}