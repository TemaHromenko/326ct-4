using System.Windows.Forms;

namespace Lab_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.змістToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iNDUSTRYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.hOLDINGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.mASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.iNDUSTRYBindingSource = StaticData.iNDUSTRYBindingSource;
            this.mASTERBindingSource = StaticData.mASTERBindingSource;
            this.hOLDINGSBindingSource = StaticData.hOLDINGSBindingSource;
            ((System.ComponentModel.ISupportInitialize)(this.iNDUSTRYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOLDINGSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpContextToolStripMenuItem,
            this.змістToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpContextToolStripMenuItem
            // 
            this.helpContextToolStripMenuItem.Name = "helpContextToolStripMenuItem";
            this.helpContextToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helpContextToolStripMenuItem.Text = "Help - context";
            this.helpContextToolStripMenuItem.Click += new System.EventHandler(this.helpContextToolStripMenuItem_Click);
            // 
            // змістToolStripMenuItem
            // 
            this.змістToolStripMenuItem.Name = "змістToolStripMenuItem";
            this.змістToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.змістToolStripMenuItem.Text = "Зміст";
            this.змістToolStripMenuItem.Click += new System.EventHandler(this.змістToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.rEADMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rEADMEToolStripMenuItem.Text = "README";
            this.rEADMEToolStripMenuItem.Click += new System.EventHandler(this.rEADMEToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить(INDUSTRY)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LONG_NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "IND_NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IND_CODE";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNDUSTRYBindingSource, "LONG_NAME", true));
            this.textBox3.Location = new System.Drawing.Point(33, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox3, "text");
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNDUSTRYBindingSource, "IND_NAME", true));
            this.textBox2.Location = new System.Drawing.Point(33, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBox2, "text");
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iNDUSTRYBindingSource, "IND_CODE", true));
            this.textBox1.Location = new System.Drawing.Point(33, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox1, "int(4)");
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOLDINGSBindingSource, "ACCT_NBR", true));
            this.textBox4.Location = new System.Drawing.Point(217, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBox4, "int(7)");
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOLDINGSBindingSource, "SYMBOL", true));
            this.textBox5.Location = new System.Drawing.Point(217, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBox5, "char(10)");
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOLDINGSBindingSource, "SHARES", true));
            this.textBox6.Location = new System.Drawing.Point(217, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 20);
            this.textBox6.TabIndex = 15;
            this.toolTip1.SetToolTip(this.textBox6, "float");
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOLDINGSBindingSource, "PUR_PRICE", true));
            this.textBox7.Location = new System.Drawing.Point(217, 159);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 20);
            this.textBox7.TabIndex = 16;
            this.toolTip1.SetToolTip(this.textBox7, "float");
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOLDINGSBindingSource, "PUR_DATE", true));
            this.textBox8.Location = new System.Drawing.Point(217, 198);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(146, 20);
            this.textBox8.TabIndex = 17;
            this.toolTip1.SetToolTip(this.textBox8, "date");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ACCT-NBR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "SYMBOL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SHARES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "PUR_PRICE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "PUR_DATE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Добавить(HOLDINGS)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "YRL_HIGH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "CUR_PRICE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "EXCHANGE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "CO-NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(445, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "SYMBOL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(626, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "RATING";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(626, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "SAFETY";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(626, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "PRICE_CHG";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(626, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "INDUSTRY";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(626, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "GRTH_GRTH";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(626, 298);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "RCMNDATION";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(626, 260);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "OUTLOOK";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(626, 221);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "RANK";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(445, 260);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "P_E_RATIO";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(445, 221);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "YRL_LOW";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(445, 299);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 55;
            this.label24.Text = "BETA";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 56;
            this.button3.Text = "Добавить(MASTER)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(445, 338);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 58;
            this.label25.Text = "RISK";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "SYMBOL", true));
            this.textBox9.Location = new System.Drawing.Point(406, 43);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(142, 20);
            this.textBox9.TabIndex = 59;
            this.toolTip1.SetToolTip(this.textBox9, "char(7)");
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "CO_NAME", true));
            this.textBox10.Location = new System.Drawing.Point(406, 82);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(142, 20);
            this.textBox10.TabIndex = 60;
            this.toolTip1.SetToolTip(this.textBox10, "char(20)");
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "EXCHANGE", true));
            this.textBox11.Location = new System.Drawing.Point(406, 121);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(142, 20);
            this.textBox11.TabIndex = 61;
            this.toolTip1.SetToolTip(this.textBox11, "char(8)");
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "CUR-PRICE", true));
            this.textBox12.Location = new System.Drawing.Point(406, 160);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(142, 20);
            this.textBox12.TabIndex = 62;
            this.toolTip1.SetToolTip(this.textBox12, "float");
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "YRL_HIGH", true));
            this.textBox13.Location = new System.Drawing.Point(406, 198);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(142, 20);
            this.textBox13.TabIndex = 63;
            this.toolTip1.SetToolTip(this.textBox13, "float");
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "YRL_LOW", true));
            this.textBox14.Location = new System.Drawing.Point(406, 237);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(142, 20);
            this.textBox14.TabIndex = 64;
            this.toolTip1.SetToolTip(this.textBox14, "float");
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "P_E_RATIO", true));
            this.textBox15.Location = new System.Drawing.Point(406, 276);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(142, 20);
            this.textBox15.TabIndex = 65;
            this.toolTip1.SetToolTip(this.textBox15, "float");
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "BETA", true));
            this.textBox16.Location = new System.Drawing.Point(406, 315);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(142, 20);
            this.textBox16.TabIndex = 66;
            this.toolTip1.SetToolTip(this.textBox16, "float");
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "GRTH_GRTH", true));
            this.textBox17.Location = new System.Drawing.Point(603, 43);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(142, 20);
            this.textBox17.TabIndex = 67;
            this.toolTip1.SetToolTip(this.textBox17, "int(5)");
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "INDUSTRY", true));
            this.textBox18.Location = new System.Drawing.Point(603, 82);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(142, 20);
            this.textBox18.TabIndex = 68;
            this.toolTip1.SetToolTip(this.textBox18, "int(4)");
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "PRICE_CHG", true));
            this.textBox19.Location = new System.Drawing.Point(603, 121);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(142, 20);
            this.textBox19.TabIndex = 69;
            this.toolTip1.SetToolTip(this.textBox19, "int(3)");
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "SAFETY", true));
            this.textBox20.Location = new System.Drawing.Point(603, 159);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(142, 20);
            this.textBox20.TabIndex = 70;
            this.toolTip1.SetToolTip(this.textBox20, "int(3)");
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "RATING", true));
            this.textBox21.Location = new System.Drawing.Point(603, 198);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(142, 20);
            this.textBox21.TabIndex = 71;
            this.toolTip1.SetToolTip(this.textBox21, "char(4)");
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "RANK", true));
            this.textBox22.Location = new System.Drawing.Point(603, 237);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(142, 20);
            this.textBox22.TabIndex = 72;
            this.toolTip1.SetToolTip(this.textBox22, "int(4)");
            this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "OUTLOOK", true));
            this.textBox23.Location = new System.Drawing.Point(603, 275);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(142, 20);
            this.textBox23.TabIndex = 73;
            this.toolTip1.SetToolTip(this.textBox23, "int(1)");
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "RCMNDATION", true));
            this.textBox24.Location = new System.Drawing.Point(603, 315);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(142, 20);
            this.textBox24.TabIndex = 74;
            this.toolTip1.SetToolTip(this.textBox24, "char(5)");
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mASTERBindingSource, "RISK", true));
            this.textBox25.Location = new System.Drawing.Point(406, 354);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(142, 20);
            this.textBox25.TabIndex = 75;
            this.toolTip1.SetToolTip(this.textBox25, "char(4)");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 39);
            this.button5.TabIndex = 77;
            this.button5.Text = "Показать данные";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 435);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.iNDUSTRYBindingSource = StaticData.iNDUSTRYBindingSource;
            this.mASTERBindingSource = StaticData.mASTERBindingSource;
            this.hOLDINGSBindingSource = StaticData.hOLDINGSBindingSource;
            ((System.ComponentModel.ISupportInitialize)(this.iNDUSTRYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOLDINGSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContextToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem rEADMEToolStripMenuItem;
        public BindingSource iNDUSTRYBindingSource;
        public BindingSource hOLDINGSBindingSource;
        public BindingSource mASTERBindingSource;
        private ToolStripMenuItem змістToolStripMenuItem;
    }
}

