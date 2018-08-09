namespace DesignCodeCreator
{
    partial class DesignCodeCreatorForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridcElement = new HollySource.GridControlEx();
            this.gridvElement = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbControlType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFormDescription = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormName = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamespace = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRefresh = new DevExpress.XtraEditors.CheckEdit();
            this.chkNullable = new DevExpress.XtraEditors.CheckEdit();
            this.txtControlRefresh = new System.Windows.Forms.RichTextBox();
            this.txtNullJudge = new System.Windows.Forms.RichTextBox();
            this.txtFormHeight = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormWidth = new DevExpress.XtraEditors.TextEdit();
            this.txtDesignCode = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbControlType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRefresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNullable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormWidth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridcElement);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1192, 715);
            this.panelControl1.TabIndex = 5;
            // 
            // gridcElement
            // 
            this.gridcElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcElement.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridcElement.Location = new System.Drawing.Point(2, 2);
            this.gridcElement.MainView = this.gridvElement;
            this.gridcElement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridcElement.Name = "gridcElement";
            this.gridcElement.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbControlType});
            this.gridcElement.Size = new System.Drawing.Size(597, 711);
            this.gridcElement.TabIndex = 6;
            this.gridcElement.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridvElement});
            this.gridcElement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridcElement_KeyDown);
            // 
            // gridvElement
            // 
            this.gridvElement.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridvElement.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridvElement.GridControl = this.gridcElement;
            this.gridvElement.Name = "gridvElement";
            this.gridvElement.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridvElement.OptionsBehavior.Editable = false;
            this.gridvElement.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridvElement.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridvElement.OptionsBehavior.ReadOnly = true;
            this.gridvElement.OptionsCustomization.AllowColumnMoving = false;
            this.gridvElement.OptionsCustomization.AllowFilter = false;
            this.gridvElement.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridvElement.OptionsMenu.EnableColumnMenu = false;
            this.gridvElement.OptionsView.ColumnAutoWidth = false;
            this.gridvElement.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridvElement.OptionsView.ShowGroupPanel = false;
            this.gridvElement.DoubleClick += new System.EventHandler(this.gridvElement_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "描述";
            this.gridColumn1.FieldName = "Caption";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FieldName";
            this.gridColumn2.FieldName = "FieldName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "控件类型";
            this.gridColumn3.ColumnEdit = this.cmbControlType;
            this.gridColumn3.FieldName = "ControlType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 149;
            // 
            // cmbControlType
            // 
            this.cmbControlType.AutoHeight = false;
            this.cmbControlType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbControlType.Name = "cmbControlType";
            this.cmbControlType.NullText = "";
            this.cmbControlType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "默认宽度";
            this.gridColumn4.FieldName = "ControlWidth";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 61;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "可否为空";
            this.gridColumn5.FieldName = "Nullable";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 56;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.txtFormDescription);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.txtFormName);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.txtNamespace);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.chkRefresh);
            this.panelControl2.Controls.Add(this.chkNullable);
            this.panelControl2.Controls.Add(this.txtControlRefresh);
            this.panelControl2.Controls.Add(this.txtNullJudge);
            this.panelControl2.Controls.Add(this.txtFormHeight);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.txtFormWidth);
            this.panelControl2.Controls.Add(this.txtDesignCode);
            this.panelControl2.Controls.Add(this.btnCreate);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(599, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(591, 711);
            this.panelControl2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "窗口说明";
            // 
            // txtFormDescription
            // 
            this.txtFormDescription.EditValue = "";
            this.txtFormDescription.Location = new System.Drawing.Point(78, 98);
            this.txtFormDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormDescription.Name = "txtFormDescription";
            this.txtFormDescription.Size = new System.Drawing.Size(91, 24);
            this.txtFormDescription.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "窗口名称";
            // 
            // txtFormName
            // 
            this.txtFormName.EditValue = "";
            this.txtFormName.Location = new System.Drawing.Point(78, 64);
            this.txtFormName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(91, 24);
            this.txtFormName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "命名空间";
            // 
            // txtNamespace
            // 
            this.txtNamespace.EditValue = "";
            this.txtNamespace.Location = new System.Drawing.Point(78, 31);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(91, 24);
            this.txtNamespace.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(183, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 72);
            this.label4.TabIndex = 13;
            this.label4.Text = "值\r\n域\r\n刷\r\n新";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(183, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 72);
            this.label3.TabIndex = 12;
            this.label3.Text = "空\r\n值\r\n限\r\n制";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(183, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 72);
            this.label2.TabIndex = 11;
            this.label2.Text = "设\r\n计\r\n代\r\n码";
            // 
            // chkRefresh
            // 
            this.chkRefresh.Location = new System.Drawing.Point(78, 206);
            this.chkRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Properties.AutoWidth = true;
            this.chkRefresh.Properties.Caption = "控件刷新";
            this.chkRefresh.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.chkRefresh.Size = new System.Drawing.Size(85, 22);
            this.chkRefresh.TabIndex = 10;
            // 
            // chkNullable
            // 
            this.chkNullable.Location = new System.Drawing.Point(78, 174);
            this.chkNullable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNullable.Name = "chkNullable";
            this.chkNullable.Properties.AutoWidth = true;
            this.chkNullable.Properties.Caption = "空值判断";
            this.chkNullable.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1;
            this.chkNullable.Size = new System.Drawing.Size(85, 22);
            this.chkNullable.TabIndex = 9;
            // 
            // txtControlRefresh
            // 
            this.txtControlRefresh.Location = new System.Drawing.Point(211, 436);
            this.txtControlRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtControlRefresh.Name = "txtControlRefresh";
            this.txtControlRefresh.Size = new System.Drawing.Size(365, 149);
            this.txtControlRefresh.TabIndex = 6;
            this.txtControlRefresh.Text = "";
            // 
            // txtNullJudge
            // 
            this.txtNullJudge.Location = new System.Drawing.Point(211, 275);
            this.txtNullJudge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNullJudge.Name = "txtNullJudge";
            this.txtNullJudge.Size = new System.Drawing.Size(365, 149);
            this.txtNullJudge.TabIndex = 5;
            this.txtNullJudge.Text = "";
            // 
            // txtFormHeight
            // 
            this.txtFormHeight.EditValue = "471";
            this.txtFormHeight.Location = new System.Drawing.Point(127, 136);
            this.txtFormHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormHeight.Name = "txtFormHeight";
            this.txtFormHeight.Size = new System.Drawing.Size(42, 24);
            this.txtFormHeight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "窗口大小";
            // 
            // txtFormWidth
            // 
            this.txtFormWidth.EditValue = "822";
            this.txtFormWidth.Location = new System.Drawing.Point(78, 136);
            this.txtFormWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormWidth.Name = "txtFormWidth";
            this.txtFormWidth.Size = new System.Drawing.Size(42, 24);
            this.txtFormWidth.TabIndex = 2;
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Location = new System.Drawing.Point(211, 18);
            this.txtDesignCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.Size = new System.Drawing.Size(365, 247);
            this.txtDesignCode.TabIndex = 1;
            this.txtDesignCode.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 275);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(77, 39);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "生成代码";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DesignCodeCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 715);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "DesignCodeCreatorForm";
            this.Text = "设计视图生成器1.0";
            this.Load += new System.EventHandler(this.DesignCodeCreatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridvElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbControlType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamespace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRefresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNullable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormWidth.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private HollySource.GridControlEx gridcElement;
        private DevExpress.XtraGrid.Views.Grid.GridView gridvElement;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbControlType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtFormDescription;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtFormName;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtNamespace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit chkRefresh;
        private DevExpress.XtraEditors.CheckEdit chkNullable;
        private System.Windows.Forms.RichTextBox txtControlRefresh;
        private System.Windows.Forms.RichTextBox txtNullJudge;
        private DevExpress.XtraEditors.TextEdit txtFormHeight;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtFormWidth;
        private System.Windows.Forms.RichTextBox txtDesignCode;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
    }
}

