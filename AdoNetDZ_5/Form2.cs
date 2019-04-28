using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDZ_5
{
    public partial class AddUser : Form
    {

        private DataTable dataTable = null;
        private Form1 Form = null;
        private int countRows = 0;

        public AddUser(Form1 form, DataTable dTable, int num)
        {
            InitializeComponent();
            dataTable = dTable;
            Form = form;
            countRows = num;            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполненны!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString().Equals(textBox1.Text))
                {
                    MessageBox.Show("Такой Login существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DataRow row = dataTable.NewRow();
            row["Id"] = countRows -2;
            row["Login"] = textBox1.Text;
            row["Password"] = textBox2.Text;            
            row["Telefon"] = textBox3.Text;
            row["Administrator"] = 0;

            dataTable.Rows.Add(row);
            Form.Update_table(dataTable);
            this.DialogResult = DialogResult.OK;
        }
    }
}
