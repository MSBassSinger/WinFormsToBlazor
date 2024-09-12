namespace WinFormsApp1
{
    partial class frmUserInformation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            lnkMoreInfo = new LinkLabel();
            grpName = new GroupBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            grpAddress = new GroupBox();
            chkUseAsShipping = new CheckBox();
            txtZip = new TextBox();
            lblZip = new Label();
            lstState = new ListBox();
            lblState = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtAddressLine2 = new TextBox();
            lblAddressLine2 = new Label();
            txtAddressLine1 = new TextBox();
            lblAddressLine1 = new Label();
            btnClear = new Button();
            button1 = new Button();
            grpName.SuspendLayout();
            grpAddress.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(13, 235);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 24);
            btnSave.TabIndex = 14;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lnkMoreInfo
            // 
            lnkMoreInfo.AutoSize = true;
            lnkMoreInfo.Location = new Point(13, 280);
            lnkMoreInfo.Name = "lnkMoreInfo";
            lnkMoreInfo.Size = new Size(121, 14);
            lnkMoreInfo.TabIndex = 15;
            lnkMoreInfo.TabStop = true;
            lnkMoreInfo.Text = "Click for more info ...";
            lnkMoreInfo.LinkClicked += lnkMoreInfo_LinkClicked;
            // 
            // grpName
            // 
            grpName.Controls.Add(txtLastName);
            grpName.Controls.Add(lblLastName);
            grpName.Controls.Add(txtFirstName);
            grpName.Controls.Add(lblFirstName);
            grpName.Location = new Point(12, 11);
            grpName.Name = "grpName";
            grpName.Size = new Size(781, 54);
            grpName.TabIndex = 16;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(494, 16);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(243, 22);
            txtLastName.TabIndex = 7;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(435, 18);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(29, 14);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 16);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(243, 22);
            txtFirstName.TabIndex = 5;
            txtFirstName.Leave += txtFirstName_Leave;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(48, 19);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(29, 14);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First";
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(chkUseAsShipping);
            grpAddress.Controls.Add(txtZip);
            grpAddress.Controls.Add(lblZip);
            grpAddress.Controls.Add(lstState);
            grpAddress.Controls.Add(lblState);
            grpAddress.Controls.Add(txtCity);
            grpAddress.Controls.Add(lblCity);
            grpAddress.Controls.Add(txtAddressLine2);
            grpAddress.Controls.Add(lblAddressLine2);
            grpAddress.Controls.Add(txtAddressLine1);
            grpAddress.Controls.Add(lblAddressLine1);
            grpAddress.Location = new Point(13, 78);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(780, 151);
            grpAddress.TabIndex = 17;
            grpAddress.TabStop = false;
            grpAddress.Text = "Address";
            // 
            // chkUseAsShipping
            // 
            chkUseAsShipping.AutoSize = true;
            chkUseAsShipping.Checked = true;
            chkUseAsShipping.CheckState = CheckState.Checked;
            chkUseAsShipping.Location = new Point(47, 105);
            chkUseAsShipping.Name = "chkUseAsShipping";
            chkUseAsShipping.Size = new Size(160, 18);
            chkUseAsShipping.TabIndex = 17;
            chkUseAsShipping.Text = "Use as shipping address?";
            chkUseAsShipping.UseVisualStyleBackColor = true;
            chkUseAsShipping.CheckedChanged += chkUseAsShipping_CheckedChanged;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(102, 77);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(243, 22);
            txtZip.TabIndex = 16;
            txtZip.Leave += txtZip_Leave;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(43, 80);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(23, 14);
            lblZip.TabIndex = 15;
            lblZip.Text = "Zip";
            // 
            // lstState
            // 
            lstState.FormattingEnabled = true;
            lstState.ItemHeight = 14;
            lstState.Location = new Point(493, 56);
            lstState.Name = "lstState";
            lstState.Size = new Size(238, 18);
            lstState.TabIndex = 14;
            lstState.ValueMemberChanged += lstState_ValueMemberChanged;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(434, 56);
            lblState.Name = "lblState";
            lblState.Size = new Size(37, 14);
            lblState.TabIndex = 13;
            lblState.Text = "State";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(102, 49);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(243, 22);
            txtCity.TabIndex = 9;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(43, 52);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(27, 14);
            lblCity.TabIndex = 8;
            lblCity.Text = "City";
            // 
            // txtAddressLine2
            // 
            txtAddressLine2.Location = new Point(493, 21);
            txtAddressLine2.Name = "txtAddressLine2";
            txtAddressLine2.Size = new Size(243, 22);
            txtAddressLine2.TabIndex = 7;
            // 
            // lblAddressLine2
            // 
            lblAddressLine2.AutoSize = true;
            lblAddressLine2.Location = new Point(434, 24);
            lblAddressLine2.Name = "lblAddressLine2";
            lblAddressLine2.Size = new Size(40, 14);
            lblAddressLine2.TabIndex = 6;
            lblAddressLine2.Text = "Line 2";
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Location = new Point(102, 21);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(243, 22);
            txtAddressLine1.TabIndex = 5;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Location = new Point(43, 24);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(40, 14);
            lblAddressLine1.TabIndex = 4;
            lblAddressLine1.Text = "Line 1";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(542, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(207, 24);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear &Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(269, 235);
            button1.Name = "button1";
            button1.Size = new Size(207, 24);
            button1.TabIndex = 19;
            button1.Text = "&Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmUserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(grpAddress);
            Controls.Add(grpName);
            Controls.Add(lnkMoreInfo);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmUserInformation";
            Text = "User Information";
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox7;
        private Label label7;
        private CheckBox checkBox1;
        private Button btnSave;
        private LinkLabel lnkMoreInfo;
        private GroupBox grpName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private GroupBox grpAddress;
        private ListBox lstState;
        private Label lblState;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtAddressLine2;
        private Label lblAddressLine2;
        private TextBox txtAddressLine1;
        private Label lblAddressLine1;
        private CheckBox chkUseAsShipping;
        private TextBox txtZip;
        private Label lblZip;
        private Button btnClear;
        private Button button1;
    }
}
