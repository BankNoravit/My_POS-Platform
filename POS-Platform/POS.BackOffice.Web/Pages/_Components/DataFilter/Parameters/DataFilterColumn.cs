using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.QueryBuilder;

namespace POS.BackOffice.Web.Pages.Components
{
    public class DataFilterColumn
    {
        public int Seq { get; set; }
        public string Field { get; set; }
        public string Label { get; set; }
        public string Format { get; set; }
        public ColumnType Type { get; set; }
        public List<OperatorsModel> Operators { get; set; }
        public DataFilterColumn()
        {
            this.Operators = null;
        }
    }
}