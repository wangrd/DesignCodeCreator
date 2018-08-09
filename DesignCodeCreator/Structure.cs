using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DesignCodeCreator
{
    /// <summary>
    /// 自定义视图结构
    /// </summary>
    public class ViewStructure
    {
        public ViewStructure(string afieldname, string acaption, string acontroltype = "TextEditEx", bool anullable = true, DataTable adatasource = null, int acontrolwidth = 100)
        {
            this.FieldName = afieldname;
            this.Caption = acaption;
            this.ControlType = string.IsNullOrEmpty(acontroltype)? "TextEditEx":acontroltype;
            this.ControlWidth = acontrolwidth ==0?100: acontrolwidth;
            this.Nullable = anullable;
            this.DataSource = adatasource;
        }

        public string FieldName = string.Empty;
        public string Caption = string.Empty;
        public string ControlType = string.Empty;
        public DataTable DataSource;
        public int ControlWidth;
        public bool Nullable;
    }

    /// <summary>
    /// 设计代码结构，默认父控件为PanelControl1
    /// </summary>
    public class DesignStructure
    {
        public string Declare;          //声明部分
        public string Instantiation;    //实例化部分
        public string BeginInit;        //挂起操作
        public string ControlAdd;       //容器初始化
        public string EndInit;          //结束挂起
        public string ControlInit;      //控件初始化
        public string NullableJudge;    //空值判断函数
        public string Refresh;          //刷新
    }
}
