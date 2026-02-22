namespace StudySchedule.UI.Forms.Agenda
{
    partial class FormJornada2
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
            pnl_jornada = new Panel();
            SuspendLayout();
            // 
            // pnl_jornada
            // 
            pnl_jornada.BackColor = SystemColors.AppWorkspace;
            pnl_jornada.BorderStyle = BorderStyle.FixedSingle;
            pnl_jornada.Dock = DockStyle.Fill;
            pnl_jornada.Location = new Point(0, 0);
            pnl_jornada.Name = "pnl_jornada";
            pnl_jornada.Size = new Size(936, 611);
            pnl_jornada.TabIndex = 0;
            // 
            // FormJornada2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(936, 611);
            Controls.Add(pnl_jornada);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormJornada2";
            Text = "FormJornada2";
            Load += FormJornada2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_jornada;
    }
}