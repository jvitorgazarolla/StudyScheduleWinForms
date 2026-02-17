namespace StudySchedule
{
    partial class LoginForm
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
            btn_login = new Button();
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            pbl_card = new Panel();
            btn_sair = new Button();
            chk_mostrar_senha = new CheckBox();
            panel1 = new Panel();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            pnlUserLine = new Panel();
            lbl_sub_titulo = new Label();
            lbl_titulo = new Label();
            pic_box = new PictureBox();
            pbl_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_box).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.RoyalBlue;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(32, 242);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(260, 35);
            btn_login.TabIndex = 9;
            btn_login.Text = "ENTRAR";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.Location = new Point(52, 124);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(266, 27);
            txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.Black;
            lbl_usuario.Location = new Point(-1, 131);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(52, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario:";
            // 
            // pbl_card
            // 
            pbl_card.BackColor = Color.White;
            pbl_card.BorderStyle = BorderStyle.FixedSingle;
            pbl_card.Controls.Add(btn_sair);
            pbl_card.Controls.Add(chk_mostrar_senha);
            pbl_card.Controls.Add(panel1);
            pbl_card.Controls.Add(txt_senha);
            pbl_card.Controls.Add(lbl_senha);
            pbl_card.Controls.Add(pnlUserLine);
            pbl_card.Controls.Add(lbl_usuario);
            pbl_card.Controls.Add(lbl_sub_titulo);
            pbl_card.Controls.Add(lbl_titulo);
            pbl_card.Controls.Add(txt_usuario);
            pbl_card.Controls.Add(btn_login);
            pbl_card.Controls.Add(pic_box);
            pbl_card.Location = new Point(50, 90);
            pbl_card.Name = "pbl_card";
            pbl_card.Size = new Size(329, 380);
            pbl_card.TabIndex = 5;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.IndianRed;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sair.ForeColor = Color.White;
            btn_sair.Location = new Point(32, 283);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(260, 35);
            btn_sair.TabIndex = 9;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            btn_sair.MouseEnter += btn_sair_MouseEnter;
            btn_sair.MouseLeave += btn_sair_MouseLeave;
            // 
            // chk_mostrar_senha
            // 
            chk_mostrar_senha.AutoSize = true;
            chk_mostrar_senha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chk_mostrar_senha.ForeColor = Color.Gray;
            chk_mostrar_senha.Location = new Point(52, 200);
            chk_mostrar_senha.Name = "chk_mostrar_senha";
            chk_mostrar_senha.Size = new Size(102, 19);
            chk_mostrar_senha.TabIndex = 8;
            chk_mostrar_senha.Text = "Mostrar Senha";
            chk_mostrar_senha.UseVisualStyleBackColor = true;
            chk_mostrar_senha.CheckedChanged += chk_mostrar_senha_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(52, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 2);
            panel1.TabIndex = 6;
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_senha.Location = new Point(52, 167);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(266, 27);
            txt_senha.TabIndex = 7;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.BackColor = Color.Transparent;
            lbl_senha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_senha.ForeColor = Color.Black;
            lbl_senha.Location = new Point(-1, 174);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(44, 15);
            lbl_senha.TabIndex = 6;
            lbl_senha.Text = "Senha:";
            // 
            // pnlUserLine
            // 
            pnlUserLine.BackColor = Color.Silver;
            pnlUserLine.Location = new Point(52, 149);
            pnlUserLine.Name = "pnlUserLine";
            pnlUserLine.Size = new Size(265, 2);
            pnlUserLine.TabIndex = 5;
            pnlUserLine.Paint += panel1_Paint;
            // 
            // lbl_sub_titulo
            // 
            lbl_sub_titulo.AutoSize = true;
            lbl_sub_titulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sub_titulo.ForeColor = Color.Gray;
            lbl_sub_titulo.Location = new Point(96, 86);
            lbl_sub_titulo.Name = "lbl_sub_titulo";
            lbl_sub_titulo.Size = new Size(141, 15);
            lbl_sub_titulo.TabIndex = 2;
            lbl_sub_titulo.Text = "Faça login para continuar";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = Color.DimGray;
            lbl_titulo.Location = new Point(105, 38);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(123, 30);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "Bem-Vindo";
            // 
            // pic_box
            // 
            pic_box.Location = new Point(16, 16);
            pic_box.Name = "pic_box";
            pic_box.Size = new Size(64, 64);
            pic_box.SizeMode = PictureBoxSizeMode.Zoom;
            pic_box.TabIndex = 0;
            pic_box.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(420, 560);
            Controls.Add(pbl_card);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            pbl_card.ResumeLayout(false);
            pbl_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_login;
        private TextBox txt_senha;
        private Panel panel1;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private Panel pbl_card;
        private Label lbl_sub_titulo;
        private Label lbl_titulo;
        private PictureBox pic_box;
        private Panel pnlUserLine;
        private Label lbl_senha;
        private CheckBox chk_mostrar_senha;
        private Button btn_sair;
    }
}
