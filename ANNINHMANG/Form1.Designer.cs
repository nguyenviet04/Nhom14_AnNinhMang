namespace ANNINHMANG
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtVanBanKy = new TextBox();
            txtP = new TextBox();
            txtB = new TextBox();
            txtQ = new TextBox();
            txtA = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtChuKy = new TextBox();
            btnFileKy = new Button();
            btnFileWordKy = new Button();
            btnReset = new Button();
            btnTaoPQ = new Button();
            btnTaoKhoa = new Button();
            btnKy = new Button();
            btnChuyen = new Button();
            btnLuuTxt = new Button();
            btnLuuWord = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtThongBao = new Label();
            txtVanBanKiemTra = new TextBox();
            txtChuKyKiemTra = new TextBox();
            txtLog = new TextBox();
            btnFileKiemTra = new Button();
            btnFileWordKiemTra = new Button();
            btnFileChuKy = new Button();
            btnFileWordChuKy = new Button();
            btnKiemTra = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(290, 10);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 1;
            label1.Text = "Phần mềm tạo chữ kí số RSA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(17, 118);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Văn bản kí:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(17, 266);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Khoá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(17, 433);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Chữ kí:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(166, 82);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 5;
            label5.Text = "Tạo chữ kí";
            // 
            // txtVanBanKy
            // 
            txtVanBanKy.Location = new Point(94, 114);
            txtVanBanKy.Multiline = true;
            txtVanBanKy.Name = "txtVanBanKy";
            txtVanBanKy.ScrollBars = ScrollBars.Vertical;
            txtVanBanKy.Size = new Size(220, 125);
            txtVanBanKy.TabIndex = 6;
            // 
            // txtP
            // 
            txtP.Location = new Point(94, 266);
            txtP.Name = "txtP";
            txtP.Size = new Size(109, 25);
            txtP.TabIndex = 7;
            // 
            // txtB
            // 
            txtB.Location = new Point(94, 301);
            txtB.Name = "txtB";
            txtB.Size = new Size(109, 25);
            txtB.TabIndex = 8;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(239, 267);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(107, 25);
            txtQ.TabIndex = 9;
            // 
            // txtA
            // 
            txtA.Location = new Point(239, 304);
            txtA.Name = "txtA";
            txtA.Size = new Size(107, 25);
            txtA.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 266);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(18, 17);
            label6.TabIndex = 11;
            label6.Text = "P:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 311);
            label7.Name = "label7";
            label7.Size = new Size(18, 17);
            label7.TabIndex = 12;
            label7.Text = "B:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 271);
            label8.Name = "label8";
            label8.Size = new Size(21, 17);
            label8.TabIndex = 13;
            label8.Text = "Q:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 312);
            label9.Name = "label9";
            label9.Size = new Size(19, 17);
            label9.TabIndex = 14;
            label9.Text = "A:";
            // 
            // txtChuKy
            // 
            txtChuKy.Location = new Point(94, 430);
            txtChuKy.Multiline = true;
            txtChuKy.Name = "txtChuKy";
            txtChuKy.ReadOnly = true;
            txtChuKy.ScrollBars = ScrollBars.Vertical;
            txtChuKy.Size = new Size(220, 130);
            txtChuKy.TabIndex = 15;
            // 
            // btnFileKy
            // 
            btnFileKy.Location = new Point(320, 150);
            btnFileKy.Name = "btnFileKy";
            btnFileKy.Size = new Size(75, 26);
            btnFileKy.TabIndex = 16;
            btnFileKy.Text = "File";
            btnFileKy.UseVisualStyleBackColor = true;
            // 
            // btnFileWordKy
            // 
            btnFileWordKy.Location = new Point(320, 182);
            btnFileWordKy.Name = "btnFileWordKy";
            btnFileWordKy.Size = new Size(75, 26);
            btnFileWordKy.TabIndex = 17;
            btnFileWordKy.Text = "File Word";
            btnFileWordKy.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(352, 291);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 39);
            btnReset.TabIndex = 18;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTaoPQ
            // 
            btnTaoPQ.Location = new Point(94, 342);
            btnTaoPQ.Name = "btnTaoPQ";
            btnTaoPQ.Size = new Size(126, 26);
            btnTaoPQ.TabIndex = 19;
            btnTaoPQ.Text = "Tạo P,Q ngẫu nhiên";
            btnTaoPQ.UseVisualStyleBackColor = true;
            // 
            // btnTaoKhoa
            // 
            btnTaoKhoa.Location = new Point(239, 342);
            btnTaoKhoa.Name = "btnTaoKhoa";
            btnTaoKhoa.Size = new Size(107, 26);
            btnTaoKhoa.TabIndex = 20;
            btnTaoKhoa.Text = "Tạo khoá";
            btnTaoKhoa.UseVisualStyleBackColor = true;
            // 
            // btnKy
            // 
            btnKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKy.Location = new Point(145, 380);
            btnKy.Name = "btnKy";
            btnKy.Size = new Size(135, 34);
            btnKy.TabIndex = 21;
            btnKy.Text = "Ký";
            btnKy.UseVisualStyleBackColor = true;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(320, 435);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(75, 26);
            btnChuyen.TabIndex = 22;
            btnChuyen.Text = "Chuyển";
            btnChuyen.UseVisualStyleBackColor = true;
            // 
            // btnLuuTxt
            // 
            btnLuuTxt.Location = new Point(320, 482);
            btnLuuTxt.Name = "btnLuuTxt";
            btnLuuTxt.Size = new Size(89, 26);
            btnLuuTxt.TabIndex = 23;
            btnLuuTxt.Text = "Lưu File Text";
            btnLuuTxt.UseVisualStyleBackColor = true;
            // 
            // btnLuuWord
            // 
            btnLuuWord.Location = new Point(320, 525);
            btnLuuWord.Name = "btnLuuWord";
            btnLuuWord.Size = new Size(89, 26);
            btnLuuWord.TabIndex = 24;
            btnLuuWord.Text = "Lưu File Word";
            btnLuuWord.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(594, 79);
            label10.Name = "label10";
            label10.Size = new Size(110, 19);
            label10.TabIndex = 25;
            label10.Text = "Kiểm tra chữ kí";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(463, 121);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 26;
            label11.Text = "Văn bản kí:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(463, 266);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 27;
            label12.Text = "Chữ kí:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(463, 430);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 28;
            label13.Text = "Thông báo:";
            // 
            // txtThongBao
            // 
            txtThongBao.AutoSize = true;
            txtThongBao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtThongBao.Location = new Point(540, 436);
            txtThongBao.Name = "txtThongBao";
            txtThongBao.Size = new Size(0, 19);
            txtThongBao.TabIndex = 29;
            // 
            // txtVanBanKiemTra
            // 
            txtVanBanKiemTra.Location = new Point(540, 118);
            txtVanBanKiemTra.Multiline = true;
            txtVanBanKiemTra.Name = "txtVanBanKiemTra";
            txtVanBanKiemTra.ScrollBars = ScrollBars.Vertical;
            txtVanBanKiemTra.Size = new Size(192, 120);
            txtVanBanKiemTra.TabIndex = 30;
            // 
            // txtChuKyKiemTra
            // 
            txtChuKyKiemTra.Location = new Point(540, 266);
            txtChuKyKiemTra.Multiline = true;
            txtChuKyKiemTra.Name = "txtChuKyKiemTra";
            txtChuKyKiemTra.ScrollBars = ScrollBars.Vertical;
            txtChuKyKiemTra.Size = new Size(192, 120);
            txtChuKyKiemTra.TabIndex = 31;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(540, 427);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(192, 130);
            txtLog.TabIndex = 32;
            // 
            // btnFileKiemTra
            // 
            btnFileKiemTra.Location = new Point(749, 150);
            btnFileKiemTra.Name = "btnFileKiemTra";
            btnFileKiemTra.Size = new Size(75, 26);
            btnFileKiemTra.TabIndex = 33;
            btnFileKiemTra.Text = "File";
            btnFileKiemTra.UseVisualStyleBackColor = true;
            // 
            // btnFileWordKiemTra
            // 
            btnFileWordKiemTra.Location = new Point(749, 182);
            btnFileWordKiemTra.Name = "btnFileWordKiemTra";
            btnFileWordKiemTra.Size = new Size(75, 26);
            btnFileWordKiemTra.TabIndex = 34;
            btnFileWordKiemTra.Text = "File Word";
            btnFileWordKiemTra.UseVisualStyleBackColor = true;
            // 
            // btnFileChuKy
            // 
            btnFileChuKy.Location = new Point(749, 296);
            btnFileChuKy.Name = "btnFileChuKy";
            btnFileChuKy.Size = new Size(75, 26);
            btnFileChuKy.TabIndex = 35;
            btnFileChuKy.Text = "File";
            btnFileChuKy.UseVisualStyleBackColor = true;
            // 
            // btnFileWordChuKy
            // 
            btnFileWordChuKy.Location = new Point(749, 329);
            btnFileWordChuKy.Name = "btnFileWordChuKy";
            btnFileWordChuKy.Size = new Size(75, 26);
            btnFileWordChuKy.TabIndex = 36;
            btnFileWordChuKy.Text = "File Word";
            btnFileWordChuKy.UseVisualStyleBackColor = true;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKiemTra.Location = new Point(749, 436);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(87, 39);
            btnKiemTra.TabIndex = 37;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 627);
            Controls.Add(btnKiemTra);
            Controls.Add(btnFileWordChuKy);
            Controls.Add(btnFileChuKy);
            Controls.Add(btnFileWordKiemTra);
            Controls.Add(btnFileKiemTra);
            Controls.Add(txtLog);
            Controls.Add(txtChuKyKiemTra);
            Controls.Add(txtVanBanKiemTra);
            Controls.Add(txtThongBao);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnLuuWord);
            Controls.Add(btnLuuTxt);
            Controls.Add(btnChuyen);
            Controls.Add(btnKy);
            Controls.Add(btnTaoKhoa);
            Controls.Add(btnTaoPQ);
            Controls.Add(btnReset);
            Controls.Add(btnFileWordKy);
            Controls.Add(btnFileKy);
            Controls.Add(txtChuKy);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtA);
            Controls.Add(txtQ);
            Controls.Add(txtB);
            Controls.Add(txtP);
            Controls.Add(txtVanBanKy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RSA Signature Tool";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        // Sender Side (Tạo Chữ Ký)
        private System.Windows.Forms.TextBox txtVanBanKy; 
        private System.Windows.Forms.TextBox txtP;           
        private System.Windows.Forms.TextBox txtB;           
        private System.Windows.Forms.TextBox txtQ;           
        private System.Windows.Forms.TextBox txtA;   
        
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox txtChuKy; 

        private System.Windows.Forms.Button btnFileKy;    
        private System.Windows.Forms.Button btnFileWordKy;    
        private System.Windows.Forms.Button btnReset;        
        private System.Windows.Forms.Button btnTaoPQ; 
        private System.Windows.Forms.Button btnTaoKhoa;     
        private System.Windows.Forms.Button btnKy;           
        private System.Windows.Forms.Button btnChuyen;       
        private System.Windows.Forms.Button btnLuuTxt;       
        private System.Windows.Forms.Button btnLuuWord;      

        // Receiver Side (Kiểm Tra Chữ Ký)
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label txtThongBao;      
        private System.Windows.Forms.TextBox txtVanBanKiemTra; 
        private System.Windows.Forms.TextBox txtChuKyKiemTra; 
        private System.Windows.Forms.TextBox txtLog;         

        private System.Windows.Forms.Button btnFileKiemTra;     
        private System.Windows.Forms.Button btnFileWordKiemTra;     
        private System.Windows.Forms.Button btnFileChuKy;  
        private System.Windows.Forms.Button btnFileWordChuKy;  
        private System.Windows.Forms.Button btnKiemTra;        
    }
}