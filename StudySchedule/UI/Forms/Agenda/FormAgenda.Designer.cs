namespace StudySchedule.UI.Forms.Agenda
{
    partial class FormAgenda
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
            pnl_lateral = new Panel();
            pnl_buscar_cliente = new Panel();
            txt_buscar_cliente = new TextBox();
            lbl_buscar_cliente = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            pnl_lateral.SuspendLayout();
            pnl_buscar_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_lateral
            // 
            pnl_lateral.BackColor = SystemColors.ButtonHighlight;
            pnl_lateral.Controls.Add(pnl_buscar_cliente);
            pnl_lateral.Dock = DockStyle.Left;
            pnl_lateral.Location = new Point(0, 0);
            pnl_lateral.Name = "pnl_lateral";
            pnl_lateral.Size = new Size(351, 700);
            pnl_lateral.TabIndex = 0;
            // 
            // pnl_buscar_cliente
            // 
            pnl_buscar_cliente.AutoSize = true;
            pnl_buscar_cliente.BorderStyle = BorderStyle.FixedSingle;
            pnl_buscar_cliente.Controls.Add(textBox1);
            pnl_buscar_cliente.Controls.Add(txt_buscar_cliente);
            pnl_buscar_cliente.Controls.Add(lbl_buscar_cliente);
            pnl_buscar_cliente.Controls.Add(flowLayoutPanel1);
            pnl_buscar_cliente.Location = new Point(29, 29);
            pnl_buscar_cliente.Name = "pnl_buscar_cliente";
            pnl_buscar_cliente.Size = new Size(305, 105);
            pnl_buscar_cliente.TabIndex = 0;
            // 
            // txt_buscar_cliente
            // 
            txt_buscar_cliente.Location = new Point(28, 37);
            txt_buscar_cliente.Name = "txt_buscar_cliente";
            txt_buscar_cliente.Size = new Size(247, 23);
            txt_buscar_cliente.TabIndex = 3;
            txt_buscar_cliente.TextChanged += txt_buscar_cliente_TextChanged;
            txt_buscar_cliente.Leave += txt_buscar_cliente_Leave;
            // 
            // lbl_buscar_cliente
            // 
            lbl_buscar_cliente.AutoSize = true;
            lbl_buscar_cliente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_buscar_cliente.ForeColor = SystemColors.ControlDarkDark;
            lbl_buscar_cliente.Location = new Point(28, 15);
            lbl_buscar_cliente.Name = "lbl_buscar_cliente";
            lbl_buscar_cliente.Size = new Size(119, 19);
            lbl_buscar_cliente.TabIndex = 2;
            lbl_buscar_cliente.Text = "1.Buscar Cliente:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.HotTrack;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(11, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // FormAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 700);
            Controls.Add(pnl_lateral);
            Name = "FormAgenda";
            Text = "FormAgenda";
            Load += FormAgenda_Load;
            pnl_lateral.ResumeLayout(false);
            pnl_lateral.PerformLayout();
            pnl_buscar_cliente.ResumeLayout(false);
            pnl_buscar_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_lateral;
        private Panel pnl_buscar_cliente;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txt_buscar_cliente;
        private Label lbl_buscar_cliente;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}