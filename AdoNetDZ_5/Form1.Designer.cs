namespace AdoNetDZ_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allUsers = new System.Windows.Forms.Button();
            this.admins = new System.Windows.Forms.Button();
            this.Add_User = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTable.ForeColor = System.Drawing.Color.YellowGreen;
            this.listViewTable.FullRowSelect = true;
            this.listViewTable.GridLines = true;
            this.listViewTable.Location = new System.Drawing.Point(13, 134);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(379, 317);
            this.listViewTable.TabIndex = 0;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            this.listViewTable.SelectedIndexChanged += new System.EventHandler(this.listViewTable_SelectedIndexChanged);
            this.listViewTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTable_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Number";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Admin";
            // 
            // allUsers
            // 
            this.allUsers.BackColor = System.Drawing.Color.Lime;
            this.allUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allUsers.Location = new System.Drawing.Point(13, 13);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(137, 23);
            this.allUsers.TabIndex = 1;
            this.allUsers.Text = "Show All Users";
            this.allUsers.UseVisualStyleBackColor = false;
            this.allUsers.Click += new System.EventHandler(this.button1_Click);
            // 
            // admins
            // 
            this.admins.BackColor = System.Drawing.Color.Red;
            this.admins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admins.Location = new System.Drawing.Point(13, 43);
            this.admins.Name = "admins";
            this.admins.Size = new System.Drawing.Size(137, 28);
            this.admins.TabIndex = 2;
            this.admins.Text = "Show admins";
            this.admins.UseVisualStyleBackColor = false;
            this.admins.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_User
            // 
            this.Add_User.BackColor = System.Drawing.Color.Yellow;
            this.Add_User.Location = new System.Drawing.Point(13, 77);
            this.Add_User.Name = "Add_User";
            this.Add_User.Size = new System.Drawing.Size(137, 23);
            this.Add_User.TabIndex = 3;
            this.Add_User.Text = "Add user";
            this.Add_User.UseVisualStyleBackColor = false;
            this.Add_User.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 463);
            this.Controls.Add(this.Add_User);
            this.Controls.Add(this.admins);
            this.Controls.Add(this.allUsers);
            this.Controls.Add(this.listViewTable);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Telephon;
        private System.Windows.Forms.ColumnHeader Admin;
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button allUsers;
        private System.Windows.Forms.Button admins;
        private System.Windows.Forms.Button Add_User;
    }
}

