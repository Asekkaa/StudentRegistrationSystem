using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistrationSystem
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        connection con = new connection();
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter adpt;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_UserName.Text != "" && txtPassword.Text != "")
                {
                    cmd = new SqlCommand("select * from Registration where UserName=@UserName and UserPassword=@UserPassword", con.opencon());
                    cmd.Parameters.Add("@UserName", txt_UserName.Text);
                    cmd.Parameters.Add("@UserPassword", txtPassword.Text);
                    adpt = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        if (txt_UserName.Text == "admin")
                        {
                            MessageBox.Show(" You Have Successfully Logged in ");
                            this.Hide();
                            Form1 obj = new Form1();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show(" You Have Successfully Logged in ");
                            this.Hide();
                            Form1 obj = new Form1();
                            obj.btn_admin_registration.Enabled = false;
                            obj.Show();
                        }
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
