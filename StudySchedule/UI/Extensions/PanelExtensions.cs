using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace StudySchedule.UI.Extensions
{
    public class PanelExtensions
    {
        public static void ApplyRoundedCorners(Control control, int radius)
        {
            if (control.Width == 0 || control.Height == 0)
                return;

            var path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - d, 0, d, d, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - d, control.Height - d, d, d, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - d, d, d, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);

            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
