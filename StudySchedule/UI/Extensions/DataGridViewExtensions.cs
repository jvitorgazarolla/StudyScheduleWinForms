using System;
using System.Collections.Generic;
using System.Text;

namespace StudySchedule.UI.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void setHeader(this DataGridView dgv, string columnName, string headerText)
        {
            dgv.Columns[columnName].HeaderText = headerText;
        }

        public static void removeColumn(this DataGridView dgv, string columnName)
        {
            dgv.Columns.Remove(columnName);
        }

        public static void addButtons(this DataGridView dgv)
        {
            try
            {
                dgv.SuspendLayout();

                if (dgv.Columns.Contains("btnEditar"))
                    dgv.Columns.Remove("btnEditar");

                if (dgv.Columns.Contains("btnDesativar"))
                    dgv.Columns.Remove("btnDesativar");


                if (dgv.Columns.Contains("btnExcluir"))
                    dgv.Columns.Remove("btnExcluir");

                dgv.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnEditar",
                    HeaderText = "",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    Width = 70,
                    DefaultCellStyle = { BackColor = Color.SteelBlue, ForeColor = Color.White }
                });

                dgv.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnDesativar",
                    HeaderText = "",
                    Text = "Desativar",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    Width = 85,
                    DefaultCellStyle = { BackColor = Color.Orange, ForeColor = Color.White }
                });

                dgv.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "btnExcluir",
                    HeaderText = "",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    Width = 70,
                    DefaultCellStyle = { BackColor = Color.IndianRed, ForeColor = Color.White }
                });

                var colEditar = dgv.Columns["btnEditar"];
                var colDesativar = dgv.Columns["btnDesativar"];
                var colExcluir = dgv.Columns["btnExcluir"];

                if (colEditar != null && colDesativar != null && colExcluir != null)
                {
                    int last = dgv.Columns.Count - 1;

                    colExcluir.DisplayIndex = last;
                    colDesativar.DisplayIndex = last - 1;
                    colEditar.DisplayIndex = last - 2;
                }
            }
            finally
            {
                dgv.ResumeLayout();
            }
        }
    }
}
