﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NewLife.Reflection;
using XCode.DataAccessLayer;

namespace XCoder
{
    public partial class FrmModel : Form
    {
        #region 属性
        /// <summary>表集合</summary>
        public IList<IDataTable> Tables { get; set; }
        #endregion

        #region 界面初始化
        public FrmModel()
        {
            InitializeComponent();

            //Icon = Source.GetIcon();
        }

        public static FrmModel Create(IList<IDataTable> tables)
        {
            if (tables == null || tables.Count < 1) throw new ArgumentNullException("tables");

            var frm = new FrmModel();
            frm.Tables = tables;

            return frm;
        }

        private void FrmModel_Load(Object sender, EventArgs e)
        {
            SetTables(Tables, 0);
            SetDbTypes();
        }
        #endregion

        #region 选择数据表
        IDataTable GetSelectedTable()
        {
            var cb = cbTables;
            if (cb == null || cb.SelectedItem == null) return null;

            return cb.SelectedItem as IDataTable;
        }

        private void cbTables_SelectedIndexChanged(Object sender, EventArgs e)
        {
            var table = GetSelectedTable();
            if (table == null) return;

            pgTable.SelectedObject = table;
            //gv.DataSource = Tables;

            gv.DataSource = table.Columns;
            dgvIndex.DataSource = table.Indexes;
            //dgvRelation.DataSource = table.Relations;
        }

        private void gv_RowEnter(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dgv = sender as DataGridView;
            if (dgv == null) return;

            var row = dgv.Rows[e.RowIndex];
            if (row == null) return;

            pgColumn.SelectedObject = row.DataBoundItem;
        }

        void SetTables(IList<IDataTable> tables, Int32 index)
        {
            cbTables.Items.Clear();
            if (Tables != null && tables.Count > 0)
            {
                foreach (var item in tables)
                {
                    cbTables.Items.Add(item);
                }

                if (index < 0) index = 0;
                cbTables.SelectedIndex = index;
            }
            cbTables.Update();
        }
        #endregion

        #region 添加
        private void btnAddTable_Click(Object sender, EventArgs e)
        {
            if (Tables == null || Tables.Count < 1) return;

            var type = Tables[0].GetType();
            if (type == null) return;

            var table = type.CreateInstance() as IDataTable;
            if (table == null) return;

            Tables.Add(table);
            var id = Tables.Count;
            table.TableName = "NewTable" + id;
            table.Description = "新建表" + id;

            SetTables(Tables, Tables.Count - 1);
        }

        private void btnAddColumn_Click(Object sender, EventArgs e)
        {
            var table = GetSelectedTable();
            if (table == null) return;

            var dc = table.CreateColumn();
            table.Columns.Add(dc);
            var id = table.Columns.Count;
            dc.ColumnName = "Column" + id;
            dc.Description = "字段" + id;

            gv.DataSource = null;
            gv.DataSource = table.Columns;
            pgColumn.SelectedObject = dc;
        }

        private void btnAddIndex_Click(Object sender, EventArgs e)
        {
            var table = GetSelectedTable();
            if (table == null) return;

            var di = table.CreateIndex();
            table.Indexes.Add(di);

            dgvIndex.DataSource = null;
            dgvIndex.DataSource = table.Indexes;
            pgColumn.SelectedObject = di;
        }

        //private void btnAddRelation_Click(Object sender, EventArgs e)
        //{
        //    IDataTable table = GetSelectedTable();
        //    if (table == null) return;

        //    IDataRelation dr = table.CreateRelation();
        //    table.Relations.Add(dr);

        //    dgvRelation.DataSource = null;
        //    dgvRelation.DataSource = table.Relations;
        //    pgColumn.SelectedObject = dr;
        //}
        #endregion

        #region 建表语句
        void SetDbTypes()
        {
            cbConn.DataSource = DAL.ConnStrs.Keys.ToList();
            cbConn.Update();
        }

        private void btnCreateTableSQL_Click(Object sender, EventArgs e)
        {
            if (cbConn.SelectedItem == null) return;

            var table = GetSelectedTable();
            if (table == null) return;

            var dal = DAL.Create("" + cbConn.SelectedItem);
            if (dal == null) return;

            try
            {
                var md = dal.Db.CreateMetaData();
                var sql = CreateTable(md, table);

                FrmText.Create(table.TableName + "表建表语句", sql).Show();
            }
            catch (Exception ex)
            {
                FrmText.Create(table.TableName + "表建表语句", "生成建表语句错误！" + Environment.NewLine + ex.ToString()).Show();
            }
        }

        static String CreateTable(IMetaData md, IDataTable table)
        {
            var sql = md.GetSchemaSQL(DDLSchema.CreateTable, table);

            var sb = new StringBuilder();
            if (!String.IsNullOrEmpty(sql)) sb.AppendLine(sql + "; ");

            // 加上表注释
            if (!String.IsNullOrEmpty(table.Description))
            {
                sql = md.GetSchemaSQL(DDLSchema.AddTableDescription, table);
                if (!String.IsNullOrEmpty(sql)) sb.AppendLine(sql + "; ");
            }

            // 加上字段注释
            foreach (var item in table.Columns)
            {
                if (!String.IsNullOrEmpty(item.Description))
                {
                    sql = md.GetSchemaSQL(DDLSchema.AddColumnDescription, item);
                    if (!String.IsNullOrEmpty(sql)) sb.AppendLine(sql + "; ");
                }
            }

            // 加上索引
            if (table.Indexes != null)
            {
                foreach (var item in table.Indexes)
                {
                    if (!item.PrimaryKey)
                    {
                        sql = md.GetSchemaSQL(DDLSchema.CreateIndex, item);
                        if (!String.IsNullOrEmpty(sql)) sb.AppendLine(sql + "; ");
                    }
                }
            }

            return sb.ToString();
        }

        private void btnCreateDbSQL_Click(Object sender, EventArgs e)
        {
            if (cbConn.SelectedItem == null) return;

            var dal = DAL.Create("" + cbConn.SelectedItem);
            if (dal == null) return;

            try
            {
                var md = dal.Db.CreateMetaData();
                var sb = new StringBuilder();
                foreach (var table in Tables)
                {
                    var sql = CreateTable(md, table);
                    if (!String.IsNullOrEmpty(sql)) sb.AppendLine(sql);
                }

                FrmText.Create("建表语句", sb.ToString()).Show();
            }
            catch (Exception ex)
            {
                FrmText.Create("建表语句", "生成建表语句错误！" + Environment.NewLine + ex.ToString()).Show();
            }
        }

        private void btnCreateDb_Click(Object sender, EventArgs e)
        {
            if (cbConn.SelectedItem == null) return;

            var dal = DAL.Create("" + cbConn.SelectedItem);
            if (dal == null) return;

            try
            {
                var md = dal.Db.CreateMetaData();
                md.SetTables(Migration.Full, Tables.ToArray());

                MessageBox.Show("成功建立" + Tables.Count + "张数据表！", Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("建表失败！" + Environment.NewLine + ex.Message, Text);
            }
        }
        #endregion
    }
}