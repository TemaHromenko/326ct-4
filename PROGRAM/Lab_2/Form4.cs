using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StaticData.hOLDINGSTableAdapter.Fill(StaticData.lab_2DataSet.HOLDINGS);
            StaticData.iNDUSTRYTableAdapter.Fill(StaticData.lab_2DataSet.INDUSTRY);
            StaticData.mASTERTableAdapter.Fill(StaticData.lab_2DataSet.MASTER);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StaticData.iNDUSTRYTableAdapter.Update(StaticData.lab_2DataSet.INDUSTRY);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            StaticData.hOLDINGSTableAdapter.Update(StaticData.lab_2DataSet.HOLDINGS);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StaticData.mASTERTableAdapter.Update(StaticData.lab_2DataSet.MASTER);
        }
    }
}
