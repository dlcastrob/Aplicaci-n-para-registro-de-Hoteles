using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad.Ventanas
{
    public partial class FACTURA : Form
    {
        public FACTURA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i <listBox1.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox1.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();
        }
    }
}
