using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;

namespace POS.BackOffice.Web.Pages.Components
{
    public class DataGridColumn
    {
        public int Seq { get; set; }
        public string Field { get; set; }
        public string HeaderText { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool AllowSearching { get; set; }
        public bool AllowEditing { get; set; }
        public string Format { get; set; }
        public ColumnType Type { get; set; }
        public EditType EditType { get; set; }
        public RenderFragment<Object> EditTemplate { get; set; }
        public TextAlign TextAlign { get; set; }
        public string Width { get; set; }
        public ColumnTemplate Template { get; set; }
        public bool Visible { get; set; }
        public bool ShowInColumnChooser { get; set; }
        
        public DataGridColumn()
        {
            this.IsPrimaryKey = false;
            this.AllowEditing = false;
            this.Type = ColumnType.None;          // Not Specific
            this.EditType = EditType.DefaultEdit; // Textbox
            this.Visible = true;
            this.ShowInColumnChooser = true;
            this.Template = ColumnTemplate.None;
        }
    }

    public enum ColumnTemplate
    {
        None = 0,
        StatusBoolean = 1
    }
}