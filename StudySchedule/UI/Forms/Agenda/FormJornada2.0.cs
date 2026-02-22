using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace StudySchedule.UI.Forms.Agenda
{
    public partial class FormJornada2 : Form
    {
        public FormJornada2()
        {
            InitializeComponent();
        }

        private void FormJornada2_Load(object sender, EventArgs e)
        {
            FormJornada2 form = new FormJornada2();
            ArredondarControle(form, 20);
        }

        private void ArredondarControle(Control control, int raio)
        {
            var path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddArc(new Rectangle(control.Width - raio, 0, raio, raio), 270, 90);
            path.AddArc(new Rectangle(control.Width - raio, control.Height - raio, raio, raio), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - raio, raio, raio), 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
