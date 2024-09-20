namespace LN_InventoryApp
{
    partial class LNInventoryForm
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
            this.ln_lblStoreName = new System.Windows.Forms.Label();
            this.ln_lblName = new System.Windows.Forms.Label();
            this.ln_lblAccountNo = new System.Windows.Forms.Label();
            this.ln_txtBxName = new System.Windows.Forms.TextBox();
            this.ln_txtBxAccountNo = new System.Windows.Forms.TextBox();
            this.ln_lblQuantity = new System.Windows.Forms.Label();
            this.ln_txtBxQuantity = new System.Windows.Forms.TextBox();
            this.ln_lblReceive = new System.Windows.Forms.Label();
            this.ln_txtBxReceive = new System.Windows.Forms.TextBox();
            this.ln_lblIssue = new System.Windows.Forms.Label();
            this.ln_txtBxIssue = new System.Windows.Forms.TextBox();
            this.ln_btnCreate = new System.Windows.Forms.Button();
            this.ln_btnUpdate = new System.Windows.Forms.Button();
            this.ln_lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ln_lblStoreName
            // 
            this.ln_lblStoreName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_lblStoreName.AutoSize = true;
            this.ln_lblStoreName.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblStoreName.ForeColor = System.Drawing.Color.Khaki;
            this.ln_lblStoreName.Location = new System.Drawing.Point(26, 9);
            this.ln_lblStoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblStoreName.Name = "ln_lblStoreName";
            this.ln_lblStoreName.Size = new System.Drawing.Size(314, 34);
            this.ln_lblStoreName.TabIndex = 0;
            this.ln_lblStoreName.Text = "Long Nguyen Store";
            // 
            // ln_lblName
            // 
            this.ln_lblName.AutoSize = true;
            this.ln_lblName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblName.Location = new System.Drawing.Point(29, 64);
            this.ln_lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblName.Name = "ln_lblName";
            this.ln_lblName.Size = new System.Drawing.Size(79, 14);
            this.ln_lblName.TabIndex = 1;
            this.ln_lblName.Text = "Item Name:";
            // 
            // ln_lblAccountNo
            // 
            this.ln_lblAccountNo.AutoSize = true;
            this.ln_lblAccountNo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblAccountNo.Location = new System.Drawing.Point(29, 103);
            this.ln_lblAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblAccountNo.Name = "ln_lblAccountNo";
            this.ln_lblAccountNo.Size = new System.Drawing.Size(119, 14);
            this.ln_lblAccountNo.TabIndex = 2;
            this.ln_lblAccountNo.Text = "Item Account No:";
            this.ln_lblAccountNo.Visible = false;
            // 
            // ln_txtBxName
            // 
            this.ln_txtBxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_txtBxName.Location = new System.Drawing.Point(158, 61);
            this.ln_txtBxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_txtBxName.Name = "ln_txtBxName";
            this.ln_txtBxName.Size = new System.Drawing.Size(159, 22);
            this.ln_txtBxName.TabIndex = 3;
            // 
            // ln_txtBxAccountNo
            // 
            this.ln_txtBxAccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_txtBxAccountNo.Location = new System.Drawing.Point(158, 100);
            this.ln_txtBxAccountNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_txtBxAccountNo.Name = "ln_txtBxAccountNo";
            this.ln_txtBxAccountNo.Size = new System.Drawing.Size(159, 22);
            this.ln_txtBxAccountNo.TabIndex = 4;
            this.ln_txtBxAccountNo.Visible = false;
            // 
            // ln_lblQuantity
            // 
            this.ln_lblQuantity.AutoSize = true;
            this.ln_lblQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblQuantity.Location = new System.Drawing.Point(29, 142);
            this.ln_lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblQuantity.Name = "ln_lblQuantity";
            this.ln_lblQuantity.Size = new System.Drawing.Size(126, 14);
            this.ln_lblQuantity.TabIndex = 5;
            this.ln_lblQuantity.Text = "Quantity On-hand:";
            // 
            // ln_txtBxQuantity
            // 
            this.ln_txtBxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_txtBxQuantity.Location = new System.Drawing.Point(158, 139);
            this.ln_txtBxQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_txtBxQuantity.Name = "ln_txtBxQuantity";
            this.ln_txtBxQuantity.Size = new System.Drawing.Size(159, 22);
            this.ln_txtBxQuantity.TabIndex = 6;
            this.ln_txtBxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ln_lblReceive
            // 
            this.ln_lblReceive.AutoSize = true;
            this.ln_lblReceive.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblReceive.Location = new System.Drawing.Point(29, 215);
            this.ln_lblReceive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblReceive.Name = "ln_lblReceive";
            this.ln_lblReceive.Size = new System.Drawing.Size(131, 14);
            this.ln_lblReceive.TabIndex = 7;
            this.ln_lblReceive.Text = "Received Quantity:";
            this.ln_lblReceive.Visible = false;
            // 
            // ln_txtBxReceive
            // 
            this.ln_txtBxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_txtBxReceive.Location = new System.Drawing.Point(158, 212);
            this.ln_txtBxReceive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_txtBxReceive.Name = "ln_txtBxReceive";
            this.ln_txtBxReceive.Size = new System.Drawing.Size(159, 22);
            this.ln_txtBxReceive.TabIndex = 8;
            this.ln_txtBxReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ln_txtBxReceive.Visible = false;
            // 
            // ln_lblIssue
            // 
            this.ln_lblIssue.AutoSize = true;
            this.ln_lblIssue.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblIssue.Location = new System.Drawing.Point(29, 257);
            this.ln_lblIssue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblIssue.Name = "ln_lblIssue";
            this.ln_lblIssue.Size = new System.Drawing.Size(112, 14);
            this.ln_lblIssue.TabIndex = 9;
            this.ln_lblIssue.Text = "Issued Quantity:";
            this.ln_lblIssue.Visible = false;
            // 
            // ln_txtBxIssue
            // 
            this.ln_txtBxIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_txtBxIssue.Location = new System.Drawing.Point(158, 254);
            this.ln_txtBxIssue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_txtBxIssue.Name = "ln_txtBxIssue";
            this.ln_txtBxIssue.Size = new System.Drawing.Size(159, 22);
            this.ln_txtBxIssue.TabIndex = 10;
            this.ln_txtBxIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ln_txtBxIssue.Visible = false;
            // 
            // ln_btnCreate
            // 
            this.ln_btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_btnCreate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_btnCreate.Location = new System.Drawing.Point(41, 298);
            this.ln_btnCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_btnCreate.Name = "ln_btnCreate";
            this.ln_btnCreate.Size = new System.Drawing.Size(126, 25);
            this.ln_btnCreate.TabIndex = 11;
            this.ln_btnCreate.Text = "Create Inventory";
            this.ln_btnCreate.UseVisualStyleBackColor = true;
            this.ln_btnCreate.Click += new System.EventHandler(this.ln_btnCreate_Click);
            // 
            // ln_btnUpdate
            // 
            this.ln_btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ln_btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_btnUpdate.Location = new System.Drawing.Point(185, 298);
            this.ln_btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ln_btnUpdate.Name = "ln_btnUpdate";
            this.ln_btnUpdate.Size = new System.Drawing.Size(132, 25);
            this.ln_btnUpdate.TabIndex = 12;
            this.ln_btnUpdate.Text = "Update Inventory";
            this.ln_btnUpdate.UseVisualStyleBackColor = true;
            this.ln_btnUpdate.Visible = false;
            this.ln_btnUpdate.Click += new System.EventHandler(this.ln_btnUpdate_Click);
            // 
            // ln_lblError
            // 
            this.ln_lblError.AutoSize = true;
            this.ln_lblError.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln_lblError.ForeColor = System.Drawing.Color.Red;
            this.ln_lblError.Location = new System.Drawing.Point(128, 164);
            this.ln_lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ln_lblError.Name = "ln_lblError";
            this.ln_lblError.Size = new System.Drawing.Size(39, 14);
            this.ln_lblError.TabIndex = 13;
            this.ln_lblError.Text = "Error";
            this.ln_lblError.Visible = false;
            // 
            // LNInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 345);
            this.Controls.Add(this.ln_lblError);
            this.Controls.Add(this.ln_btnUpdate);
            this.Controls.Add(this.ln_btnCreate);
            this.Controls.Add(this.ln_txtBxIssue);
            this.Controls.Add(this.ln_lblIssue);
            this.Controls.Add(this.ln_txtBxReceive);
            this.Controls.Add(this.ln_lblReceive);
            this.Controls.Add(this.ln_txtBxQuantity);
            this.Controls.Add(this.ln_lblQuantity);
            this.Controls.Add(this.ln_txtBxAccountNo);
            this.Controls.Add(this.ln_txtBxName);
            this.Controls.Add(this.ln_lblAccountNo);
            this.Controls.Add(this.ln_lblName);
            this.Controls.Add(this.ln_lblStoreName);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(500, 384);
            this.MinimumSize = new System.Drawing.Size(369, 384);
            this.Name = "LNInventoryForm";
            this.Text = "LNInventoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ln_lblStoreName;
        private System.Windows.Forms.Label ln_lblName;
        private System.Windows.Forms.Label ln_lblAccountNo;
        private System.Windows.Forms.TextBox ln_txtBxName;
        private System.Windows.Forms.TextBox ln_txtBxAccountNo;
        private System.Windows.Forms.Label ln_lblQuantity;
        private System.Windows.Forms.TextBox ln_txtBxQuantity;
        private System.Windows.Forms.Label ln_lblReceive;
        private System.Windows.Forms.TextBox ln_txtBxReceive;
        private System.Windows.Forms.Label ln_lblIssue;
        private System.Windows.Forms.TextBox ln_txtBxIssue;
        private System.Windows.Forms.Button ln_btnCreate;
        private System.Windows.Forms.Button ln_btnUpdate;
        private System.Windows.Forms.Label ln_lblError;
    }
}

