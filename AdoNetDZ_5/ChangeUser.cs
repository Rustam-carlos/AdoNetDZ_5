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
    public partial class ChangeUser : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int number_Rows = 0;
        public ChangeUser(Form1 form, DataTable Dtable, int num)
        {
            InitializeComponent();
            Form = form;
            dataTable = Dtable;
            number_Rows = num;
            Change.Click += Change_Click;
            Delete.Click += Delete_Click;
            cancle.Click += cancle_Click;
            textBox1.Text = Dtable.Rows[num][1].ToString();
            textBox2.Text = Dtable.Rows[num][2].ToString();
            textBox3.Text = Dtable.Rows[num][3].ToString();              
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dataTable.Rows[number_Rows].Delete();
            Form.Update_table(dataTable);
            this.DialogResult = DialogResult.OK;
        }

        private void Change_Click(object sender, EventArgs e)
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

            dataTable.Rows[number_Rows][1] = textBox1.Text.ToString();
            dataTable.Rows[number_Rows][2] = textBox2.Text.ToString();
            dataTable.Rows[number_Rows][3] = textBox3.Text.ToString();            
            
            Form.Update_table(dataTable);
            this.DialogResult = DialogResult.OK;
        }
    }
}
