using System;
using System.Drawing;
using System.Windows.Forms;


namespace Diagnoses
{
    public partial class Form2 : Form
    {
        
       public void cleen1()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            radioButton30.Checked = false;
            radioButton31.Checked = false;
            radioButton32.Checked = false;
            radioButton33.Checked = false;
            radioButton34.Checked = false;
            radioButton35.Checked = false;
            radioButton36.Checked = false;
            radioButton37.Checked = false;
            radioButton38.Checked = false;
            radioButton39.Checked = false;
            radioButton40.Checked = false;
            radioButton41.Checked = false;
            radioButton42.Checked = false;
            radioButton43.Checked = false;
            radioButton44.Checked = false;
            radioButton45.Checked = false;
            radioButton46.Checked = false;
            radioButton47.Checked = false;
            radioButton48.Checked = false;
            richTextBox1.Text = "";
            textBox5.Text = "";
        }
        public void cleen2()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBoxPrintCtrl1.Text = "";
            cleen1();
            textBox1.Select();
            button19.Enabled = false;
            btnPrintPreview.Enabled = false;
            button21.Enabled = false;
            button22.Visible = false;
            richTextBoxPrintCtrl1.Visible = false;
            label1.Visible = true;
            textBox5.Visible = true;
            z1 = ""; z2 = ""; z3 = ""; z4 = ""; z5 = ""; z6 = ""; z7 = ""; z8 = ""; z9 = ""; z10 = ""; z11 = ""; z12 = ""; z13 = ""; z14 = "";
            za1 = ""; za2 = ""; za3 = ""; za4 = ""; za5 = ""; za6 = ""; za7 = ""; za8 = ""; za9 = ""; za10 = ""; za11 = ""; za12 = ""; za13 = ""; za14 = "";
            organ1 = ""; organ2 = ""; organ3 = ""; organ4 = ""; organ5 = ""; organ6 = ""; organ7 = ""; organ8 = ""; organ9 = ""; organ10 = ""; organ11 = ""; organ12 = ""; organ13 = ""; organ14 = "";
            a = 0;
            b = 0;
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }

        public Form2()
        {
            InitializeComponent();
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint); this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            cleen1();
            textBox1.Select();
            richTextBoxPrintCtrl1.Visible = false;
            button22.Visible = false;
            button19.Enabled = false;
            btnPrintPreview.Enabled = false;
            button21.Enabled = false;
            button20.Visible = false;
            btnPageSetup.Enabled = false;
        }
        string name, name1;
        string
        //Заключении для печени
                                                                                             pe = "Печень - ",
                nor1 = "не увеличена, контуры четкие, ровные, паренхима обычной акустической плотности, однородная, мелкозернистая, без видимой очаговой патологии. Сосудистая и билиарная сеть не расширена.",
                sp = "не увеличена, контуры нечеткие, края неровные, паренхима печени повышенной эхоплотности, диффузно неоднородная за счет фиброза печеночной ткани, четко ограниченных узловых образований не выявлено, сосуды печени местами расширены, билиарная сеть не изменена.",
                dzg = "слегка увеличена, контуры закруглены, края ровные, структура паренхимы повышенной эхоплотности, однородная, ограниченных узловых образований не выявлено. Сосуды печени и внутрипеченочные желчные протоки не расширены.",
                hg = "увеличена, контуры четкие, закруглены, края ровные, эхогенность паренхимы понижена, структура уплотнена, неоднородная, видимой очаговой патологии не выявлено, сосудистая и билиарная сеть не расширена.",
                ppn = "увеличена в размере, контуры ее закруглены, паренхима печени диффузно пониженной эхоплотности, однородная, признаков очаговой патологии не выявлено, сосуды печени расширены, вена порте-мм, нижняя полая вена-мм",
                jg = "увеличена, контуры нечеткие, закруглены, края ровные, эхогенность паренхимы диффузно повышена, однородная, мелкозернистая, без видимой очаговой патологии, сосудистый рисунок печени обеднен.",
                ap = "не увеличена, контуры нечеткие, паренхима однородная, обычной акустической плотности, в проекции---сегмента печени определяется кистозное образование с утолщенными и уплотненными стенками р:-мм. Сосудистая и билиарная сеть не изменена.";
        //Заключении для желчного пузыря
        string
                                                                                        ge = "Желчный пузырь - ",
             nor2 = "обычной формы и размеров, стенки не утолщены, содержимое гомогенное, без признаков конкрементов. Холедох – не расширен.",
             hh = "не увеличен, стенки утолщены и уплотнены, содержимое гомогенное, без признаков конкрементов.  Холедох - не расширен.",
             gkbh = "стенки его утолщены и уплотнены, в просвете конкременты размером до  мм и менее. Холедох- не расширен.",
             gkbo = "резко увеличен, деформирован, стенки диффузно утолщены, местами двухслойные, в просвете мелкозернистая взвесь и конкременты размером до  мм. Холедох - нерасширен.",
             po = "холецистэктомия. Холедох - не расширен.";








        //заключении для поджелудочной железы
        string
                                                                               pg = "Поджелудочная железа - ",
               nor3 = "не увеличена, подковообразной формы, контуры ее ровные, четкие, структура паренхимы однородная, без видимой очаговой патологии. Панкреатический проток нерасширен.",
               hp = "слегка увеличена, контуры нечеткие, ровные, структура паренхимы однородная, повышенной эхоплотности, без видимой очаговой патологии. Панкреатический проток слегка расширен.",
               op = "увеличена, контуры нечеткие, неровные, паренхима диффузно повышенной эхогенности, однородная, очаговой патологии не выявлено, панкреатический проток расширен.";







        //заключении для селезенка
        string
                                                                                sel = "Селезенка - ",
              nor4 = "не увеличена, контуры ее четкие, ровные, структура паренхимы однородная, без очаговой патологии. Сосуды селезенки не расширены.",
              cpl = "увеличена, контуры ее ровные, четкие, структура паренхимы однородная, без очаговых изменений, сосуды селезенки не расширены.";







        //заключении для Брюшной полости.
        string
                                                                           bp = "Брюшная полость - ",
             nor5 = " в брюшной полости наличие свободной жидкости и узловых образований не выявлено.",
             at = "в брюшной полости определяется наличие свободной жидкости в большом количестве.",
             pkn = "в брюшной полости определяются расширенные петли кишечника и наличие свободной жидкости в умеренном количестве. Наличие кистозных и узловых образований четко не выявлено.";







        //заключении для почек.
        string
                                                                            po4 = "Почки - ",
            nor6 = "с 2-х сторон нормальных размеров, бобовидной формы, расположены в типичном месте, контуры их ровные, четкие, паренхима однородная, кортико-медуллярная дифференциация сохранена, без видимой очаговой патологии. ЧЛС – не расширена, признаков конкрементов не выявлено.",
            hpi = "с 2-х сторон не увеличены, расположены в типичном месте, контуры их четкие, паренхима обеих почек однородная, без очаговой патологии. ЧЛС – деформирована, местами уплотнена ,не расширена, признаков конкрементов не выявлено.",
            pgpp = "Правая почка слегка увеличена, контуры нечеткие, паренхима однородная, без видимой очаговой патологии. ЧЛС – расширена, деформирована, конкрементов четко не выявлено." + "\n"  + "Левая почка - не увеличена, контуры четкие, ровные, паренхима однородная. ЧЛС – не расширена, конкрементов не выявлено.",
            nor6_1 = "с 2-х сторон не увеличены, расположены в типичном месте, контуры их ровные, четкие, паренхима однородная, без видимой очаговой патологии. ЧЛС – не расширена, деформирована, признаков конкрементов не выявлено.",
            ddp = "с обеих сторон увеличены, контуры  их нечеткие, паренхима почек местами утолщена, однородная, без видимой очаговой патологии. ЧЛС – деформирована, местами расширена, признаков камнеобразования не выявлено. ";


        //Мягкие ткани
        string
                                                                         mt = "Мягкие ткани - ";
        //заключении для Мочевого пузыря.
        string
                                                                        mp = "Мочевой пузырь - ",
             nor7 = "недостаточно наполнен, обычной формы, стенки не утолщены, содержимое гомогенное, признаков конкрементов не выявлено.",
             oss = "наполнен, стенки диффузно утолщены, содержимое гомогенное, конкрементов не выявлено.",
             hs="наполнен, стенки неровные, местами утольшены, в просвете конкрементов не выявлено.";




        //заключении для Предстательной железы.
        string
                                                            pj = "Предстательная железа - ",
            nor8 = "не увеличена, контуры ровные, четкие, капсула не утолщена, структура паренхимы однородная, мелкозернистая,  без признаков узлообразования, простатический отдел уретры не изменен.",
            hpro = "слегка увеличена, р:----, контуры нечеткие, капсула местами утолщена и уплотнена, паренхима повышенной эхоплотности, однородная, без очаговых изменений. Простатическая часть уретры местами расширена.",
            dgpj = "резко увеличена, р:----, выступает в просвет пузыря, контуры нечеткие, местами неровные, капсула  уплотнена, местами утолщена, паренхима неоднородная, признаков очаговой патологии не выявлено, простатическая часть уретры расширена, извитая.";







        //заключении для Органы машонки.
        string
                                                   om = "Органы машонки - ",
            nor9 = "яички и их придатки с 2-х сторон не увеличены,  паренхима однородная, без видимой очаговой патологии, в полостях мошонки с обеих сторон наличие свободной жидкости и ограниченных образований не выявлено, гроздевидное сплетение не расширено.",
            oos = "яичко и его придаток справа слегка увеличены, паренхима повышенной эхогенности, однородная, без очаговой патологии, в правой половине машонки свободная жидкость незначительно превышает норму. Слева яичко и придаток без изменений. Сосуды семенного канатика не расширены.",
            vys = "яички и их придатки с 2-х сторон не увеличены, контуры их четкие, паренхима однородная, без очаговой патологии, в правой половине мошонки свободная жидкость превышает норму, гроздевидное сплетение с обеих сторон не расширено.",
            vsks = "яички и придатки с 2-х сторон не увеличены,  паренхима однородная, без очаговой патологии, в правой половине мошонки определяется ограниченная жидкость в умеренном количестве, гроздевидное сплетение не расширено.",
            vs = "яички и придатки с 2-х сторон не увеличены, паренхима однородная, без очаговой патологии, в полостях мошонки с обеих сторон свободная жидкость не превышает норму, отмечается расширение и извитость гроздевидного сплетения слева.";

     







        //заключении для матки.
        string
                                                      mat = "Матка - ",
        nor10 = "расположена правильно, не увеличена, контуры четкие, ровные, миометрий однородный, эндометрий соответствует циклу, яичники с обеих сторон не изменены, без признаков фолликулярных изменений, задний свод свободен.",
        bn1 = "в полости матки 1 плодное яйцо диаметром ---мм, КТР----мм.Сердцебиение +. Харион по передней стенке. Желточный мешок - ---мм.",
        bn2 = "в полости матки 1 плод в головном предлежании, БПР - мм,  ДБ - мм, Сердцебиение  +, Шевеление +. Со стороны внутренних  органов патологии не выявлено. " + "\n" + "Плацента расположена по передней стенке --- степени, толщиной---мм.Околоплодные воды в норме.";

        






        //заключении для Молочной железы.
        string
                                                           mj = "Молочная железа - ",
            nor11 = "строма обеих молочных желез однородной средней звуковой плотности. Протоки   молочных желез не расширены. Подкожно жировая клетчатка и жировая клетчатка ретромаммарного  пространства без особенностей.",
            dkmlmg = "структура паренхимы правой молочной железы однородная, признаков узлообразования не выявлено. Молочные протоки не расширены." + "\n" + "   " + "По --- квадранту левой молочной железы просматривается кистозное образование р: ---мм.";

        



        //заключении для Щитовидной железы.
        string
                                                           shj = "Щитовидная железа - ",
          nor12 = "не увеличена, размеры соответствуют возрастным нормам, контуры ровные, четкие, эхоструктура паренхимы однородная, признаков узлообразования не выявлено.",
            gsj = "слегка увеличена, правая доля-мм, левая доля-мм, перешеек-мм, контуры ровные, четкие, эхоструктура паренхимы однородная, без видимых узловых образований.",
            dz = "увеличена, правая доля-мм, левая доля-мм, перешеек-мм, контуры ровные, четкие, структура паренхимы диффузно уплотнена, неоднородная, местами отмечаются гипо- и гиперэхогенные участки, четко ограниченных узловых образований не выявлено.";

       






        //заключении для Плевральной полости.
        string
                                                          pp = "Плевральная полость - ",
            nor13 = "в проекции синусов легких с обеих сторон наличие свободной жидкости не выявлено.",
            aps = "в проекции синуса правого легкого определяется наличие свободной жидкости в большом количестве.",
            dep = "в проекции синусов легких с обеих сторон определяется наличие свободной жидкости в умеренном количестве.";


        int a,b;
        string
            bol1 = "Сузакская Территориальная Больница",
            pui1 = "Протокол ультразвукового исследования",
            cstr = "Данное заключение не является окончательным диагнозом, должно быть интерпретировано лечащим врачом с использованием клинико-лабораторных данных.",
            vra4 = "Врач УЗД:                                            Абдумоминов. А.",
            prob1 = "                                 ",
            prob2 = "          ",
            prob3 = "     ",
            c = "\n   ",
            c1="\n",
              z1 ="", z2="", z3="", z4="", z5="", z6="", z7="", z8="", z9="", z10="", z11="", z12="", z13="", z14="",
              za1="", za2="", za3="", za4="", za5="", za6="", za7="", za8="", za9="", za10="", za11="", za12="", za13="", za14="",
              organ1 ="", organ2="", organ3="", organ4="", organ5="", organ6="", organ7="", organ8 = "", organ9 = "", organ10 = "", organ11 = "", organ12 = "", organ13 = "", organ14 = "";

        private void button20_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (tabControl1.TabIndex == 1)
            {
                za1 = c + label1.Text + textBox5.Text;
            }

            if (tabControl1.TabIndex == 2)
            {
                za2 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 3)
            {
                za3 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 4)
            {
                za4 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 5)
            {
                za5 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 6)
            {
                za6 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 7)
            {
                za7 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 10)
            {
                za8 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 8)
            {
                za9 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 12)
            {
                za10 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 11)
            {
                za11 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 9)
            {
                za12 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 13)
            {
                za13 = c + label1.Text + textBox5.Text;
            }
            if (tabControl1.TabIndex == 14)
            {
                za14 = c + label1.Text + textBox5.Text;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                za1 = c + label1.Text + textBox5.Text;
            }

            if (a == 2)
            {
                za2 = c + label1.Text + textBox5.Text;
            }
            if (a == 3)
            {
                za3 = c + label1.Text + textBox5.Text;
            }
            if (a == 4)
            {
                za4 = c + label1.Text + textBox5.Text;
            }
            if (a == 5)
            {
                za5 = c + label1.Text + textBox5.Text;
            }
            if (a == 6)
            {
                za6 = c + label1.Text + textBox5.Text;
            }
            if (a == 7)
            {
                za7 = c + label1.Text + textBox5.Text;
            }
            if (a == 8)
            {
                za8 = c + label1.Text + textBox5.Text;
            }
            if (a == 9)
            {
                za9 = c + label1.Text + textBox5.Text;
            }
            if (a == 10)
            {
                za10 = c + label1.Text + textBox5.Text;
            }
            if (a == 11)
            {
                za11 = c + label1.Text + textBox5.Text;
            }
            if (a == 12)
            {
                za12 = c + label1.Text + textBox5.Text;
            }
            if (a == 13)
            {
                za13 = c + label1.Text + textBox5.Text;
            }
            if (a == 14)
            {
                za14 = c + label1.Text + textBox5.Text;
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tabControl1.TabIndex==1)
            {
                z1 = richTextBox1.Text;
            }

            if (tabControl1.TabIndex == 2)
            {
                z2 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 3)
            {
                z3 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 4)
            {
                z4 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 5)
            {
                z5 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 6)
            {
                z6 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 7)
            {
                z7 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 10)
            {
                z8 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 8)
            {
                z9 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 12)
            {
                z10 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 11)
            {
                z11 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 9)
            {
                z12 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 13)
            {
                z13 = richTextBox1.Text;
            }
            if (tabControl1.TabIndex == 14)
            {
                z14 = richTextBox1.Text;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox2))
                        tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                }
                return;
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            
            if (b == 1)
            {
                printDocument1.Print();
            }

            if(b!=1)
            {
                if (MessageBox.Show("Вы забыли сохранить заключение, хотите сохранить?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    name1 = textBox1.Text;
                    SaveFileDialog save1 = new SaveFileDialog();
                    save1.FileName = textBox1.Text;
                    save1.OverwritePrompt = true;
                    save1.CheckPathExists = true;
                    save1.RestoreDirectory = true;
                    save1.InitialDirectory = "‪D:/UZI/Архив";
                    save1.Filter = "Rtf Files(*.rtf)|*.rtf|Doc Files(*.doc)|*.doc|Text Files(*.txt) | *.txt";
                    save1.FilterIndex = 1;
                    if (save1.ShowDialog() == DialogResult.OK)
                    {
                        // временно отключаем обработчик события
                        textBox1.TextChanged -= textBox1_TextChanged;
                        try
                        {
                            // присваиваем выбранное в диалоге новое имя файла
                            textBox1.Text = save1.FileName;
                        }
                        finally
                        {
                            // опять подключаем обработчик события
                            textBox1.TextChanged += textBox1_TextChanged;
                        }
                        richTextBoxPrintCtrl1.SaveFile(save1.FileName, RichTextBoxStreamType.RichText);
                        textBox1.Text = name1;

                    }
                    printDocument1.Print();
                    cleen2();
                }
                else 
                {
                    printDocument1.Print();
                    cleen2();
                }
            }
            cleen2();
            button20.Visible = false;
            button18.Visible = true;
            btnPageSetup.Enabled = false;
        }

        private int checkPrint; private void btnPageSetup_Click(object sender, System.EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = richTextBoxPrintCtrl1.Print(checkPrint, richTextBoxPrintCtrl1.TextLength, e);

           //  Check for more pages
            if (checkPrint < richTextBoxPrintCtrl1.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
               z1 = richTextBox1.Text;
            }

            if (a == 2)
            {
                z2 = richTextBox1.Text;
            }
            if (a == 3)
            {
                z3 = richTextBox1.Text;
            }
            if (a == 4)
            {
                z4 = richTextBox1.Text;
            }
            if (a == 5)
            {
                z5 = richTextBox1.Text;
            }
            if (a == 6)
            {
                z6 = richTextBox1.Text;
            }
            if (a == 7)
            {
                z7 = richTextBox1.Text;
            }
            if (a == 8)
            {
                z8 = richTextBox1.Text;
            }
            if (a == 9)
            {
                z9 = richTextBox1.Text;
            }
            if (a == 10)
            {
                z10 = richTextBox1.Text;
            }
            if (a == 11)
            {
                z11 = richTextBox1.Text;
            }
            if (a == 12)
            {
                z12 = richTextBox1.Text;
            }
            if (a == 13)
            {
                z13 = richTextBox1.Text;
            }
            if (a == 14)
            {
                z14 = richTextBox1.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = 1;
            name1 = textBox1.Text;
            SaveFileDialog save1 = new SaveFileDialog();
                save1.FileName = textBox1.Text;
                save1.OverwritePrompt = true;
                save1.CheckPathExists = true;
                save1.RestoreDirectory = true;
                save1.InitialDirectory = "‪D:/UZI/Архив";
                save1.Filter = "Rtf Files(*.rtf)|*.rtf|Doc Files(*.doc)|*.doc|Text Files(*.txt) | *.txt";
                save1.FilterIndex = 1;
                if (save1.ShowDialog() == DialogResult.OK)
                {
                    // временно отключаем обработчик события
                    textBox1.TextChanged -= textBox1_TextChanged;
                    try
                    {
                        // присваиваем выбранное в диалоге новое имя файла
                        textBox1.Text = save1.FileName;
                    }
                    finally
                    {
                        // опять подключаем обработчик события
                        textBox1.TextChanged += textBox1_TextChanged;
                    }
                    richTextBoxPrintCtrl1.SaveFile(save1.FileName, RichTextBoxStreamType.RichText);
                    textBox1.Text = name1;

                }
       
         
            }

        private void button22_Click(object sender, EventArgs e)
        {
            richTextBoxPrintCtrl1.Visible = false;
            richTextBoxPrintCtrl1.Text = "";
            label1.Visible = true;
            textBox5.Visible = true;
            button18.Enabled = true;
            button19.Enabled = false;
            btnPrintPreview.Enabled = false;
            button21.Enabled = false;
            button22.Visible = false;
            button18.Visible = true;
            button20.Visible = false;
            btnPageSetup.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleen2();
            button18.Visible = true;
            button20.Visible = false;
            btnPageSetup.Enabled = false;
            textBox1.Focus();
        }

        private void очиститьБланкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleen2();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBoxPrintCtrl1.SelectionFont = fontDialog1.Font;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 res = new Form4();
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "Rtf Files(*.rtf)|*.rtf|Doc Files(*.doc)|*.doc|Text Files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               name = openFileDialog1.FileName;
               res.richTextBoxPrintCtrl2.Clear();
               res.richTextBoxPrintCtrl2.LoadFile(openFileDialog1.FileName);
               res.ShowDialog();

            }
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form4 res = new Form4();
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "Rtf Files(*.rtf)|*.rtf|Doc Files(*.doc)|*.doc|Text Files(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                res.richTextBoxPrintCtrl2.Clear();
                res.richTextBoxPrintCtrl2.LoadFile(openFileDialog1.FileName);
                res.ShowDialog();

            }
        }

      


      
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 op = new Form5();
            op.ShowDialog();
        }



      


     

        // Переключения с помощю кнопок с иконками..
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
        }

  

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage3"];
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage4"];
        }



        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage5"];
        }



        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage6"];
        }

    

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage7"];
        }



        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage8"];
        }

     

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage9"];
        }



        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage10"];
        }



        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage11"];
        }



        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage12"];
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage13"];
        }


        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TabPage14"];
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox3.Text = dateTimePicker1.Text;
            }
        }





        //zaklu4eniya dly pe4eni
        //begin
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
                a = 0;
                za1 = "";
                textBox5.Text = "";
                richTextBox1.Text = nor1;
                z1 = richTextBox1.Text;
                organ1 = pe;
                a = 1;
       
           
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = sp;
            textBox5.Text = radioButton4.Text;
            z1 = richTextBox1.Text;
            za1 = c+label1.Text+textBox5.Text;
            organ1 = pe;
            a = 1;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = dzg;
            textBox5.Text = radioButton5.Text;
            z1 = richTextBox1.Text;
            za1 = c + label1.Text + textBox5.Text;
            organ1 = pe;
            a = 1;
        }


        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = hg;
            textBox5.Text = radioButton6.Text;
            z1 = richTextBox1.Text;
            za1 = c + label1.Text + textBox5.Text;
            organ1 = pe;
            a = 1;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = ppn;
            textBox5.Text = radioButton7.Text;
            z1 = richTextBox1.Text;
            za1 = c + label1.Text + textBox5.Text;
            organ1 = pe;
            a = 1;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = jg;
            textBox5.Text = radioButton8.Text;
            z1 = richTextBox1.Text;
            za1 = c + label1.Text + textBox5.Text;
            organ1 = pe;
            a = 1;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = ap;
            textBox5.Text = radioButton9.Text;
            z1 = richTextBox1.Text;
            za1 = c + label1.Text + textBox5.Text;
            organ1 = pe;
            a = 1;
        }
        //end;



                        //zaklu4eniya dly jelo4-puzyr
        //begin
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor2;
            z2 = richTextBox1.Text;
            za2 = "";
            organ2 = c1+ge;
            a = 2;
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = hh;
            textBox5.Text = radioButton11.Text;
            z2 = richTextBox1.Text;
            za2 = c + label1.Text+textBox5.Text;
            organ2 = c1+ge;
            a = 2;
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = gkbh;
            textBox5.Text = radioButton12.Text;
            z2 = richTextBox1.Text;
            za2 =c + label1.Text+textBox5.Text;
            organ2 = c1+ge;
            a = 2;
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = gkbo;
            textBox5.Text = radioButton13.Text;
            z2 = richTextBox1.Text;
            za2 =c + label1.Text+textBox5.Text;
            organ2 = c1+ge;
            a = 2;
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = po;
            textBox5.Text = radioButton14.Text;
            z2 = richTextBox1.Text;
            za2 = c + label1.Text + textBox5.Text;
            organ2 = c1+ge;
            a = 2;
        }
        //end;




                                    //zaklu4eniya dly pod-jel;
        //begin
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor3;
            z3 = richTextBox1.Text;
            za3 = "";
            organ3 = c1+pg;
            a = 3;
        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = hp;
            textBox5.Text = radioButton16.Text;
            z3 = richTextBox1.Text;
            za3 = c+label1.Text + textBox5.Text;
            organ3 = c1+pg;
            a = 3;
        }
        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = op;
            textBox5.Text = radioButton48.Text;
            z3 = richTextBox1.Text;
            za3 = c + label1.Text + textBox5.Text;
            organ3 = c1 + pg;
            a = 3;
        }
        //end;





                          //zaklu4eniya dly selez;
        //begin
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor4;
            z4 = richTextBox1.Text;
            za4 = "";
            organ4 = c1+sel;
            a = 4;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = cpl;
            textBox5.Text =radioButton18.Text;
            z4 = richTextBox1.Text;
            za4 = c+label1.Text + textBox5.Text;
            organ4 =c1+ sel;
            a = 4;
        }
        //end;





                                     //zaklu4eniya dly brush-pol;
        //begin
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor5;
            z5 = richTextBox1.Text;
            za5 = "";
            organ5 = c1+bp;
            a = 5;
        }
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = at;
            textBox5.Text = radioButton20.Text;
            z5 = richTextBox1.Text;
            za5 = c+label1.Text + textBox5.Text;
            organ5 =c1+ bp;
            a = 5;
        }
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = pkn;
            textBox5.Text = radioButton21.Text;
            z5 = richTextBox1.Text;
            za5 = c+label1.Text + textBox5.Text;
            organ5 =c1+ bp;
            a = 5;
        }

        //end;




                                     //zaklu4eniya dly po4ek;
        //begin
        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor6;
            z6 = richTextBox1.Text;
            za6 = "";
            organ6 =c1+ po4;
            a = 6;
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = hpi;
            textBox5.Text = radioButton23.Text;
            z6 = richTextBox1.Text;
            za6 = c+label1.Text + textBox5.Text;
            organ6 = c1+po4;
            a = 6;
        }
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = pgpp;
            textBox5.Text = radioButton24.Text;
            z6 = richTextBox1.Text;
            za6 = c+label1.Text + textBox5.Text;
            organ6 =c1+ po4;
            a = 6;
        }
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = nor6_1;
            textBox5.Text = "";
            z6 = richTextBox1.Text;
            za6 = "";
            organ6 =c1+ po4;
            a = 6;
        }
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = ddp;
            textBox5.Text = radioButton26.Text;
            z6 = richTextBox1.Text;
            za6 = c+label1.Text + textBox5.Text;
            organ6 = c1+po4;
            a = 6;
        }
        //end;




                          //zaklu4eniya dly mo4-puz;
        //begin
        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor7;
            z7 = richTextBox1.Text;
            za7 ="";
            organ7 =c1+ mp;
            a = 7;
        }
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = oss;
            textBox5.Text = radioButton28.Text;
            z7 = richTextBox1.Text;
            za7 = c+label1.Text + textBox5.Text;
            organ7 = c1+mp;
            a = 7;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text =hs;
            textBox5.Text = radioButton2.Text;
            z7 = richTextBox1.Text;
            za7 = c + label1.Text + textBox5.Text;
            organ7 = c1 + mp;
            a = 7;
        }

        //end;


        //zaklu4eniya dly matki;
        //begin
        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor10;
            z8 = richTextBox1.Text;
            za8 = "";
            organ8 = c1 + mat;
            a = 8;
        }
        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = bn1;
            textBox5.Text = radioButton38.Text;
            z8 = richTextBox1.Text;
            za8 = c + label1.Text + textBox5.Text;
            organ8 = c1 + mat;
            a = 8;

        }
        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = bn2;
            textBox5.Text = radioButton39.Text;
            z8 = richTextBox1.Text;
            za8 = c + label1.Text + textBox5.Text;
            organ8 = c1 + mat;
            a = 8;
        }
        //end.


                           //zaklu4eniya dly pred-jel;
        //begin
        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text =nor8;
            z9 = richTextBox1.Text;
            za9 = "";
            organ9 = c1 + pj;
            a = 9;
        }
        private void radioButton30_CheckedChanged_1(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text =hpro;
            textBox5.Text = radioButton30.Text;
            z9 = richTextBox1.Text;
            za9 = c + label1.Text + textBox5.Text;
            organ9 = c1 + pj;
            a = 9;
        }
        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text =dgpj;
            textBox5.Text = radioButton31.Text;
            z9 = richTextBox1.Text;
            za9 = c + label1.Text + textBox5.Text;
            organ9 = c1 + pj;
            a = 9;
        }
        //end.
        
            
                           //zaklu4eniya dly shit-jel;
        //begin
        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor12;
            z10 = richTextBox1.Text;
            za10 = "";
            organ10 = c1 + shj;
            a = 10;
        }
        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = gsj;
            textBox5.Text = radioButton43.Text;
            z10 = richTextBox1.Text;
            za10 = c + label1.Text + textBox5.Text;
            organ10 = c1 + shj;
            a = 10;

        }
        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = dz;
            textBox5.Text = radioButton44.Text;
            z10 = richTextBox1.Text;
            za10 = c + label1.Text + textBox5.Text;
            organ10 = c1 + shj;
            a = 10;
        }
        //end.

                     //zaklu4eniya dly mol-jel;
        //begin
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor11;
            z11 = richTextBox1.Text;
            za11 = "";
            organ11 = c1 + mj;
            a = 11;
        }
        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = dkmlmg;
            textBox5.Text = radioButton41.Text;
            z11 = richTextBox1.Text;
            za11 = c + label1.Text + textBox5.Text;
            organ11 = c1 + mj;
            a = 11;
        }
        //end.


                            //zaklu4eniya dly O-m;
        //begin
        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor9;
            z12 = richTextBox1.Text;
            za12 = "";
            organ12 = c1 + om;
            a = 12;
        }
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = oos;
            textBox5.Text = radioButton33.Text;
            z12 = richTextBox1.Text;
            za12 = c + label1.Text + textBox5.Text;
            organ12 = c1 + om;
            a = 12;
        }
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = vys;
            textBox5.Text = radioButton34.Text;
            z12 = richTextBox1.Text;
            za12 = c + label1.Text + textBox5.Text;
            organ12 = c1 + om;
            a = 12;
        }
        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = vsks;
            textBox5.Text = radioButton35.Text;
            z12 = richTextBox1.Text;
            za12 = c + label1.Text + textBox5.Text;
            organ12 = c1 + om;
            a = 12;
        }
        private void radioButton36_CheckedChanged_1(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = vs;
            textBox5.Text = radioButton36.Text;
            z12 = richTextBox1.Text;
            za12 = c + label1.Text + textBox5.Text;
            organ12 = c1 + om;
            a = 12;
        }
        //end.

                       //zaklu4eniya dly plev-pol;
        //begin
        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            textBox5.Text = "";
            richTextBox1.Text = nor13;
            z13 = richTextBox1.Text;
            za13 = "";
            organ13 = c1 + pp;
            a = 13;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = aps;
            textBox5.Text = radioButton45.Text;
            z13 = richTextBox1.Text;
            za13 = c + label1.Text + textBox5.Text;
            organ13 = c1 + pp;
            a = 13;
        }
        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = dep;
            textBox5.Text = radioButton46.Text;
            z13 = richTextBox1.Text;
            za13 = c + label1.Text + textBox5.Text;
            organ13 = c1 + pp;
            a = 13;
        }
        //end.


        //zaklu4eniya dly myg-tkani;
        //begin
        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text="";
            textBox5.Text = "";
            z14 = richTextBox1.Text;
            if (za14 != "")
            {
                za14 = c + label1.Text + textBox5.Text;
            }
            organ14 = c1 + mt;
            a = 14;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            richTextBox1.Text = "";
            textBox5.Text = "";
            z14 = richTextBox1.Text;
            if (za14 != "")
            {
                za14 = c + label1.Text + textBox5.Text;
            }
            organ14 = c1 + mt;
            a = 14;
        }
        //end

        private void button18_Click(object sender, EventArgs e)
        {
            //присвоение
            //Title
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold|FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = prob1+ prob2 + "         " + bol1 + "\n" + prob1+prob2 + "       " + pui1 + "\n" + "\n";
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = label3.Text+' '+ textBox1.Text + "." + "\n" + label4.Text + ' ' + textBox2.Text + "." + "\n" + label5.Text + ' ' + textBox3.Text + "." + "\n" + "\n";

                                                      //1
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ1;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z1;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za1;
                                                      //2
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ2;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z2;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText =  za2;
                                                    //3
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText =  organ3;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z3;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za3;
                                                     //4
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText =  organ4;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z4;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za4;
                                                     //5
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText =  organ5;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z5;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za5;
                                                      //6
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText =  organ6;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z6;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za6;
                                                        //7
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText =  organ7;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z7;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za7;
                                                       //8
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ8;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z8;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za8;
                                                     //9
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ9;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z9;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za9;
                                                      //10
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ10;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z10;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za10;
                                                     //11
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ11;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z11;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za11;
                                                      //12
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ12;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z12;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za12;
                                                      //13
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ13;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z13;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za13;
                                                       //14
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = organ14;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12);
            richTextBoxPrintCtrl1.SelectedText = z14;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 13, (FontStyle.Bold | FontStyle.Italic));
            richTextBoxPrintCtrl1.SelectedText = za14;



            //концовка
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 9);
            richTextBoxPrintCtrl1.SelectedText = c+c + prob3 + cstr;
            richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12,FontStyle.Bold);
            richTextBoxPrintCtrl1.SelectedText = c+c+c+ prob1+prob3 + vra4;



            richTextBoxPrintCtrl1.Visible = true;
            label1.Visible = false;
            textBox5.Visible = false;
            button22.Visible = true;
            button19.Enabled = true;
            btnPrintPreview.Enabled = true;
            button21.Enabled = true;
            button18.Visible = false;
            button20.Visible = true;
            btnPageSetup.Enabled = true;

        }
    }
}
