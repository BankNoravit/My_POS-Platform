using POS.BackOffice.Web.Services;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Data;

namespace POS.BackOffice.Web.Pages.Templates
{
    public class TemplatePageConfig
    {                                                               // For:
        public string PageTitle { get; set; }                       // List, Info page
        public string PageName { get; set; }                        // List, Info page
        public string InfoPageRoute { get; set; }                   // List page
        public string ListPageRoute { get; set; }                   // Info page
        public Dictionary<string, string> Breadcrumb { get; set; }  // List, Info page

        public string Mode { get; set; }                            // Info page
        public string HeaderText { get; set; }                      // Info page
        public bool IsActive { get; set; }                          // Info page

        public TemplatePageConfig()
        {
            this.Breadcrumb = new Dictionary<string, string>();
        }
    }
}