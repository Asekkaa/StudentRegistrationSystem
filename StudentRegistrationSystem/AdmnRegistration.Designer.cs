namespace StudentRegistrationSystem
{
    partial class AdmnRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_New_registration = new System.Windows.Forms.Button();
            this.btnSave_Registration = new System.Windows.Forms.Button();
            this.btnUpdate_Registration = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(133, 137);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(312, 34);
            this.txtUserName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 351);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(411, 185);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 197);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 34);
            this.txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // btn_New_registration
            // 
            this.btn_New_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_New_registration.FlatAppearance.BorderSize = 0;
            this.btn_New_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_registration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New_registration.ForeColor = System.Drawing.Color.White;
            this.btn_New_registration.Location = new System.Drawing.Point(39, 272);
            this.btn_New_registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_New_registration.Name = "btn_New_registration";
            this.btn_New_registration.Size = new System.Drawing.Size(84, 37);
            this.btn_New_registration.TabIndex = 37;
            this.btn_New_registration.Text = "New";
            this.btn_New_registration.UseVisualStyleBackColor = false;
            this.btn_New_registration.Click += new System.EventHandler(this.btn_New_registration_Click);
            // 
            // btnSave_Registration
            // 
            this.btnSave_Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave_Registration.FlatAppearance.BorderSize = 0;
            this.btnSave_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Registration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Registration.ForeColor = System.Drawing.Color.White;
            this.btnSave_Registration.Location = new System.Drawing.Point(148, 272);
            this.btnSave_Registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave_Registration.Name = "btnSave_Registration";
            this.btnSave_Registration.Size = new System.Drawing.Size(84, 37);
            this.btnSave_Registration.TabIndex = 38;
            this.btnSave_Registration.Text = "Save";
            this.btnSave_Registration.UseVisualStyleBackColor = false;
            this.btnSave_Registration.Click += new System.EventHandler(this.btnSave_Registration_Click);
            // 
            // btnUpdate_Registration
            // 
            this.btnUpdate_Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate_Registration.FlatAppearance.BorderSize = 0;
            this.btnUpdate_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Registration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Registration.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Registration.Location = new System.Drawing.Point(255, 272);
            this.btnUpdate_Registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate_Registration.Name = "btnUpdate_Registration";
            this.btnUpdate_Registration.Size = new System.Drawing.Size(84, 37);
            this.btnUpdate_Registration.TabIndex = 39;
            this.btnUpdate_Registration.Text = "Update";
            this.btnUpdate_Registration.UseVisualStyleBackColor = false;
            this.btnUpdate_Registration.Click += new System.EventHandler(this.btnUpdate_Registration_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(364, 272);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 37);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AdmnRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 656);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btnUpdate_Registration);
            this.Controls.Add(this.btnSave_Registration);
            this.Controls.Add(this.btn_New_registration);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AdmnRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmnRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_New_registration;
        public System.Windows.Forms.Button btnSave_Registration;
        public System.Windows.Forms.Button btnUpdate_Registration;
        public System.Windows.Forms.Button btn_Delete;
    }
}