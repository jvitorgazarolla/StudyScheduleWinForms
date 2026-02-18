namespace StudySchedule.UI.Forms
{
    partial class DashboardForm
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
            pnl_sidebar = new Panel();
            pnl_cliente = new Panel();
            btn_gerenciar_cliente = new Button();
            btn_cliente = new Button();
            pnl_especialidade = new Panel();
            btn_gerenciar_especialidade = new Button();
            btn_especialidade = new Button();
            pnl_profissional = new Panel();
            btn_gerencar_profissional = new Button();
            btn_profissional = new Button();
            pnl_agenda = new Panel();
            btn_gerenciar_agenda = new Button();
            btn_agenda_jornada = new Button();
            btn_agenda = new Button();
            pnl_sidebar_titulo = new Panel();
            lbl_titulo = new Label();
            pnl_content = new Panel();
            btn_close = new Button();
            pnl_sidebar.SuspendLayout();
            pnl_cliente.SuspendLayout();
            pnl_especialidade.SuspendLayout();
            pnl_profissional.SuspendLayout();
            pnl_agenda.SuspendLayout();
            pnl_sidebar_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.BackColor = SystemColors.WindowFrame;
            pnl_sidebar.Controls.Add(pnl_cliente);
            pnl_sidebar.Controls.Add(btn_cliente);
            pnl_sidebar.Controls.Add(pnl_especialidade);
            pnl_sidebar.Controls.Add(btn_especialidade);
            pnl_sidebar.Controls.Add(pnl_profissional);
            pnl_sidebar.Controls.Add(btn_profissional);
            pnl_sidebar.Controls.Add(pnl_agenda);
            pnl_sidebar.Controls.Add(btn_agenda);
            pnl_sidebar.Controls.Add(pnl_sidebar_titulo);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 0);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(218, 611);
            pnl_sidebar.TabIndex = 0;
            // 
            // pnl_cliente
            // 
            pnl_cliente.Controls.Add(btn_gerenciar_cliente);
            pnl_cliente.Dock = DockStyle.Top;
            pnl_cliente.Location = new Point(0, 476);
            pnl_cliente.Name = "pnl_cliente";
            pnl_cliente.Size = new Size(218, 72);
            pnl_cliente.TabIndex = 7;
            // 
            // btn_gerenciar_cliente
            // 
            btn_gerenciar_cliente.FlatAppearance.BorderSize = 0;
            btn_gerenciar_cliente.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_cliente.Font = new Font("Verdana", 9F);
            btn_gerenciar_cliente.ForeColor = SystemColors.ButtonFace;
            btn_gerenciar_cliente.Location = new Point(3, 6);
            btn_gerenciar_cliente.Name = "btn_gerenciar_cliente";
            btn_gerenciar_cliente.Size = new Size(206, 32);
            btn_gerenciar_cliente.TabIndex = 0;
            btn_gerenciar_cliente.Text = "Gerenciar Cliente";
            btn_gerenciar_cliente.UseVisualStyleBackColor = true;
            btn_gerenciar_cliente.Click += btn_gerenciar_cliente_Click;
            // 
            // btn_cliente
            // 
            btn_cliente.Dock = DockStyle.Top;
            btn_cliente.FlatAppearance.BorderSize = 0;
            btn_cliente.FlatStyle = FlatStyle.Flat;
            btn_cliente.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btn_cliente.ForeColor = SystemColors.Control;
            btn_cliente.Image = Properties.Resources.icons8_cliente_34;
            btn_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cliente.Location = new Point(0, 436);
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Size = new Size(218, 40);
            btn_cliente.TabIndex = 6;
            btn_cliente.Text = "CLIENTE";
            btn_cliente.UseVisualStyleBackColor = true;
            btn_cliente.Click += btn_cliente_Click;
            // 
            // pnl_especialidade
            // 
            pnl_especialidade.Controls.Add(btn_gerenciar_especialidade);
            pnl_especialidade.Dock = DockStyle.Top;
            pnl_especialidade.Location = new Point(0, 364);
            pnl_especialidade.Name = "pnl_especialidade";
            pnl_especialidade.Size = new Size(218, 72);
            pnl_especialidade.TabIndex = 5;
            // 
            // btn_gerenciar_especialidade
            // 
            btn_gerenciar_especialidade.FlatAppearance.BorderSize = 0;
            btn_gerenciar_especialidade.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_especialidade.Font = new Font("Verdana", 9F);
            btn_gerenciar_especialidade.ForeColor = SystemColors.ButtonFace;
            btn_gerenciar_especialidade.Location = new Point(3, 6);
            btn_gerenciar_especialidade.Name = "btn_gerenciar_especialidade";
            btn_gerenciar_especialidade.Size = new Size(206, 32);
            btn_gerenciar_especialidade.TabIndex = 0;
            btn_gerenciar_especialidade.Text = "Gerenciar Especialidade";
            btn_gerenciar_especialidade.UseVisualStyleBackColor = true;
            btn_gerenciar_especialidade.Click += btn_gerenciar_especialidade_Click;
            // 
            // btn_especialidade
            // 
            btn_especialidade.Dock = DockStyle.Top;
            btn_especialidade.FlatAppearance.BorderSize = 0;
            btn_especialidade.FlatStyle = FlatStyle.Flat;
            btn_especialidade.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btn_especialidade.ForeColor = SystemColors.Control;
            btn_especialidade.Image = Properties.Resources.icons8_barbearia_34;
            btn_especialidade.ImageAlign = ContentAlignment.MiddleLeft;
            btn_especialidade.Location = new Point(0, 324);
            btn_especialidade.Name = "btn_especialidade";
            btn_especialidade.Size = new Size(218, 40);
            btn_especialidade.TabIndex = 4;
            btn_especialidade.Text = "ESPECIALIDADE";
            btn_especialidade.UseVisualStyleBackColor = true;
            btn_especialidade.Click += btn_especialidade_Click;
            // 
            // pnl_profissional
            // 
            pnl_profissional.Controls.Add(btn_gerencar_profissional);
            pnl_profissional.Dock = DockStyle.Top;
            pnl_profissional.Location = new Point(0, 252);
            pnl_profissional.Name = "pnl_profissional";
            pnl_profissional.Size = new Size(218, 72);
            pnl_profissional.TabIndex = 3;
            // 
            // btn_gerencar_profissional
            // 
            btn_gerencar_profissional.FlatAppearance.BorderSize = 0;
            btn_gerencar_profissional.FlatStyle = FlatStyle.Flat;
            btn_gerencar_profissional.Font = new Font("Verdana", 9F);
            btn_gerencar_profissional.ForeColor = SystemColors.ButtonFace;
            btn_gerencar_profissional.Location = new Point(3, 6);
            btn_gerencar_profissional.Name = "btn_gerencar_profissional";
            btn_gerencar_profissional.Size = new Size(206, 32);
            btn_gerencar_profissional.TabIndex = 0;
            btn_gerencar_profissional.Text = "Gerenciar Profissional";
            btn_gerencar_profissional.UseVisualStyleBackColor = true;
            btn_gerencar_profissional.Click += btn_gerenciar_profissional_Click;
            // 
            // btn_profissional
            // 
            btn_profissional.Dock = DockStyle.Top;
            btn_profissional.FlatAppearance.BorderSize = 0;
            btn_profissional.FlatStyle = FlatStyle.Flat;
            btn_profissional.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btn_profissional.ForeColor = SystemColors.Control;
            btn_profissional.Image = Properties.Resources.icons8_profissional_34;
            btn_profissional.ImageAlign = ContentAlignment.MiddleLeft;
            btn_profissional.Location = new Point(0, 212);
            btn_profissional.Name = "btn_profissional";
            btn_profissional.Size = new Size(218, 40);
            btn_profissional.TabIndex = 2;
            btn_profissional.Text = "PROFISSIONAL";
            btn_profissional.UseVisualStyleBackColor = true;
            btn_profissional.Click += btn_profissional_Click;
            // 
            // pnl_agenda
            // 
            pnl_agenda.Controls.Add(btn_gerenciar_agenda);
            pnl_agenda.Controls.Add(btn_agenda_jornada);
            pnl_agenda.Dock = DockStyle.Top;
            pnl_agenda.Location = new Point(0, 140);
            pnl_agenda.Name = "pnl_agenda";
            pnl_agenda.Size = new Size(218, 72);
            pnl_agenda.TabIndex = 1;
            // 
            // btn_gerenciar_agenda
            // 
            btn_gerenciar_agenda.FlatAppearance.BorderSize = 0;
            btn_gerenciar_agenda.FlatStyle = FlatStyle.Flat;
            btn_gerenciar_agenda.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_gerenciar_agenda.ForeColor = SystemColors.ButtonFace;
            btn_gerenciar_agenda.Location = new Point(3, 3);
            btn_gerenciar_agenda.Name = "btn_gerenciar_agenda";
            btn_gerenciar_agenda.Size = new Size(212, 32);
            btn_gerenciar_agenda.TabIndex = 1;
            btn_gerenciar_agenda.Text = "Gerenciar Agenda";
            btn_gerenciar_agenda.UseVisualStyleBackColor = true;
            btn_gerenciar_agenda.Click += btn_gerenciar_agenda_Click;
            // 
            // btn_agenda_jornada
            // 
            btn_agenda_jornada.FlatAppearance.BorderSize = 0;
            btn_agenda_jornada.FlatStyle = FlatStyle.Flat;
            btn_agenda_jornada.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agenda_jornada.ForeColor = SystemColors.ButtonFace;
            btn_agenda_jornada.Location = new Point(3, 34);
            btn_agenda_jornada.Name = "btn_agenda_jornada";
            btn_agenda_jornada.Size = new Size(206, 32);
            btn_agenda_jornada.TabIndex = 0;
            btn_agenda_jornada.Text = "Jornada";
            btn_agenda_jornada.UseVisualStyleBackColor = true;
            btn_agenda_jornada.Click += btn_agenda_jornada_Click;
            // 
            // btn_agenda
            // 
            btn_agenda.Dock = DockStyle.Top;
            btn_agenda.FlatAppearance.BorderSize = 0;
            btn_agenda.FlatStyle = FlatStyle.Flat;
            btn_agenda.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agenda.ForeColor = SystemColors.Control;
            btn_agenda.Image = Properties.Resources.icons8_agenda_34;
            btn_agenda.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agenda.Location = new Point(0, 100);
            btn_agenda.Name = "btn_agenda";
            btn_agenda.Size = new Size(218, 40);
            btn_agenda.TabIndex = 0;
            btn_agenda.Text = "AGENDA";
            btn_agenda.UseVisualStyleBackColor = true;
            btn_agenda.Click += btn_agenda_Click;
            // 
            // pnl_sidebar_titulo
            // 
            pnl_sidebar_titulo.Controls.Add(lbl_titulo);
            pnl_sidebar_titulo.Dock = DockStyle.Top;
            pnl_sidebar_titulo.Location = new Point(0, 0);
            pnl_sidebar_titulo.Name = "pnl_sidebar_titulo";
            pnl_sidebar_titulo.Size = new Size(218, 100);
            pnl_sidebar_titulo.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.ButtonFace;
            lbl_titulo.Image = Properties.Resources.icons8_barbearia_48;
            lbl_titulo.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_titulo.Location = new Point(49, 38);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(127, 25);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "DASHBOARD";
            // 
            // pnl_content
            // 
            pnl_content.Location = new Point(259, 38);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(995, 561);
            pnl_content.TabIndex = 1;
            // 
            // btn_close
            // 
            btn_close.BackColor = SystemColors.Control;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Image = Properties.Resources.vcsconflicting_93497;
            btn_close.Location = new Point(1279, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(50, 32);
            btn_close.TabIndex = 2;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            btn_close.MouseHover += btn_close_MouseHover;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1341, 611);
            Controls.Add(btn_close);
            Controls.Add(pnl_content);
            Controls.Add(pnl_sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            pnl_sidebar.ResumeLayout(false);
            pnl_cliente.ResumeLayout(false);
            pnl_especialidade.ResumeLayout(false);
            pnl_profissional.ResumeLayout(false);
            pnl_agenda.ResumeLayout(false);
            pnl_sidebar_titulo.ResumeLayout(false);
            pnl_sidebar_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Panel pnl_sidebar;
        private Panel pnl_agenda;
        private Button btn_agenda;
        private Panel pnl_sidebar_titulo;
        private Button btn_agenda_jornada;
        private Panel pnl_content;
        private Button btn_profissional;
        private Panel pnl_profissional;
        private Button btn_gerencar_profissional;
        private Button btn_close;
        private Panel pnl_especialidade;
        private Button btn_gerenciar_especialidade;
        private Button btn_especialidade;
        private Label lbl_titulo;
        private Panel pnl_cliente;
        private Button btn_gerenciar_cliente;
        private Button btn_cliente;
        private Button btn_gerenciar_agenda;
    }
}