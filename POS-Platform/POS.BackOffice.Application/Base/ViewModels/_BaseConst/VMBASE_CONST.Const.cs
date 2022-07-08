using System;
using System.Collections.Generic;
using System.Text;

namespace POS.ViewModels
{
    public partial class VMBASE_CONST
    {
        public const string SERVER_ERROR_MSG = "Server error. (code: {0})";
        public const string GET_DATA_SUCCESS_MSG = "สำเร็จ";
        public const string INIT_DATA_SUCCESS_MSG = "สำเร็จ";
        public const string DELETE_SUCCESS_MSG = "ลบรายการสำเร็จ";
        public const string DELETE_FAILED_REFERRED_MSG = "ลบรายการไม่สำเร็จ\r\nเนื่องจากข้อมูลถูกนำไปใช้อ้างอิงแล้ว";
        public const string DELETE_FAILED_SUPERADMIN_MSG = "ลบรายการไม่สำเร็จ\r\nเนื่องจาก User/Role ดังกล่าวเป็น Super Admin";
        public const string UPDATE_SUCCESS_MSG = "แก้ไขข้อมูลสำเร็จ";
        public const string UPDATE_FAILED_HAS_BEEN_DELETED = "บันทึกรายการไม่สำเร็จ\r\nเนื่องจากรายการนี้ถูกลบแล้ว";
        public const string SAVE_SUCCESS_MSG = "บันทึกข้อมูลสำเร็จ";
        public const string CREATE_SUCCESS_MSG = "เพิ่มข้อมูลสำเร็จ";
        public const string DATA_NOT_FOUND_MSG = "ไม่พบข้อมูล";
        public const string UNAUTHOIRZE = "ไม่ได้รับอนุญาตเข้าถึงข้อมูล";
        public const string DATA_DUPLICATE = "{0} นี้มีอยู่ในระบบแล้ว";
        public const string DATA_PASSWORD_NOT_MATCH = "Password และ Confirm Password ไม่ตรงกัน";
        public const string DEFAULT_SELECT_OPTION = "-- SELECT --";

        public const string USERNAME_ALREADY_EXISTS = "Username ดังกล่าวไม่สามารถใช้งานได้ เนื่องจากถูกใช้งานแล้ว";
        public const string ROLENAME_ALREADY_EXISTS = "ชื่อบทบาท ดังกล่าวไม่สามารถใช้งานได้ เนื่องจากถูกใช้งานแล้ว";

        public const string STATUS_ACTIVE = "Active";
        public const string STATUS_INACTIVE = "Inactive";

        public const string FORMAT_DATE = "dd/MM/yyyy";
        public const string FORMAT_TIME = "HH:mm";
        public const string LOCATION_NAME_TH = "จุดรับบริการ";
        public const string SERVICE_TYPE_NAME_TH = "ประเภทบริการ";
        public const string SERVICE_NAME_TH = "บริการ";

        public const string DEFAULT_IMAGE_LINK_PATH = "\\default\\img\\default-image.png";

  
        public const string NOT_DELETE_DATA_LOCATION_SERVICE = "ไม่สามารถลบข้อมูลได้ เนื่องจากมีผู้ลงทะเบียนเข้ารับบริการแล้ว";
   

        public enum ACTION_MODE
        {
            DEFAULT = -1,
            CREATE = 1,
            UPDATE = 2
        }

        public enum ERROR_CODE
        {
            LANGUAGE = 0
        }

        public enum COMPANY
        {
            DDC_MOPH = 1
        }

        public enum IDENTITY_CLAIM_KEY
        {
        }

        public enum USER_ADMIN
        {
            ADMIN = 1
        }

        public enum MASTER_DATA_TYPE
        {
            GENDER,
            TITLE,
            AGE_RANGE,
            APM_TIME_RANGE,
            WORK_SCHEDULE,
            APPOINTMENT_STATUS,
            SATISFACTION_TOPIC,
            SATISFACTION_ITEM
        }

        public enum HTTP_REQUEST
        {
            GET = 1,
            POST = 2,
            PUT = 3,
            DELETE = 4,
            PATCH = 5
        }

        public enum MENU_DEFINITION
        {
            NOTSET = 0,
            LV1_INDEX = 1,
            LV1_REGISTRANT_LIST = 2,
            LV1_REPORT = 3,
            LV2_ASSESSMENT_REPORT = 4,
            LV2_REGISTRANT_REPORT = 5,
            LV1_PRESS_RELEASE_LIST = 6,
            LV1_SCHEDULE = 7,
            LV2_SERVICE_TYPE_LIST = 8,
            LV2_LOCATION_LIST = 9,
            LV1_USER_MENAGEMENT = 10,
            LV2_USER_LIST = 11,
            LV2_ROLE_LIST = 12
        }

        public enum UPDATE_APPOINTMENT_MODE
        {
            CANCEL_ALL = 1,
            RECEIVED = 2,
            CANCEL = 3
        }

        public enum APPOINTMENT_STATUS
        {
            Waiting = 2055,
            Received = 2057,
            Canceled = 2058
        }

        public enum LANG_CODE
        {
            EN,
            TH
        }

        public enum TAB_PAGE_APPOINTMENT_HISTORY
        {
            WAIT_APPOINTMENT,
            HISTORY
        }
    }
}
