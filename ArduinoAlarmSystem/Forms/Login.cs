using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ArduinoAlarmSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //UseWaitCursor = true;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string emailParam = "@email";
                string passwordParam = "@password";

                string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                SqlConnection con = new SqlConnection(Alarm); // making connection
                SqlCommand sqlCommand = new SqlCommand("UspLogIn", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter email = new SqlParameter(emailParam, SqlDbType.VarChar, 50);
                email.Direction = ParameterDirection.Input;
                email.Value = txtEmail.Text;
                SqlParameter password = new SqlParameter(passwordParam, SqlDbType.VarChar, 15);
                password.Direction = ParameterDirection.Input;
                password.Value = txtPassword.Text;
                SqlParameter loginSuccessful = new SqlParameter("@tmp", SqlDbType.Bit);
                loginSuccessful.Direction = ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(email);
                sqlCommand.Parameters.Add(password);
                sqlCommand.Parameters.Add(loginSuccessful);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                bool result = Convert.ToBoolean(loginSuccessful.Value);

                if (result)
                {
                    Cursor.Current = Cursors.Default;
                    MenyAfterLogin frmMenyEtterLogin = new MenyAfterLogin();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    Hide();
                    frmMenyEtterLogin.ShowDialog();
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Login failed");
                }
            }
            catch (SqlException sqlerr)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Sql connection error", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            //exit 
            Environment.Exit(1337);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1337);
        }
    }

   
}
