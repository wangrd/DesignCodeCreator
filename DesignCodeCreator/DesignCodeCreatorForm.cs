using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HollySource;
using System.Reflection;

namespace DesignCodeCreator
{
    public partial class DesignCodeCreatorForm : MyXtraForm
    {
        ViewCreator Creator;
        DataTable dtTableStructure = new DataTable();


        public DesignCodeCreatorForm()
        {
            InitializeComponent();
        }

        private void DesignCodeCreatorForm_Load(object sender, EventArgs e)
        {
            this.gridvElement.OptionsBehavior.Editable = true;
            this.gridvElement.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;

            //初始化视图元素
            DataTable controls = new DataTable();
            cmbControlType.DisplayMember = "ID";
            cmbControlType.ValueMember = "ID";
            cmbControlType.ShowHeader = false;
            cmbControlType.ShowFooter = false;
            cmbControlType.NullText = string.Empty;
            cmbControlType.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            cmbControlType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            controls.Columns.Add("ID", typeof(string));
            Type[] classes = Assembly.Load("HollySource").GetTypes();
            foreach (Type t in classes)
            {
                if (t.Name.EndsWith("Ex"))
                {
                    controls.Rows.Add(t.Name);
                }
            }
            cmbControlType.DataSource = controls;

            //绑定数据源
            foreach (DevExpress.XtraGrid.Columns.GridColumn cl in this.gridvElement.Columns)
            {
                dtTableStructure.Columns.Add(cl.FieldName, cl.ColumnType);
            }
            this.gridcElement.DataSource = dtTableStructure;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataView)this.gridvElement.DataSource).ToTable();
            if (dt == null)
            {
                MessageBox.Show("获取原始数据失败！");
                return;
            }

            Size fsize = new Size(Convert.ToInt32(txtFormWidth.Text ?? "0"), Convert.ToInt32(txtFormHeight.Text ?? "0"));
            Creator = new ViewCreator(DataInvert(dt));
            Creator.NameSpace = this.txtNamespace.Text.Trim();
            Creator.FormName = this.txtFormName.Text.Trim();
            Creator.FormDescription = this.txtFormDescription.Text.Trim();
            Creator.NeedNullJudge = this.chkNullable.Checked;
            Creator.NeedRefresh = this.chkRefresh.Checked;
            this.txtDesignCode.Text = Creator.CreateEditorView(fsize);
            this.txtNullJudge.Text = Creator.Designcode.NullableJudge;
            this.txtControlRefresh.Text = Creator.Designcode.Refresh;
        }

        private List<ViewStructure> DataInvert(DataTable aTable)
        {
            if (aTable == null) return null;
            List<ViewStructure> columns = new List<ViewStructure>();
            foreach (DataRow dr in aTable.Rows)
            {
                ViewStructure structure = new ViewStructure(dr["FieldName"].ToString(),
                                                            dr["Caption"].ToString(),
                                                            dr["ControlType"].ToString(),
                                                            acontrolwidth: Convert.ToInt16(dr["ControlWidth"].ToString() == "" ? "0" : dr["ControlWidth"].ToString()),
                                                            anullable: dr["Nullable"].ToString() != "N");
                columns.Add(structure);
            }
            return columns;
        }

        private void gridcElement_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control == true) && e.KeyCode == Keys.V)
            {
                string copy = Clipboard.GetText();
                if (string.IsNullOrEmpty(copy)) return;
                DataTable dt = dtTableStructure.Clone();
                copy = copy.Replace("\r", "");
                string[] data = copy.Split('\n');
                foreach (string r in data)
                {
                    if (string.IsNullOrEmpty(r)) break;
                    dt.Rows.Add(r.Split('\t'));
                }
                this.gridcElement.DataSource = dt;
                e.Handled = true;
            }
        }

        private void gridvElement_DoubleClick(object sender, EventArgs e)
        {
            this.gridvElement.OptionsBehavior.ReadOnly = false;
        }
        
    }
}
