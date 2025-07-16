namespace NU_Cafe
{
    partial class OrderDetail
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
            this.dtgOrderDetails = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOrderDetails
            // 
            this.dtgOrderDetails.AllowUserToAddRows = false;
            this.dtgOrderDetails.AllowUserToDeleteRows = false;
            this.dtgOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dtgOrderDetails.ColumnHeadersHeight = 29;
            this.dtgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgOrderDetails.Location = new System.Drawing.Point(42, 108);
            this.dtgOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgOrderDetails.Name = "dtgOrderDetails";
            this.dtgOrderDetails.ReadOnly = true;
            this.dtgOrderDetails.RowHeadersWidth = 51;
            this.dtgOrderDetails.RowTemplate.Height = 24;
            this.dtgOrderDetails.Size = new System.Drawing.Size(546, 234);
            this.dtgOrderDetails.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 81);
            this.label6.TabIndex = 38;
            this.label6.Text = "Order Detail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(627, 353);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgOrderDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrderDetails;
        private System.Windows.Forms.Label label6;
    }
}