namespace Projeto3CamadasPOO
{
    partial class CadAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAdmin));
            this.btnCadAdmin = new System.Windows.Forms.Button();
            this.btnCadastrado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadAdmin
            // 
            this.btnCadAdmin.BackColor = System.Drawing.Color.Sienna;
            this.btnCadAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCadAdmin.Location = new System.Drawing.Point(452, 312);
            this.btnCadAdmin.Name = "btnCadAdmin";
            this.btnCadAdmin.Size = new System.Drawing.Size(0, 0);
            this.btnCadAdmin.TabIndex = 21;
            this.btnCadAdmin.Text = "CADASTRAR ADMINISTRADOR";
            this.btnCadAdmin.UseVisualStyleBackColor = false;
            // 
            // btnCadastrado
            // 
            this.btnCadastrado.BackColor = System.Drawing.Color.Sienna;
            this.btnCadastrado.ForeColor = System.Drawing.Color.White;
            this.btnCadastrado.Location = new System.Drawing.Point(452, 329);
            this.btnCadastrado.Name = "btnCadastrado";
            this.btnCadastrado.Size = new System.Drawing.Size(140, 37);
            this.btnCadastrado.TabIndex = 20;
            this.btnCadastrado.Text = "SOU CADASTRADO";
            this.btnCadastrado.UseVisualStyleBackColor = false;
            this.btnCadastrado.Click += new System.EventHandler(this.btnCadastrado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 259);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastra
            // 
            this.btnCadastra.BackColor = System.Drawing.Color.Sienna;
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.Location = new System.Drawing.Point(452, 275);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(140, 37);
            this.btnCadastra.TabIndex = 17;
            this.btnCadastra.Text = "CADASTRAR";
            this.btnCadastra.UseVisualStyleBackColor = false;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(544, 221);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 16;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(544, 171);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "SENHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "USUARIO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 80);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRAR ADMINISTRADOR";
            // 
            // CadAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 422);
            this.Controls.Add(this.btnCadAdmin);
            this.Controls.Add(this.btnCadastrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastra);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "CadAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadAdmin;
        private System.Windows.Forms.Button btnCadastrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}