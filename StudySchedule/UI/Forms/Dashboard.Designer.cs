namespace StudySchedule.UI.Forms
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btn_agenda = new Button();
            btn_especialidade = new Button();
            btn_profissional = new Button();
            btn_cliente = new Button();
            panelHeader = new Panel();
            panelDesktop = new Panel();
            cms_profissional = new ContextMenuStrip(components);
            gerenciarToolStripMenuItem = new ToolStripMenuItem();
            jornadaToolStripMenuItem = new ToolStripMenuItem();
            panelMenu.SuspendLayout();
            cms_profissional.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 30, 54);
            panelMenu.Controls.Add(btn_agenda);
            panelMenu.Controls.Add(btn_especialidade);
            panelMenu.Controls.Add(btn_profissional);
            panelMenu.Controls.Add(btn_cliente);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(147, 450);
            panelMenu.TabIndex = 0;
            // 
            // btn_agenda
            // 
            btn_agenda.FlatAppearance.BorderSize = 0;
            btn_agenda.FlatStyle = FlatStyle.Flat;
            btn_agenda.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agenda.ForeColor = Color.White;
            btn_agenda.Location = new Point(8, 208);
            btn_agenda.Name = "btn_agenda";
            btn_agenda.Padding = new Padding(10, 0, 0, 0);
            btn_agenda.Size = new Size(136, 34);
            btn_agenda.TabIndex = 3;
            btn_agenda.Text = "Agenda";
            btn_agenda.TextAlign = ContentAlignment.MiddleLeft;
            btn_agenda.UseVisualStyleBackColor = true;
            btn_agenda.Click += btn_agenda_Click;
            // 
            // btn_especialidade
            // 
            btn_especialidade.FlatAppearance.BorderSize = 0;
            btn_especialidade.FlatStyle = FlatStyle.Flat;
            btn_especialidade.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_especialidade.ForeColor = Color.White;
            btn_especialidade.Location = new Point(9, 164);
            btn_especialidade.Name = "btn_especialidade";
            btn_especialidade.Padding = new Padding(10, 0, 0, 0);
            btn_especialidade.Size = new Size(135, 34);
            btn_especialidade.TabIndex = 2;
            btn_especialidade.Text = "Especilaidade";
            btn_especialidade.TextAlign = ContentAlignment.MiddleLeft;
            btn_especialidade.UseVisualStyleBackColor = true;
            btn_especialidade.Click += btn_especialidade_Click;
            // 
            // btn_profissional
            // 
            btn_profissional.FlatAppearance.BorderSize = 0;
            btn_profissional.FlatStyle = FlatStyle.Flat;
            btn_profissional.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_profissional.ForeColor = Color.White;
            btn_profissional.Location = new Point(9, 84);
            btn_profissional.Name = "btn_profissional";
            btn_profissional.Padding = new Padding(10, 0, 0, 0);
            btn_profissional.Size = new Size(138, 34);
            btn_profissional.TabIndex = 1;
            btn_profissional.Text = "Profissional";
            btn_profissional.TextAlign = ContentAlignment.MiddleLeft;
            btn_profissional.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_profissional.UseVisualStyleBackColor = true;
            btn_profissional.Click += btn_profissional_Click;
            btn_profissional.MouseEnter += btn_profissional_MouseEnter;
            btn_profissional.MouseLeave += btn_profissional_MouseLeave;
            // 
            // btn_cliente
            // 
            btn_cliente.FlatAppearance.BorderSize = 0;
            btn_cliente.FlatStyle = FlatStyle.Flat;
            btn_cliente.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cliente.ForeColor = Color.White;
            btn_cliente.Location = new Point(9, 124);
            btn_cliente.Name = "btn_cliente";
            btn_cliente.Padding = new Padding(10, 0, 0, 0);
            btn_cliente.Size = new Size(135, 34);
            btn_cliente.TabIndex = 0;
            btn_cliente.Text = "Cliente";
            btn_cliente.TextAlign = ContentAlignment.MiddleLeft;
            btn_cliente.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_cliente.UseVisualStyleBackColor = true;
            btn_cliente.Click += btn_cliente_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(46, 51, 73);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ControlText;
            panelHeader.Location = new Point(147, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(653, 90);
            panelHeader.TabIndex = 1;
            panelHeader.MouseDown += panelHeader_MouseDown;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(37, 42, 64);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(800, 450);
            panelDesktop.TabIndex = 2;
            // 
            // cms_profissional
            // 
            cms_profissional.Items.AddRange(new ToolStripItem[] { gerenciarToolStripMenuItem, jornadaToolStripMenuItem });
            cms_profissional.Name = "contextMenuStrip1";
            cms_profissional.Size = new Size(125, 48);
            // 
            // gerenciarToolStripMenuItem
            // 
            gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            gerenciarToolStripMenuItem.Size = new Size(124, 22);
            gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // jornadaToolStripMenuItem
            // 
            jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            jornadaToolStripMenuItem.Size = new Size(124, 22);
            jornadaToolStripMenuItem.Text = "Jornada";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Controls.Add(panelDesktop);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelMenu.ResumeLayout(false);
            cms_profissional.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelHeader;
        private Panel panelDesktop;
        private Button btn_cliente;
        private Button btn_profissional;
        private Button btn_especialidade;
        private Button btn_agenda;
        private ContextMenuStrip cms_profissional;
        private ToolStripMenuItem gerenciarToolStripMenuItem;
        private ToolStripMenuItem jornadaToolStripMenuItem;
    }
}