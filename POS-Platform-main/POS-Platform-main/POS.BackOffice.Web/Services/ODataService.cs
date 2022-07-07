using Microsoft.Extensions.Options;
using Microsoft.OData.Client;
using POS.BackOffice.Web.Configuration;
using POS.Domain.Models;
using System.Linq.Expressions;

namespace POS.BackOffice.Web.Services
{
    public enum ODATA_ROUTE_NAME
    {
        Employee,
        Position,
        PositionLevel,
        Company,
        Department,
        Zone,
        Flex_Item,
        Branch
    }

    public class ODataContext : DataServiceContext
    {
        public ODataContext(Uri serviceRoot) : base(serviceRoot)
        {
            this.Position = base.CreateQuery<ORG_POSITION>(ODATA_ROUTE_NAME.Position.ToString());
            this.PositionLevel = base.CreateQuery<ORG_POSITION_LEVEL>(ODATA_ROUTE_NAME.PositionLevel.ToString());
            this.Zone = base.CreateQuery<ORG_ZONE>(ODATA_ROUTE_NAME.Zone.ToString());
            this.Company = base.CreateQuery<ORG_COMPANY>(ODATA_ROUTE_NAME.Company.ToString());
            this.Department = base.CreateQuery<ORG_DEPARTMENT>(ODATA_ROUTE_NAME.Department.ToString());
            this.Flex_Item = base.CreateQuery<SYS_FLEX_ITEM>(ODATA_ROUTE_NAME.Flex_Item.ToString());
            this.Branch = base.CreateQuery<ORG_BRANCH>(ODATA_ROUTE_NAME.Branch.ToString());
        }

        public DataServiceQuery<ORG_POSITION> Position { get; }
        public DataServiceQuery<ORG_POSITION_LEVEL> PositionLevel { get; }
        public DataServiceQuery<ORG_ZONE> Zone { get; }
        public DataServiceQuery<ORG_COMPANY> Company { get; }
        public DataServiceQuery<ORG_DEPARTMENT> Department { get; }
        public DataServiceQuery<SYS_FLEX_ITEM> Flex_Item { get; }
        public DataServiceQuery<ORG_BRANCH> Branch { get; }



        #region [Position]
        public void AddToPosition(ORG_POSITION position)
        {
            base.AddObject(ODATA_ROUTE_NAME.Position.ToString(), position);
        }
        public void UpdatePosition(ORG_POSITION position)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Position.ToString(), position);
            base.UpdateObject(position);
        }
        public void DeletePosition(ORG_POSITION position)
        {
            base.DeleteObject(position);
        }
        #endregion [Position]

        #region [PositionLevel]
        public void AddToPositionLevel(ORG_POSITION_LEVEL positionLevel)
        {
            base.AddObject(ODATA_ROUTE_NAME.PositionLevel.ToString(), positionLevel);
        }
        public void UpdatePositionLevel(ORG_POSITION_LEVEL positionLevel)
        {
            base.AttachTo(ODATA_ROUTE_NAME.PositionLevel.ToString(), positionLevel);
            base.UpdateObject(positionLevel);
        }
        public void DeletePositionLevel(ORG_POSITION_LEVEL positionLevel)
        {
            base.DeleteObject(positionLevel);
        }
        #endregion [PositionLevel]

        #region [Zone]
        public void AddToZone(ORG_ZONE zone)
        {
            base.AddObject(ODATA_ROUTE_NAME.Zone.ToString(), zone);
        }
        public void UpdateZone(ORG_ZONE zone)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Zone.ToString(), zone);
            base.UpdateObject(zone);
        }
        public void DeleteZone(ORG_ZONE zone)
        {
            base.DeleteObject(zone);
        }
        #endregion [Zone]

        #region [Company]
        public void AddToCompany(ORG_COMPANY company)
        {
            base.AddObject(ODATA_ROUTE_NAME.Company.ToString(), company);
        }
        public void UpdateCompany(ORG_COMPANY company)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Company.ToString(), company);
            base.UpdateObject(company);
        }
        public void DeleteCompany(ORG_COMPANY company)
        {
            base.DeleteObject(company);
        }
        #endregion

        #region [Department]
        public void AddToDepartment(ORG_DEPARTMENT department)
        {
            base.AddObject(ODATA_ROUTE_NAME.Department.ToString(), department);
        }
        public void UpdateDepartment(ORG_DEPARTMENT department)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Department.ToString(), department);
            base.UpdateObject(department);
        }
        public void DeleteDepartment(ORG_DEPARTMENT department)
        {
            base.DeleteObject(department);
        }
        #endregion

        #region [SYS_FLEX_ITEM]
        public void AddToFlexItem(SYS_FLEX_ITEM flexitem)
        {
            base.AddObject(ODATA_ROUTE_NAME.Flex_Item.ToString(), flexitem);
        }
        public void UpdateFlexItem(SYS_FLEX_ITEM flexitem)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Flex_Item.ToString(), flexitem);
            base.UpdateObject(flexitem);
        }
        public void DeleteFlexItem(SYS_FLEX_ITEM flexitem)
        {
            base.DeleteObject(flexitem);
        }
        #endregion

        #region [ORG_BRANCH]
        public void AddToBranch(ORG_BRANCH branch)
        {
            base.AddObject(ODATA_ROUTE_NAME.Branch.ToString(), branch);
        }
        public void UpdateBranch(ORG_BRANCH branch)
        {
            base.AttachTo(ODATA_ROUTE_NAME.Branch.ToString(), branch);
            base.UpdateObject(branch);
        }
        public void DeleteBranch(ORG_BRANCH branch)
        {
            base.DeleteObject(branch);
        }
        #endregion

    }
}