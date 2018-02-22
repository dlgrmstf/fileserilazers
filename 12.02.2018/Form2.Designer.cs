namespace _deneme1
{
    partial class Frmadd
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
            this.cbbMaried = new System.Windows.Forms.ComboBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbMaried
            // 
            this.cbbMaried.FormattingEnabled = true;
            this.cbbMaried.Items.AddRange(new object[] {
            "married",
            "single"});
            this.cbbMaried.Location = new System.Drawing.Point(407, 470);
            this.cbbMaried.Name = "cbbMaried";
            this.cbbMaried.Size = new System.Drawing.Size(121, 39);
            this.cbbMaried.TabIndex = 22;
            // 
            // cbbGender
            // 
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "female",
            "male"});
            this.cbbGender.Location = new System.Drawing.Point(417, 348);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(121, 39);
            this.cbbGender.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "marired";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 56);
            this.label4.TabIndex = 19;
            this.label4.Text = "gender";
            // 
            // datetimeDateofBirth
            // 
            this.datetimeDateofBirth.Location = new System.Drawing.Point(349, 256);
            this.datetimeDateofBirth.Name = "datetimeDateofBirth";
            this.datetimeDateofBirth.Size = new System.Drawing.Size(384, 38);
            this.datetimeDateofBirth.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 56);
            this.label3.TabIndex = 17;
            this.label3.Text = "surname";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 38);
            this.label2.TabIndex = 16;
            this.label2.Text = "doğum tarihi";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "name";
            // 
            // txSurname
            // 
            this.txSurname.Location = new System.Drawing.Point(349, 148);
            this.txSurname.Multiline = true;
            this.txSurname.Name = "txSurname";
            this.txSurname.Size = new System.Drawing.Size(374, 56);
            this.txSurname.TabIndex = 14;
            this.txSurname.Click += new System.EventHandler(this.txSurname_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(349, 55);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 63);
            this.txtName.TabIndex = 13;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(239, 583);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(259, 73);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(520, 583);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(259, 73);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 668);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbbMaried);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetimeDateofBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Frmadd";
            this.Text = "Frmadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaried;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeDateofBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}