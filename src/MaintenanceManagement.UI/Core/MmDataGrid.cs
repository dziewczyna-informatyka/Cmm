using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceManagement.UI.Core
{
    using System.Collections;
    using System.IO;
    using System.Windows.Forms;

    using MaintenanceManagement.Core;

    public class MmDataGrid : DataGridView
    {
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private System.ComponentModel.IContainer components;

        public MmDataGrid()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Eksport do CSV ...";
            this.toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }

            base.OnMouseDown(e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs args)
        {
            var dialog = new SaveFileDialog { Filter = ".CSV|*.CSV" };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var text = this.ExportToCsv();
                File.WriteAllText(dialog.FileName, Encoding.UTF8.GetString(Encoding.Default.GetBytes(text)));
            }
        }

        private static string SerializeLine(IEnumerable<string> line)
        {
            return
                line.Select(l => l.Replace("\"", "\\"))
                    .Select(l => string.Format("\"{0}\"", l))
                    .Aggregate((acc, c) => string.Format("{0},{1}", acc, c));
        }

        private string ExportToCsv()
        {
            var sb = new StringBuilder();

            sb.AppendLine(SerializeLine(this.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText)));

            for (var i = 0; i < this.Rows.Count; i++)
            {
                sb.AppendLine(
                    SerializeLine(
                        this.Rows[i].Cells.Cast<DataGridViewCell>().Select(c => (c.Value ?? string.Empty).ToString())));
            }


            return sb.ToString();
        }
    }
}
