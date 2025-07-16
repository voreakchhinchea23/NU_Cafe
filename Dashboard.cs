using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NU_Cafe
{
    public partial class DashboardView : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public DashboardView()
        {
            InitializeComponent();

            DashboardView_Load();
            
        }

        // This method is called to initialize the form and set up the database connection
        private void myCon()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NU_Cafe.Properties.Settings.NU_CafeDBConnectionString"].ConnectionString;
            con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        // Load every tab/table
        private void DashboardView_Load()
        {
            // TODO: This line of code loads data into the 'nU_CafeDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nU_CafeDBDataSet.Products);
            ShowProducts();
            ShowInventory();
            ShowUsers();
            ShowSupplier();
            // all orders datatable and order details datatable
            ShowOrders();
            ShowProductsToOrders();
            ShowStaff();
            // all reports datatable
            ShowSaleReports();
            ShowPopularProducts();
            ShowOutstandingStaff();

        }

        //
        // Menu management
        //
        private void btnMenuCancel_Click(object sender, EventArgs e)
        {
            ClearMenuFields();
        }
        private void ClearMenuFields()
        {
            txtProductName.Text = string.Empty;
            txtCate.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtProductID.Text = string.Empty;
            cbIsAvailable.Checked = false;
            dtgMenu.ClearSelection();
            txtProductName.Focus();
        }
        private void ShowProducts()
        {
            try
            {
                myCon();
                string query = "SELECT ProductId, Name, Price, Category, Description, IsAvailable FROM Products";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        clProductId.DataPropertyName = "ProductId";
                        clName.DataPropertyName = "Name";
                        clPrice.DataPropertyName = "Price";
                        clCate.DataPropertyName = "Category";
                        clDesc.DataPropertyName = "Description";
                        clAvailable.DataPropertyName = "IsAvailable";

                        clPrice.DefaultCellStyle.Format = "#,##0៛"; 

                        dtgMenu.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void ShowSelectedProducts()
        {
            if (dtgMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgMenu.SelectedRows[0];
                txtProductName.Text = selectedRow.Cells["clName"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["clPrice"].Value.ToString();
                txtCate.Text = selectedRow.Cells["clCate"].Value.ToString();
                txtDesc.Text = selectedRow.Cells["clDesc"].Value.ToString();
                txtProductID.Text = selectedRow.Cells["clProductId"].Value.ToString();

                if (selectedRow.Cells["clAvailable"].Value != null)
                {
                    bool isAvailable;

                    if (bool.TryParse(selectedRow.Cells["clAvailable"].Value.ToString(), out isAvailable))
                    {
                        cbIsAvailable.Checked = isAvailable;
                    }
                    else
                    {
                        cbIsAvailable.Checked = false;
                    }
                }
            }
        }
        private void dtgMenu_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelectedProducts();
            if (dtgMenu.SelectedRows.Count > 0)
            {
                btnMenuSave.Text = "Update";
            }
            else
            {
                btnMenuSave.Text = "Save";
            }

        }
        private void btnMenuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtCate.Text))
                {
                    return;
                }
                else
                {
                    myCon();
                    if (string.IsNullOrEmpty(txtProductID.Text))
                    {
                        // Save
                        string query = "INSERT INTO Products (Name, Price, Category, Description, IsAvailable) VALUES (@Name, @Price, @Category, @Description, 1)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to UPDATE this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Update
                            string query = "UPDATE Products SET Name = @Name, Price = @Price, Category = @Category, Description = @Description, IsAvailable = @IsAvailable WHERE ProductId = @ProductId";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductID.Text));
                        }

                    }

                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Category", txtCate.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDesc.Text.Trim());
                    cmd.Parameters.AddWithValue("@IsAvailable", cbIsAvailable.Checked);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowProducts();
                ClearMenuFields();
            }

        }
        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to DELETE this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtProductID.Text))
                    {
                        MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    myCon();
                    string query = "DELETE FROM Products WHERE ProductId = @ProductId";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(txtProductID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowProducts();
                ClearMenuFields();
            }
        }

        //
        // Inventory management
        //
        private void btnInventoryCancel_Click(object sender, EventArgs e)
        {
            ClearInventoryFields();
        }
        private void ClearInventoryFields()
        {
            txtInventoryName.Text = string.Empty;
            txtInventoryQty.Text = string.Empty;
            txtInventoryUnit.Text = string.Empty;
            txtInventoryReorder.Text = string.Empty;
            txtInventorySupplier.Text = string.Empty;
            txtInventoryName.Focus();
            dtgInventory.ClearSelection();
        }
        private void ShowInventory()
        {
            try
            {
                myCon();
                string query = "SELECT InventoryID, ItemName, Quantity, Unit, ReorderLevel, SupplierID FROM Inventories";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        clInventoryID.DataPropertyName = "InventoryID";
                        clInventoryName.DataPropertyName = "ItemName";
                        clInventoryQty.DataPropertyName = "Quantity";
                        clInventoryUnit.DataPropertyName = "Unit";
                        clReorder.DataPropertyName = "ReorderLevel";
                        clSupplier.DataPropertyName = "SupplierID";
                        dtgInventory.DataSource = dataTable.DefaultView;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnInventorySave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInventoryName.Text) || string.IsNullOrEmpty(txtInventoryQty.Text) || string.IsNullOrEmpty(txtInventoryUnit.Text) || string.IsNullOrEmpty(txtInventoryReorder.Text) || string.IsNullOrEmpty(txtInventorySupplier.Text))
                {
                    return;
                }
                else
                {
                    myCon();
                    if (string.IsNullOrEmpty(txtInventoryID.Text))
                    {
                        // Save
                        string query = "INSERT INTO Inventories (ItemName, Quantity, Unit, ReorderLevel, SupplierID) VALUES (@ItemName, @Quantity, @Unit, @ReorderLevel, @SupplierID)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to UPDATE the inventory item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Update
                            string query = "UPDATE Inventories SET ItemName = @ItemName, Quantity = @Quantity, Unit = @Unit, ReorderLevel = @ReorderLevel, SupplierID = @SupplierID WHERE InventoryID = @InventoryID";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@InventoryID", Convert.ToInt32(txtInventoryID.Text));
                        }
                    }
                    cmd.Parameters.AddWithValue("@ItemName", txtInventoryName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtInventoryQty.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Unit", txtInventoryUnit.Text.Trim());
                    cmd.Parameters.AddWithValue("@ReorderLevel", Convert.ToInt32(txtInventoryReorder.Text.Trim()));
                    cmd.Parameters.AddWithValue("@SupplierID", txtInventorySupplier.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowInventory();
                ClearInventoryFields();
            }
        }
        private void dtgInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgInventory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgInventory.SelectedRows[0];
                txtInventoryName.Text = selectedRow.Cells["clInventoryName"].Value.ToString();
                txtInventoryQty.Text = selectedRow.Cells["clInventoryQty"].Value.ToString();
                txtInventoryUnit.Text = selectedRow.Cells["clInventoryUnit"].Value.ToString();
                txtInventoryReorder.Text = selectedRow.Cells["clReorder"].Value.ToString();
                txtInventorySupplier.Text = selectedRow.Cells["clSupplier"].Value.ToString();
                txtInventoryID.Text = selectedRow.Cells["clInventoryID"].Value.ToString();

                btnInventorySave.Text = "Update";
            }
            else
            {
                btnInventorySave.Text = "Save";
            }
        }
        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myCon();
                string query = "DELETE FROM Inventories WHERE InventoryID = @InventoryID";
                if (MessageBox.Show("Are you sure you want to DELETE this inventory item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtInventoryID.Text))
                    {
                        MessageBox.Show("Please select an inventory item to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@InventoryID", Convert.ToInt32(txtInventoryID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowInventory();
                ClearInventoryFields();
            }
        }

        //
        // User management
        //
        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            ClearUserFields();
        }
        private void ClearUserFields()
        {
            txtUserID.Text = string.Empty;
            txtFullname.Text = string.Empty;
            txtSetPw.Text = string.Empty;
            txtSetusername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtRole.Text = string.Empty;
            cbUserPw.Checked = false;
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            rbtnOther.Checked = false;
            dtgUsers.ClearSelection();
            txtFullname.Focus();
        }
        private void ShowUsers()
        {
            try
            {
                myCon();
                string query = "SELECT UserID, Username, Password, Fullname, ContactNumber, Role, Gender, Email FROM Users";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        UserID.DataPropertyName = "UserID";
                        clFullName.DataPropertyName = "Fullname";
                        clGender.DataPropertyName = "Gender";
                        clRole.DataPropertyName = "Role";
                        clEmail.DataPropertyName = "Email";
                        clUsername.DataPropertyName = "Username";
                        clPw.DataPropertyName = "Password"; // Password column for internal use only
                        clPw.Visible = false; // Hide password column for security reasons
                        clUserContact.DataPropertyName = "ContactNumber";
                        dtgUsers.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
        private void cbUserPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUserPw.Checked)
            {
                txtSetPw.UseSystemPasswordChar = false;
                cbUserPw.Text = "👁️‍🗨";
            }
            else
            {
                txtSetPw.UseSystemPasswordChar = true;
                cbUserPw.Text = "👁";

            }
        }
        private void dtgUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgUsers.SelectedRows[0];
                txtUserID.Text = selectedRow.Cells["UserID"].Value.ToString();
                txtFullname.Text = selectedRow.Cells["clFullName"].Value.ToString();
                txtSetusername.Text = selectedRow.Cells["clUsername"].Value.ToString();
                txtSetPw.Text = "********";
                txtEmail.Text = selectedRow.Cells["clEmail"].Value.ToString();
                txtContact.Text = selectedRow.Cells["clUserContact"].Value.ToString();
                txtRole.Text = selectedRow.Cells["clRole"].Value.ToString();
                // Handle gender radio buttons
                string gender = selectedRow.Cells["clGender"].Value.ToString().ToLower();
                rbtnMale.Checked = gender == "male";
                rbtnFemale.Checked = gender == "female";
                rbtnOther.Checked = gender == "other" || string.IsNullOrEmpty(gender);

                btnUserSave.Text = "Update";
            }
            else
            {
                btnUserSave.Text = "Save";
            }
        }
        private string GetSelectedGender()
        {
            if (rbtnMale.Checked)
                return "Male";
            else if (rbtnFemale.Checked)
                return "Female";
            else if (rbtnOther.Checked)
                return "Other";
            else
                return ""; // Default if no radio button is selected
        }
        private void btnUserSave_Click(object sender, EventArgs e)
        {
            try
            {
                myCon();
                if (string.IsNullOrEmpty(txtFullname.Text) || string.IsNullOrEmpty(txtSetusername.Text) || string.IsNullOrEmpty(txtSetPw.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtContact.Text) || string.IsNullOrEmpty(txtRole.Text))
                {
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtUserID.Text))
                    {
                        // Save
                        string query = "INSERT INTO Users (Username, Password, Fullname, ContactNumber, Role, Email,Gender) " +
                                        "VALUES (@Username, @Password, @Fullname, @ContactNumber, @Role, @Email, @Gender)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to UPDATE this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Update
                            string query = "UPDATE Users SET Username = @Username, Fullname = @Fullname, " +
                                            "ContactNumber = @ContactNumber, Role = @Role, Email = @Email, Gender = @Gender " +
                                            "WHERE UserID = @UserID";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(txtUserID.Text));
                        }
                    }
                    cmd.Parameters.AddWithValue("@Username", txtSetusername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtSetPw.Text.Trim()); // Store password securely in production
                    cmd.Parameters.AddWithValue("@Fullname", txtFullname.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Role", txtRole.Text.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", GetSelectedGender());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowUsers();
                ClearUserFields();
            }
        }
        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myCon();
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                if (MessageBox.Show("Are you sure you want to DELETE this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtUserID.Text))
                    {
                        MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(txtUserID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowUsers();
                ClearUserFields();
            }
        }

        //
        // Supplier management
        //
        private void btnSupplierCancel_Click(object sender, EventArgs e)
        {
            ClearSupplierFields();
        }
        private void ClearSupplierFields()
        {
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtSupplierContact.Text = string.Empty;
            txtSupplierEmail.Text = string.Empty;
            txtSupplierAddress.Text = string.Empty;
            dtgSupplier.ClearSelection();
            txtSupplierName.Focus();
        }
        private void ShowSupplier()
        {
            try
            {
                myCon();
                string query = "SELECT SupplierID, Name, Contact, Email, Address FROM Suppliers";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        clSupplierID.DataPropertyName = "SupplierID";
                        clSupplierName.DataPropertyName = "Name";
                        clSupplierContact.DataPropertyName = "Contact";
                        clSupplierEmail.DataPropertyName = "Email";
                        clSupplierAddress.DataPropertyName = "Address";
                        dtgSupplier.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void dtgSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgSupplier.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgSupplier.SelectedRows[0];
                txtSupplierID.Text = selectedRow.Cells["clSupplierID"].Value.ToString();
                txtSupplierName.Text = selectedRow.Cells["clSupplierName"].Value.ToString();
                txtSupplierContact.Text = selectedRow.Cells["clSupplierContact"].Value.ToString();
                txtSupplierEmail.Text = selectedRow.Cells["clSupplierEmail"].Value.ToString();
                txtSupplierAddress.Text = selectedRow.Cells["clSupplierAddress"].Value.ToString();
                btnSupplierSave.Text = "Update";
            }
            else
            {
                btnSupplierSave.Text = "Save";
            }
        }
        private void btnSupplierSave_Click(object sender, EventArgs e)
        {
            try
            {
                myCon();
                if (string.IsNullOrEmpty(txtSupplierAddress.Text) || string.IsNullOrEmpty(txtSupplierContact.Text) || string.IsNullOrEmpty(txtSupplierEmail.Text) || string.IsNullOrEmpty(txtSupplierName.Text))
                {
                    return;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSupplierID.Text))
                    {
                        // Save
                        string query = "INSERT INTO Suppliers (Name, Contact, Email, Address) VALUES (@Name, @Contact, @Email, @Address)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to UPDATE this supplier?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Update
                            string query = "UPDATE Suppliers SET Name = @Name, Contact = @Contact, Email = @Email, Address = @Address WHERE SupplierID = @SupplierID";
                            cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@SupplierID", Convert.ToInt32(txtSupplierID.Text));
                        }
                    }
                    cmd.Parameters.AddWithValue("@Name", txtSupplierName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Contact", txtSupplierContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtSupplierEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtSupplierAddress.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowSupplier();
                ClearSupplierFields();
            }
        }
        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSupplierID.Text))
                {
                    MessageBox.Show("Please select a supplier to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                myCon();
                string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                if (MessageBox.Show("Are you sure you want to DELETE this supplier?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SupplierID", Convert.ToInt32(txtSupplierID.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ShowSupplier();
                ClearSupplierFields();
            }
        }

        //
        // Order Management
        //
        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            ClearOrderFields();
        }
        private void ClearOrderFields()
        {
            txtOrderedProduct.Text = string.Empty;
            txtQty.Text = string.Empty;
            comboStaff.Text = string.Empty;
            txtOrderedPrice.Text = string.Empty;
            dtgOrderMenu.ClearSelection();
            dtgOrders.ClearSelection();
            txtQty.Focus();
        }
        private void ShowOrders()
        {
            try
            {
                myCon();
                string query = "SELECT OrderID, StaffID, TotalAmount, OrderDate FROM Orders ORDER BY OrderDate DESC";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        clOrderId.DataPropertyName = "OrderID";
                        clStaff.DataPropertyName = "StaffID";
                        clOrderTotal.DataPropertyName = "TotalAmount";
                        clOrderDate.DataPropertyName = "OrderDate";

                        clOrderTotal.DefaultCellStyle.Format = "#,##0៛";
                        clOrderDate.DefaultCellStyle.Format = "dd/MMM/yyyy HH:mm"; 

                        dtgOrders.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void ShowProductsToOrders()
        {
            try
            {
                myCon();
                string query = "SELECT ProductId, Name, Price FROM Products WHERE IsAvailable = 1"; // Only show available products
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        clOrderProductID.DataPropertyName = "ProductId";
                        clOrderProductName.DataPropertyName = "Name";
                        clOrderPrice.DataPropertyName = "Price";
                        dtgOrderMenu.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnOrderRefresh_Click(object sender, EventArgs e)
        {
            ShowProductsToOrders();
            ClearOrderFields();
            comboStaff.Enabled = true;
            llbOrderDetail.Enabled = true;
        }
        private void llbOrderDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // In case users click it more than once
            if (llbOrderDetail.Enabled)
            {
                llbOrderDetail.Enabled = false;
                ShowOrderDetails();
            }
        }
        private void ShowOrderDetails()
        {
            try
            {
                myCon();
                string query = "SELECT OrderDetailID, OrderID, ProductID, Quantity, UnitPrice FROM OrderDetails ORDER BY OrderDetailID";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        orderDetail.DisplayOrderDetails(dataTable);
                        orderDetail.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderedProduct.Text) || string.IsNullOrWhiteSpace(comboStaff.Text))
            {
                MessageBox.Show("Please select a product and staff member.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (greater than 0).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            DataTable dataTable = dtgCart.DataSource as DataTable;

            if (dataTable == null)
            {
                // Initialize DataTable if it doesn't exist
                dataTable = new DataTable();
                dataTable.Columns.Add("ProductID", typeof(int));
                dataTable.Columns.Add("ProductName", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(int));
                dataTable.Columns.Add("StaffID", typeof(int));
                dataTable.Columns.Add("UnitPrice", typeof(decimal));

                dtgCart.DataSource = dataTable;
            }

            // Add new row to the DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["ProductID"] = Convert.ToInt32(txtProductHiddenID.Text);
            newRow["ProductName"] = txtOrderedProduct.Text;
            newRow["Quantity"] = quantity;
            newRow["StaffID"] = comboStaff.SelectedValue;
            //newRow["UnitPrice"] = Convert.ToDecimal(txtOrderedPrice.Text);
            newRow["UnitPrice"] = dtgOrderMenu.SelectedRows[0].Cells["clOrderPrice"].Value; 

            dataTable.Rows.Add(newRow);

            // Clear inputs for next item
            txtOrderedProduct.Clear();
            txtQty.Clear();
            txtProductHiddenID.Clear();
            comboStaff.Enabled = false;
            txtOrderedPrice.Clear();
        }
        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dtgCart.Rows)
            {
                if (row.Cells["UnitPrice"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    totalAmount += unitPrice * quantity;
                }
            }
            return totalAmount;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                myCon();
                if (dtgCart.Rows.Count == 0)
                {
                    MessageBox.Show("Please add items to the cart before placing an order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Insert order into Orders table
                string insertOrderQuery = "INSERT INTO Orders (StaffID, TotalAmount, OrderDate) VALUES (@StaffID, @TotalAmount, @OrderDate); SELECT SCOPE_IDENTITY();";
                cmd = new SqlCommand(insertOrderQuery, con);
                cmd.Parameters.AddWithValue("@StaffID", comboStaff.SelectedValue);
                cmd.Parameters.AddWithValue("@TotalAmount", CalculateTotalAmount());
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                // Insert each item in the cart into OrderDetails table
                foreach (DataGridViewRow row in dtgCart.Rows)
                {
                    string insertOrderDetailQuery = "INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice)";
                    using (cmd= new SqlCommand(insertOrderDetailQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(row.Cells["ProductID"].Value));
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                        cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(row.Cells["UnitPrice"].Value));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                dtgCart.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                ClearOrderFields();
                ShowOrders();
                comboStaff.Enabled = true;
            }
        }
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dtgCart.SelectedRows.Count > 0)
            {
                dtgCart.Rows.RemoveAt(dtgCart.SelectedRows[0].Index);
            }
        }
        private void ShowStaff()
        {
            try
            {
                myCon();
                string query = "SELECT UserID, Fullname FROM Users";
                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        comboStaff.DataSource = dataTable;
                        comboStaff.DisplayMember = "Fullname"; // display Fullname in the ComboBox
                        comboStaff.ValueMember = "UserID"; // use UserID as the value
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void dtgOrderMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgOrderMenu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgOrderMenu.SelectedRows[0];
                txtOrderedProduct.Text = selectedRow.Cells["clOrderProductName"].Value.ToString();
                txtProductHiddenID.Text = selectedRow.Cells["clOrderProductID"].Value.ToString();
                txtOrderedPrice.Text = selectedRow.Cells["clOrderPrice"].Value.ToString();
                txtQty.Text = "1"; // default quantity to 1
                txtQty.Focus();
            }
        }
        private void dtgOrders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is actually selected
                if (dtgOrders.SelectedRows.Count == 0) return;

                myCon();
                string query = "SELECT OrderDetailID, OrderID, ProductID, Quantity, UnitPrice FROM OrderDetails WHERE OrderID = @SelectedOrderID";

                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SelectedOrderID", Convert.ToInt32(dtgOrders.SelectedRows[0].Cells["clOrderId"].Value));

                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.DisplayOrderDetails(dataTable);
                        orderDetail.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtQty.Text, out Int32 qty) || qty <= 0) // convert quantity to integer
            {
                return;
            }
            qty++;
            double total = qty * Convert.ToDouble(dtgOrderMenu.SelectedRows[0].Cells["clOrderPrice"].Value); 
            txtQty.Text = qty.ToString();
            txtOrderedPrice.Text = total.ToString();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtQty.Text, out Int32 qty) || qty <= 0) // convert quantity to integer
            {
                return;
            }
            qty--;
            double total = qty * Convert.ToDouble(dtgOrderMenu.SelectedRows[0].Cells["clOrderPrice"].Value);
            txtQty.Text = qty.ToString();
            txtOrderedPrice.Text = total.ToString();
        }

        //
        // Reports
        //
        private void ShowSaleReports()
        {
            try
            {
                myCon();
                string query = @"
                               SELECT 
                               CONVERT(date, OrderDate) AS [OrderDate],  
                               SUM(TotalAmount) AS [Total] 
                               FROM Orders 
                               GROUP BY CONVERT(date, OrderDate)  
                               ORDER BY [OrderDate] DESC;";

                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        clReportDate.DataPropertyName = "OrderDate";
                        clReportDate.DefaultCellStyle.Format = "dd/MMM/yyyy";
                        clReportTotalAmount.DataPropertyName = "Total";
                        clReportTotalAmount.DefaultCellStyle.Format = "#,##0៛";
                        dtgSalesReport.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        
        }
        private void ShowPopularProducts()
        {
            try
            {
                myCon();
                string query = @"
                               SELECT TOP 5 
                               p.Name AS [ProductName], 
                               SUM(od.Quantity) AS [TotalSold] 
                               FROM OrderDetails od 
                               JOIN Products p ON od.ProductID = p.ProductId 
                               GROUP BY p.Name 
                               ORDER BY SUM(od.Quantity) DESC;";

                using (cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        colPopularProducts.DataPropertyName = "ProductName";
                        colTotalQty.DataPropertyName = "TotalSold";
                        dtgPopularItems.DataSource = dataTable.DefaultView;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void ShowOutstandingStaff()
        {
            try
            {
                myCon();
                string query = @"
                               SELECT TOP 5 
                               u.Fullname AS [StaffName], 
                               SUM(o.TotalAmount) AS [TotalSales] 
                               FROM Orders o 
                               JOIN Users u ON o.StaffID = u.UserID 
                               GROUP BY u.Fullname 
                               ORDER BY SUM(o.TotalAmount) DESC;";
                using(cmd = new SqlCommand(query, con))
                {
                    using (da = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);
                        colStaffName.DataPropertyName = "StaffName";
                        colTotalSold.DataPropertyName = "TotalSales";
                        colTotalSold.DefaultCellStyle.Format = "#,##0៛"; 
                        dtgOutstanding.DataSource = dataTable.DefaultView;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            ShowPopularProducts();
            ShowSaleReports();
            ShowOutstandingStaff();
            
        }
        private void dtpSaleReport_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                myCon();
                string query = @"
                               SELECT 
                               CONVERT(date, OrderDate) AS [OrderDate],  
                               SUM(TotalAmount) AS [Total] 
                               FROM Orders 
                               WHERE CONVERT(date, OrderDate) = @SelectedDate
                               GROUP BY CONVERT(date, OrderDate)  
                               ORDER BY [OrderDate] DESC;";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SelectedDate", dtpSaleReport.Value.Date);
                using (da = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    clReportDate.DataPropertyName = "OrderDate";
                    clReportDate.DefaultCellStyle.Format = "dd/MMM/yyyy";
                    clReportTotalAmount.DataPropertyName = "Total";
                    clReportTotalAmount.DefaultCellStyle.Format = "#,##0៛";
                    dtgSalesReport.DataSource = dataTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpSaleReport.Value = DateTime.Now; 
        }

        
    }
}