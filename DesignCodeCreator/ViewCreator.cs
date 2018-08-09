using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using HollySource;
using System.IO;

namespace DesignCodeCreator
{
    /// <summary>
    /// 根据View的结构生成编辑视图，默认编辑框为Textedit
    /// </summary>
    public class ViewCreator
    {
        #region 基础定义和初始化
        public List<ViewStructure> Columns = new List<ViewStructure>();
        public int ColumnCount;
        private int UnitIndex;                      //当前单位(描述+控件)序号
        private Point Location = new Point(20, 20);
        public static int GapRow = 6;              //行间距
        public static int GapColumn = 10;          //列间距
        public static int GapDescription = 0;      //描述间距
        private int RowIndex;                       //行号
        private int ColumnIndex;                    //列号
        public Size PanelSize = new Size(822, 471);
        public DesignStructure Designcode = new DesignStructure();
        public bool NeedNullJudge = true;                  //需要做空值判断
        public bool NeedRefresh = true;                    //需要刷新
        private string form_description = "AutoCreateForm";
        private string form_name = "AutoCreateForm";
        private string name_space = "AutoCreate";

        public string FormName
        {
            get{ return form_name; }
            set {if (string.IsNullOrEmpty(value)) return;
                this.form_name = value; }
        }
        public string FormDescription
        {
            get { return form_description; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                this.form_description = value;
            }
        }
        public string NameSpace
        {
            get { return name_space; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                this.name_space = value;
            }
        }

        public ViewCreator(List<ViewStructure> aColumns = null)
        {
            if (aColumns == null) return;
            this.Columns = aColumns;
        }
        #endregion

        public string CreateEditorView(Size ControlSize)
        {
            this.Init();
            string _designcode = string.Empty;
            if (ControlSize.Height>0 && ControlSize.Width >0)
                PanelSize = ControlSize;
            //生成布局
            foreach (ViewStructure cl in Columns)
            {
                if (!AddCaption(cl)) break;
                if (!AddControl(cl)) break;
            }
            Designcode.EndInit += "this.ResumeLayout(false);\n";
            Designcode.EndInit += "\n\n\t\t}\n\n#endregion\n";
            Designcode.Declare += "\n}\n}";
            _designcode = Designcode.Instantiation + Designcode.BeginInit + 
                        Designcode.ControlAdd + Designcode.ControlInit + 
                        Designcode.EndInit + Designcode.Declare;

            if(NeedNullJudge)
            {
                Designcode.NullableJudge += "}\n";
            }
            if(NeedRefresh)
            {
                Designcode.Refresh += "}\n";
            }
            return _designcode;
        }


        //必要的初始化
        public bool Init()
        {
            #region 设计视图代码初始化
            Designcode.BeginInit = "((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();\n";
            Designcode.BeginInit = "this.panelControl1.SuspendLayout();\n";

            Designcode.Instantiation = "namespace "+name_space + "\n{\npartial class "+form_name+"\n{\n";
            Designcode.Instantiation += "private System.ComponentModel.IContainer components = null;\n";
            Designcode.Instantiation += "protected override void Dispose(bool disposing)\n{\n";
            Designcode.Instantiation += "if (disposing && (components != null))\n{\ncomponents.Dispose();\n}\n";
            Designcode.Instantiation += "base.Dispose(disposing);\n}\n";
            Designcode.Instantiation += "#region Windows Form Designer generated code\n";
            Designcode.Instantiation += "private void InitializeComponent()\n{\n";

            Designcode.Instantiation += "this.panelControl1 = new DevExpress.XtraEditors.PanelControl();\n";
            Designcode.Declare = "private DevExpress.XtraEditors.PanelControl panelControl1;\n";
            Designcode.EndInit = "//\n// "+ FormName+"\n//\n";
            Designcode.EndInit += "this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);\n";
            Designcode.EndInit += "this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;\n";
            Designcode.EndInit += "this.ClientSize = new System.Drawing.Size("+PanelSize.Width+","+PanelSize.Height+");\n";
            Designcode.EndInit += "this.Controls.Add(this.panelControl1);\n";
            Designcode.EndInit += "this.KeyPreview = true;\n";
            Designcode.EndInit += "this.Name = \"" +FormName+ "\";\n";
            Designcode.EndInit += "this.Text = \"" +FormDescription+ "\";\n";
            Designcode.EndInit += "((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();\n";
            Designcode.EndInit += "this.panelControl1.ResumeLayout(false);\n";
            Designcode.EndInit += "this.panelControl1.PerformLayout();\n";
            Designcode.ControlAdd += "//\n// panelControl1\n//\n";
            Designcode.ControlInit = "this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;\n";
            Designcode.ControlInit += "this.panelControl1.Location = new System.Drawing.Point(0, 0);\n";
            Designcode.ControlInit += "this.panelControl1.Name = \"panelControl1\";\n";
            Designcode.ControlInit += "this.panelControl1.Size = new System.Drawing.Size(" + (PanelSize.Width-16) + "," + (PanelSize.Height-39) + ");\n";
            Designcode.ControlInit += "this.panelControl1.TabIndex = 0;\n";
            #endregion

            //空值函数初始化
            if(NeedNullJudge)
            {
                Designcode.NullableJudge = "private void NullableControl()\n{\n";
            }
            //刷新函数初始化
            if(NeedRefresh)
            {
                Designcode.Refresh = "private void ControlRefresh()\n{\n";
            }
            return true;
        }

        private bool AddCaption(ViewStructure cl)
        {
            string lbname = "label" + UnitIndex;
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = cl.Caption;
            Graphics gh = lb.CreateGraphics();
            gh.PageUnit = GraphicsUnit.Pixel;
            gh.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            int lbwidth = (int)(gh.MeasureString(lb.Text, lb.Font).Width);
            if (Location.X >= PanelSize.Width - (GapRow + cl.ControlWidth+ lbwidth)
                || (ColumnIndex >= ColumnCount) && ColumnCount != 0)
            {
                Location.Y += GapRow +20; //行间距+控件宽度
                RowIndex++;
                ColumnIndex = 0;
                Location.X = 20;
                //if (Location.Y >= PanelSize.Height - 20) return false;
            }
            Designcode.Declare += "DevExpress.XtraEditors.LabelControl " + lbname + ";\n";
            Designcode.Instantiation += "this." + lbname + " = new DevExpress.XtraEditors.LabelControl();\n";
            Designcode.ControlAdd += "this.panelControl1.Controls.Add(this." + lbname + ");\n";

            Designcode.ControlInit += "//\n// "+lbname+"\n//\n";
            Designcode.ControlInit += "this." + lbname + ".AutoSize = true;\n";
            Designcode.ControlInit += "this." + lbname + ".Location = new System.Drawing.Point("+ Location.X+","+ Location.Y + ");\n";
            Designcode.ControlInit += "this."+lbname + ".TabIndex = "+ UnitIndex + ";\n";
            Designcode.ControlInit += "this." + lbname + ".Text = \""+cl.Caption+ "\";\n";

            Location.X += (GapDescription + lbwidth);
            return true;
        }

        private bool AddControl(ViewStructure cl)
        {
            //遍历命名空间下所有类
            Type[] classes = Assembly.Load("HollySource").GetTypes();
            Control ctl = null;
            foreach (var item in classes)
            {
                if(item.Name== cl.ControlType)
                {
                    ctl = (Control)Activator.CreateInstance(item);
                    ctl.Width = cl.ControlWidth;
                    ctl.Height = 20;
                }
            }
            if(ctl ==null)
                return false;
            string clname = string.Empty;
            switch(ctl.GetType().Name)
            {
                case "TextEditEx":
                    clname = "txt" + cl.FieldName;
                    Designcode.Declare += "private HollySource.TextEditEx "+clname+";\n";
                    Designcode.Instantiation += "this." + clname + " = new HollySource.TextEditEx();\n";
                    Designcode.ControlInit += "//\n// "+clname+"\n//\n";
                    Designcode.ControlInit += "this." + clname + ".Location = new System.Drawing.Point(" + Location.X + "," + Location.Y + ");\n";
                    Designcode.ControlInit += "this."+clname+".Size = new System.Drawing.Size("+cl.ControlWidth +", 20);\n";
                    Designcode.ControlInit += "this."+clname+".TabIndex = "+UnitIndex+";\n";
                    #region 空值判断和刷新
                    if(NeedNullJudge&&!cl.Nullable)
                    {
                        Designcode.NullableJudge += "if (string.IsNullOrEmpty(this."+clname+".Text))\n{\n";
                        Designcode.NullableJudge += "this.DialogInformation(\"" + cl.Caption+"不能为空!\");\n";
                        Designcode.NullableJudge += "this."+clname+".Focus();\n}\n";
                    }
                    if (NeedRefresh)
                    {
                        Designcode.Refresh += "this." + clname + ".Text = string.Empty;\n";
                    }
                    #endregion
                    break;
                case "SearchLookUpEditEx":
                    
                    break;
                case "LookUpEditEx":
                    clname = "cmb" + cl.FieldName;
                    Designcode.Declare += "private HollySource.LookUpEditEx " + clname + ";\n";
                    Designcode.Instantiation += "this." + clname + " = new HollySource.LookUpEditEx();\n";
                    Designcode.ControlInit += "//\n// " + clname + "\n//\n";
                    Designcode.ControlInit += "this." + clname + ".AutoClear = true;\n";
                    Designcode.ControlInit += "this." + clname + ".Location = new System.Drawing.Point(" + Location.X + "," + Location.Y + ");\n";
                    Designcode.ControlInit += "this." + clname + ".Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {\n";
                    Designcode.ControlInit += "new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});\n";
                    Designcode.ControlInit += "this." + clname +".Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {\n";
                    Designcode.ControlInit += "new DevExpress.XtraEditors.Controls.LookUpColumnInfo(\"ID\", \"编号\", 20, DevExpress.Utils.FormatType.None, \"\", false, DevExpress.Utils.HorzAlignment.Default),\n";
                    Designcode.ControlInit += "new DevExpress.XtraEditors.Controls.LookUpColumnInfo(\"NAME\", \"名称\")});\n";
                    Designcode.ControlInit += "this."+clname+ ".Properties.DisplayMember = \"NAME\";\n";
                    Designcode.ControlInit += "this."+clname+".Properties.NullText = \"\";\n";
                    Designcode.ControlInit += "this."+clname+ ".Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;\n";
                    Designcode.ControlInit += "this."+clname+ ".Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;\n";
                    Designcode.ControlInit += "this." + clname + ".Properties.ValueMember = \"ID\";\n";
                    Designcode.ControlInit += "this."+clname+ ".Size = new System.Drawing.Size("+cl.ControlWidth+", 20);\n";
                    Designcode.ControlInit += "this."+clname+".TabIndex = "+UnitIndex+";\n";
                    #region 空值判断和刷新
                    if (NeedNullJudge && !cl.Nullable)
                    {
                        Designcode.NullableJudge += "if (string.IsNullOrEmpty(this." + clname + ".Key))\n{\n";
                        Designcode.NullableJudge += "this.DialogInformation(\"" + cl.Caption + "不能为空!\");\n";
                        Designcode.NullableJudge += "this."+clname+".Focus();\n}\n";
                    }
                    if(NeedRefresh)
                    {
                        Designcode.Refresh += "this."+clname+ ".Key = string.Empty;\n";
                    }
                    #endregion
                    break;
                case "ListBoxControlEx":
                    break;
                case "DateEditEx":
                    clname = "de" + cl.FieldName;
                    Designcode.Declare += "private HollySource.DateEditEx " + clname + ";\n";
                    Designcode.Instantiation += "this." + clname + " = new HollySource.DateEditEx();\n";
                    Designcode.ControlInit += "//\n// " + clname + "\n//\n";
                    Designcode.ControlInit += "this." + clname + ".Location = new System.Drawing.Point(" + Location.X + "," + Location.Y + ");\n";
                    Designcode.ControlInit += "this."+clname+ ".DateFormat = null;\n";
                    Designcode.ControlInit += "this."+clname+ ".DateType = null;\n";
                    Designcode.ControlInit += "this." + clname+ ".EditValue = null;\n";
                    Designcode.ControlInit += "this." + clname+ ".Name = \""+clname+ "\";\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {\n";
                    Designcode.ControlInit += "new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {\n";
                    Designcode.ControlInit += "new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.DisplayFormat.FormatString = \"yyyy-MM-dd\";\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.EditFormat.FormatString = \"yyyy-MM-dd\";\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.Mask.EditMask = \"yyyy-MM-dd\";\n";
                    Designcode.ControlInit += "this." + clname+ ".Properties.Mask.UseMaskAsDisplayFormat = true;\n";
                    Designcode.ControlInit += "this." + clname+ ".QueryParamName = \"\";\n";
                    Designcode.ControlInit += "this." + clname+ ".Size = new System.Drawing.Size("+cl.ControlWidth+", 20);\n";
                    Designcode.ControlInit += "this." + clname+ ".TabIndex = "+UnitIndex+";\n";
                    Designcode.ControlInit += "this." + clname+ ".Value = \"\";\n";
                    #region 空值判断和刷新
                    if (NeedNullJudge && !cl.Nullable)
                    {
                        Designcode.NullableJudge += "if (string.IsNullOrEmpty(this." + clname + ".Value))\n{\n";
                        Designcode.NullableJudge += "this.DialogInformation(\"" + cl.Caption + "不能为空!\");\n";
                        Designcode.NullableJudge += "this." + clname + ".Focus();\n}\n";
                    }
                    if (NeedRefresh)
                    {
                        Designcode.Refresh += "this." + clname + ".Value = string.Empty;\n";
                    }
                    #endregion
                    break;
                case "ComboBoxEx":
                    clname = "cmb" + cl.FieldName;
                    Designcode.Declare += "private HollySource.ComboBoxEx " + clname + ";\n";
                    Designcode.Instantiation += "this." + clname + " = new HollySource.ComboBoxEx();\n";
                    Designcode.ControlInit += "//\n// " + clname + "\n//\n";
                    Designcode.ControlInit += "this." + clname + ".Location = new System.Drawing.Point(" + Location.X + "," + Location.Y + ");\n";
                    Designcode.ControlInit += "this." + clname + ".DisplayMember = \"name\";\n";
                    Designcode.ControlInit += "this." + clname + ".FormattingEnabled = true;\n";
                    Designcode.ControlInit += "this." + clname + ".Key = \"\";\n";
                    Designcode.ControlInit += "this." + clname + ".Name = \"" + clname + "\";\n";
                    Designcode.ControlInit += "this." + clname + ".Size = new System.Drawing.Size("+cl.ControlWidth+", 20);\n";
                    Designcode.ControlInit += "this." + clname + ".TabIndex = "+UnitIndex+";\n";
                    Designcode.ControlInit += "this." + clname + ".Value = \"\";\n";
                    Designcode.ControlInit += "this." + clname + ".ValueMember = \"id\";\n";
                    #region 空值判断和刷新
                    if (NeedNullJudge && !cl.Nullable)
                    {
                        Designcode.NullableJudge += "if (string.IsNullOrEmpty(this." + clname + ".Key))\n{\n";
                        Designcode.NullableJudge += "this.DialogInformation(\"" + cl.Caption + "不能为空!\");\n";
                        Designcode.NullableJudge += "this." + clname + ".Focus();\n}\n";
                    }
                    if (NeedRefresh)
                    {
                        Designcode.Refresh += "this." + clname + ".Key = string.Empty;\n";
                    }
                    #endregion
                    break;
                default:
                    return false;
            }
            Designcode.BeginInit += "((System.ComponentModel.ISupportInitialize)(this." + clname + ".Properties)).BeginInit();\n";
            Designcode.EndInit += "((System.ComponentModel.ISupportInitialize)(this."+clname+ ".Properties)).EndInit();\n";
            Designcode.ControlAdd += "this.panelControl1.Controls.Add(this." + clname + ");\n";
            Location.X += GapColumn + cl.ControlWidth;

            ColumnIndex++;
            UnitIndex++;
            return true;
        }
        

    }
}
