namespace Bai1_Trang55
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLamLai = new System.Windows.Forms.Button();
			this.txtN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDaySo = new System.Windows.Forms.Label();
			this.lblDayGiamDan = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.lblTong = new System.Windows.Forms.Label();
			this.btnTinhTong = new System.Windows.Forms.Button();
			this.btnSapXep = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNhap
			// 
			resources.ApplyResources(this.btnNhap, "btnNhap");
			this.btnNhap.Name = "btnNhap";
			this.btnNhap.UseVisualStyleBackColor = true;
			this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
			this.btnNhap.MouseLeave += new System.EventHandler(this.btnNhap_MouseLeave);
			this.btnNhap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseMove);
			// 
			// btnThoat
			// 
			resources.ApplyResources(this.btnThoat, "btnThoat");
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			this.btnThoat.MouseLeave += new System.EventHandler(this.btnNhap_MouseLeave);
			this.btnThoat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseMove);
			// 
			// btnLamLai
			// 
			resources.ApplyResources(this.btnLamLai, "btnLamLai");
			this.btnLamLai.Name = "btnLamLai";
			this.btnLamLai.UseVisualStyleBackColor = true;
			this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
			this.btnLamLai.MouseLeave += new System.EventHandler(this.btnNhap_MouseLeave);
			this.btnLamLai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseMove);
			// 
			// txtN
			// 
			resources.ApplyResources(this.txtN, "txtN");
			this.txtN.Name = "txtN";
			this.txtN.Enter += new System.EventHandler(this.txtN_Enter);
			this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
			this.txtN.Leave += new System.EventHandler(this.txtN_Leave);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// lblDaySo
			// 
			this.lblDaySo.AllowDrop = true;
			resources.ApplyResources(this.lblDaySo, "lblDaySo");
			this.lblDaySo.Name = "lblDaySo";
			// 
			// lblDayGiamDan
			// 
			this.lblDayGiamDan.AllowDrop = true;
			resources.ApplyResources(this.lblDayGiamDan, "lblDayGiamDan");
			this.lblDayGiamDan.Name = "lblDayGiamDan";
			// 
			// lbl
			// 
			this.lbl.AllowDrop = true;
			resources.ApplyResources(this.lbl, "lbl");
			this.lbl.Name = "lbl";
			// 
			// lblTong
			// 
			this.lblTong.AllowDrop = true;
			resources.ApplyResources(this.lblTong, "lblTong");
			this.lblTong.Name = "lblTong";
			// 
			// btnTinhTong
			// 
			resources.ApplyResources(this.btnTinhTong, "btnTinhTong");
			this.btnTinhTong.Name = "btnTinhTong";
			this.btnTinhTong.UseVisualStyleBackColor = true;
			this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
			this.btnTinhTong.MouseLeave += new System.EventHandler(this.btnNhap_MouseLeave);
			this.btnTinhTong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseMove);
			// 
			// btnSapXep
			// 
			resources.ApplyResources(this.btnSapXep, "btnSapXep");
			this.btnSapXep.Name = "btnSapXep";
			this.btnSapXep.UseVisualStyleBackColor = true;
			this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
			this.btnSapXep.MouseLeave += new System.EventHandler(this.btnNhap_MouseLeave);
			this.btnSapXep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseMove);
			// 
			// frmMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OliveDrab;
			this.Controls.Add(this.btnSapXep);
			this.Controls.Add(this.btnTinhTong);
			this.Controls.Add(this.lblTong);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.lblDayGiamDan);
			this.Controls.Add(this.lblDaySo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.btnLamLai);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnNhap);
			this.Name = "frmMain";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaySo;
        private System.Windows.Forms.Label lblDayGiamDan;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnSapXep;
    }
}

