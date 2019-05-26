using System;
using System.Text;
using System.Windows.Forms;
using Another_Morrowind_Utility.FileStructure;

namespace Another_Morrowind_Utility
{
    public partial class Form1 : Form
    {
        ESXParser parser = new ESXParser();

        public Form1()
        {
            InitializeComponent();         
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "TES Plugin files(*.ESP;*.ESM)|*.ESP; *.ESM"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ESXFile file = parser.Parse(openFileDialog.FileName);

                    StringBuilder sb = new StringBuilder();
                
                    TES3Record tes3record = file.Records[0] as TES3Record;
                    sb.Append(tes3record.Version).Append('\n').Append(tes3record.Author).Append('\n');
                    sb.Append(tes3record.Description).Append('\n').Append(tes3record.IsMaster).Append('\n');
                    sb.Append(tes3record.RecordsNum).Append('\n').Append('\n');

                    foreach (Record r in file.Records)
                    {
                        sb.Append(r.Header.Type).Append(' ').Append(r.Header.Size).Append('\n');
                    }
                    sb.Append('\n').Append(file.Records.Count.ToString());

                    textBox1.Lines = sb.ToString().Split('\n');

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error processing file." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
