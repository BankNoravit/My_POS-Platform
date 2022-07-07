using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using POS.Domain.Models;
using POS.ViewModels.v1;

namespace POS.BackOffice.WebAPI
{
    public static class ODataConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "POS.BackOffice";
            builder.ContainerName = "POSBackOfficeContainer";
            builder.ModelAliasingEnabled = true;
   
            builder.RegisterModels();
            builder.RegisterViewModelV1();

            return builder.GetEdmModel();
        }

        public static void RegisterModels(this ODataConventionModelBuilder builder)
        {
            builder.EntitySet<ORG_EMPLOYEE>("Employee");
            builder.EntitySet<ORG_POSITION>("Position");
            builder.EntitySet<ORG_POSITION_LEVEL>("PositionLevel");
            builder.EntitySet<ORG_COMPANY>("Company");
            builder.EntitySet<ORG_DEPARTMENT>("Department");
            builder.EntitySet<ORG_ZONE>("Zone");
            builder.EntitySet<SYS_USER>("User");
            builder.EntitySet<SYS_FLEX_ITEM>("Flex_Item");
            builder.EntitySet<ORG_BRANCH>("Branch");


        }

        public static void RegisterViewModelV1(this ODataConventionModelBuilder builder)
        {

        }

        public static void RegisterViewModelV2(this ODataConventionModelBuilder builder)
        {

        }

        public static void RegisterViewModelV3(this ODataConventionModelBuilder builder)
        {

        }
    }
}
