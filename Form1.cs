using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NU_Cafe
{
    public partial class LoginView : Form
    {
        SqlConnection connection;
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["NU_Cafe.Properties.Settings.NU_CafeDBConnectionString"].ConnectionString;
                connection = new SqlConnection(connectionString);
                if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtPw.Text))
                {
                    lblFeedback.Text = "Please enter username and password.";
                    return;
                }
                else
                {
                    using (connection)
                    {
                        connection.Open();
                        string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        using (adapter)
                        {
                            command.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                            command.Parameters.AddWithValue("@password", txtPw.Text.Trim());
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                string role = result.ToString();
                                DashboardView dashboard = new DashboardView();

                                if (role == "admin")
                                {
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else if (role == "seller")
                                {
                                    TabControl tabControl = dashboard.Controls["MainTab"] as TabControl;
                                    if (tabControl != null)
                                    {
                                        TabPage tpOrder = tabControl.TabPages["tpOrder"];

                                        if (tpOrder != null)
                                        {
                                            tabControl.SelectedTab = tpOrder;

                                            // Hide other tabs
                                            foreach (TabPage tab in tabControl.TabPages)
                                            {
                                                if (tab != tpOrder)
                                                {
                                                    tabControl.TabPages.Remove(tab);
                                                }
                                            }

                                        }

                                        dashboard.Show();
                                        this.Hide();
                                    }

                                }
                            }
                            else
                            {
                                lblFeedback.Text = "Incorrect username or password.";
                                txtusername.Focus();
                            }   
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection?.Close();
            }
        }
        private void ClearField()
        {
            txtusername.Text = "";
            txtPw.Text = "";
            cbPw.Checked = false;
            lblFeedback.Text = "";
            txtusername.Focus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }
        private void cbPw_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPw.Checked == true)
            {
                txtPw.UseSystemPasswordChar = false;
            }
            else
            {
                txtPw.UseSystemPasswordChar = true;
            }
        }
    }
}
