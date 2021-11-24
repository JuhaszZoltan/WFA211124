namespace WFA211124
{
    partial class FrmMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOltasDatum = new System.Windows.Forms.DateTimePicker();
            this.tbMOra = new System.Windows.Forms.TextBox();
            this.tbOltasOra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOltasPerc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(63, 29);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(932, 214);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "név";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "szül";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "olt";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "m idő";
            this.Column5.Name = "Column5";
            // 
            // dtpSzul
            // 
            this.dtpSzul.Location = new System.Drawing.Point(192, 347);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(285, 26);
            this.dtpSzul.TabIndex = 1;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(192, 289);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(285, 26);
            this.tbNev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(289, 436);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(499, 67);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Új sor rögzítése";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Munkaórák száma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oltási időpont:";
            // 
            // dtpOltasDatum
            // 
            this.dtpOltasDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOltasDatum.Location = new System.Drawing.Point(681, 283);
            this.dtpOltasDatum.Name = "dtpOltasDatum";
            this.dtpOltasDatum.Size = new System.Drawing.Size(123, 26);
            this.dtpOltasDatum.TabIndex = 1;
            // 
            // tbMOra
            // 
            this.tbMOra.Location = new System.Drawing.Point(681, 347);
            this.tbMOra.Name = "tbMOra";
            this.tbMOra.Size = new System.Drawing.Size(285, 26);
            this.tbMOra.TabIndex = 2;
            // 
            // tbOltasOra
            // 
            this.tbOltasOra.Location = new System.Drawing.Point(819, 282);
            this.tbOltasOra.Name = "tbOltasOra";
            this.tbOltasOra.Size = new System.Drawing.Size(61, 26);
            this.tbOltasOra.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(886, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // tbOltasPerc
            // 
            this.tbOltasPerc.Location = new System.Drawing.Point(905, 283);
            this.tbOltasPerc.Name = "tbOltasPerc";
            this.tbOltasPerc.Size = new System.Drawing.Size(61, 26);
            this.tbOltasPerc.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 549);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOltasPerc);
            this.Controls.Add(this.tbOltasOra);
            this.Controls.Add(this.tbMOra);
            this.Controls.Add(this.dtpOltasDatum);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker dtpSzul;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOltasDatum;
        private System.Windows.Forms.TextBox tbMOra;
        private System.Windows.Forms.TextBox tbOltasOra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbOltasPerc;
    }
}

