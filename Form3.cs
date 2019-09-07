using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diagnoses
{
    public partial class Form3 : Form
    {
        public string a = "",
            bol = "Сузакская Территориальная Больница",
            pui = "Протокол ультразвукового исследования",
            prob1 = "                                 ",
            prob2 = "                           ",
            prob3 = "     ",
            a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "", a7 = "", a8 = "", a9 = "", a10 = "", a11 = "", a12 = "", a13 = "", a14 = "",
            zklu1 = "", zklu2 = "", zklu3 = "", zklu4 = "", zklu5 = "", zklu6 = "", zklu7 = "", zklu8 = "", zklu9 = "", zklu10 = "", zklu11 = "", zklu12 = "", zklu13 = "", zklu14 = "",
            organ1 ="", organ2="", organ3="", organ4="", organ5="", organ6="", organ7="", organ8 = "", organ9 = "", organ10 = "", organ11 = "", organ12 = "", organ13 = "", organ14 = "";

        public string Getval
        {
            get
            {
                return a;
            }
        }
        public Form3()
        {

            InitializeComponent();
            textBox1.Select();
            button11.Enabled = false;
            clean();
        }
        private void clean()
        {
            radioButton1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            radioButton24.Visible = false;
            radioButton25.Visible = false;
            radioButton26.Visible = false;
            radioButton27.Visible = false;
            radioButton28.Visible = false;
            radioButton29.Visible = false;
            radioButton30.Visible = false;
            radioButton31.Visible = false;
            radioButton32.Visible = false;
            radioButton33.Visible = false;
            radioButton34.Visible = false;
            radioButton35.Visible = false;
            radioButton36.Visible = false;
            radioButton37.Visible = false;
            radioButton38.Visible = false;
            radioButton39.Visible = false;
            radioButton40.Visible = false;
            radioButton41.Visible = false;
            radioButton42.Visible = false;
            radioButton43.Visible = false;
            radioButton44.Visible = false;
            radioButton45.Visible = false;
            radioButton46.Visible = false;
            radioButton47.Visible = false;


            richTextBox1.Text = "";
            textBox4.Text = "";
          

        }
        string
                                                                                              //Заключении для печени
                                                                                              pe = "   Печень - ",
                 nor1 = "не увеличена, контуры четкие, ровные, паренхима обычной акустической плотности, однородная, мелкозернистая, без видимой очаговой патологии. Сосудистая и билиарная сеть не расширена.",
                 sp = "не увеличена, контуры нечеткие, края неровные, паренхима печени повышенной эхоплотности, диффузно неоднородная за счет фиброза печеночной ткани, четко ограниченных узловых образований не выявлено, сосуды печени местами расширены, билиарная сеть не изменена.",
                 dzg = "слегка увеличена, контуры закруглены, края ровные, структура паренхимы повышенной эхоплотности, однородная, ограниченных узловых образований не выявлено. Сосуды печени и внутрипеченочные желчные протоки не расширены. Отмечается двойной контур желчного пузыря.",
                 hg = "увеличена, контуры четкие, закруглены, края ровные, эхогенность паренхимы понижена, структура уплотнена, неоднородная, видимой очаговой патологии не выявлено, сосудистая и билиарная сеть не расширена.",
                 ppn = "увеличена в размере, контуры ее закруглены, паренхима печени диффузно пониженной эхоплотности, однородная, признаков очаговой патологии не выявлено, сосуды печени расширены, вена порте-мм, нижняя полая вена-мм",
                 jg = "увеличена, контуры нечеткие, закруглены, края ровные, эхогенность паренхимы диффузно повышена, однородная, мелкозернистая, без видимой очаговой патологии, сосудистый рисунок печени обеднен.",
                 ap = "не увеличена, контуры нечеткие, паренхима однородная, обычной акустической плотности, в проекции---сегмента печени определяется кистозное образование с утолщенными и уплотненными стенками р:-мм. Сосудистая и билиарная сеть не изменена.";
        //Заключении для желчного пузыря
       string
                                                                                       ge = "   Желчный пузырь - ",
            nor2 = "обычной формы и размеров, стенки не утолщены, содержимое гомогенное, без признаков конкрементов. Холедох – не расширен.",
            hh = "не увеличен, стенки его утолщены и уплотнены, содержимое гомогенное, без признаков конкрементов.  Холедох - не расширен.",
            gkbh = "стенки его утолщены и уплотнены, в просвете конкременты размером до  мм. и менее. Холедох- не расширен.",
            gkbo = "резко увеличен, деформирован, стенки диффузно утолщены, местами двухслойные, в просвете густой желчь и конкременты размером до  мм. Холедох - нерасширен.",
            po = "Холецистэктомия. Холедох - не расширен.";

        






        //заключении для поджелудочной железы
      string
                                                                             pg = "   Поджелудочная железа - ",
             nor3 = "не увеличена, подковообразной формы, контуры ее ровные, четкие, структура паренхимы однородная, без видимой очаговой патологии. Панкреатический проток нерасширен.",
             hp = "слегка увеличена, контуры нечеткие, ровные, структура паренхимы однородная, повышенной эхоплотности, без видимой очаговой патологии. Панкреатический проток слегка расширен.",
             op = "увеличена, контуры нечеткие, неровные, паренхима диффузно повышенной эхогенности, однородная, очаговой патологии не выявлено, панкреатический проток расширен.";

       





        //заключении для селезенка
        string
                                                                                sel = "   Селезенка - ",
              nor4 = "не увеличена, контуры ее четкие, ровные, структура паренхимы однородная, без очаговой патологии. Сосуды селезенки не расширены.",
              cpl = "увеличена, контуры ее ровные, четкие, структура паренхимы однородная, без очаговых изменений, Сосуды селезенки не расширены.";

        





        //заключении для Брюшной полости.
        string
                                                                           bp = "   Брюшная полость - ",
             nor5 = " в брюшной полости наличие свободной жидкости и узловых образований не выявлено.",
             at = "в брюшной полости определяется наличие свободной жидкости в большом количестве.",
             pkn = "в брюшной полости определяются расширенные петли кишечника и наличие свободной жидкости в умеренном количестве. Наличие кистозных и узловых образований четко не выявлено.";

      





        //заключении для почки.
        string
                                                                            po4 = "   Почки - ",
            nor6 = "с 2-х сторон нормальных размеров, бобовидной формы, расположены в типичном месте, контуры их ровные, четкие, паренхима однородная, кортико-медуллярная дифференциация сохранена, без видимой очаговой патологии. ЧЛС – не расширена, признаков конкрементов не выявлено.",
            hpi = "с 2-х сторон не увеличены, расположены в типичном месте, контуры их четкие, паренхима обеих почек однородная, без очаговой патологии. ЧЛС – деформирована, местами уплотнена ,не расширена, признаков конкрементов не выявлено.",
            pgpp = "Правая почка слегка увеличена, контуры нечеткие, паренхима однородная, без видимой очаговой патологии. ЧЛС – расширена, деформирована, конкрементов четко не выявлено." + "\n" +"   "+ "Левая почка - не увеличена, контуры четкие, ровные, паренхима однородная. ЧЛС – не расширена, конкрементов не выявлено.",
            kpp = "Правая почка не увеличена, контуры нечетки, паренхима однородная, очаговой патологии нет. ЧЛС – не расширена, деформирована, местами уплотнена, ------- чашке конкремент р:10мм." + "\n"+"   " + "Левая почка - не увеличена, контуры четкие, ровные, паренхима однородная. ЧЛС – не расширена, признаков конкрементов не выявлено.",
            ddp = "с обеих сторон увеличены, контуры  их нечеткие, паренхима почек местами утолщена, однородная, без видимой очаговой патологии. ЧЛС – деформирована, местами расширена, признаков камнеобразования не выявлено. ";


        //Мягкие ткани
        string
                                                                         mt = "   Мягкие ткани - ";
        //заключении для Мочевого пузыря.
       string
                                                                       mp = "   Мочевой пузырь - ",
            nor7 = "Мочевой пузырь наполнен, обычной формы, стенки не утолщены, без признаков пролиферативных изменений, содержимое гомогенное, признаков конкрементов не выявлено.",
            oss = "наполнен, стенки диффузно утолщены, содержимое гомогенное, конкрементов не выявлено.";

       


        //заключении для Предстательной железы.
        string
                                                            pj = "   Предстательная железа - ",
            nor8 = "не увеличена, контуры ровные, четкие, капсула не утолщена, структура паренхимы однородная, мелкозернистая,  без признаков узлообразования, простатический отдел уретры не изменен.",
            hpro = "слегка увеличена, р:----,контуры нечеткие, капсула местами утолщена и уплотнена, паренхима повышенной эхоплотности, однородная, без очаговых изменений. Простатическая часть уретры местами расширена.",
            dgpj = "резко увеличена, р:----, выступает в просвет пузыря, контуры нечеткие, местами неровные, капсула  уплотнена, местами утолщена, паренхима неоднородная, признаков очаговой патологии не выявлено, простатическая часть уретры расширена, извитая.";

       





        //заключении для Органы машонки.
        string
                                                   om = "   Органы машонки - ",
            nor9 = "яички и их придатки с 2-х сторон не увеличены,  паренхима однородная, без видимой очаговой патологии, в полостях мошонки с обеих сторон наличие свободной жидкости и ограниченных образований не выявлено, гроздевидное сплетение не расширено.",
            oos = "яичко и его придаток справа слегка увеличены, паренхима повышенной эхогенности, однородная, без очаговой патологии, в правой половине машонки имеется незначительная свободная жидкость. Слева яичко и придаток без изменений. Сосуды семенного канатика не расширены.",
            vys = "яички и их придатки с 2-х сторон не увеличены, контуры их четкие, паренхима однородная, без очаговой патологии, в правой половине мошонки определяется наличие свободной жидкости в --- количестве, гроздевидное сплетение с обеих сторон не расширено.",
            vsks = "яички и придатки с 2-х сторон не увеличены,  паренхима однородная, без очаговой патологии, в правой половине мошонки определяется ограниченная жидкость в умеренном количестве, гроздевидное сплетение не расширено.",
            vs = "яички и придатки с 2-х сторон не увеличены, паренхима однородная, без очаговой патологии, в полостях мошонки с обеих сторон наличие жидкости и ограниченных образований не выявлено, отмечается расширение и извитость гроздевидного сплетения слева.";

       

        //заключении для матки.
        string
                                                      mat = "   Матка - ",
        nor10 = "расположена правильно, не увеличена, контуры четкие, ровные, миометрий однородный, эндометрий соответствует циклу, яичники с обеих сторон не изменены, без признаков фолликулярных изменений, задний свод свободен.",
        bn1 = "В полости матки 1 плодное яйцо диаметром ---мм, КТР----мм.Сердцебиение +. Харион по передней стенке.Желточный мешок - ---мм.",
        bn2 = "В полости матки 1 плод в головном предлежании, БПР - мм,  ДБ - мм, Сердцебиение  +, Шевеление +. Со стороны внутренних  органов патологии не выявлено. "+"\n"+"   "+"Плацента расположена по передней стенке --- степени, толщиной---мм.Околоплодные воды в норме.";
        //заключении для Молочной железы.
        string
                                                           mj = "   Молочная железа - ",
            nor11 = "Строма обеих молочных желез однородной средней звуковой плотности. Протоки   молочных желез не расширены. Подкожно жировая клетчатка и жировая клетчатка ретромаммарного  пространства без особенностей.",
            dkmlmg = "Структура паренхимы правой молочной железы однородная, признаков узлообразования не выявлено. Молочные протоки не расширены."+"\n"+"   "+"По --- квадранту левой молочной железы просматривается кистозное образование р: ---мм.";

        //заключении для Щитовидной железы.
        string
                                                           shj = "   Щитовидная железа - ",
          nor12 = "не увеличена, размеры соответствуют возрастным нормам, контуры ровные, четкие, эхоструктура паренхимы однородная, признаков узлообразования не выявлено.",
            gsj = "слегка увеличена, правая доля-мм, левая доля-мм, перешеек-мм, контуры ровные, четкие, эхоструктура паренхимы однородная, без видимых узловых образований.",
            dz = "увеличена, правая доля-мм, левая доля-мм, перешеек-мм, контуры ровные, четкие, структура паренхимы диффузно уплотнена, неоднородная, местами отмечаются гипо- и гиперэхогенные участки, четко ограниченных узловых образований не выявлено.";

        //заключении для Плевральной полости.
        string
                                                          pp = "   Плевральная полость - ",
            nor13 = "",
            aps = "в проекции синуса правого легкого определяется наличие свободной жидкости в большом количестве.",
            dep = "в проекции синусов легких с обеих сторон определяется наличие свободной жидкости в умеренном количестве.";


        string
            organ,
            bol1 = "Сузакская территориальная больница.",
            pui1 = "Протокол ультразвукового исследования.",
            cstr = "Данное заключение не является окончательным диагнозом, должен быть интерпретирован лечащим врачом с использованием клинико-лабороторных данных.",
            vra4 = "Врач УЗД:                                            Абдумоминов. А.";
        int sh = 0,r=12;


       












        //Печень 
        private void button1_Click(object sender, EventArgs e)
        {
            clean();
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            organ = pe;


        }


        //начало
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor1;
            textBox4.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = sp;
            textBox4.Text = radioButton2.Text;
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text = dzg;
            textBox4.Text = radioButton3.Text;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = hg;
            textBox4.Text = radioButton4.Text;

        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = ppn;
            textBox4.Text = radioButton7.Text;
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  jg;
            textBox4.Text = radioButton8.Text;
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = ap;
            textBox4.Text = radioButton9.Text;
        }
        //конец





        //Желчный пузырь.
        private void button8_Click(object sender, EventArgs e)
        {
            clean();
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            organ = ge;
        }




        //начало

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  nor2;
            textBox4.Text = radioButton5.Text;
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  hh;
            textBox4.Text = radioButton6.Text;
        }


        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  gkbh;
            textBox4.Text = radioButton10.Text;
        }



        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  gkbo;
            textBox4.Text = radioButton11.Text;
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  po;
            textBox4.Text = radioButton12.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
                button11.Enabled = true;
            else
                button11.Enabled = false;

        }




        //конец


        //поджелудочны

        private void button6_Click(object sender, EventArgs e)
        {
            clean();
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            organ = pg;
        }

        //начало
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  nor3;
            textBox4.Text = radioButton13.Text;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  hp;
            textBox4.Text = radioButton14.Text;
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  op;
            textBox4.Text = radioButton15.Text;
        }
        //конец



        //Селезенка


        private void button4_Click(object sender, EventArgs e)
        {
            clean();
            radioButton16.Visible = true;
            radioButton17.Visible = true;
            organ = sel;
        }



        //начало

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor4;
            textBox4.Text = radioButton16.Text;

        }
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  cpl;
            textBox4.Text = radioButton17.Text;
        }

        //Конец




        //Брюшной полости.
        private void button13_Click(object sender, EventArgs e)
        {
            clean();
            radioButton18.Visible = true;
            radioButton19.Visible = true;
            radioButton20.Visible = true;
            organ = bp;

        }

        //начало



        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  nor5;
            textBox4.Text = radioButton18.Text;
        }


        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  at;
            textBox4.Text = radioButton19.Text;
        }

        private void radioButton20_CheckedChanged_1(object sender, EventArgs e)
        {
            richTextBox1.Text =  pkn;
            textBox4.Text = radioButton20.Text;
        }

        //конец




        //Почки
        private void button3_Click(object sender, EventArgs e)
        {
            clean();
            radioButton21.Visible = true;
            radioButton22.Visible = true;
            radioButton23.Visible = true;
            radioButton24.Visible = true;
            radioButton25.Visible = true;
            organ = po4;
        }

        //начало

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  nor6;
            textBox4.Text = radioButton21.Text;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = hpi;
            textBox4.Text = radioButton22.Text;

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = pgpp;
            textBox4.Text = radioButton23.Text;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = kpp;
            textBox4.Text = radioButton24.Text;
        }
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text =  ddp;
            textBox4.Text = radioButton25.Text;
        }

        //конец

                   //Мягкие ткани
        private void button16_Click(object sender, EventArgs e)
        {
            clean();
            radioButton26.Visible = true;
            organ = mt;
        }
        //начало
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "---";
            textBox4.Text = radioButton26.Text;
        }
        //конец












        //Мочевой пузырь
        private void button2_Click(object sender, EventArgs e)
        {
            clean();
            radioButton27.Visible = true;
            radioButton28.Visible = true;
            organ = mp;


        }




        //начало

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor7;
            textBox4.Text = radioButton27.Text;
        }
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = oss;
            textBox4.Text = radioButton28.Text;
        }


        //конец







        //Предстательная железа.
        private void button20_Click(object sender, EventArgs e)
        {
            clean();
            radioButton29.Visible = true;
            radioButton30.Visible = true;
            radioButton31.Visible = true;
            organ = pj;
        }

        //начало
        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor8;
            textBox4.Text = radioButton29.Text;
        }
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = hpro;
            textBox4.Text = radioButton30.Text;
        }
        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dgpj;
            textBox4.Text = radioButton31.Text;
        }


        //конец






        //Органы машонки.
        private void button17_Click(object sender, EventArgs e)
        {
            clean();
            radioButton32.Visible = true;
            radioButton33.Visible = true;
            radioButton34.Visible = true;
            radioButton35.Visible = true;
            radioButton36.Visible = true;
            organ = om;



        }
        //начало

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {

            richTextBox1.Text = nor9;
            textBox4.Text = radioButton32.Text;

        }
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = oos;
            textBox4.Text = radioButton33.Text;
        }
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = vys;
            textBox4.Text = radioButton34.Text;

        }
        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = vsks;
            textBox4.Text = radioButton35.Text;
        }
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = vs;
            textBox4.Text = radioButton36.Text;

        }

        //конец

        // матка
        private void button5_Click(object sender, EventArgs e)
        {
            clean();
            radioButton37.Visible = true;
            radioButton38.Visible = true;
            radioButton39.Visible = true;
            organ = mat;
        }

        //начало
        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor10;
            textBox4.Text = radioButton37.Text;

        }
        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = bn1;
            textBox4.Text = radioButton38.Text;
        }
        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = bn2;
            textBox4.Text = radioButton39.Text;
        }
        //конец





       //молочная железа
        private void button7_Click(object sender, EventArgs e)
        {
            clean();
            radioButton40.Visible = true;
            radioButton41.Visible = true;
            organ = mj;
        }

        //начало
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor11;
            textBox4.Text = radioButton40.Text;
        }
        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dkmlmg;
            textBox4.Text = radioButton41.Text;
        }

        //конец



        //Щитовидная железа.
        private void button14_Click(object sender, EventArgs e)
        {
            clean();
            radioButton42.Visible = true;
            radioButton43.Visible = true;
            radioButton44.Visible = true;
            organ = shj;
        }
        //начало
        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = nor12;
            textBox4.Text = radioButton42.Text;
        }
        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = gsj;
            textBox4.Text = radioButton43.Text;
        }
        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dz;
            textBox4.Text = radioButton44.Text;
        }

        //конец



        //Плевральная полость.
        private void button15_Click(object sender, EventArgs e)
        {
            clean();
            radioButton45.Visible = true;
            radioButton46.Visible = true;
            radioButton47.Visible = true;
            organ = pp;  
        }
        //начало
        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "---";
            textBox4.Text = radioButton45.Text;
        }
        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = aps;
            textBox4.Text = radioButton46.Text;
        }
        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dep;
            textBox4.Text = radioButton47.Text;

        }
        //конец

     





        private void button11_Click(object sender, EventArgs e)
        {
            sh++;
            if(sh==1)
            {
                organ1 = organ;
                a1 = richTextBox1.Text;
                zklu1 ="\n          "+"Заключение:"+ textBox4.Text+"\n";
            }
            if (sh == 2)
            {
                organ2 = organ;
                a2 = richTextBox1.Text;
                zklu2 = "\n          " + "Заключение:" + textBox4.Text+"\n";
            }
            if (sh == 3)
            {
                organ3 = organ;
                a3 = richTextBox1.Text;
                zklu3 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 4)
            {
                organ4 = organ;
                a4 = richTextBox1.Text;
                zklu4 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 5)
            {
                organ5 = organ;
                a5 = richTextBox1.Text;
                zklu5 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 6)
            {
                organ6 = organ;
                a6 = richTextBox1.Text;
                zklu6 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 7)
            {
                organ7 = organ;
                a7 = richTextBox1.Text;
                zklu7 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 8)
            {
                organ8 = organ;
                a8 = richTextBox1.Text;
                zklu8 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 9)
            {
                organ9 = organ;
                a9 = richTextBox1.Text;
                zklu9 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 10)
            {
                organ10 = organ;
                a10 = richTextBox1.Text;
                zklu10 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 11)
            {
                organ11 = organ;
                a11 = richTextBox1.Text;
                zklu11 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 12)
            {
                organ12 = organ;
                a12 = richTextBox1.Text;
                zklu12 = "\n          " + "Заключение:" + textBox4.Text + "\n";
                r = 11;
            }
            if (sh == 13)
            {
                organ13 = organ;
                a13 = richTextBox1.Text;
                zklu13 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 14)
            {
               
                organ14 = organ;
                a14 = richTextBox1.Text;
                zklu14 = "\n          " + "Заключение:" + textBox4.Text + "\n";
            }
            if (sh == 15)
            {
                richTextBox1.Text = "";
                textBox4.Text = "";
                richTextBox1.SelectionFont = new Font("Times New Roman", 19, FontStyle.Bold);
                richTextBox1.SelectedText = "\n"+"\n"+prob2 + "Вы уже заполнили 14 заключении";
                button11.Enabled = false;


            }
            else
            {

                textBox4.Text = "";
                richTextBox1.Text = "";
            }



        }





        private void button9_Click(object sender, EventArgs e)
        {
            Form4 zak = new Form4();
                                        //Title
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText =prob1+"       "+bol1+"\n"+prob1+"     "+pui1+"\n"+"\n";
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText =label3.Text + textBox1.Text+"." + "\n" +  label4.Text + textBox3.Text + "." +  "\n" + label5.Text + textBox5.Text + "." + "\n" + "\n";

                                          //1
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ1;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a1;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r,FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu1;
                                            //2
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ2;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a2;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu2;
                                            //3
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ3;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a3;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu3;
                                             //4
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ4;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a4;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu4;
                                               //5
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ5;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a5;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu5;
                                                //6
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ6;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a6;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu6;
                                                //7
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ7;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a7;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu7;
                                                 //8
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ8;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a8;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu8;
                                                  //9
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ9;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a9;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu9;
                                                   //10
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ10;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a10;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu10;
                                                   //11
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ11;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a11;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu11;
                                                    //12
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ12;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a12;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu12;
                                                     //13
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ13;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a13;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu13;
                                                     //14
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = organ14;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r);
            zak.richTextBoxPrintCtrl1.SelectedText = a14;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", r, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = zklu14;

            //Final
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 9);
            zak.richTextBoxPrintCtrl1.SelectedText = "\n"+cstr;
            zak.richTextBoxPrintCtrl1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            zak.richTextBoxPrintCtrl1.SelectedText = "\n"  + "\n" +prob2+ vra4;


            if (zak.ShowDialog() == DialogResult.OK)
                a = textBox1.Text;
        }
    
    
        private void button10_Click(object sender, EventArgs e)
        {
            a1 = ""; a2 = ""; a3 = ""; a4 = ""; a5 = ""; a6 = ""; a7 = ""; a8 = ""; a9 = ""; a10 = ""; a11 = "";  a12 = ""; a13 = ""; a14 = "";
            zklu1 = ""; zklu2 = ""; zklu3 = ""; zklu4 = ""; zklu5 = ""; zklu6 = ""; zklu7 = ""; zklu8 = ""; zklu9 = ""; zklu10 = ""; zklu11 = ""; zklu12 = ""; zklu13 = ""; zklu14 = "";
            organ1 = ""; organ2 = ""; organ3 = ""; organ4 = ""; organ5 = ""; organ6 = ""; organ7 = ""; organ8 = ""; organ9 = ""; organ10 = ""; organ11 = ""; organ12 = ""; organ13 = ""; organ14 = "";
            r = 12;
            sh = 0;
            clean();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox1.Select();
        }
        private void button12_Click(object sender, EventArgs e)
        {   
            Close();
        }
                        
        
        
        
                           //Переход крусора при нажатии клавишу enter 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (sender.Equals(textBox1))
                    textBox3.Focus();

            }
            return;


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox3))
                        button1.Focus();
                }
                return;
            }
            e.Handled = true;

        }

  
    }
}
