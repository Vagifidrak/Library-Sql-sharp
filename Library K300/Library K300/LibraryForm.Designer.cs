namespace Library_K300
{
    partial class LibraryForm
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
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReader = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbFaculity = new System.Windows.Forms.ComboBox();
            this.pcPhtForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcPhtForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrstName
            // 
            this.txtFrstName.Location = new System.Drawing.Point(48, 235);
            this.txtFrstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrstName.Multiline = true;
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(240, 28);
            this.txtFrstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(48, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(366, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(366, 235);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(240, 28);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(360, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(365, 375);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 28);
            this.txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(48, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Faculity";
            // 
            // BtnReader
            // 
            this.BtnReader.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnReader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnReader.Location = new System.Drawing.Point(202, 447);
            this.BtnReader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReader.Name = "BtnReader";
            this.BtnReader.Size = new System.Drawing.Size(242, 100);
            this.BtnReader.TabIndex = 10;
            this.BtnReader.Text = "Add Reader";
            this.BtnReader.UseVisualStyleBackColor = false;
            this.BtnReader.Click += new System.EventHandler(this.BtnReader_Click);
            // 
            // cmbFaculity
            // 
            this.cmbFaculity.FormattingEnabled = true;
            this.cmbFaculity.Location = new System.Drawing.Point(48, 375);
            this.cmbFaculity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFaculity.Name = "cmbFaculity";
            this.cmbFaculity.Size = new System.Drawing.Size(240, 28);
            this.cmbFaculity.TabIndex = 11;
            // 
            // pcPhtForm
            // 
            this.pcPhtForm.Image = global::Library_K300.Properties.Resources.IconUp;
            this.pcPhtForm.Location = new System.Drawing.Point(202, 12);
            this.pcPhtForm.Name = "pcPhtForm";
            this.pcPhtForm.Size = new System.Drawing.Size(230, 164);
            this.pcPhtForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcPhtForm.TabIndex = 12;
            this.pcPhtForm.TabStop = false;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 692);
            this.Controls.Add(this.pcPhtForm);
            this.Controls.Add(this.cmbFaculity);
            this.Controls.Add(this.BtnReader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrstName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcPhtForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbFaculity;
        private System.Windows.Forms.PictureBox pcPhtForm;
    }
}