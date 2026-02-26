namespace StudySchedule.UI.Forms.Cliente
{
    partial class CardCliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome = new Label();
            pnl_cliente = new Panel();
            btn_editar = new Button();
            label2 = new Label();
            lbl_telefone = new Label();
            pnl_cliente.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = SystemColors.HighlightText;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = SystemColors.ControlText;
            lbl_nome.Location = new Point(14, 9);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(57, 21);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome";
            // 
            // pnl_cliente
            // 
            pnl_cliente.BackColor = SystemColors.HighlightText;
            pnl_cliente.Controls.Add(btn_editar);
            pnl_cliente.Controls.Add(label2);
            pnl_cliente.Controls.Add(lbl_telefone);
            pnl_cliente.Controls.Add(lbl_nome);
            pnl_cliente.Location = new Point(3, 3);
            pnl_cliente.Name = "pnl_cliente";
            pnl_cliente.Size = new Size(300, 140);
            pnl_cliente.TabIndex = 3;
            // 
            // btn_editar
            // 
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editar.ForeColor = SystemColors.MenuHighlight;
            btn_editar.Location = new Point(165, 111);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 4;
            btn_editar.Text = "EDITAR";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Segoe UI", 12F);
            lbl_telefone.ForeColor = SystemColors.ControlDark;
            lbl_telefone.Location = new Point(14, 30);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 21);
            lbl_telefone.TabIndex = 2;
            lbl_telefone.Text = "telefone";
            // 
            // CardCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_cliente);
            Name = "CardCliente";
            Size = new Size(246, 140);
            pnl_cliente.ResumeLayout(false);
            pnl_cliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nome;
        private Panel pnl_cliente;
        private Label lbl_telefone;
        private Button btn_editar;
        private Label label2;
    }
}
