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
            txt_senha = new TextBox();
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(362, 272);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(353, 243);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(353, 214);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(297, 217);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(50, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(297, 246);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(42, 15);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_usuario);
            Controls.Add(txt_senha);
            Controls.Add(btn_login);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_senha;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private Label lbl_senha;
    }
}
