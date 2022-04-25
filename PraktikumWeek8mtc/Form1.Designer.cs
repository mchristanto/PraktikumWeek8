namespace PraktikumWeek8mtc
{
    partial class formPertandingan
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
            this.cBoxKiri = new System.Windows.Forms.ComboBox();
            this.cBoxKanan = new System.Windows.Forms.ComboBox();
            this.lblManagerKiri = new System.Windows.Forms.Label();
            this.lblCaptainKiri = new System.Windows.Forms.Label();
            this.lblNamaManagerKiri = new System.Windows.Forms.Label();
            this.lblNamaCaptainKiri = new System.Windows.Forms.Label();
            this.lblManagerKanan = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblCaptainKanan = new System.Windows.Forms.Label();
            this.lblNamaManagerKanan = new System.Windows.Forms.Label();
            this.lblNamaCaptainKanan = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblNamaStadium = new System.Windows.Forms.Label();
            this.lblJumlahCapacity = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblHasilSkor = new System.Windows.Forms.Label();
            this.lblHasilTanggal = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxKiri
            // 
            this.cBoxKiri.FormattingEnabled = true;
            this.cBoxKiri.Location = new System.Drawing.Point(40, 24);
            this.cBoxKiri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxKiri.Name = "cBoxKiri";
            this.cBoxKiri.Size = new System.Drawing.Size(197, 21);
            this.cBoxKiri.TabIndex = 0;
            this.cBoxKiri.UseWaitCursor = true;
            this.cBoxKiri.SelectedIndexChanged += new System.EventHandler(this.cBoxKiri_SelectedIndexChanged);
            // 
            // cBoxKanan
            // 
            this.cBoxKanan.FormattingEnabled = true;
            this.cBoxKanan.Location = new System.Drawing.Point(364, 24);
            this.cBoxKanan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxKanan.Name = "cBoxKanan";
            this.cBoxKanan.Size = new System.Drawing.Size(197, 21);
            this.cBoxKanan.TabIndex = 1;
            this.cBoxKanan.UseWaitCursor = true;
            this.cBoxKanan.SelectedIndexChanged += new System.EventHandler(this.cBoxKanan_SelectedIndexChanged);
            // 
            // lblManagerKiri
            // 
            this.lblManagerKiri.AutoSize = true;
            this.lblManagerKiri.Location = new System.Drawing.Point(38, 80);
            this.lblManagerKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerKiri.Name = "lblManagerKiri";
            this.lblManagerKiri.Size = new System.Drawing.Size(55, 13);
            this.lblManagerKiri.TabIndex = 2;
            this.lblManagerKiri.Text = "Manager: ";
            this.lblManagerKiri.UseWaitCursor = true;
            // 
            // lblCaptainKiri
            // 
            this.lblCaptainKiri.AutoSize = true;
            this.lblCaptainKiri.Location = new System.Drawing.Point(38, 110);
            this.lblCaptainKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptainKiri.Name = "lblCaptainKiri";
            this.lblCaptainKiri.Size = new System.Drawing.Size(46, 13);
            this.lblCaptainKiri.TabIndex = 3;
            this.lblCaptainKiri.Text = "Captain:";
            this.lblCaptainKiri.UseWaitCursor = true;
            // 
            // lblNamaManagerKiri
            // 
            this.lblNamaManagerKiri.AutoSize = true;
            this.lblNamaManagerKiri.Location = new System.Drawing.Point(106, 80);
            this.lblNamaManagerKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaManagerKiri.Name = "lblNamaManagerKiri";
            this.lblNamaManagerKiri.Size = new System.Drawing.Size(16, 13);
            this.lblNamaManagerKiri.TabIndex = 4;
            this.lblNamaManagerKiri.Text = "...";
            this.lblNamaManagerKiri.UseWaitCursor = true;
            // 
            // lblNamaCaptainKiri
            // 
            this.lblNamaCaptainKiri.AutoSize = true;
            this.lblNamaCaptainKiri.Location = new System.Drawing.Point(106, 110);
            this.lblNamaCaptainKiri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaCaptainKiri.Name = "lblNamaCaptainKiri";
            this.lblNamaCaptainKiri.Size = new System.Drawing.Size(16, 13);
            this.lblNamaCaptainKiri.TabIndex = 5;
            this.lblNamaCaptainKiri.Text = "...";
            this.lblNamaCaptainKiri.UseWaitCursor = true;
            // 
            // lblManagerKanan
            // 
            this.lblManagerKanan.AutoSize = true;
            this.lblManagerKanan.Location = new System.Drawing.Point(362, 80);
            this.lblManagerKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagerKanan.Name = "lblManagerKanan";
            this.lblManagerKanan.Size = new System.Drawing.Size(55, 13);
            this.lblManagerKanan.TabIndex = 6;
            this.lblManagerKanan.Text = "Manager: ";
            this.lblManagerKanan.UseWaitCursor = true;
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(221, 144);
            this.lblStadium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(48, 13);
            this.lblStadium.TabIndex = 7;
            this.lblStadium.Text = "Stadium:";
            this.lblStadium.UseWaitCursor = true;
            // 
            // lblCaptainKanan
            // 
            this.lblCaptainKanan.AutoSize = true;
            this.lblCaptainKanan.Location = new System.Drawing.Point(362, 110);
            this.lblCaptainKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaptainKanan.Name = "lblCaptainKanan";
            this.lblCaptainKanan.Size = new System.Drawing.Size(46, 13);
            this.lblCaptainKanan.TabIndex = 8;
            this.lblCaptainKanan.Text = "Captain:";
            this.lblCaptainKanan.UseWaitCursor = true;
            // 
            // lblNamaManagerKanan
            // 
            this.lblNamaManagerKanan.AutoSize = true;
            this.lblNamaManagerKanan.Location = new System.Drawing.Point(442, 80);
            this.lblNamaManagerKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaManagerKanan.Name = "lblNamaManagerKanan";
            this.lblNamaManagerKanan.Size = new System.Drawing.Size(16, 13);
            this.lblNamaManagerKanan.TabIndex = 9;
            this.lblNamaManagerKanan.Text = "...";
            this.lblNamaManagerKanan.UseWaitCursor = true;
            // 
            // lblNamaCaptainKanan
            // 
            this.lblNamaCaptainKanan.AutoSize = true;
            this.lblNamaCaptainKanan.Location = new System.Drawing.Point(442, 110);
            this.lblNamaCaptainKanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaCaptainKanan.Name = "lblNamaCaptainKanan";
            this.lblNamaCaptainKanan.Size = new System.Drawing.Size(16, 13);
            this.lblNamaCaptainKanan.TabIndex = 10;
            this.lblNamaCaptainKanan.Text = "...";
            this.lblNamaCaptainKanan.UseWaitCursor = true;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(284, 30);
            this.lblVS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(21, 13);
            this.lblVS.TabIndex = 11;
            this.lblVS.Text = "VS";
            this.lblVS.UseWaitCursor = true;
            this.lblVS.Click += new System.EventHandler(this.lblVS_Click);
            // 
            // lblNamaStadium
            // 
            this.lblNamaStadium.AutoSize = true;
            this.lblNamaStadium.Location = new System.Drawing.Point(284, 144);
            this.lblNamaStadium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamaStadium.Name = "lblNamaStadium";
            this.lblNamaStadium.Size = new System.Drawing.Size(16, 13);
            this.lblNamaStadium.TabIndex = 12;
            this.lblNamaStadium.Text = "...";
            this.lblNamaStadium.UseWaitCursor = true;
            // 
            // lblJumlahCapacity
            // 
            this.lblJumlahCapacity.AutoSize = true;
            this.lblJumlahCapacity.Location = new System.Drawing.Point(284, 171);
            this.lblJumlahCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJumlahCapacity.Name = "lblJumlahCapacity";
            this.lblJumlahCapacity.Size = new System.Drawing.Size(16, 13);
            this.lblJumlahCapacity.TabIndex = 13;
            this.lblJumlahCapacity.Text = "...";
            this.lblJumlahCapacity.UseWaitCursor = true;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(221, 171);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 14;
            this.lblCapacity.Text = "Capacity:";
            this.lblCapacity.UseWaitCursor = true;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(221, 255);
            this.lblSkor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(32, 13);
            this.lblSkor.TabIndex = 18;
            this.lblSkor.Text = "Skor:";
            this.lblSkor.UseWaitCursor = true;
            // 
            // lblHasilSkor
            // 
            this.lblHasilSkor.AutoSize = true;
            this.lblHasilSkor.Location = new System.Drawing.Point(284, 255);
            this.lblHasilSkor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasilSkor.Name = "lblHasilSkor";
            this.lblHasilSkor.Size = new System.Drawing.Size(16, 13);
            this.lblHasilSkor.TabIndex = 17;
            this.lblHasilSkor.Text = "...";
            this.lblHasilSkor.UseWaitCursor = true;
            // 
            // lblHasilTanggal
            // 
            this.lblHasilTanggal.AutoSize = true;
            this.lblHasilTanggal.Location = new System.Drawing.Point(284, 228);
            this.lblHasilTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasilTanggal.Name = "lblHasilTanggal";
            this.lblHasilTanggal.Size = new System.Drawing.Size(16, 13);
            this.lblHasilTanggal.TabIndex = 16;
            this.lblHasilTanggal.Text = "...";
            this.lblHasilTanggal.UseWaitCursor = true;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(221, 228);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(49, 13);
            this.lblTanggal.TabIndex = 15;
            this.lblTanggal.Text = "Tanggal:";
            this.lblTanggal.UseWaitCursor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(287, 194);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 19;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(13, 286);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(575, 150);
            this.dgvData.TabIndex = 20;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // formPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblHasilSkor);
            this.Controls.Add(this.lblHasilTanggal);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblJumlahCapacity);
            this.Controls.Add(this.lblNamaStadium);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblNamaCaptainKanan);
            this.Controls.Add(this.lblNamaManagerKanan);
            this.Controls.Add(this.lblCaptainKanan);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblManagerKanan);
            this.Controls.Add(this.lblNamaCaptainKiri);
            this.Controls.Add(this.lblNamaManagerKiri);
            this.Controls.Add(this.lblCaptainKiri);
            this.Controls.Add(this.lblManagerKiri);
            this.Controls.Add(this.cBoxKanan);
            this.Controls.Add(this.cBoxKiri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formPertandingan";
            this.Text = "Hasil Pertandingan";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxKiri;
        private System.Windows.Forms.ComboBox cBoxKanan;
        private System.Windows.Forms.Label lblManagerKiri;
        private System.Windows.Forms.Label lblCaptainKiri;
        private System.Windows.Forms.Label lblNamaManagerKiri;
        private System.Windows.Forms.Label lblNamaCaptainKiri;
        private System.Windows.Forms.Label lblManagerKanan;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblCaptainKanan;
        private System.Windows.Forms.Label lblNamaManagerKanan;
        private System.Windows.Forms.Label lblNamaCaptainKanan;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblNamaStadium;
        private System.Windows.Forms.Label lblJumlahCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblHasilSkor;
        private System.Windows.Forms.Label lblHasilTanggal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

