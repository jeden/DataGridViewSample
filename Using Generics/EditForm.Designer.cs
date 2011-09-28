namespace DataGridViewSample
{
    partial class EditForm
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
            this._editFirstName = new System.Windows.Forms.TextBox();
            this._editLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._editStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._editPostalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._editCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // _editFirstName
            // 
            this._editFirstName.Location = new System.Drawing.Point(85, 6);
            this._editFirstName.Name = "_editFirstName";
            this._editFirstName.Size = new System.Drawing.Size(187, 20);
            this._editFirstName.TabIndex = 1;
            // 
            // _editLastName
            // 
            this._editLastName.Location = new System.Drawing.Point(85, 32);
            this._editLastName.Name = "_editLastName";
            this._editLastName.Size = new System.Drawing.Size(187, 20);
            this._editLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // _editStreet
            // 
            this._editStreet.Location = new System.Drawing.Point(85, 74);
            this._editStreet.Name = "_editStreet";
            this._editStreet.Size = new System.Drawing.Size(187, 20);
            this._editStreet.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street";
            // 
            // _editPostalCode
            // 
            this._editPostalCode.Location = new System.Drawing.Point(85, 100);
            this._editPostalCode.Name = "_editPostalCode";
            this._editPostalCode.Size = new System.Drawing.Size(67, 20);
            this._editPostalCode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Postal Code";
            // 
            // _editCity
            // 
            this._editCity.Location = new System.Drawing.Point(85, 126);
            this._editCity.Name = "_editCity";
            this._editCity.Size = new System.Drawing.Size(187, 20);
            this._editCity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // _btnSave
            // 
            this._btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnSave.Location = new System.Drawing.Point(197, 152);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(107, 152);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 11;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._editCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._editPostalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._editStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._editLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._editFirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _editFirstName;
        private System.Windows.Forms.TextBox _editLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _editStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _editPostalCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _editCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
    }
}