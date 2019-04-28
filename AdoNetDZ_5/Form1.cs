using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace AdoNetDZ_5
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter Dadapter = null;
        DataSet Dset = null;
        SqlCommandBuilder cmdBuilder = null;

        private DataTable Dtable = null;
        int count = 0;
        bool flag = true;

        string[] Request = {
            "SELECT * FROM users WHERE Administrator = 0",
            "SELECT * FROM users WHERE Administrator = 1",
            "SELECT * FROM users"
        };
        public Form1()
        {
            InitializeComponent();
            ShowTable(Request[1]);
            listViewTable.Items.Clear();
        }

        private void ShowTable(string strRequest)
        {
            count = 0;
            listViewTable.Items.Clear();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string stringQuery = strRequest;
            Dset = new DataSet();
            Dadapter = new SqlDataAdapter(stringQuery, connection);
            cmdBuilder = new SqlCommandBuilder(Dadapter);
            Dadapter.Fill(Dset);
            Dtable = Dset.Tables[0];

            string[] str = new string[Dset.Tables[0].Columns.Count];
            ListViewItem itemListView;
            for (int i = 0; i < Dset.Tables[0].Rows.Count; i++)
            {
                count++;
                for (int j = 0; j < Dset.Tables[0].Columns.Count; j++)
                {
                    str[j] = Dset.Tables[0].Rows[i][j].ToString();
                }
                itemListView = new ListViewItem(str);
                listViewTable.Items.Add(itemListView);
            }
        }

        public void Update_table(DataTable table)
        {
            Dset = table.DataSet;
            Dadapter.Update(Dset);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTable(Request[0]);
            flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowTable(Request[1]);
            flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUser AddUser = new AddUser(this, Dtable, count);
            if (AddUser.ShowDialog() == DialogResult.OK && flag)
            {
                ShowTable(Request[0]);
            }
            else
            {
                ShowTable(Request[1]);
            }
        }

        private void listViewTable_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void listViewTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ChangeUser changeUser = new ChangeUser(this, Dtable, listViewTable.FocusedItem.Index);
                if (changeUser.ShowDialog() == DialogResult.OK && flag)
                {
                    ShowTable(Request[0]);
                }
                else
                {
                    ShowTable(Request[1]);
                }
            }
        }
    }
}
