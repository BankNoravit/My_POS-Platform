using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Domain.Models
{
    [Table("SYS_USER")]
    public class SYS_USER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"USER_ID", Order = 1, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        [Key]
        public System.Guid USER_ID { get; set; } // USER_ID (Primary key)

        [Column(@"COMPANY_ID", Order = 2, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? COMPANY_ID { get; set; } // COMPANY_ID

        [Column(@"EMPLOYEE_ID", Order = 3, TypeName = SQLSERVER_CONST.UNIQUE)]
        public System.Guid? EMPLOYEE_ID { get; set; } // EMPLOYEE_ID

        [Column(@"USERNAME", Order = 4, TypeName = SQLSERVER_CONST.VARCHAR_100)]
        [Required]
        [MaxLength(100)]
        public string? USERNAME { get; set; } // USERNAME (length: 100)

        [Column(@"PASSWORD", Order = 5, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [Required]
        [MaxLength(500)]
        public string? PASSWORD { get; set; } // PASSWORD (length: 500)

        [Column(@"SALT", Order = 6, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? SALT { get; set; } // SALT (length: 500)

        [Column(@"FULLNAME", Order = 7, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [Required]
        [MaxLength(300)]
        public string? FULLNAME { get; set; } // FULLNAME (length: 300)

        [Column(@"PHOTO_URL", Order = 8, TypeName = SQLSERVER_CONST.VARCHAR_300)]
        [MaxLength(300)]
        public string? PHOTO_URL { get; set; } // PHOTO_URL (length: 300)

        [Column(@"IS_ACCOUNT_EXPIRE", Order = 9, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACCOUNT_EXPIRE { get; set; } // IS_ACCOUNT_EXPIRE

        [Column(@"ACCOUNT_EXPIRE_DATE", Order = 10, TypeName = SQLSERVER_CONST.DATETIME)]
        public System.DateTime? ACCOUNT_EXPIRE_DATE { get; set; } // ACCOUNT_EXPIRE_DATE

        [Column(@"PASSWORD_LAST_UPDATE_DATE", Order = 11, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime PASSWORD_LAST_UPDATE_DATE { get; set; } // PASSWORD_LAST_UPDATE_DATE

        [Column(@"FORGOT_PASSWORD_TOKEN", Order = 12, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? FORGOT_PASSWORD_TOKEN { get; set; } // FORGOT_PASSWORD_TOKEN (length: 500)

        [Column(@"RESET_PASSWORD_TOKEN", Order = 13, TypeName = SQLSERVER_CONST.VARCHAR_500)]
        [MaxLength(500)]
        public string? RESET_PASSWORD_TOKEN { get; set; } // RESET_PASSWORD_TOKEN (length: 500)

        [Column(@"COMMENTS", Order = 14, TypeName = SQLSERVER_CONST.VARCHAR_4000)]
        [MaxLength(4000)]
        public string? COMMENTS { get; set; } // COMMENTS (length: 4000)

        [Column(@"CREATED_BY_ID", Order = 15, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid CREATED_BY_ID { get; set; } // CREATED_BY_ID

        [Column(@"CREATION_DATE", Order = 16, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime CREATION_DATE { get; set; } // CREATION_DATE

        [Column(@"LAST_UPDATED_BY_ID", Order = 17, TypeName = SQLSERVER_CONST.UNIQUE)]
        [Required]
        public System.Guid LAST_UPDATED_BY_ID { get; set; } // LAST_UPDATED_BY_ID

        [Column(@"LAST_UPDATE_DATE", Order = 18, TypeName = SQLSERVER_CONST.DATETIME)]
        [Required]
        public System.DateTime LAST_UPDATE_DATE { get; set; } // LAST_UPDATE_DATE

        [Column(@"IS_ACTIVE", Order = 19, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_ACTIVE { get; set; } // IS_ACTIVE

        [Column(@"IS_DELETE", Order = 20, TypeName = SQLSERVER_CONST.BIT)]
        [Required]
        public bool IS_DELETE { get; set; } // IS_DELETE

        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ASM_FA_OS_MATCHING> ASM_FA_OS_MATCHING_CREATED_BY { get; set; } // ASM_FA_OS_MATCHING.FK_ASM_FA_OS_MATCHING_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ASM_FA_OS_MATCHING> ASM_FA_OS_MATCHING_LAST_UPDATED_BY { get; set; } // ASM_FA_OS_MATCHING.FK_ASM_FA_OS_MATCHING_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_BANK_ACCOUNT> FNA_BANK_ACCOUNT_CREATED_BY { get; set; } // FNA_BANK_ACCOUNT.FK_FNA_BANK_ACCOUNT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_BANK_ACCOUNT> FNA_BANK_ACCOUNT_LAST_UPDATED_BY { get; set; } // FNA_BANK_ACCOUNT.FK_FNA_BANK_ACCOUNT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_BANK_BRANCH> FNA_BANK_BRANCH_CREATED_BY { get; set; } // FNA_BANK_BRANCH.FK_FNA_BANK_BRANCH_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_BANK_BRANCH> FNA_BANK_BRANCH_LAST_UPDATED_BY { get; set; } // FNA_BANK_BRANCH.FK_FNA_BANK_BRANCH_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_BANK> FNA_BANK_CREATED_BY { get; set; } // FNA_BANK.FK_FNA_BANK_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_BANK> FNA_BANK_LAST_UPDATED_BY { get; set; } // FNA_BANK.FK_FNA_BANK_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_COST_CENTER> FNA_COST_CENTER_CREATED_BY { get; set; } // FNA_COST_CENTER.FK_FNA_COST_CENTER_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_COST_CENTER> FNA_COST_CENTER_LAST_UPDATED_BY { get; set; } // FNA_COST_CENTER.FK_FNA_COST_CENTER_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_CURRENCY> FNA_CURRENCY_CREATED_BY { get; set; } // FNA_CURRENCY.FK_FNA_CURRENCY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_CURRENCY> FNA_CURRENCY_LAST_UPDATED_BY { get; set; } // FNA_CURRENCY.FK_FNA_CURRENCY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_EXPENSE> FNA_EXPENSE_CREATED_BY { get; set; } // FNA_EXPENSE.FK_FNA_EXPENSE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_EXPENSE> FNA_EXPENSE_LAST_UPDATED_BY { get; set; } // FNA_EXPENSE.FK_FNA_EXPENSE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<FNA_TAX> FNA_TAX_CREATED_BY { get; set; } // FNA_TAX.FK_FNA_TAX_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<FNA_TAX> FNA_TAX_LAST_UPDATED_BY { get; set; } // FNA_TAX.FK_FNA_TAX_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_BRAND> INV_BRAND_CREATED_BY { get; set; } // INV_BRAND.FK_INV_BRAND_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_BRAND> INV_BRAND_LAST_UPDATED_BY { get; set; } // INV_BRAND.FK_INV_BRAND_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_CATEGORY> INV_CATEGORY_CREATED_BY { get; set; } // INV_CATEGORY.FK_INV_CATEGORY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_CATEGORY> INV_CATEGORY_LAST_UPDATED_BY { get; set; } // INV_CATEGORY.FK_INV_CATEGORY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_GROUP_CATEGORY> INV_GROUP_CATEGORY_CREATED_BY { get; set; } // INV_GROUP_CATEGORY.FK_INV_GROUP_CATEGORY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_GROUP_CATEGORY> INV_GROUP_CATEGORY_LAST_UPDATED_BY { get; set; } // INV_GROUP_CATEGORY.FK_INV_GROUP_CATEGORY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_PRODDUCT_SELLING_POINT> INV_PRODDUCT_SELLING_POINT_CREATED_BY { get; set; } // INV_PRODDUCT_SELLING_POINT.FK_INV_PRODDUCT_SELLING_POINT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_PRODDUCT_SELLING_POINT> INV_PRODDUCT_SELLING_POINT_LAST_UPDATED_BY { get; set; } // INV_PRODDUCT_SELLING_POINT.FK_INV_PRODDUCT_SELLING_POINT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_PRODUCT_IMAGE> INV_PRODUCT_IMAGE_CREATED_BY { get; set; } // INV_PRODUCT_IMAGE.FK_INV_PRODUCT_IMAGE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_PRODUCT_IMAGE> INV_PRODUCT_IMAGE_LAST_UPDATED_BY { get; set; } // INV_PRODUCT_IMAGE.FK_INV_PRODUCT_IMAGE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_PRODUCT_SPECIFICATION> INV_PRODUCT_SPECIFICATION_CREATED_BY { get; set; } // INV_PRODUCT_SPECIFICATION.FK_INV_PRODUCT_SPECIFICATION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_PRODUCT_SPECIFICATION> INV_PRODUCT_SPECIFICATION_LAST_UPDATED_BY { get; set; } // INV_PRODUCT_SPECIFICATION.FK_INV_PRODUCT_SPECIFICATION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_PRODUCT> INV_PRODUCT_CREATED_BY { get; set; } // INV_PRODUCT.FK_INV_PRODUCT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_PRODUCT> INV_PRODUCT_LAST_UPDATED_BY { get; set; } // INV_PRODUCT.FK_INV_PRODUCT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_SPECIFICATION_ITEM> INV_SPECIFICATION_ITEM_CREATED_BY { get; set; } // INV_SPECIFICATION_ITEM.FK_INV_SPECIFICATION_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_SPECIFICATION_ITEM> INV_SPECIFICATION_ITEM_LAST_UPDATED_BY { get; set; } // INV_SPECIFICATION_ITEM.FK_INV_SPECIFICATION_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_SPECIFICATION> INV_SPECIFICATION_CREATED_BY { get; set; } // INV_SPECIFICATION.FK_INV_SPECIFICATION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_SPECIFICATION> INV_SPECIFICATION_LAST_UPDATED_BY { get; set; } // INV_SPECIFICATION.FK_INV_SPECIFICATION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM_CREATED_BY { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM_LAST_UPDATED_BY { get; set; } // INV_STOCK_REQUISITION_ITEM.FK_INV_STOCK_REQUISITION_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_STOCK_REQUISITION> INV_STOCK_REQUISITION_CREATED_BY { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_STOCK_REQUISITION> INV_STOCK_REQUISITION_LAST_UPDATED_BY { get; set; } // INV_STOCK_REQUISITION.FK_INV_STOCK_REQUISITION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_SUB_CATEGORY> INV_SUB_CATEGORY_CREATED_BY { get; set; } // INV_SUB_CATEGORY.FK_INV_SUB_CATEGORY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_SUB_CATEGORY> INV_SUB_CATEGORY_LAST_UPDATED_BY { get; set; } // INV_SUB_CATEGORY.FK_INV_SUB_CATEGORY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_UOM> INV_UOM_CREATED_BY { get; set; } // INV_UOM.FK_INV_UOM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_UOM> INV_UOM_LAST_UPDATED_BY { get; set; } // INV_UOM.FK_INV_UOM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_WAREHOUSE_ADDRESS> INV_WAREHOUSE_ADDRESS_CREATED_BY { get; set; } // INV_WAREHOUSE_ADDRESS.FK_INV_WAREHOUSE_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_WAREHOUSE_ADDRESS> INV_WAREHOUSE_ADDRESS_LAST_UPDATED_BY { get; set; } // INV_WAREHOUSE_ADDRESS.FK_INV_WAREHOUSE_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_WAREHOUSE_LOCATION> INV_WAREHOUSE_LOCATION_CREATED_BY { get; set; } // INV_WAREHOUSE_LOCATION.FK_INV_WAREHOUSE_LOCATION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_WAREHOUSE_LOCATION> INV_WAREHOUSE_LOCATION_LAST_UPDATED_BY { get; set; } // INV_WAREHOUSE_LOCATION.FK_INV_WAREHOUSE_LOCATION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<INV_WAREHOUSE> INV_WAREHOUSE_CREATED_BY { get; set; } // INV_WAREHOUSE.FK_INV_WAREHOUSE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<INV_WAREHOUSE> INV_WAREHOUSE_LAST_UPDATED_BY { get; set; } // INV_WAREHOUSE.FK_INV_WAREHOUSE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_BRANCH_ADDRESS> ORG_BRANCH_ADDRESS_CREATED_BY { get; set; } // ORG_BRANCH_ADDRESS.FK_ORG_BRANCH_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_BRANCH_ADDRESS> ORG_BRANCH_ADDRESS_LAST_UPDATED_BY { get; set; } // ORG_BRANCH_ADDRESS.FK_ORG_BRANCH_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_BRANCH_GROUP_ITEM> ORG_BRANCH_GROUP_ITEM_CREATED_BY { get; set; } // ORG_BRANCH_GROUP_ITEM.FK_ORG_BRANCH_GROUP_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_BRANCH_GROUP_ITEM> ORG_BRANCH_GROUP_ITEM_LAST_UPDATED_BY { get; set; } // ORG_BRANCH_GROUP_ITEM.FK_ORG_BRANCH_GROUP_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_BRANCH_GROUP> ORG_BRANCH_GROUP_CREATED_BY { get; set; } // ORG_BRANCH_GROUP.FK_ORG_BRANCH_GROUP_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_BRANCH_GROUP> ORG_BRANCH_GROUP_LAST_UPDATED_BY { get; set; } // ORG_BRANCH_GROUP.FK_ORG_BRANCH_GROUP_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_BRANCH> ORG_BRANCH_CREATED_BY { get; set; } // ORG_BRANCH.FK_ORG_BRANCH_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_BRANCH> ORG_BRANCH_LAST_UPDATED_BY { get; set; } // ORG_BRANCH.FK_ORG_BRANCH_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_BUSINESS_UNIT> ORG_BUSINESS_UNIT_CREATED_BY { get; set; } // ORG_BUSINESS_UNIT.FK_ORG_BUSINESS_UNIT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_BUSINESS_UNIT> ORG_BUSINESS_UNIT_LAST_UPDATED_BY { get; set; } // ORG_BUSINESS_UNIT.FK_ORG_BUSINESS_UNIT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_COMPANY_ADDRESS> ORG_COMPANY_ADDRESS_CREATED_BY { get; set; } // ORG_COMPANY_ADDRESS.FK_ORG_COMPANY_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_COMPANY_ADDRESS> ORG_COMPANY_ADDRESS_LAST_UPDATED_BY { get; set; } // ORG_COMPANY_ADDRESS.FK_ORG_COMPANY_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_COMPANY> ORG_COMPANY_CREATED_BY { get; set; } // ORG_COMPANY.FK_ORG_COMPANY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_COMPANY> ORG_COMPANY_LAST_UPDATED_BY { get; set; } // ORG_COMPANY.FK_ORG_COMPANY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_DEPARTMENT> ORG_DEPARTMENT_CREATED_BY { get; set; } // ORG_DEPARTMENT.FK_ORG_DEPARTMENT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_DEPARTMENT> ORG_DEPARTMENT_LAST_UPDATED_BY { get; set; } // ORG_DEPARTMENT.FK_ORG_DEPARTMENT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_EMPLOYEE_ADDRESS> ORG_EMPLOYEE_ADDRESS_CREATED_BY { get; set; } // ORG_EMPLOYEE_ADDRESS.FK_ORG_EMPLOYEE_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_EMPLOYEE_ADDRESS> ORG_EMPLOYEE_ADDRESS_LAST_UPDATED_BY { get; set; } // ORG_EMPLOYEE_ADDRESS.FK_ORG_EMPLOYEE_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_EMPLOYEE> ORG_EMPLOYEE_CREATED_BY { get; set; } // ORG_EMPLOYEE.FK_ORG_EMPLOYEE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_EMPLOYEE> ORG_EMPLOYEE_LAST_UPDATED_BY { get; set; } // ORG_EMPLOYEE.FK_ORG_EMPLOYEE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_FRANCHISEE_ADDRESS> ORG_FRANCHISEE_ADDRESS_CREATED_BY { get; set; } // ORG_FRANCHISEE_ADDRESS.FK_ORG_FRANCHISEE_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_FRANCHISEE_ADDRESS> ORG_FRANCHISEE_ADDRESS_LAST_UPDATED_BY { get; set; } // ORG_FRANCHISEE_ADDRESS.FK_ORG_FRANCHISEE_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_FRANCHISEE> ORG_FRANCHISEE_CREATED_BY { get; set; } // ORG_FRANCHISEE.FK_ORG_FRANCHISEE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_FRANCHISEE> ORG_FRANCHISEE_LAST_UPDATED_BY { get; set; } // ORG_FRANCHISEE.FK_ORG_FRANCHISEE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_POSITION_LEVEL> ORG_POSITION_LEVEL_CREATED_BY { get; set; } // ORG_POSITION_LEVEL.FK_ORG_POSITION_LEVEL_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_POSITION_LEVEL> ORG_POSITION_LEVEL_LAST_UPDATED_BY { get; set; } // ORG_POSITION_LEVEL.FK_ORG_POSITION_LEVEL_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_POSITION> ORG_POSITION_CREATED_BY { get; set; } // ORG_POSITION.FK_ORG_POSITION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_POSITION> ORG_POSITION_LAST_UPDATED_BY { get; set; } // ORG_POSITION.FK_ORG_POSITION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<ORG_ZONE> ORG_ZONE_CREATED_BY { get; set; } // ORG_ZONE.FK_ORG_ZONE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<ORG_ZONE> ORG_ZONE_LAST_UPDATED_BY { get; set; } // ORG_ZONE.FK_ORG_ZONE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM_SERIAL> PUR_GOODS_RECEIPT_ITEM_SERIAL_CREATED_BY { get; set; } // PUR_GOODS_RECEIPT_ITEM_SERIAL.FK_PUR_GOODS_RECEIPT_ITEM_SERIAL_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM_SERIAL> PUR_GOODS_RECEIPT_ITEM_SERIAL_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RECEIPT_ITEM_SERIAL.FK_PUR_GOODS_RECEIPT_ITEM_SERIAL_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM_CREATED_BY { get; set; } // PUR_GOODS_RECEIPT_ITEM.FK_PUR_GOODS_RECEIPT_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RECEIPT_ITEM.FK_PUR_GOODS_RECEIPT_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT_CREATED_BY { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RECEIPT.FK_PUR_GOODS_RECEIPT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN_ITEM_SERIAL> PUR_GOODS_RETURN_ITEM_SERIAL_CREATED_BY { get; set; } // PUR_GOODS_RETURN_ITEM_SERIAL.FK_PUR_GOODS_RETURN_ITEM_SERIAL_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN_ITEM_SERIAL> PUR_GOODS_RETURN_ITEM_SERIAL_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RETURN_ITEM_SERIAL.FK_PUR_GOODS_RETURN_ITEM_SERIAL_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN_ITEM> PUR_GOODS_RETURN_ITEM_CREATED_BY { get; set; } // PUR_GOODS_RETURN_ITEM.FK_PUR_GOODS_RETURN_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN_ITEM> PUR_GOODS_RETURN_ITEM_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RETURN_ITEM.FK_PUR_GOODS_RETURN_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN_CREATED_BY { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_GOODS_RETURN> PUR_GOODS_RETURN_LAST_UPDATED_BY { get; set; } // PUR_GOODS_RETURN.FK_PUR_GOODS_RETURN_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION_CREATED_BY { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION.FK_PUR_PURCHASE_ORDER_ITEM_LOCATION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM> PUR_PURCHASE_ORDER_ITEM_CREATED_BY { get; set; } // PUR_PURCHASE_ORDER_ITEM.FK_PUR_PURCHASE_ORDER_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER_ITEM> PUR_PURCHASE_ORDER_ITEM_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_ORDER_ITEM.FK_PUR_PURCHASE_ORDER_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER_CREATED_BY { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_ORDER.FK_PUR_PURCHASE_ORDER_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> PUR_PURCHASE_REQUISITION_ITEM_LOCATION_CREATED_BY { get; set; } // PUR_PURCHASE_REQUISITION_ITEM_LOCATION.FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> PUR_PURCHASE_REQUISITION_ITEM_LOCATION_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_REQUISITION_ITEM_LOCATION.FK_PUR_PURCHASE_REQUISITION_ITEM_LOCATION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM_CREATED_BY { get; set; } // PUR_PURCHASE_REQUISITION_ITEM.FK_PUR_PURCHASE_REQUISITION_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_REQUISITION_ITEM.FK_PUR_PURCHASE_REQUISITION_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_CREATED_BY { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION_LAST_UPDATED_BY { get; set; } // PUR_PURCHASE_REQUISITION.FK_PUR_PURCHASE_REQUISITION_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR_ADDRESS> PUR_VENDOR_ADDRESS_CREATED_BY { get; set; } // PUR_VENDOR_ADDRESS.FK_PUR_VENDOR_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR_ADDRESS> PUR_VENDOR_ADDRESS_LAST_UPDATED_BY { get; set; } // PUR_VENDOR_ADDRESS.FK_PUR_VENDOR_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT_CREATED_BY { get; set; } // PUR_VENDOR_BANK_ACCOUNT.FK_PUR_VENDOR_BANK_ACCOUNT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT_LAST_UPDATED_BY { get; set; } // PUR_VENDOR_BANK_ACCOUNT.FK_PUR_VENDOR_BANK_ACCOUNT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR_CONTACT> PUR_VENDOR_CONTACT_CREATED_BY { get; set; } // PUR_VENDOR_CONTACT.FK_PUR_VENDOR_CONTACT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR_CONTACT> PUR_VENDOR_CONTACT_LAST_UPDATED_BY { get; set; } // PUR_VENDOR_CONTACT.FK_PUR_VENDOR_CONTACT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR_GROUP> PUR_VENDOR_GROUP_CREATED_BY { get; set; } // PUR_VENDOR_GROUP.FK_PUR_VENDOR_GROUP_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR_GROUP> PUR_VENDOR_GROUP_LAST_UPDATED_BY { get; set; } // PUR_VENDOR_GROUP.FK_PUR_VENDOR_GROUP_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR_TYPE> PUR_VENDOR_TYPE_CREATED_BY { get; set; } // PUR_VENDOR_TYPE.FK_PUR_VENDOR_TYPE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR_TYPE> PUR_VENDOR_TYPE_LAST_UPDATED_BY { get; set; } // PUR_VENDOR_TYPE.FK_PUR_VENDOR_TYPE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<PUR_VENDOR> PUR_VENDOR_CREATED_BY { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<PUR_VENDOR> PUR_VENDOR_LAST_UPDATED_BY { get; set; } // PUR_VENDOR.FK_PUR_VENDOR_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SA_PASSWORD_POLICY> SA_PASSWORD_POLICY_CREATED_BY { get; set; } // SA_PASSWORD_POLICY.FK_SA_PASSWORD_POLICY_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SA_PASSWORD_POLICY> SA_PASSWORD_POLICY_LAST_UPDATED_BY { get; set; } // SA_PASSWORD_POLICY.FK_SA_PASSWORD_POLICY_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_ADDRESS> SAL_CUSTOMER_ADDRESS_CREATED_BY { get; set; } // SAL_CUSTOMER_ADDRESS.FK_SAL_CUSTOMER_ADDRESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_ADDRESS> SAL_CUSTOMER_ADDRESS_LAST_UPDATED_BY { get; set; } // SAL_CUSTOMER_ADDRESS.FK_SAL_CUSTOMER_ADDRESS_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_BANK_ACCOUNT> SAL_CUSTOMER_BANK_ACCOUNT_CREATED_BY { get; set; } // SAL_CUSTOMER_BANK_ACCOUNT.FK_SAL_CUSTOMER_BANK_ACCOUNT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_BANK_ACCOUNT> SAL_CUSTOMER_BANK_ACCOUNT_LAST_UPDATED_BY { get; set; } // SAL_CUSTOMER_BANK_ACCOUNT.FK_SAL_CUSTOMER_BANK_ACCOUNT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_CONTACT> SAL_CUSTOMER_CONTACT_CREATED_BY { get; set; } // SAL_CUSTOMER_CONTACT.FK_SAL_CUSTOMER_CONTACT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_CONTACT> SAL_CUSTOMER_CONTACT_LAST_UPDATED_BY { get; set; } // SAL_CUSTOMER_CONTACT.FK_SAL_CUSTOMER_CONTACT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_GROUP> SAL_CUSTOMER_GROUP_CREATED_BY { get; set; } // SAL_CUSTOMER_GROUP.FK_SAL_CUSTOMER_GROUP_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SAL_CUSTOMER_GROUP> SAL_CUSTOMER_GROUP_LAST_UPDATED_BY { get; set; } // SAL_CUSTOMER_GROUP.FK_SAL_CUSTOMER_GROUP_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_CREATED_BY { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SAL_CUSTOMER> SAL_CUSTOMER_LAST_UPDATED_BY { get; set; } // SAL_CUSTOMER.FK_SAL_CUSTOMER_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_COLUMN_LANG> SYS_COLUMN_LANG_CREATED_BY { get; set; } // SYS_COLUMN_LANG.FK_SYS_COLUMN_LANG_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_COLUMN_LANG> SYS_COLUMN_LANG_LAST_UPDATED_BY { get; set; } // SYS_COLUMN_LANG.FK_SYS_COLUMN_LANG_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_COLUMN> SYS_COLUMN_CREATED_BY { get; set; } // SYS_COLUMN.FK_SYS_COLUMN_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_COLUMN> SYS_COLUMN_LAST_UPDATED_BY { get; set; } // SYS_COLUMN.FK_SYS_COLUMN_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_DISTRICT> SYS_DISTRICT_CREATED_BY { get; set; } // SYS_DISTRICT.FK_SYS_DISTRICT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_DISTRICT> SYS_DISTRICT_LAST_UPDATED_BY { get; set; } // SYS_DISTRICT.FK_SYS_DISTRICT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_FLEX_ITEM> SYS_FLEX_ITEM_CREATED_BY { get; set; } // SYS_FLEX_ITEM.FK_SYS_FLEX_ITEM_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_FLEX_ITEM> SYS_FLEX_ITEM_LAST_UPDATED_BY { get; set; } // SYS_FLEX_ITEM.FK_SYS_FLEX_ITEM_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_FLEX> SYS_FLEX_CREATED_BY { get; set; } // SYS_FLEX.FK_SYS_FLEX_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_FLEX> SYS_FLEX_LAST_UPDATED_BY { get; set; } // SYS_FLEX.FK_SYS_FLEX_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_MENU_LANG> SYS_MENU_LANG_CREATED_BY { get; set; } // SYS_MENU_LANG.FK_SYS_MENU_LANG_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_MENU_LANG> SYS_MENU_LANG_LAST_UPDATED_BY { get; set; } // SYS_MENU_LANG.FK_SYS_MENU_LANG_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_MENU> SYS_MENU_CREATED_BY { get; set; } // SYS_MENU.FK_SYS_MENU_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_MENU> SYS_MENU_LAST_UPDATED_BY { get; set; } // SYS_MENU.FK_SYS_MENU_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_OBJECT> SYS_OBJECT_CREATED_BY { get; set; } // SYS_OBJECT.FK_SYS_OBJECT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_OBJECT> SYS_OBJECT_LAST_UPDATED_BY { get; set; } // SYS_OBJECT.FK_SYS_OBJECT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_PROVINCE> SYS_PROVINCE_CREATED_BY { get; set; } // SYS_PROVINCE.FK_SYS_PROVINCE_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_PROVINCE> SYS_PROVINCE_LAST_UPDATED_BY { get; set; } // SYS_PROVINCE.FK_SYS_PROVINCE_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_SUB_DISTRICT> SYS_SUB_DISTRICT_CREATED_BY { get; set; } // SYS_SUB_DISTRICT.FK_SYS_SUB_DISTRICT_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_SUB_DISTRICT> SYS_SUB_DISTRICT_LAST_UPDATED_BY { get; set; } // SYS_SUB_DISTRICT.FK_SYS_SUB_DISTRICT_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_USER_ACCESS_LOG> SYS_USER_ACCESS_LOG_CREATED_BY { get; set; } // SYS_USER_ACCESS_LOG.FK_SYS_USER_ACCESS_LOG_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_USER_ACCESS_LOG> SYS_USER_ACCESS_LOG_LAST_UPDATED_BY { get; set; } // SYS_USER_ACCESS_LOG.FK_SYS_USER_ACCESS_LOG_LAST_UPDATED_BY_ID
        public virtual ICollection<SYS_USER_ACCESS> SYS_USER_ACCESS { get; set; } // SYS_USER_ACCESS.FK_SYS_USER_ACCESS_USER_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_USER_ACCESS> SYS_USER_ACCESS_CREATED_BY { get; set; } // SYS_USER_ACCESS.FK_SYS_USER_ACCESS_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_USER_ACCESS> SYS_USER_ACCESS_LAST_UPDATED_BY { get; set; } // SYS_USER_ACCESS.FK_SYS_USER_ACCESS_LAST_UPDATED_BY_ID
        [InverseProperty("SYS_USER_CREATER")]
        public virtual ICollection<SYS_USER> SYS_USER_CREATED_CHILD { get; set; } // SYS_USER.FK_SYS_USER_CREATED_BY_ID
        [InverseProperty("SYS_USER_UPDATER")]
        public virtual ICollection<SYS_USER> SYS_USER_UPDATED_CHILD { get; set; } // SYS_USER.FK_SYS_USER_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_VIEW_COLUMN_FILTER> SYS_VIEW_COLUMN_FILTER_CREATED_BY { get; set; } // SYS_VIEW_COLUMN_FILTER.FK_SYS_VIEW_COLUMN_FILTER_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_VIEW_COLUMN_FILTER> SYS_VIEW_COLUMN_FILTER_LAST_UPDATED_BY { get; set; } // SYS_VIEW_COLUMN_FILTER.FK_SYS_VIEW_COLUMN_FILTER_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_VIEW_COLUMN> SYS_VIEW_COLUMN_CREATED_BY { get; set; } // SYS_VIEW_COLUMN.FK_SYS_VIEW_COLUMN_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_VIEW_COLUMN> SYS_VIEW_COLUMN_LAST_UPDATED_BY { get; set; } // SYS_VIEW_COLUMN.FK_SYS_VIEW_COLUMN_LAST_UPDATED_BY_ID
        [InverseProperty("CREATED_BY")]
        public virtual ICollection<SYS_VIEW> SYS_VIEW_CREATED_BY { get; set; } // SYS_VIEW.FK_SYS_VIEW_CREATED_BY_ID
        [InverseProperty("LAST_UPDATED_BY")]
        public virtual ICollection<SYS_VIEW> SYS_VIEW_LAST_UPDATED_BY { get; set; } // SYS_VIEW.FK_SYS_VIEW_LAST_UPDATED_BY_ID

        public virtual ORG_COMPANY ORG_COMPANY { get; set; } // FK_SYS_USER_COMPANY_ID
        public virtual ORG_EMPLOYEE ORG_EMPLOYEE { get; set; } // FK_SYS_USER_EMPLOYEE_ID
        public virtual SYS_USER SYS_USER_CREATER { get; set; } // FK_SYS_USER_CREATED_BY_ID
        public virtual SYS_USER SYS_USER_UPDATER { get; set; } // FK_SYS_USER_LAST_UPDATED_BY_ID

        public SYS_USER()
        {
            this.ASM_FA_OS_MATCHING_CREATED_BY = new List<ASM_FA_OS_MATCHING>();
            this.ASM_FA_OS_MATCHING_LAST_UPDATED_BY = new List<ASM_FA_OS_MATCHING>();
            this.FNA_BANK_CREATED_BY = new List<FNA_BANK>();
            this.FNA_BANK_LAST_UPDATED_BY = new List<FNA_BANK>();
            this.FNA_BANK_ACCOUNT_CREATED_BY = new List<FNA_BANK_ACCOUNT>();
            this.FNA_BANK_ACCOUNT_LAST_UPDATED_BY = new List<FNA_BANK_ACCOUNT>();
            this.FNA_BANK_BRANCH_CREATED_BY = new List<FNA_BANK_BRANCH>();
            this.FNA_BANK_BRANCH_LAST_UPDATED_BY = new List<FNA_BANK_BRANCH>();
            this.FNA_COST_CENTER_CREATED_BY = new List<FNA_COST_CENTER>();
            this.FNA_COST_CENTER_LAST_UPDATED_BY = new List<FNA_COST_CENTER>();
            this.FNA_CURRENCY_CREATED_BY = new List<FNA_CURRENCY>();
            this.FNA_CURRENCY_LAST_UPDATED_BY = new List<FNA_CURRENCY>();
            this.FNA_EXPENSE_CREATED_BY = new List<FNA_EXPENSE>();
            this.FNA_EXPENSE_LAST_UPDATED_BY = new List<FNA_EXPENSE>();
            this.FNA_TAX_CREATED_BY = new List<FNA_TAX>();
            this.FNA_TAX_LAST_UPDATED_BY = new List<FNA_TAX>();
            this.INV_BRAND_CREATED_BY = new List<INV_BRAND>();
            this.INV_BRAND_LAST_UPDATED_BY = new List<INV_BRAND>();
            this.INV_CATEGORY_CREATED_BY = new List<INV_CATEGORY>();
            this.INV_CATEGORY_LAST_UPDATED_BY = new List<INV_CATEGORY>();
            this.INV_GROUP_CATEGORY_CREATED_BY = new List<INV_GROUP_CATEGORY>();
            this.INV_GROUP_CATEGORY_LAST_UPDATED_BY = new List<INV_GROUP_CATEGORY>();
            this.INV_PRODDUCT_SELLING_POINT_CREATED_BY = new List<INV_PRODDUCT_SELLING_POINT>();
            this.INV_PRODDUCT_SELLING_POINT_LAST_UPDATED_BY = new List<INV_PRODDUCT_SELLING_POINT>();
            this.INV_PRODUCT_CREATED_BY = new List<INV_PRODUCT>();
            this.INV_PRODUCT_LAST_UPDATED_BY = new List<INV_PRODUCT>();
            this.INV_PRODUCT_IMAGE_CREATED_BY = new List<INV_PRODUCT_IMAGE>();
            this.INV_PRODUCT_IMAGE_LAST_UPDATED_BY = new List<INV_PRODUCT_IMAGE>();
            this.INV_PRODUCT_SPECIFICATION_CREATED_BY = new List<INV_PRODUCT_SPECIFICATION>();
            this.INV_PRODUCT_SPECIFICATION_LAST_UPDATED_BY = new List<INV_PRODUCT_SPECIFICATION>();
            this.INV_SPECIFICATION_CREATED_BY = new List<INV_SPECIFICATION>();
            this.INV_SPECIFICATION_LAST_UPDATED_BY = new List<INV_SPECIFICATION>();
            this.INV_SPECIFICATION_ITEM_CREATED_BY = new List<INV_SPECIFICATION_ITEM>();
            this.INV_SPECIFICATION_ITEM_LAST_UPDATED_BY = new List<INV_SPECIFICATION_ITEM>();
            this.INV_STOCK_REQUISITION_CREATED_BY = new List<INV_STOCK_REQUISITION>();
            this.INV_STOCK_REQUISITION_LAST_UPDATED_BY = new List<INV_STOCK_REQUISITION>();
            this.INV_STOCK_REQUISITION_ITEM_CREATED_BY = new List<INV_STOCK_REQUISITION_ITEM>();
            this.INV_STOCK_REQUISITION_ITEM_LAST_UPDATED_BY = new List<INV_STOCK_REQUISITION_ITEM>();
            this.INV_SUB_CATEGORY_CREATED_BY = new List<INV_SUB_CATEGORY>();
            this.INV_SUB_CATEGORY_LAST_UPDATED_BY = new List<INV_SUB_CATEGORY>();
            this.INV_UOM_CREATED_BY = new List<INV_UOM>();
            this.INV_UOM_LAST_UPDATED_BY = new List<INV_UOM>();
            this.INV_WAREHOUSE_CREATED_BY = new List<INV_WAREHOUSE>();
            this.INV_WAREHOUSE_LAST_UPDATED_BY = new List<INV_WAREHOUSE>();
            this.INV_WAREHOUSE_ADDRESS_CREATED_BY = new List<INV_WAREHOUSE_ADDRESS>();
            this.INV_WAREHOUSE_ADDRESS_LAST_UPDATED_BY = new List<INV_WAREHOUSE_ADDRESS>();
            this.INV_WAREHOUSE_LOCATION_CREATED_BY = new List<INV_WAREHOUSE_LOCATION>();
            this.INV_WAREHOUSE_LOCATION_LAST_UPDATED_BY = new List<INV_WAREHOUSE_LOCATION>();
            this.ORG_BRANCH_CREATED_BY = new List<ORG_BRANCH>();
            this.ORG_BRANCH_LAST_UPDATED_BY = new List<ORG_BRANCH>();
            this.ORG_BRANCH_ADDRESS_CREATED_BY = new List<ORG_BRANCH_ADDRESS>();
            this.ORG_BRANCH_ADDRESS_LAST_UPDATED_BY = new List<ORG_BRANCH_ADDRESS>();
            this.ORG_BRANCH_GROUP_CREATED_BY = new List<ORG_BRANCH_GROUP>();
            this.ORG_BRANCH_GROUP_LAST_UPDATED_BY = new List<ORG_BRANCH_GROUP>();
            this.ORG_BRANCH_GROUP_ITEM_CREATED_BY = new List<ORG_BRANCH_GROUP_ITEM>();
            this.ORG_BRANCH_GROUP_ITEM_LAST_UPDATED_BY = new List<ORG_BRANCH_GROUP_ITEM>();
            this.ORG_BUSINESS_UNIT_CREATED_BY = new List<ORG_BUSINESS_UNIT>();
            this.ORG_BUSINESS_UNIT_LAST_UPDATED_BY = new List<ORG_BUSINESS_UNIT>();
            this.ORG_COMPANY_CREATED_BY = new List<ORG_COMPANY>();
            this.ORG_COMPANY_LAST_UPDATED_BY = new List<ORG_COMPANY>();
            this.ORG_COMPANY_ADDRESS_CREATED_BY = new List<ORG_COMPANY_ADDRESS>();
            this.ORG_COMPANY_ADDRESS_LAST_UPDATED_BY = new List<ORG_COMPANY_ADDRESS>();
            this.ORG_DEPARTMENT_CREATED_BY = new List<ORG_DEPARTMENT>();
            this.ORG_DEPARTMENT_LAST_UPDATED_BY = new List<ORG_DEPARTMENT>();
            this.ORG_EMPLOYEE_CREATED_BY = new List<ORG_EMPLOYEE>();
            this.ORG_EMPLOYEE_LAST_UPDATED_BY = new List<ORG_EMPLOYEE>();
            this.ORG_EMPLOYEE_ADDRESS_CREATED_BY = new List<ORG_EMPLOYEE_ADDRESS>();
            this.ORG_EMPLOYEE_ADDRESS_LAST_UPDATED_BY = new List<ORG_EMPLOYEE_ADDRESS>();
            this.ORG_FRANCHISEE_CREATED_BY = new List<ORG_FRANCHISEE>();
            this.ORG_FRANCHISEE_LAST_UPDATED_BY = new List<ORG_FRANCHISEE>();
            this.ORG_FRANCHISEE_ADDRESS_CREATED_BY = new List<ORG_FRANCHISEE_ADDRESS>();
            this.ORG_FRANCHISEE_ADDRESS_LAST_UPDATED_BY = new List<ORG_FRANCHISEE_ADDRESS>();
            this.ORG_POSITION_CREATED_BY = new List<ORG_POSITION>();
            this.ORG_POSITION_LAST_UPDATED_BY = new List<ORG_POSITION>();
            this.ORG_POSITION_LEVEL_CREATED_BY = new List<ORG_POSITION_LEVEL>();
            this.ORG_POSITION_LEVEL_LAST_UPDATED_BY = new List<ORG_POSITION_LEVEL>();
            this.ORG_ZONE_CREATED_BY = new List<ORG_ZONE>();
            this.ORG_ZONE_LAST_UPDATED_BY = new List<ORG_ZONE>();
            this.PUR_GOODS_RECEIPT_CREATED_BY = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RECEIPT_LAST_UPDATED_BY = new List<PUR_GOODS_RECEIPT>();
            this.PUR_GOODS_RECEIPT_ITEM_CREATED_BY = new List<PUR_GOODS_RECEIPT_ITEM>();
            this.PUR_GOODS_RECEIPT_ITEM_LAST_UPDATED_BY = new List<PUR_GOODS_RECEIPT_ITEM>();
            this.PUR_GOODS_RECEIPT_ITEM_SERIAL_CREATED_BY = new List<PUR_GOODS_RECEIPT_ITEM_SERIAL>();
            this.PUR_GOODS_RECEIPT_ITEM_SERIAL_LAST_UPDATED_BY = new List<PUR_GOODS_RECEIPT_ITEM_SERIAL>();
            this.PUR_GOODS_RETURN_CREATED_BY = new List<PUR_GOODS_RETURN>();
            this.PUR_GOODS_RETURN_LAST_UPDATED_BY = new List<PUR_GOODS_RETURN>();
            this.PUR_GOODS_RETURN_ITEM_CREATED_BY = new List<PUR_GOODS_RETURN_ITEM>();
            this.PUR_GOODS_RETURN_ITEM_LAST_UPDATED_BY = new List<PUR_GOODS_RETURN_ITEM>();
            this.PUR_GOODS_RETURN_ITEM_SERIAL_CREATED_BY = new List<PUR_GOODS_RETURN_ITEM_SERIAL>();
            this.PUR_GOODS_RETURN_ITEM_SERIAL_LAST_UPDATED_BY = new List<PUR_GOODS_RETURN_ITEM_SERIAL>();
            this.PUR_PURCHASE_ORDER_CREATED_BY = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_ORDER_LAST_UPDATED_BY = new List<PUR_PURCHASE_ORDER>();
            this.PUR_PURCHASE_ORDER_ITEM_CREATED_BY = new List<PUR_PURCHASE_ORDER_ITEM>();
            this.PUR_PURCHASE_ORDER_ITEM_LAST_UPDATED_BY = new List<PUR_PURCHASE_ORDER_ITEM>();
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION_CREATED_BY = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION_LAST_UPDATED_BY = new List<PUR_PURCHASE_ORDER_ITEM_LOCATION>();
            this.PUR_PURCHASE_REQUISITION_CREATED_BY = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_PURCHASE_REQUISITION_LAST_UPDATED_BY = new List<PUR_PURCHASE_REQUISITION>();
            this.PUR_PURCHASE_REQUISITION_ITEM_CREATED_BY = new List<PUR_PURCHASE_REQUISITION_ITEM>();
            this.PUR_PURCHASE_REQUISITION_ITEM_LAST_UPDATED_BY = new List<PUR_PURCHASE_REQUISITION_ITEM>();
            this.PUR_PURCHASE_REQUISITION_ITEM_LOCATION_CREATED_BY = new List<PUR_PURCHASE_REQUISITION_ITEM_LOCATION>();
            this.PUR_PURCHASE_REQUISITION_ITEM_LOCATION_LAST_UPDATED_BY = new List<PUR_PURCHASE_REQUISITION_ITEM_LOCATION>();
            this.PUR_VENDOR_CREATED_BY = new List<PUR_VENDOR>();
            this.PUR_VENDOR_LAST_UPDATED_BY = new List<PUR_VENDOR>();
            this.PUR_VENDOR_ADDRESS_CREATED_BY = new List<PUR_VENDOR_ADDRESS>();
            this.PUR_VENDOR_ADDRESS_LAST_UPDATED_BY = new List<PUR_VENDOR_ADDRESS>();
            this.PUR_VENDOR_BANK_ACCOUNT_CREATED_BY = new List<PUR_VENDOR_BANK_ACCOUNT>();
            this.PUR_VENDOR_BANK_ACCOUNT_LAST_UPDATED_BY = new List<PUR_VENDOR_BANK_ACCOUNT>();
            this.PUR_VENDOR_CONTACT_CREATED_BY = new List<PUR_VENDOR_CONTACT>();
            this.PUR_VENDOR_CONTACT_LAST_UPDATED_BY = new List<PUR_VENDOR_CONTACT>();
            this.PUR_VENDOR_GROUP_CREATED_BY = new List<PUR_VENDOR_GROUP>();
            this.PUR_VENDOR_GROUP_LAST_UPDATED_BY = new List<PUR_VENDOR_GROUP>();
            this.PUR_VENDOR_TYPE_CREATED_BY = new List<PUR_VENDOR_TYPE>();
            this.PUR_VENDOR_TYPE_LAST_UPDATED_BY = new List<PUR_VENDOR_TYPE>();
            this.SA_PASSWORD_POLICY_CREATED_BY = new List<SA_PASSWORD_POLICY>();
            this.SA_PASSWORD_POLICY_LAST_UPDATED_BY = new List<SA_PASSWORD_POLICY>();
            this.SAL_CUSTOMER_CREATED_BY = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_LAST_UPDATED_BY = new List<SAL_CUSTOMER>();
            this.SAL_CUSTOMER_ADDRESS_CREATED_BY = new List<SAL_CUSTOMER_ADDRESS>();
            this.SAL_CUSTOMER_ADDRESS_LAST_UPDATED_BY = new List<SAL_CUSTOMER_ADDRESS>();
            this.SAL_CUSTOMER_BANK_ACCOUNT_CREATED_BY = new List<SAL_CUSTOMER_BANK_ACCOUNT>();
            this.SAL_CUSTOMER_BANK_ACCOUNT_LAST_UPDATED_BY = new List<SAL_CUSTOMER_BANK_ACCOUNT>();
            this.SAL_CUSTOMER_CONTACT_CREATED_BY = new List<SAL_CUSTOMER_CONTACT>();
            this.SAL_CUSTOMER_CONTACT_LAST_UPDATED_BY = new List<SAL_CUSTOMER_CONTACT>();
            this.SAL_CUSTOMER_GROUP_CREATED_BY = new List<SAL_CUSTOMER_GROUP>();
            this.SAL_CUSTOMER_GROUP_LAST_UPDATED_BY = new List<SAL_CUSTOMER_GROUP>();
            this.SYS_COLUMN_CREATED_BY = new List<SYS_COLUMN>();
            this.SYS_COLUMN_LAST_UPDATED_BY = new List<SYS_COLUMN>();
            this.SYS_COLUMN_LANG_CREATED_BY = new List<SYS_COLUMN_LANG>();
            this.SYS_COLUMN_LANG_LAST_UPDATED_BY = new List<SYS_COLUMN_LANG>();
            this.SYS_DISTRICT_CREATED_BY = new List<SYS_DISTRICT>();
            this.SYS_DISTRICT_LAST_UPDATED_BY = new List<SYS_DISTRICT>();
            this.SYS_FLEX_CREATED_BY = new List<SYS_FLEX>();
            this.SYS_FLEX_LAST_UPDATED_BY = new List<SYS_FLEX>();
            this.SYS_FLEX_ITEM_CREATED_BY = new List<SYS_FLEX_ITEM>();
            this.SYS_FLEX_ITEM_LAST_UPDATED_BY = new List<SYS_FLEX_ITEM>();
            this.SYS_MENU_CREATED_BY = new List<SYS_MENU>();
            this.SYS_MENU_LAST_UPDATED_BY = new List<SYS_MENU>();
            this.SYS_MENU_LANG_CREATED_BY = new List<SYS_MENU_LANG>();
            this.SYS_MENU_LANG_LAST_UPDATED_BY = new List<SYS_MENU_LANG>();
            this.SYS_OBJECT_CREATED_BY = new List<SYS_OBJECT>();
            this.SYS_OBJECT_LAST_UPDATED_BY = new List<SYS_OBJECT>();
            this.SYS_PROVINCE_CREATED_BY = new List<SYS_PROVINCE>();
            this.SYS_PROVINCE_LAST_UPDATED_BY = new List<SYS_PROVINCE>();
            this.SYS_SUB_DISTRICT_CREATED_BY = new List<SYS_SUB_DISTRICT>();
            this.SYS_SUB_DISTRICT_LAST_UPDATED_BY = new List<SYS_SUB_DISTRICT>();
            this.SYS_USER_CREATED_CHILD = new List<SYS_USER>();
            this.SYS_USER_UPDATED_CHILD = new List<SYS_USER>();
            this.SYS_USER_ACCESS_CREATED_BY = new List<SYS_USER_ACCESS>();
            this.SYS_USER_ACCESS_LAST_UPDATED_BY = new List<SYS_USER_ACCESS>();
            this.SYS_USER_ACCESS = new List<SYS_USER_ACCESS>();
            this.SYS_USER_ACCESS_LOG_CREATED_BY = new List<SYS_USER_ACCESS_LOG>();
            this.SYS_USER_ACCESS_LOG_LAST_UPDATED_BY = new List<SYS_USER_ACCESS_LOG>();
            this.SYS_VIEW_CREATED_BY = new List<SYS_VIEW>();
            this.SYS_VIEW_LAST_UPDATED_BY = new List<SYS_VIEW>();
            this.SYS_VIEW_COLUMN_CREATED_BY = new List<SYS_VIEW_COLUMN>();
            this.SYS_VIEW_COLUMN_LAST_UPDATED_BY = new List<SYS_VIEW_COLUMN>();
            this.SYS_VIEW_COLUMN_FILTER_CREATED_BY = new List<SYS_VIEW_COLUMN_FILTER>();
            this.SYS_VIEW_COLUMN_FILTER_LAST_UPDATED_BY = new List<SYS_VIEW_COLUMN_FILTER>();
        }
    }
}

