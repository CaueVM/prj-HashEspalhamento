namespace Net_Hashing
{
    partial class Form1
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeraHashSHA512 = new System.Windows.Forms.Button();
            this.btnGeraHashMD5 = new System.Windows.Forms.Button();
            this.btnGeraHashRIPEMD160 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTexto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(28, 58);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(559, 33);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite sua senha";
            // 
            // txtHash
            // 
            this.txtHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHash.Enabled = false;
            this.txtHash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtHash.Location = new System.Drawing.Point(28, 131);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(559, 152);
            this.txtHash.TabIndex = 2;
            this.txtHash.TextChanged += new System.EventHandler(this.txtHash_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha passando pelo Hash";
            // 
            // btnGeraHashSHA512
            // 
            this.btnGeraHashSHA512.BackColor = System.Drawing.Color.Gold;
            this.btnGeraHashSHA512.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraHashSHA512.Location = new System.Drawing.Point(30, 289);
            this.btnGeraHashSHA512.Name = "btnGeraHashSHA512";
            this.btnGeraHashSHA512.Size = new System.Drawing.Size(106, 58);
            this.btnGeraHashSHA512.TabIndex = 4;
            this.btnGeraHashSHA512.Text = "SHA512";
            this.btnGeraHashSHA512.UseVisualStyleBackColor = false;
            this.btnGeraHashSHA512.Click += new System.EventHandler(this.btnGeraHashSHA512_Click);
            // 
            // btnGeraHashMD5
            // 
            this.btnGeraHashMD5.BackColor = System.Drawing.Color.Gold;
            this.btnGeraHashMD5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraHashMD5.Location = new System.Drawing.Point(142, 289);
            this.btnGeraHashMD5.Name = "btnGeraHashMD5";
            this.btnGeraHashMD5.Size = new System.Drawing.Size(106, 58);
            this.btnGeraHashMD5.TabIndex = 4;
            this.btnGeraHashMD5.Text = "MD5";
            this.btnGeraHashMD5.UseVisualStyleBackColor = false;
            this.btnGeraHashMD5.Click += new System.EventHandler(this.btnGeraHashMD5_Click);
            // 
            // btnGeraHashRIPEMD160
            // 
            this.btnGeraHashRIPEMD160.BackColor = System.Drawing.Color.Gold;
            this.btnGeraHashRIPEMD160.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraHashRIPEMD160.Location = new System.Drawing.Point(254, 289);
            this.btnGeraHashRIPEMD160.Name = "btnGeraHashRIPEMD160";
            this.btnGeraHashRIPEMD160.Size = new System.Drawing.Size(106, 58);
            this.btnGeraHashRIPEMD160.TabIndex = 5;
            this.btnGeraHashRIPEMD160.Text = "RIPEMD160";
            this.btnGeraHashRIPEMD160.UseVisualStyleBackColor = false;
            this.btnGeraHashRIPEMD160.Click += new System.EventHandler(this.btnGeraHashRIPEMD160_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(481, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 58);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpar.Location = new System.Drawing.Point(366, 289);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(106, 58);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(624, 376);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGeraHashRIPEMD160);
            this.Controls.Add(this.btnGeraHashMD5);
            this.Controls.Add(this.btnGeraHashSHA512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash de Espalhamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeraHashSHA512;
        private System.Windows.Forms.Button btnGeraHashMD5;
        private System.Windows.Forms.Button btnGeraHashRIPEMD160;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_limpar;
    }
}

