using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StaticData.iNDUSTRYTableAdapter.Fill(StaticData.lab_2DataSet.INDUSTRY);
            StaticData.mASTERTableAdapter.Fill(StaticData.lab_2DataSet.MASTER);
            StaticData.hOLDINGSTableAdapter.Fill(StaticData.lab_2DataSet.HOLDINGS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 mainOk = new Form1();
            mainOk.Show();
        }
    }
}
