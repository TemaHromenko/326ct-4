using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private const string projectWay = "C:/Projects/";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StaticData.mASTERTableAdapter.Fill(StaticData.lab_2DataSet.MASTER);
            StaticData.hOLDINGSTableAdapter.Fill(StaticData.lab_2DataSet.HOLDINGS);
            StaticData.iNDUSTRYTableAdapter.Fill(StaticData.lab_2DataSet.INDUSTRY);

            StaticData.mASTERBindingSource.AddNew();
            StaticData.hOLDINGSBindingSource.AddNew();
            StaticData.iNDUSTRYBindingSource.AddNew();

            textBox1.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox1.htm"));
            textBox2.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox2.htm"));
            textBox3.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox3.htm"));

            textBox4.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox4.htm"));
            textBox5.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox5.htm"));
            textBox6.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox6.htm"));
            textBox7.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox7.htm"));
            textBox8.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox8.htm"));

            textBox9.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox9.htm"));
            textBox10.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox10.htm"));
            textBox11.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox11.htm"));
            textBox12.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox12.htm"));
            textBox13.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox13.htm"));
            textBox14.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox14.htm"));
            textBox15.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox15.htm"));
            textBox16.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox16.htm"));
            textBox17.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox17.htm"));
            textBox18.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox18.htm"));
            textBox19.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox19.htm"));
            textBox20.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox20.htm"));
            textBox21.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox21.htm"));
            textBox22.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox22.htm"));
            textBox23.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox23.htm"));
            textBox24.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox24.htm"));
            textBox25.HelpRequested += new HelpEventHandler((sender1, helpEvent) => Help.ShowHelp(this, $"{projectWay}Lab_2/Lab_2.chm", HelpNavigator.Topic, "textBox25.htm"));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            StaticData.iNDUSTRYBindingSource.EndEdit();
            StaticData.iNDUSTRYTableAdapter.Update(StaticData.lab_2DataSet.INDUSTRY);

            MessageBox.Show("Успешно");
            StaticData.iNDUSTRYBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StaticData.hOLDINGSBindingSource.EndEdit();
            StaticData.hOLDINGSTableAdapter.Update(StaticData.lab_2DataSet.HOLDINGS);

            MessageBox.Show("Успешно");
            StaticData.hOLDINGSBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StaticData.mASTERBindingSource.EndEdit();
            StaticData.mASTERTableAdapter.Update(StaticData.lab_2DataSet.MASTER);

            MessageBox.Show("Успешно");
            StaticData.mASTERBindingSource.AddNew();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это 1,2,3 лабораторная работа по этой дисциплне. " +
                "Здесь используються базы данных. Автор - Артём Громенко, Илья Калюга, Костенко Валентин группа 326ст. Было сложно (нет). ");
        }

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В следующей лабе будет что-то похожее.Наверное... ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaticData.mASTERBindingSource.RemoveCurrent();
            StaticData.hOLDINGSBindingSource.RemoveCurrent();
            StaticData.iNDUSTRYBindingSource.RemoveCurrent();
            Hide();
            Form2 showDate = new Form2();
            showDate.Show();
        }

        private void rEADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ВНИМАНИЕ!!! Ввод данных допускаеться в размерах, указанных в задании." +
                "В случае попытки ввести данные, которые больше по размеру, произойдёт ошибка. Спасибо.");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            StaticData.mASTERBindingSource.RemoveCurrent();
            StaticData.hOLDINGSBindingSource.RemoveCurrent();
            StaticData.iNDUSTRYBindingSource.RemoveCurrent();
            Hide();
            Form4 showDate = new Form4();
            showDate.Show();
        }

        private void змістToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це пргорама для роботи з базою даних, вона складається з 3 вікон. Ви знаходитесь у вікні головного меню де ви можите додовати нові строки у бази даних, інші вікна для просмотру цих даних");
        }

    }
}
