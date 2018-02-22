namespace _deneme1
{
    partial class Frmbase
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
            this.dataGridViewBindingList = new System.Windows.Forms.DataGridView();
            this.clmnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnsurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmndt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmngender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clmnmarried = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRmove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.comboBoxFileFormat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBindingList
            // 
            this.dataGridViewBindingList.AllowUserToAddRows = false;
            this.dataGridViewBindingList.AllowUserToOrderColumns = true;
            this.dataGridViewBindingList.AllowUserToResizeRows = false;
            this.dataGridViewBindingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBindingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnid,
            this.clmnname,
            this.clmnsurname,
            this.clmndt,
            this.clmngender,
            this.Clmnmarried});
            this.dataGridViewBindingList.Location = new System.Drawing.Point(21, 28);
            this.dataGridViewBindingList.MultiSelect = false;
            this.dataGridViewBindingList.Name = "dataGridViewBindingList";
            this.dataGridViewBindingList.RowTemplate.Height = 40;
            this.dataGridViewBindingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBindingList.Size = new System.Drawing.Size(1145, 433);
            this.dataGridViewBindingList.TabIndex = 0;
            // 
            // clmnid
            // 
            this.clmnid.DataPropertyName = "id";
            this.clmnid.HeaderText = "ID";
            this.clmnid.Name = "clmnid";
            this.clmnid.Width = 150;
            // 
            // clmnname
            // 
            this.clmnname.DataPropertyName = "name";
            this.clmnname.HeaderText = "Name";
            this.clmnname.Name = "clmnname";
            this.clmnname.Width = 150;
            // 
            // clmnsurname
            // 
            this.clmnsurname.DataPropertyName = "surname";
            this.clmnsurname.HeaderText = "Surname";
            this.clmnsurname.Name = "clmnsurname";
            this.clmnsurname.Width = 150;
            // 
            // clmndt
            // 
            this.clmndt.DataPropertyName = "dt";
            this.clmndt.HeaderText = "Datatime";
            this.clmndt.Name = "clmndt";
            this.clmndt.Width = 150;
            // 
            // clmngender
            // 
            this.clmngender.DataPropertyName = "gender";
            this.clmngender.HeaderText = "Gender";
            this.clmngender.Name = "clmngender";
            this.clmngender.Width = 150;
            // 
            // Clmnmarried
            // 
            this.Clmnmarried.DataPropertyName = "married";
            this.Clmnmarried.HeaderText = "Married";
            this.Clmnmarried.MinimumWidth = 50;
            this.Clmnmarried.Name = "Clmnmarried";
            this.Clmnmarried.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(42, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 74);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(255, 503);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(185, 74);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(470, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 74);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRmove
            // 
            this.btnRmove.Location = new System.Drawing.Point(700, 503);
            this.btnRmove.Name = "btnRmove";
            this.btnRmove.Size = new System.Drawing.Size(185, 74);
            this.btnRmove.TabIndex = 4;
            this.btnRmove.Text = "Remove";
            this.btnRmove.UseVisualStyleBackColor = true;
            this.btnRmove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(911, 503);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 74);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboBoxFileFormat
            // 
            this.comboBoxFileFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFileFormat.FormattingEnabled = true;
            this.comboBoxFileFormat.Items.AddRange(new object[] {
            "Xml",
            "Json",
            "Csv"});
            this.comboBoxFileFormat.Location = new System.Drawing.Point(77, 592);
            this.comboBoxFileFormat.Name = "comboBoxFileFormat";
            this.comboBoxFileFormat.Size = new System.Drawing.Size(300, 39);
            this.comboBoxFileFormat.TabIndex = 8;
            // 
            // Frmbase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 937);
            this.Controls.Add(this.comboBoxFileFormat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRmove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewBindingList);
            this.Name = "Frmbase";
            this.Text = "Frmbase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBindingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public  System.Windows.Forms.DataGridView dataGridViewBindingList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRmove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnsurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmndt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmngender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clmnmarried;
        private System.Windows.Forms.ComboBox comboBoxFileFormat;
    }
}

