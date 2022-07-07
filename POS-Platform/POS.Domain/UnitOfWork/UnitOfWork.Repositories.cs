using Microsoft.Extensions.DependencyInjection;
using POS.Domain;
using POS.Domain.Repositories;

namespace POS.Domain
{
    public partial interface IUnitOfWork
    {
        IASM_FA_OS_MATCHINGRepository ASM_FA_OS_MATCHING { get; }
        IFNA_BANK_ACCOUNTRepository FNA_BANK_ACCOUNT { get; }
        IFNA_BANK_BRANCHRepository FNA_BANK_BRANCH { get; }
        IFNA_BANKRepository FNA_BANK { get; }
        IFNA_COST_CENTERRepository FNA_COST_CENTER { get; }
        IFNA_CURRENCYRepository FNA_CURRENCY { get; }
        IFNA_EXPENSERepository FNA_EXPENSE { get; }
        IFNA_TAXRepository FNA_TAX { get; }
        IINV_BRANDRepository INV_BRAND { get; }
        IINV_CATEGORYRepository INV_CATEGORY { get; }
        IINV_GROUP_CATEGORYRepository INV_GROUP_CATEGORY { get; }
        IINV_PRODDUCT_SELLING_POINTRepository INV_PRODDUCT_SELLING_POINT { get; }
        IINV_PRODUCT_IMAGERepository INV_PRODUCT_IMAGE { get; }
        IINV_PRODUCT_SPECIFICATIONRepository INV_PRODUCT_SPECIFICATION { get; }
        IINV_PRODUCTRepository INV_PRODUCT { get; }
        IINV_SPECIFICATION_ITEMRepository INV_SPECIFICATION_ITEM { get; }
        IINV_SPECIFICATIONRepository INV_SPECIFICATION { get; }
        IINV_STOCK_REQUISITION_ITEMRepository INV_STOCK_REQUISITION_ITEM { get; }
        IINV_STOCK_REQUISITIONRepository INV_STOCK_REQUISITION { get; }
        IINV_SUB_CATEGORYRepository INV_SUB_CATEGORY { get; }
        IINV_UOMRepository INV_UOM { get; }
        IINV_WAREHOUSE_ADDRESSRepository INV_WAREHOUSE_ADDRESS { get; }
        IINV_WAREHOUSE_LOCATIONRepository INV_WAREHOUSE_LOCATION { get; }
        IINV_WAREHOUSERepository INV_WAREHOUSE { get; }
        IORG_BRANCH_ADDRESSRepository ORG_BRANCH_ADDRESS { get; }
        IORG_BRANCH_GROUP_ITEMRepository ORG_BRANCH_GROUP_ITEM { get; }
        IORG_BRANCH_GROUPRepository ORG_BRANCH_GROUP { get; }
        IORG_BRANCHRepository ORG_BRANCH { get; }
        IORG_BUSINESS_UNITRepository ORG_BUSINESS_UNIT { get; }
        IORG_COMPANY_ADDRESSRepository ORG_COMPANY_ADDRESS { get; }
        IORG_COMPANYRepository ORG_COMPANY { get; }
        IORG_DEPARTMENTRepository ORG_DEPARTMENT { get; }
        IORG_EMPLOYEE_ADDRESSRepository ORG_EMPLOYEE_ADDRESS { get; }
        IORG_EMPLOYEERepository ORG_EMPLOYEE { get; }
        IORG_FRANCHISEE_ADDRESSRepository ORG_FRANCHISEE_ADDRESS { get; }
        IORG_FRANCHISEERepository ORG_FRANCHISEE { get; }
        IORG_POSITION_LEVELRepository ORG_POSITION_LEVEL { get; }
        IORG_POSITIONRepository ORG_POSITION { get; }
        IORG_ZONERepository ORG_ZONE { get; }
        IPUR_GOODS_RECEIPT_ITEM_SERIALRepository PUR_GOODS_RECEIPT_ITEM_SERIAL { get; }
        IPUR_GOODS_RECEIPT_ITEMRepository PUR_GOODS_RECEIPT_ITEM { get; }
        IPUR_GOODS_RECEIPTRepository PUR_GOODS_RECEIPT { get; }
        IPUR_GOODS_RETURN_ITEM_SERIALRepository PUR_GOODS_RETURN_ITEM_SERIAL { get; }
        IPUR_GOODS_RETURN_ITEMRepository PUR_GOODS_RETURN_ITEM { get; }
        IPUR_GOODS_RETURNRepository PUR_GOODS_RETURN { get; }
        IPUR_PURCHASE_ORDER_ITEM_LOCATIONRepository PUR_PURCHASE_ORDER_ITEM_LOCATION { get; }
        IPUR_PURCHASE_ORDER_ITEMRepository PUR_PURCHASE_ORDER_ITEM { get; }
        IPUR_PURCHASE_ORDERRepository PUR_PURCHASE_ORDER { get; }
        IPUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository PUR_PURCHASE_REQUISITION_ITEM_LOCATION { get; }
        IPUR_PURCHASE_REQUISITION_ITEMRepository PUR_PURCHASE_REQUISITION_ITEM { get; }
        IPUR_PURCHASE_REQUISITIONRepository PUR_PURCHASE_REQUISITION { get; }
        IPUR_VENDOR_ADDRESSRepository PUR_VENDOR_ADDRESS { get; }
        IPUR_VENDOR_BANK_ACCOUNTRepository PUR_VENDOR_BANK_ACCOUNT { get; }
        IPUR_VENDOR_CONTACTRepository PUR_VENDOR_CONTACT { get; }
        IPUR_VENDOR_GROUPRepository PUR_VENDOR_GROUP { get; }
        IPUR_VENDOR_TYPERepository PUR_VENDOR_TYPE { get; }
        IPUR_VENDORRepository PUR_VENDOR { get; }
        ISA_PASSWORD_POLICYRepository SA_PASSWORD_POLICY { get; }
        ISAL_CUSTOMER_ADDRESSRepository SAL_CUSTOMER_ADDRESS { get; }
        ISAL_CUSTOMER_BANK_ACCOUNTRepository SAL_CUSTOMER_BANK_ACCOUNT { get; }
        ISAL_CUSTOMER_CONTACTRepository SAL_CUSTOMER_CONTACT { get; }
        ISAL_CUSTOMER_GROUPRepository SAL_CUSTOMER_GROUP { get; }
        ISAL_CUSTOMERRepository SAL_CUSTOMER { get; }
        ISYS_COLUMN_LANGRepository SYS_COLUMN_LANG { get; }
        ISYS_COLUMNRepository SYS_COLUMN { get; }
        ISYS_DISTRICTRepository SYS_DISTRICT { get; }
        ISYS_FLEX_ITEMRepository SYS_FLEX_ITEM { get; }
        ISYS_FLEXRepository SYS_FLEX { get; }
        ISYS_MENU_LANGRepository SYS_MENU_LANG { get; }
        ISYS_MENURepository SYS_MENU { get; }
        ISYS_OBJECTRepository SYS_OBJECT { get; }
        ISYS_PROVINCERepository SYS_PROVINCE { get; }
        ISYS_SUB_DISTRICTRepository SYS_SUB_DISTRICT { get; }
        ISYS_USER_ACCESS_LOGRepository SYS_USER_ACCESS_LOG { get; }
        ISYS_USER_ACCESSRepository SYS_USER_ACCESS { get; }
        ISYS_USERRepository SYS_USER { get; }
        ISYS_VIEW_COLUMN_FILTERRepository SYS_VIEW_COLUMN_FILTER { get; }
        ISYS_VIEW_COLUMNRepository SYS_VIEW_COLUMN { get; }
        ISYS_VIEWRepository SYS_VIEW { get; }
    }
    
    public partial class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IASM_FA_OS_MATCHINGRepository ASM_FA_OS_MATCHING { get; private set; }
        public IFNA_BANK_ACCOUNTRepository FNA_BANK_ACCOUNT { get; private set; }
        public IFNA_BANK_BRANCHRepository FNA_BANK_BRANCH { get; private set; }
        public IFNA_BANKRepository FNA_BANK { get; private set; }
        public IFNA_COST_CENTERRepository FNA_COST_CENTER { get; private set; }
        public IFNA_CURRENCYRepository FNA_CURRENCY { get; private set; }
        public IFNA_EXPENSERepository FNA_EXPENSE { get; private set; }
        public IFNA_TAXRepository FNA_TAX { get; private set; }
        public IINV_BRANDRepository INV_BRAND { get; private set; }
        public IINV_CATEGORYRepository INV_CATEGORY { get; private set; }
        public IINV_GROUP_CATEGORYRepository INV_GROUP_CATEGORY { get; private set; }
        public IINV_PRODDUCT_SELLING_POINTRepository INV_PRODDUCT_SELLING_POINT { get; private set; }
        public IINV_PRODUCT_IMAGERepository INV_PRODUCT_IMAGE { get; private set; }
        public IINV_PRODUCT_SPECIFICATIONRepository INV_PRODUCT_SPECIFICATION { get; private set; }
        public IINV_PRODUCTRepository INV_PRODUCT { get; private set; }
        public IINV_SPECIFICATION_ITEMRepository INV_SPECIFICATION_ITEM { get; private set; }
        public IINV_SPECIFICATIONRepository INV_SPECIFICATION { get; private set; }
        public IINV_STOCK_REQUISITION_ITEMRepository INV_STOCK_REQUISITION_ITEM { get; private set; }
        public IINV_STOCK_REQUISITIONRepository INV_STOCK_REQUISITION { get; private set; }
        public IINV_SUB_CATEGORYRepository INV_SUB_CATEGORY { get; private set; }
        public IINV_UOMRepository INV_UOM { get; private set; }
        public IINV_WAREHOUSE_ADDRESSRepository INV_WAREHOUSE_ADDRESS { get; private set; }
        public IINV_WAREHOUSE_LOCATIONRepository INV_WAREHOUSE_LOCATION { get; private set; }
        public IINV_WAREHOUSERepository INV_WAREHOUSE { get; private set; }
        public IORG_BRANCH_ADDRESSRepository ORG_BRANCH_ADDRESS { get; private set; }
        public IORG_BRANCH_GROUP_ITEMRepository ORG_BRANCH_GROUP_ITEM { get; private set; }
        public IORG_BRANCH_GROUPRepository ORG_BRANCH_GROUP { get; private set; }
        public IORG_BRANCHRepository ORG_BRANCH { get; private set; }
        public IORG_BUSINESS_UNITRepository ORG_BUSINESS_UNIT { get; private set; }
        public IORG_COMPANY_ADDRESSRepository ORG_COMPANY_ADDRESS { get; private set; }
        public IORG_COMPANYRepository ORG_COMPANY { get; private set; }
        public IORG_DEPARTMENTRepository ORG_DEPARTMENT { get; private set; }
        public IORG_EMPLOYEE_ADDRESSRepository ORG_EMPLOYEE_ADDRESS { get; private set; }
        public IORG_EMPLOYEERepository ORG_EMPLOYEE { get; private set; }
        public IORG_FRANCHISEE_ADDRESSRepository ORG_FRANCHISEE_ADDRESS { get; private set; }
        public IORG_FRANCHISEERepository ORG_FRANCHISEE { get; private set; }
        public IORG_POSITION_LEVELRepository ORG_POSITION_LEVEL { get; private set; }
        public IORG_POSITIONRepository ORG_POSITION { get; private set; }        
        public IORG_ZONERepository ORG_ZONE { get; private set; }
        public IPUR_GOODS_RECEIPT_ITEM_SERIALRepository PUR_GOODS_RECEIPT_ITEM_SERIAL { get; private set; }
        public IPUR_GOODS_RECEIPT_ITEMRepository PUR_GOODS_RECEIPT_ITEM { get; private set; }
        public IPUR_GOODS_RECEIPTRepository PUR_GOODS_RECEIPT { get; private set; }
        public IPUR_GOODS_RETURN_ITEM_SERIALRepository PUR_GOODS_RETURN_ITEM_SERIAL { get; private set; }
        public IPUR_GOODS_RETURN_ITEMRepository PUR_GOODS_RETURN_ITEM { get; private set; }
        public IPUR_GOODS_RETURNRepository PUR_GOODS_RETURN { get; private set; }
        public IPUR_PURCHASE_ORDER_ITEM_LOCATIONRepository PUR_PURCHASE_ORDER_ITEM_LOCATION { get; private set; }
        public IPUR_PURCHASE_ORDER_ITEMRepository PUR_PURCHASE_ORDER_ITEM { get; private set; }
        public IPUR_PURCHASE_ORDERRepository PUR_PURCHASE_ORDER { get; private set; }
        public IPUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository PUR_PURCHASE_REQUISITION_ITEM_LOCATION { get;private set; }
        public IPUR_PURCHASE_REQUISITION_ITEMRepository PUR_PURCHASE_REQUISITION_ITEM { get; private set; }
        public IPUR_PURCHASE_REQUISITIONRepository PUR_PURCHASE_REQUISITION { get; private set; }
        public IPUR_VENDOR_ADDRESSRepository PUR_VENDOR_ADDRESS { get; private set; }
        public IPUR_VENDOR_BANK_ACCOUNTRepository PUR_VENDOR_BANK_ACCOUNT { get; private set; }
        public IPUR_VENDOR_CONTACTRepository PUR_VENDOR_CONTACT { get; private set; }
        public IPUR_VENDOR_GROUPRepository PUR_VENDOR_GROUP { get; private set; }
        public IPUR_VENDOR_TYPERepository PUR_VENDOR_TYPE { get; private set; }
        public IPUR_VENDORRepository PUR_VENDOR { get; private set; }
        public ISA_PASSWORD_POLICYRepository SA_PASSWORD_POLICY { get; private set; }
        public ISAL_CUSTOMER_ADDRESSRepository SAL_CUSTOMER_ADDRESS { get; private set; }
        public ISAL_CUSTOMER_BANK_ACCOUNTRepository SAL_CUSTOMER_BANK_ACCOUNT { get; private set; }
        public ISAL_CUSTOMER_CONTACTRepository SAL_CUSTOMER_CONTACT { get; private set; }
        public ISAL_CUSTOMER_GROUPRepository SAL_CUSTOMER_GROUP { get; private set; }
        public ISAL_CUSTOMERRepository SAL_CUSTOMER { get; private set; }
        public ISYS_COLUMN_LANGRepository SYS_COLUMN_LANG { get; private set; }
        public ISYS_COLUMNRepository SYS_COLUMN { get; private set; }
        public ISYS_DISTRICTRepository SYS_DISTRICT { get; private set; }
        public ISYS_FLEX_ITEMRepository SYS_FLEX_ITEM { get; private set; }
        public ISYS_FLEXRepository SYS_FLEX { get; private set; }
        public ISYS_MENU_LANGRepository SYS_MENU_LANG { get; private set; }
        public ISYS_MENURepository SYS_MENU { get; private set; }
        public ISYS_OBJECTRepository SYS_OBJECT { get; private set; }
        public ISYS_PROVINCERepository SYS_PROVINCE { get; private set; }
        public ISYS_SUB_DISTRICTRepository SYS_SUB_DISTRICT { get; private set; }
        public ISYS_USER_ACCESS_LOGRepository SYS_USER_ACCESS_LOG { get; private set; }
        public ISYS_USER_ACCESSRepository SYS_USER_ACCESS { get; private set; }
        public ISYS_USERRepository SYS_USER { get; private set; }
        public ISYS_VIEW_COLUMN_FILTERRepository SYS_VIEW_COLUMN_FILTER { get; private set; }
        public ISYS_VIEW_COLUMNRepository SYS_VIEW_COLUMN { get; private set; }
        public ISYS_VIEWRepository SYS_VIEW { get; private set; }

        private void _RegisterRepositories(ReadWriteMainDBContext readWriteDB, ReadOnlyMainDBContext readOnlyDB)
        {
            this.ASM_FA_OS_MATCHING = new ASM_FA_OS_MATCHINGRepository(readWriteDB, readOnlyDB);
            this.FNA_BANK_ACCOUNT = new FNA_BANK_ACCOUNTRepository(readWriteDB, readOnlyDB);
            this.FNA_BANK_BRANCH = new FNA_BANK_BRANCHRepository(readWriteDB, readOnlyDB);
            this.FNA_BANK = new FNA_BANKRepository(readWriteDB, readOnlyDB);
            this.FNA_COST_CENTER = new FNA_COST_CENTERRepository(readWriteDB, readOnlyDB);
            this.FNA_CURRENCY = new FNA_CURRENCYRepository(readWriteDB, readOnlyDB);
            this.FNA_EXPENSE = new FNA_EXPENSERepository(readWriteDB, readOnlyDB);
            this.FNA_TAX = new FNA_TAXRepository(readWriteDB, readOnlyDB);
            this.INV_BRAND = new INV_BRANDRepository(readWriteDB, readOnlyDB);
            this.INV_CATEGORY = new INV_CATEGORYRepository(readWriteDB, readOnlyDB);
            this.INV_GROUP_CATEGORY = new INV_GROUP_CATEGORYRepository(readWriteDB, readOnlyDB);    
            this.INV_PRODDUCT_SELLING_POINT = new INV_PRODDUCT_SELLING_POINTRepository(readWriteDB,readOnlyDB);
            this.INV_PRODUCT_IMAGE = new INV_PRODUCT_IMAGERepository(readWriteDB, readOnlyDB);
            this.INV_PRODUCT_SPECIFICATION = new INV_PRODUCT_SPECIFICATIONRepository(readWriteDB, readOnlyDB);
            this.INV_PRODUCT = new INV_PRODUCTRepository(readWriteDB, readOnlyDB);
            this.INV_SPECIFICATION_ITEM = new INV_SPECIFICATION_ITEMRepository(readWriteDB, readOnlyDB);
            this.INV_SPECIFICATION = new INV_SPECIFICATIONRepository(readWriteDB, readOnlyDB);
            this.INV_STOCK_REQUISITION_ITEM = new INV_STOCK_REQUISITION_ITEMRepository(readWriteDB, readOnlyDB);
            this.INV_STOCK_REQUISITION = new INV_STOCK_REQUISITIONRepository(readWriteDB, readOnlyDB);
            this.INV_SUB_CATEGORY = new INV_SUB_CATEGORYRepository(readWriteDB, readOnlyDB);
            this.INV_UOM = new INV_UOMRepository(readWriteDB, readOnlyDB);
            this.INV_WAREHOUSE_ADDRESS = new INV_WAREHOUSE_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.INV_WAREHOUSE_LOCATION = new INV_WAREHOUSE_LOCATIONRepository(readWriteDB, readOnlyDB);
            this.INV_WAREHOUSE = new INV_WAREHOUSERepository(readWriteDB, readOnlyDB);
            this.ORG_BRANCH_ADDRESS = new ORG_BRANCH_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.ORG_BRANCH_GROUP_ITEM = new ORG_BRANCH_GROUP_ITEMRepository(readWriteDB, readOnlyDB);
            this.ORG_BRANCH_GROUP = new ORG_BRANCH_GROUPRepository(readWriteDB, readOnlyDB);
            this.ORG_BRANCH = new ORG_BRANCHRepository(readWriteDB, readOnlyDB);
            this.ORG_BUSINESS_UNIT = new ORG_BUSINESS_UNITRepository(readWriteDB, readOnlyDB);
            this.ORG_COMPANY_ADDRESS = new ORG_COMPANY_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.ORG_COMPANY = new ORG_COMPANYRepository(readWriteDB, readOnlyDB);
            this.ORG_DEPARTMENT = new ORG_DEPARTMENTRepository(readWriteDB, readOnlyDB);
            this.ORG_EMPLOYEE_ADDRESS = new ORG_EMPLOYEE_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.ORG_EMPLOYEE = new ORG_EMPLOYEERepository(readWriteDB, readOnlyDB);
            this.ORG_FRANCHISEE_ADDRESS = new ORG_FRANCHISEE_ADDRESSRepository(readWriteDB, readOnlyDB); 
            this.ORG_FRANCHISEE = new ORG_FRANCHISEERepository(readWriteDB, readOnlyDB);
            this.ORG_POSITION_LEVEL = new ORG_POSITION_LEVELRepository(readWriteDB, readOnlyDB);
            this.ORG_POSITION = new ORG_POSITIONRepository(readWriteDB, readOnlyDB);
            this.ORG_ZONE = new ORG_ZONERepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RECEIPT_ITEM_SERIAL = new PUR_GOODS_RECEIPT_ITEM_SERIALRepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RECEIPT_ITEM = new PUR_GOODS_RECEIPT_ITEMRepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RECEIPT = new PUR_GOODS_RECEIPTRepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RETURN_ITEM_SERIAL = new PUR_GOODS_RETURN_ITEM_SERIALRepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RETURN_ITEM = new PUR_GOODS_RETURN_ITEMRepository(readWriteDB, readOnlyDB);
            this.PUR_GOODS_RETURN = new PUR_GOODS_RETURNRepository(readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_ORDER_ITEM_LOCATION = new PUR_PURCHASE_ORDER_ITEM_LOCATIONRepository(readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_ORDER_ITEM = new PUR_PURCHASE_ORDER_ITEMRepository(readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_ORDER = new PUR_PURCHASE_ORDERRepository(readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_REQUISITION_ITEM_LOCATION = new PUR_PURCHASE_REQUISITION_ITEM_LOCATIONRepository (readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_REQUISITION_ITEM = new PUR_PURCHASE_REQUISITION_ITEMRepository(readWriteDB, readOnlyDB);
            this.PUR_PURCHASE_REQUISITION = new PUR_PURCHASE_REQUISITIONRepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR_ADDRESS = new PUR_VENDOR_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR_BANK_ACCOUNT = new PUR_VENDOR_BANK_ACCOUNTRepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR_CONTACT = new PUR_VENDOR_CONTACTRepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR_GROUP = new PUR_VENDOR_GROUPRepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR_TYPE = new PUR_VENDOR_TYPERepository(readWriteDB, readOnlyDB);
            this.PUR_VENDOR = new PUR_VENDORRepository(readWriteDB, readOnlyDB);
            this.SA_PASSWORD_POLICY = new SA_PASSWORD_POLICYRepository(readWriteDB, readOnlyDB);
            this.SAL_CUSTOMER_ADDRESS = new SAL_CUSTOMER_ADDRESSRepository(readWriteDB, readOnlyDB);
            this.SAL_CUSTOMER_BANK_ACCOUNT = new SAL_CUSTOMER_BANK_ACCOUNTRepository(readWriteDB, readOnlyDB);
            this.SAL_CUSTOMER_CONTACT = new SAL_CUSTOMER_CONTACTRepository(readWriteDB, readOnlyDB);
            this.SAL_CUSTOMER_GROUP = new SAL_CUSTOMER_GROUPRepository(readWriteDB, readOnlyDB);
            this.SAL_CUSTOMER = new SAL_CUSTOMERRepository(readWriteDB, readOnlyDB);
            this.SYS_COLUMN_LANG = new SYS_COLUMN_LANGRepository(readWriteDB, readOnlyDB);
            this.SYS_COLUMN = new SYS_COLUMNRepository(readWriteDB, readOnlyDB);
            this.SYS_DISTRICT = new SYS_DISTRICTRepository(readWriteDB, readOnlyDB);
            this.SYS_FLEX_ITEM = new SYS_FLEX_ITEMRepository(readWriteDB, readOnlyDB);
            this.SYS_FLEX = new SYS_FLEXRepository(readWriteDB, readOnlyDB);
            this.SYS_MENU_LANG = new SYS_MENU_LANGRepository(readWriteDB, readOnlyDB);
            this.SYS_MENU = new SYS_MENURepository(readWriteDB, readOnlyDB);
            this.SYS_OBJECT = new SYS_OBJECTRepository(readWriteDB, readOnlyDB);
            this.SYS_PROVINCE = new SYS_PROVINCERepository(readWriteDB, readOnlyDB);
            this.SYS_SUB_DISTRICT = new SYS_SUB_DISTRICTRepository(readWriteDB, readOnlyDB);
            this.SYS_USER_ACCESS_LOG = new SYS_USER_ACCESS_LOGRepository(readWriteDB, readOnlyDB);
            this.SYS_USER_ACCESS = new SYS_USER_ACCESSRepository(readWriteDB, readOnlyDB);
            this.SYS_USER = new SYS_USERRepository(readWriteDB, readOnlyDB);
            this.SYS_VIEW_COLUMN_FILTER = new SYS_VIEW_COLUMN_FILTERRepository(readWriteDB, readOnlyDB);
            this.SYS_VIEW_COLUMN = new SYS_VIEW_COLUMNRepository(readWriteDB, readOnlyDB);
            this.SYS_VIEW = new SYS_VIEWRepository(readWriteDB, readOnlyDB);
        }
    }
}