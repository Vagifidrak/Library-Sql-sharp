namespace Library_K300
{
    partial class ShowReaders
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
            this.dtgReaders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReaders
            // 
            this.dtgReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReaders.Location = new System.Drawing.Point(79, 65);
            this.dtgReaders.Name = "dtgReaders";
            this.dtgReaders.RowHeadersWidth = 62;
            this.dtgReaders.RowTemplate.Height = 28;
            this.dtgReaders.Size = new System.Drawing.Size(861, 464);
            this.dtgReaders.TabIndex = 0;
            // 
            // ShowReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 591);
            this.Controls.Add(this.dtgReaders);
            this.Name = "ShowReaders";
            this.Text = "ShowReaders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowReaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgReaders;
    }
}