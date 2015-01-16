namespace EmployeeLayerArchitectureApp.UI
{
    partial class AddEmployeeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.addEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeEmailTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeAddressTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeDesignationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Designation";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(185, 211);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(87, 211);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addEmployeeNameTextBox
            // 
            this.addEmployeeNameTextBox.Location = new System.Drawing.Point(87, 38);
            this.addEmployeeNameTextBox.Name = "addEmployeeNameTextBox";
            this.addEmployeeNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.addEmployeeNameTextBox.TabIndex = 6;
            // 
            // addEmployeeEmailTextBox
            // 
            this.addEmployeeEmailTextBox.Location = new System.Drawing.Point(87, 72);
            this.addEmployeeEmailTextBox.Name = "addEmployeeEmailTextBox";
            this.addEmployeeEmailTextBox.Size = new System.Drawing.Size(173, 20);
            this.addEmployeeEmailTextBox.TabIndex = 7;
            // 
            // addEmployeeAddressTextBox
            // 
            this.addEmployeeAddressTextBox.Location = new System.Drawing.Point(87, 106);
            this.addEmployeeAddressTextBox.Multiline = true;
            this.addEmployeeAddressTextBox.Name = "addEmployeeAddressTextBox";
            this.addEmployeeAddressTextBox.Size = new System.Drawing.Size(173, 51);
            this.addEmployeeAddressTextBox.TabIndex = 8;
            // 
            // addEmployeeDesignationComboBox
            // 
            this.addEmployeeDesignationComboBox.FormattingEnabled = true;
            this.addEmployeeDesignationComboBox.Location = new System.Drawing.Point(87, 160);
            this.addEmployeeDesignationComboBox.Name = "addEmployeeDesignationComboBox";
            this.addEmployeeDesignationComboBox.Size = new System.Drawing.Size(173, 21);
            this.addEmployeeDesignationComboBox.TabIndex = 9;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addEmployeeDesignationComboBox);
            this.Controls.Add(this.addEmployeeAddressTextBox);
            this.Controls.Add(this.addEmployeeEmailTextBox);
            this.Controls.Add(this.addEmployeeNameTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox addEmployeeNameTextBox;
        private System.Windows.Forms.TextBox addEmployeeEmailTextBox;
        private System.Windows.Forms.TextBox addEmployeeAddressTextBox;
        private System.Windows.Forms.ComboBox addEmployeeDesignationComboBox;
    }
}