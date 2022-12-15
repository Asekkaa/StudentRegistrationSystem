namespace StudentRegistrationSystem
{
    partial class Records
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
            this.btn_Student_Record = new System.Windows.Forms.Button();
            this.btn_teacher_record = new System.Windows.Forms.Button();
            this.btn_Fees_record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Student_Record
            // 
            this.btn_Student_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Student_Record.FlatAppearance.BorderSize = 0;
            this.btn_Student_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student_Record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_Record.ForeColor = System.Drawing.Color.White;
            this.btn_Student_Record.Location = new System.Drawing.Point(16, 140);
            this.btn_Student_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Student_Record.Name = "btn_Student_Record";
            this.btn_Student_Record.Size = new System.Drawing.Size(171, 47);
            this.btn_Student_Record.TabIndex = 1;
            this.btn_Student_Record.Text = "Student Record";
            this.btn_Student_Record.UseVisualStyleBackColor = false;
            this.btn_Student_Record.Click += new System.EventHandler(this.btn_Student_Record_Click);
            // 
            // btn_teacher_record
            // 
            this.btn_teacher_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_teacher_record.FlatAppearance.BorderSize = 0;
            this.btn_teacher_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_record.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_record.Location = new System.Drawing.Point(217, 140);
            this.btn_teacher_record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_teacher_record.Name = "btn_teacher_record";
            this.btn_teacher_record.Size = new System.Drawing.Size(171, 47);
            this.btn_teacher_record.TabIndex = 2;
            this.btn_teacher_record.Text = "Teacher Record";
            this.btn_teacher_record.UseVisualStyleBackColor = false;
            this.btn_teacher_record.Click += new System.EventHandler(this.btn_teacher_record_Click);
            // 
            // btn_Fees_record
            // 
            this.btn_Fees_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Fees_record.FlatAppearance.BorderSize = 0;
            this.btn_Fees_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fees_record.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fees_record.ForeColor = System.Drawing.Color.White;
            this.btn_Fees_record.Location = new System.Drawing.Point(419, 140);
            this.btn_Fees_record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Fees_record.Name = "btn_Fees_record";
            this.btn_Fees_record.Size = new System.Drawing.Size(171, 47);
            this.btn_Fees_record.TabIndex = 3;
            this.btn_Fees_record.Text = "Fees Record";
            this.btn_Fees_record.UseVisualStyleBackColor = false;
            this.btn_Fees_record.Click += new System.EventHandler(this.btn_Fees_record_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 313);
            this.Controls.Add(this.btn_Fees_record);
            this.Controls.Add(this.btn_teacher_record);
            this.Controls.Add(this.btn_Student_Record);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Student_Record;
        public System.Windows.Forms.Button btn_teacher_record;
        public System.Windows.Forms.Button btn_Fees_record;
    }
}