using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            aaa();

            return;

            //this.dataGridView1.ColumnCount = 3;
            //this.dataGridView1.Columns[0].ReadOnly = true;
            //this.dataGridView1.Columns[1].ReadOnly = true;
            //this.dataGridView1.Columns[2].ReadOnly = true;
            //this.dataGridView1.Columns[0].Width = 300;
            //this.dataGridView1.Columns[1].Width = 200;
            //this.dataGridView1.Columns[2].Width = 200;
            //this.dataGridView1.RowCount = 5;


            //DataGridViewComboBoxColumn a = new DataGridViewComboBoxColumn();
            //DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
            //c.Value = 100;
            
            //a.Name = "100";
            //a.HeaderText = "aaaa";

            //((DataGridViewComboBoxCell)dataGridView1[1, 2]).co

            //((DataGridViewComboBoxCell)dataGridView1[1, 4]).Items.Add(param.Name);
        }

        private void aaa()
        {
            DataTable dt = new DataTable();
            DataRow dr;

            //テーブルに列追加
            dt.Columns.Add("コード");
            dt.Columns.Add("曜日");

            //テーブルに曜日をセット
            dr = dt.NewRow();
            dr["コード"] = "1";
            dr["曜日"] = "月曜日";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["コード"] = "2";
            dr["曜日"] = "火曜日";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["コード"] = "3";
            dr["曜日"] = "水曜日";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["コード"] = "4";
            dr["曜日"] = "木曜日";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["コード"] = "5";
            dr["曜日"] = "金曜日";
            dt.Rows.Add(dr);

            //曜日カラムをデータグリッドビューにセット
            DataGridViewComboBoxColumn colDate = new DataGridViewComboBoxColumn();
            colDate.DataPropertyName = "Date";
            colDate.DataSource = dt;
            colDate.ValueMember = "コード";
            colDate.DisplayMember = "曜日";
            dataGridView1.Columns.Insert(0, colDate);
            colDate.Name = "曜日";
        }
    }
    
}
