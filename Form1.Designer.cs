
namespace Lab4DhruvP
{
    partial class FormContactTracer
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelContacted = new System.Windows.Forms.Label();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.dataGridViewTracer = new System.Windows.Forms.DataGridView();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(226, 27);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(83, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(315, 20);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(125, 27);
            this.textBoxFirstName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxFirstName, "Enter Your First Name Here.");
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(227, 64);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(315, 64);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(125, 27);
            this.textBoxLastName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxLastName, "Enter Your Last Name Here.");
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Location = new System.Drawing.Point(203, 111);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(106, 20);
            this.labelEmailAddress.TabIndex = 4;
            this.labelEmailAddress.Text = "&Email Address:";
            this.labelEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(315, 108);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxEmail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.maskedTextBoxEmail, "Enter Your Email Address Here.");
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(198, 155);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "&Phone Number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(315, 152);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxPhoneNumber.TabIndex = 7;
            this.toolTip1.SetToolTip(this.maskedTextBoxPhoneNumber, "Enter Phone Number.");
            // 
            // labelContacted
            // 
            this.labelContacted.AutoSize = true;
            this.labelContacted.Location = new System.Drawing.Point(229, 195);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(80, 20);
            this.labelContacted.TabIndex = 8;
            this.labelContacted.Text = "&Contacted:";
            this.labelContacted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.AutoSize = true;
            this.checkBoxContacted.Location = new System.Drawing.Point(315, 198);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxContacted.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBoxContacted, "Check the Box if it is contacted.");
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTracer
            // 
            this.dataGridViewTracer.AllowUserToAddRows = false;
            this.dataGridViewTracer.AllowUserToDeleteRows = false;
            this.dataGridViewTracer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.colContacted,
            this.colFirstName,
            this.colLastName,
            this.colDate,
            this.dataGridViewEmail});
            this.dataGridViewTracer.Location = new System.Drawing.Point(13, 238);
            this.dataGridViewTracer.MultiSelect = false;
            this.dataGridViewTracer.Name = "dataGridViewTracer";
            this.dataGridViewTracer.ReadOnly = true;
            this.dataGridViewTracer.RowHeadersVisible = false;
            this.dataGridViewTracer.RowHeadersWidth = 51;
            this.dataGridViewTracer.RowTemplate.Height = 29;
            this.dataGridViewTracer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTracer.Size = new System.Drawing.Size(627, 224);
            this.dataGridViewTracer.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dataGridViewTracer, "Displays data which is entered in the textboxes.");
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 487);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(627, 110);
            this.textBoxOutput.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxOutput, "Displays Error Message if an of the Value is not entered.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(345, 617);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(94, 29);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "By clicking this will display the entered value in DataGridView.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(445, 617);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 29);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Makes the form default.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(545, 617);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 29);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "Exits the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // colContacted
            // 
            this.colContacted.DataPropertyName = "Contacted";
            this.colContacted.HeaderText = "Contacted";
            this.colContacted.MinimumWidth = 6;
            this.colContacted.Name = "colContacted";
            this.colContacted.ReadOnly = true;
            this.colContacted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colContacted.Width = 125;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.MinimumWidth = 6;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 125;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 125;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // dataGridViewEmail
            // 
            this.dataGridViewEmail.HeaderText = "Email";
            this.dataGridViewEmail.MinimumWidth = 6;
            this.dataGridViewEmail.Name = "dataGridViewEmail";
            this.dataGridViewEmail.ReadOnly = true;
            this.dataGridViewEmail.Width = 125;
            // 
            // FormContactTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 677);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.dataGridViewTracer);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.maskedTextBoxEmail);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            this.toolTip1.SetToolTip(this, "This form helps to enter the details of the customer and helps to tracer the cont" +
        "act.");
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label labelContacted;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.DataGridView dataGridViewTracer;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewEmail;
    }
}

