﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_st_registration_Click(object sender, EventArgs e)
        {
            st_registration_form obj = new st_registration_form();
            obj.Show();
        }

        private void btn_teach_registration_Click(object sender, EventArgs e)
        {
            Teacher_Form obj = new Teacher_Form();
            obj.Show();
        }

        private void btn_fees_Click(object sender, EventArgs e)
        {
            Fees_Form obj = new Fees_Form();
            obj.Show();
        }

        private void btn_records_Click(object sender, EventArgs e)
        {
            Records obj = new Records();
            obj.Show();
        }

        private void btn_admin_registration_Click(object sender, EventArgs e)
        {
            AdmnRegistration admn = new AdmnRegistration();
            admn.Show();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
