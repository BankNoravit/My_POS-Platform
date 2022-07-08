using Microsoft.EntityFrameworkCore;
using POS.Domain.Config.EFConfig;
using POS.Domain.Models;

namespace POS.Domain
{
    public class ReadWriteMainDBContext : DbContext
    {
        public ReadWriteMainDBContext(DbContextOptions<ReadWriteMainDBContext> options) : base(options) { }

        public DbSet<ASM_FA_OS_MATCHING> ASM_FA_OS_MATCHING { get; set; } // ASM_FA_OS_MATCHING
        public DbSet<FNA_BANK> FNA_BANK { get; set; } // FNA_BANK
        public DbSet<FNA_BANK_ACCOUNT> FNA_BANK_ACCOUNT { get; set; } // FNA_BANK_ACCOUNT
        public DbSet<FNA_BANK_BRANCH> FNA_BANK_BRANCH { get; set; } // FNA_BANK_BRANCH
        public DbSet<FNA_COST_CENTER> FNA_COST_CENTER { get; set; } // FNA_COST_CENTER
        public DbSet<FNA_CURRENCY> FNA_CURRENCY { get; set; } // FNA_CURRENCY
        public DbSet<FNA_EXPENSE> FNA_EXPENSE { get; set; } // FNA_EXPENSE
        public DbSet<FNA_TAX> FNA_TAX { get; set; } // FNA_TAX
        public DbSet<INV_BRAND> INV_BRAND { get; set; } // INV_BRAND
        public DbSet<INV_CATEGORY> INV_CATEGORY { get; set; } // INV_CATEGORY
        public DbSet<INV_GROUP_CATEGORY> INV_GROUP_CATEGORY { get; set; } // INV_GROUP_CATEGORY
        public DbSet<INV_PRODDUCT_SELLING_POINT> INV_PRODDUCT_SELLING_POINT { get; set; } // INV_PRODDUCT_SELLING_POINT
        public DbSet<INV_PRODUCT> INV_PRODUCT { get; set; } // INV_PRODUCT
        public DbSet<INV_PRODUCT_IMAGE> INV_PRODUCT_IMAGE { get; set; } // INV_PRODUCT_IMAGE
        public DbSet<INV_PRODUCT_SPECIFICATION> INV_PRODUCT_SPECIFICATION { get; set; } // INV_PRODUCT_SPECIFICATION
        public DbSet<INV_SPECIFICATION> INV_SPECIFICATION { get; set; } // INV_SPECIFICATION
        public DbSet<INV_SPECIFICATION_ITEM> INV_SPECIFICATION_ITEM { get; set; } // INV_SPECIFICATION_ITEM
        public DbSet<INV_STOCK_REQUISITION> INV_STOCK_REQUISITION { get; set; } // INV_STOCK_REQUISITION
        public DbSet<INV_STOCK_REQUISITION_ITEM> INV_STOCK_REQUISITION_ITEM { get; set; } // INV_STOCK_REQUISITION_ITEM
        public DbSet<INV_SUB_CATEGORY> INV_SUB_CATEGORY { get; set; } // INV_SUB_CATEGORY
        public DbSet<INV_UOM> INV_UOM { get; set; } // INV_UOM
        public DbSet<INV_WAREHOUSE> INV_WAREHOUSE { get; set; } // INV_WAREHOUSE
        public DbSet<INV_WAREHOUSE_ADDRESS> INV_WAREHOUSE_ADDRESS { get; set; } // INV_WAREHOUSE_ADDRESS
        public DbSet<INV_WAREHOUSE_LOCATION> INV_WAREHOUSE_LOCATION { get; set; } // INV_WAREHOUSE_LOCATION
        public DbSet<ORG_BRANCH> ORG_BRANCH { get; set; } // ORG_BRANCH
        public DbSet<ORG_BRANCH_ADDRESS> ORG_BRANCH_ADDRESS { get; set; } // ORG_BRANCH_ADDRESS
        public DbSet<ORG_BRANCH_GROUP> ORG_BRANCH_GROUP { get; set; } // ORG_BRANCH_GROUP
        public DbSet<ORG_BRANCH_GROUP_ITEM> ORG_BRANCH_GROUP_ITEM { get; set; } // ORG_BRANCH_GROUP_ITEM
        public DbSet<ORG_BUSINESS_UNIT> ORG_BUSINESS_UNIT { get; set; } // ORG_BUSINESS_UNIT
        public DbSet<ORG_COMPANY> ORG_COMPANY { get; set; } // ORG_COMPANY
        public DbSet<ORG_COMPANY_ADDRESS> ORG_COMPANY_ADDRESS { get; set; } // ORG_COMPANY_ADDRESS
        public DbSet<ORG_DEPARTMENT> ORG_DEPARTMENT { get; set; } // ORG_DEPARTMENT
        public DbSet<ORG_EMPLOYEE> ORG_EMPLOYEE { get; set; } // ORG_EMPLOYEE
        public DbSet<ORG_EMPLOYEE_ADDRESS> ORG_EMPLOYEE_ADDRESS { get; set; } // ORG_EMPLOYEE_ADDRESS
        public DbSet<ORG_FRANCHISEE> ORG_FRANCHISEE { get; set; } // ORG_FRANCHISEE
        public DbSet<ORG_FRANCHISEE_ADDRESS> ORG_FRANCHISEE_ADDRESS { get; set; } // ORG_FRANCHISEE_ADDRESS
        public DbSet<ORG_POSITION> ORG_POSITION { get; set; } // ORG_POSITION
        public DbSet<ORG_POSITION_LEVEL> ORG_POSITION_LEVEL { get; set; } // ORG_POSITION_LEVEL
        public DbSet<ORG_ZONE> ORG_ZONE { get; set; } // ORG_ZONE
        public DbSet<PUR_GOODS_RECEIPT> PUR_GOODS_RECEIPT { get; set; } // PUR_GOODS_RECEIPT
        public DbSet<PUR_GOODS_RECEIPT_ITEM> PUR_GOODS_RECEIPT_ITEM { get; set; } // PUR_GOODS_RECEIPT_ITEM
        public DbSet<PUR_GOODS_RECEIPT_ITEM_SERIAL> PUR_GOODS_RECEIPT_ITEM_SERIAL { get; set; } // PUR_GOODS_RECEIPT_ITEM_SERIAL
        public DbSet<PUR_GOODS_RETURN> PUR_GOODS_RETURN { get; set; } // PUR_GOODS_RETURN
        public DbSet<PUR_GOODS_RETURN_ITEM> PUR_GOODS_RETURN_ITEM { get; set; } // PUR_GOODS_RETURN_ITEM
        public DbSet<PUR_GOODS_RETURN_ITEM_SERIAL> PUR_GOODS_RETURN_ITEM_SERIAL { get; set; } // PUR_GOODS_RETURN_ITEM_SERIAL
        public DbSet<PUR_PURCHASE_ORDER> PUR_PURCHASE_ORDER { get; set; } // PUR_PURCHASE_ORDER
        public DbSet<PUR_PURCHASE_ORDER_ITEM> PUR_PURCHASE_ORDER_ITEM { get; set; } // PUR_PURCHASE_ORDER_ITEM
        public DbSet<PUR_PURCHASE_ORDER_ITEM_LOCATION> PUR_PURCHASE_ORDER_ITEM_LOCATION { get; set; } // PUR_PURCHASE_ORDER_ITEM_LOCATION
        public DbSet<PUR_PURCHASE_REQUISITION> PUR_PURCHASE_REQUISITION { get; set; } // PUR_PURCHASE_REQUISITION
        public DbSet<PUR_PURCHASE_REQUISITION_ITEM> PUR_PURCHASE_REQUISITION_ITEM { get; set; } // PUR_PURCHASE_REQUISITION_ITEM
        public DbSet<PUR_PURCHASE_REQUISITION_ITEM_LOCATION> PUR_PURCHASE_REQUISITION_ITEM_LOCATION { get; set; } // PUR_PURCHASE_REQUISITION_ITEM_LOCATION
        public DbSet<PUR_VENDOR> PUR_VENDOR { get; set; } // PUR_VENDOR
        public DbSet<PUR_VENDOR_ADDRESS> PUR_VENDOR_ADDRESS { get; set; } // PUR_VENDOR_ADDRESS
        public DbSet<PUR_VENDOR_BANK_ACCOUNT> PUR_VENDOR_BANK_ACCOUNT { get; set; } // PUR_VENDOR_BANK_ACCOUNT
        public DbSet<PUR_VENDOR_CONTACT> PUR_VENDOR_CONTACT { get; set; } // PUR_VENDOR_CONTACT
        public DbSet<PUR_VENDOR_GROUP> PUR_VENDOR_GROUP { get; set; } // PUR_VENDOR_GROUP
        public DbSet<PUR_VENDOR_TYPE> PUR_VENDOR_TYPE { get; set; } // PUR_VENDOR_TYPE
        public DbSet<SA_PASSWORD_POLICY> SA_PASSWORD_POLICY { get; set; } // SA_PASSWORD_POLICY
        public DbSet<SAL_CUSTOMER> SAL_CUSTOMER { get; set; } // SAL_CUSTOMER
        public DbSet<SAL_CUSTOMER_ADDRESS> SAL_CUSTOMER_ADDRESS { get; set; } // SAL_CUSTOMER_ADDRESS
        public DbSet<SAL_CUSTOMER_BANK_ACCOUNT> SAL_CUSTOMER_BANK_ACCOUNT { get; set; } // SAL_CUSTOMER_BANK_ACCOUNT
        public DbSet<SAL_CUSTOMER_CONTACT> SAL_CUSTOMER_CONTACT { get; set; } // SAL_CUSTOMER_CONTACT
        public DbSet<SAL_CUSTOMER_GROUP> SAL_CUSTOMER_GROUP { get; set; } // SAL_CUSTOMER_GROUP
        public DbSet<SYS_COLUMN> SYS_COLUMN { get; set; } // SYS_COLUMN
        public DbSet<SYS_COLUMN_LANG> SYS_COLUMN_LANG { get; set; } // SYS_COLUMN_LANG
        public DbSet<SYS_DISTRICT> SYS_DISTRICT { get; set; } // SYS_DISTRICT
        public DbSet<SYS_FLEX> SYS_FLEX { get; set; } // SYS_FLEX
        public DbSet<SYS_FLEX_ITEM> SYS_FLEX_ITEM { get; set; } // SYS_FLEX_ITEM
        public DbSet<SYS_MENU> SYS_MENU { get; set; } // SYS_MENU
        public DbSet<SYS_MENU_LANG> SYS_MENU_LANG { get; set; } // SYS_MENU_LANG
        public DbSet<SYS_OBJECT> SYS_OBJECT { get; set; } // SYS_OBJECT
        public DbSet<SYS_PROVINCE> SYS_PROVINCE { get; set; } // SYS_PROVINCE
        public DbSet<SYS_SUB_DISTRICT> SYS_SUB_DISTRICT { get; set; } // SYS_SUB_DISTRICT
        public DbSet<SYS_USER> SYS_USER { get; set; } // SYS_USER
        public DbSet<SYS_USER_ACCESS> SYS_USER_ACCESS { get; set; } // SYS_USER_ACCESS
        public DbSet<SYS_USER_ACCESS_LOG> SYS_USER_ACCESS_LOG { get; set; } // SYS_USER_ACCESS_LOG
        public DbSet<SYS_VIEW> SYS_VIEW { get; set; } // SYS_VIEW
        public DbSet<SYS_VIEW_COLUMN> SYS_VIEW_COLUMN { get; set; } // SYS_VIEW_COLUMN
        public DbSet<SYS_VIEW_COLUMN_FILTER> SYS_VIEW_COLUMN_FILTER { get; set; } // SYS_VIEW_COLUMN_FILTER

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            // fluent API: Support Code-First composite key design.
            // Data Annotation: Not Support Code-First composite key design.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SYS_USERConfiguration).Assembly);
        }
    }
}
