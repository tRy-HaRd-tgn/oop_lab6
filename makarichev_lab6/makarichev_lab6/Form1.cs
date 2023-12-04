using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makarichev_lab6
{

    public partial class Form1 : Form
    {

        Shape ptr1 = null;// фигура 1
        Shape ptr2 = null;// фигура 2
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//отвечает за ptr1
        {
            label1.Text += " - КВАДРАТ";
            ptr1 = Shape.createShape(1);//создание квадрата
            ((Control)checkBox1).Hide();
            ((Control)checkBox2).Hide();
            ((Control)label3).Visible = true;
            ((Control)textBox1).Visible = true;
            ((Control)enter).Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//отвечает за ptr1
        {
            label1.Text += " - ПАРАЛЛЕЛОГРАМ";
            ptr1 = Shape.createShape(2);//создание параллелограма
            ((Control)checkBox1).Hide();
            ((Control)checkBox2).Hide();
            ((Control)label3).Visible = true;
            ((Control)textBox1).Visible = true;
            ((Control)enter).Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//отвечает за ptr2
        {
            label2.Text += " - КВАДРАТ";
            ptr2 = Shape.createShape(1);//создание квадрата
            ((Control)checkBox3).Hide();
            ((Control)checkBox4).Hide();
            ((Control)label18).Visible = true;
            ((Control)textBox16).Visible = true;
            ((Control)button15).Visible = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)//отвечает за ptr2
        {
            label2.Text += " - ПАРАЛЛЕЛОГРАМ";
            ptr2 = Shape.createShape(2);//создание параллелограма
            ((Control)checkBox3).Hide();
            ((Control)checkBox4).Hide();
            ((Control)label18).Visible = true;
            ((Control)textBox16).Visible = true;
            ((Control)button15).Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //ЗАПОЛНЕНИЕ ПЕРВОЙ ФИГУРЫ 
        private void enter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                ((Control)label4).Visible = true;
                ((Control)textBox2).Visible = true;
                ((Control)button2).Visible = true;

                ((Control)label3).Visible = false;
                ((Control)textBox1).Visible = false;
                ((Control)enter).Visible = false;
                ptr1.setx1(Convert.ToDouble(textBox1.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                ((Control)label5).Visible = true;
                ((Control)textBox3).Visible = true;
                ((Control)button3).Visible = true;

                ((Control)label4).Visible = false;
                ((Control)textBox2).Visible = false;
                ((Control)button2).Visible = false;
                ptr1.sety1(Convert.ToDouble(textBox2.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                ((Control)label6).Visible = true;
                ((Control)textBox4).Visible = true;
                ((Control)button4).Visible = true;

                ((Control)label5).Visible = false;
                ((Control)textBox3).Visible = false;
                ((Control)button3).Visible = false;
                ptr1.setx2(Convert.ToDouble(textBox3.Text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                ((Control)label10).Visible = true;
                ((Control)textBox8).Visible = true;
                ((Control)button7).Visible = true;

                ((Control)label6).Visible = false;
                ((Control)textBox4).Visible = false;
                ((Control)button4).Visible = false;
                ptr1.sety2(Convert.ToDouble(textBox4.Text));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                ((Control)label9).Visible = true;
                ((Control)textBox7).Visible = true;
                ((Control)button6).Visible = true;

                ((Control)label10).Visible = false;
                ((Control)textBox8).Visible = false;
                ((Control)button7).Visible = false;
                ptr1.setx3(Convert.ToDouble(textBox8.Text));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                ((Control)label8).Visible = true;
                ((Control)textBox6).Visible = true;
                ((Control)button5).Visible = true;

                ((Control)label9).Visible = false;
                ((Control)textBox7).Visible = false;
                ((Control)button6).Visible = false;
                ptr1.sety3(Convert.ToDouble(textBox7.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                ((Control)label7).Visible = true;
                ((Control)textBox5).Visible = true;
                ((Control)button1).Visible = true;

                ((Control)label8).Visible = false;
                ((Control)textBox6).Visible = false;
                ((Control)button5).Visible = false;
                ptr1.setx4(Convert.ToDouble(textBox6.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                ((Control)label2).Visible = true;
                ((Control)checkBox3).Visible = true;
                ((Control)checkBox4).Visible = true;

                ((Control)label7).Visible = false;
                ((Control)textBox5).Visible = false;
                ((Control)button1).Visible = false;
                ((Control)richTextBox1).Visible = true;

                ((Control)label37).Visible = true;

                ((Control)label21).Visible = true;
                ((Control)textBox17).Visible = true;
                ((Control)button17).Visible = true;
                ((Control)button16).Visible = true;

                ptr1.sety4(Convert.ToDouble(textBox5.Text));
                ptr1.centerOfGravity();
                ((Control)label22).Visible = true;
                ((Control)label23).Visible = true; label23.Text += Convert.ToString(ptr1.getCenterOfGravityX());
                ((Control)label24).Visible = true; label24.Text += Convert.ToString(ptr1.getCenterOfGravityY());

                ((Control)label25).Visible = true;
                ((Control)label26).Visible = true;
                ((Control)label27).Visible = true;
                ((Control)textBox18).Visible = true;
                ((Control)textBox19).Visible = true;
                ((Control)button18).Visible = true;

                //
                richTextBox1.Text += "x1 - "; richTextBox1.Text += ptr1.getx1(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y1 - "; richTextBox1.Text += ptr1.gety1(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x2 - "; richTextBox1.Text += ptr1.getx2(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y2 - "; richTextBox1.Text += ptr1.gety2(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x3 - "; richTextBox1.Text += ptr1.getx3(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y3 - "; richTextBox1.Text += ptr1.gety3(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x4 - "; richTextBox1.Text += ptr1.getx4(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y4 - "; richTextBox1.Text += ptr1.gety4(); richTextBox1.Text += "\n";
                //
                ((Control)label20).Visible = true;
                label37.Text = (Convert.ToString(ptr1.square()));
            }
        }

        //НАЧАЛО ЗАПОЛНЕНИЯ ВТОРОЙ ФИГУРЫ
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                ((Control)label17).Visible = true;
                ((Control)textBox15).Visible = true;
                ((Control)button14).Visible = true;

                ((Control)label18).Visible = false;
                ((Control)textBox16).Visible = false;
                ((Control)button15).Visible = false;
                ptr2.setx1(Convert.ToDouble(textBox16.Text));
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                ((Control)label16).Visible = true;
                ((Control)textBox14).Visible = true;
                ((Control)button13).Visible = true;

                ((Control)label17).Visible = false;
                ((Control)textBox15).Visible = false;
                ((Control)button14).Visible = false;
                ptr2.sety1(Convert.ToDouble(textBox15.Text));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                ((Control)label15).Visible = true;
                ((Control)textBox13).Visible = true;
                ((Control)button12).Visible = true;

                ((Control)label16).Visible = false;
                ((Control)textBox14).Visible = false;
                ((Control)button13).Visible = false;
                ptr2.setx2(Convert.ToDouble(textBox14.Text));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                ((Control)label14).Visible = true;
                ((Control)textBox12).Visible = true;
                ((Control)button11).Visible = true;

                ((Control)label15).Visible = false;
                ((Control)textBox13).Visible = false;
                ((Control)button12).Visible = false;
                ptr2.sety2(Convert.ToDouble(textBox13.Text));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                ((Control)label13).Visible = true;
                ((Control)textBox11).Visible = true;
                ((Control)button10).Visible = true;

                ((Control)label14).Visible = false;
                ((Control)textBox12).Visible = false;
                ((Control)button11).Visible = false;
                ptr2.setx3(Convert.ToDouble(textBox12.Text));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                ((Control)label12).Visible = true;
                ((Control)textBox10).Visible = true;
                ((Control)button9).Visible = true;

                ((Control)label13).Visible = false;
                ((Control)textBox11).Visible = false;
                ((Control)button10).Visible = false;
                ptr2.sety3(Convert.ToDouble(textBox11.Text));
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                ((Control)label11).Visible = true;
                ((Control)textBox9).Visible = true;
                ((Control)button8).Visible = true;

                ((Control)label12).Visible = false;
                ((Control)textBox10).Visible = false;
                ((Control)button9).Visible = false;
                ptr2.setx4(Convert.ToDouble(textBox10.Text));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                ((Control)label11).Visible = false;
                ((Control)textBox9).Visible = false;
                ((Control)button8).Visible = false;
                ((Control)richTextBox2).Visible = true;

                ((Control)label29).Visible = true;
                ((Control)button19).Visible = true;

                ((Control)label30).Visible = true;
                ((Control)textBox20).Visible = true;
                ((Control)button20).Visible = true;
                ((Control)button21).Visible = true;

                ((Control)label31).Visible = true;
                ((Control)label32).Visible = true;
                ((Control)label33).Visible = true;

                ((Control)label35).Visible = true;
                ((Control)label36).Visible = true;
                ((Control)label34).Visible = true;

                ((Control)textBox21).Visible = true;
                ((Control)textBox22).Visible = true;
                ((Control)label28).Visible = true;

                ((Control)label19).Visible = true; 
                if (Operations.compare(ptr1, ptr2) == 1) 
                {
                    label19.Text = "Площадь первой фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 2)
                {
                    label19.Text = "Площадь второй фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 0)
                {
                    label19.Text = "Площади фигур одинаковы ";
                }
                ((Control)label38).Visible = true;
                if (Operations.isInclude(ptr1, ptr2) == true)
                {
                    label38.Text = "Первая фигура включена во вторую ";
                }
                else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
                if (Operations.inTersect(ptr1, ptr2) == true)
                {
                    label39.Text = "Фигуры пересекаются ";
                }
                else { label39.Text = "Фигуры не пересекаются "; }
                label29.Text = Convert.ToString(ptr2.square());
                ptr2.sety4(Convert.ToDouble(textBox9.Text));
                label32.Text = "";
                label33.Text = "";
                label32.Text += "x - "; label32.Text += Convert.ToString(ptr2.getCenterOfGravityX());
                label33.Text += "y - "; label33.Text += Convert.ToString(ptr2.getCenterOfGravityY());
                richTextBox2.Text += "x1 - "; richTextBox2.Text += ptr2.getx1(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y1 - "; richTextBox2.Text += ptr2.gety1(); richTextBox2.Text += "\n";
                //
                richTextBox2.Text += "x1 - "; richTextBox2.Text += ptr2.getx1(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y1 - "; richTextBox2.Text += ptr2.gety1(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x2 - "; richTextBox2.Text += ptr2.getx2(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y2 - "; richTextBox2.Text += ptr2.gety2(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x3 - "; richTextBox2.Text += ptr2.getx3(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y3 - "; richTextBox2.Text += ptr2.gety3(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x4 - "; richTextBox2.Text += ptr2.getx4(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y4 - "; richTextBox2.Text += ptr2.gety4(); richTextBox2.Text += "\n";
                //
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox17.Text != "")
            {
                ptr1.centerOfGravity();//вычисление центра тяжести
                ptr1.rotate(Convert.ToInt32(textBox17.Text));
                richTextBox1.Clear();//очистить поле с координатами
                
                label23.Text = "";
                label24.Text = "";
                label23.Text += "x - "; label23.Text += Convert.ToString(ptr1.getCenterOfGravityX());
                label24.Text += "y - "; label24.Text += Convert.ToString(ptr1.getCenterOfGravityY());
                //заново заполнить поле с координатами
                richTextBox1.Text += "x1 - "; richTextBox1.Text += ptr1.getx1(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y1 - "; richTextBox1.Text += ptr1.gety1(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x2 - "; richTextBox1.Text += ptr1.getx2(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y2 - "; richTextBox1.Text += ptr1.gety2(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x3 - "; richTextBox1.Text += ptr1.getx3(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y3 - "; richTextBox1.Text += ptr1.gety3(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x4 - "; richTextBox1.Text += ptr1.getx4(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y4 - "; richTextBox1.Text += ptr1.gety4(); richTextBox1.Text += "\n";
                ((Control)label19).Visible = true;
                if (Operations.compare(ptr1, ptr2) == 1)
                {
                    label19.Text = "Площадь первой фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 2)
                {
                    label19.Text = "Площадь второй фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 0)
                {
                    label19.Text = "Площади фигур одинаковы ";
                }
                ((Control)label38).Visible = true;
                if (Operations.isInclude(ptr1, ptr2) == true)
                {
                    label38.Text = "Первая фигура включена во вторую ";
                }
                else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
                if (Operations.inTersect(ptr1, ptr2) == true)
                {
                    label39.Text = "Фигуры пересекаются ";
                }
                else { label39.Text = "Фигуры не пересекаются "; }
                label37.Text = Convert.ToString(ptr1.square());
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox18.Text != "" && textBox19.Text != "")
            {
                ptr1.move(Convert.ToInt32(textBox18.Text), Convert.ToInt32(textBox19.Text));
                ptr1.centerOfGravity();
                richTextBox1.Clear();//очистить поле с координатами

                label23.Text = "";
                label24.Text = "";
                label23.Text += "x - "; label23.Text += Convert.ToString(ptr1.getCenterOfGravityX());
                label24.Text += "y - "; label24.Text += Convert.ToString(ptr1.getCenterOfGravityY());
                //заново заполнить поле с координатами
                richTextBox1.Text += "x1 - "; richTextBox1.Text += ptr1.getx1(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y1 - "; richTextBox1.Text += ptr1.gety1(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x2 - "; richTextBox1.Text += ptr1.getx2(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y2 - "; richTextBox1.Text += ptr1.gety2(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x3 - "; richTextBox1.Text += ptr1.getx3(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y3 - "; richTextBox1.Text += ptr1.gety3(); richTextBox1.Text += "\n";

                richTextBox1.Text += "x4 - "; richTextBox1.Text += ptr1.getx4(); richTextBox1.Text += "\n";
                richTextBox1.Text += "y4 - "; richTextBox1.Text += ptr1.gety4(); richTextBox1.Text += "\n";
                ((Control)label19).Visible = true;
                if (Operations.compare(ptr1, ptr2) == 1)
                {
                    label19.Text = "Площадь первой фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 2)
                {
                    label19.Text = "Площадь второй фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 0)
                {
                    label19.Text = "Площади фигур одинаковы ";
                }
                ((Control)label38).Visible = true;
                if (Operations.isInclude(ptr1, ptr2) == true)
                {
                    label38.Text = "Первая фигура включена во вторую ";
                }
                else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
                if (Operations.inTersect(ptr1, ptr2) == true)
                {
                    label39.Text = "Фигуры пересекаются ";
                }
                else { label39.Text = "Фигуры не пересекаются "; }

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox21.Text != "" && textBox22.Text != "")
            {
                ptr2.move(Convert.ToInt32(textBox21.Text), Convert.ToInt32(textBox22.Text));
                richTextBox2.Clear();
                ptr2.centerOfGravity();
                label32.Text = "";
                label33.Text = "";
                label32.Text += "x - "; label32.Text += Convert.ToString(ptr2.getCenterOfGravityX());
                label33.Text += "y - "; label33.Text += Convert.ToString(ptr2.getCenterOfGravityY());
                richTextBox2.Text += "x1 - "; richTextBox2.Text += ptr2.getx1(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y1 - "; richTextBox2.Text += ptr2.gety1(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x2 - "; richTextBox2.Text += ptr2.getx2(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y2 - "; richTextBox2.Text += ptr2.gety2(); richTextBox2.Text += "\n";
                    
                richTextBox2.Text += "x3 - "; richTextBox2.Text += ptr2.getx3(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y3 - "; richTextBox2.Text += ptr2.gety3(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x4 - "; richTextBox2.Text += ptr2.getx4(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y4 - "; richTextBox2.Text += ptr2.gety4(); richTextBox2.Text += "\n";
                ((Control)label19).Visible = true;
                if (Operations.compare(ptr1, ptr2) == 1)
                {
                    label19.Text = "Площадь первой фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 2)
                {
                    label19.Text = "Площадь второй фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 0)
                {
                    label19.Text = "Площади фигур одинаковы ";
                }
                ((Control)label38).Visible = true;
                if (Operations.isInclude(ptr1, ptr2) == true)
                {
                    label38.Text = "Первая фигура включена во вторую ";
                }
                else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
                if (Operations.inTersect(ptr1, ptr2) == true)
                {
                    label39.Text = "Фигуры пересекаются ";
                }
                else { label39.Text = "Фигуры не пересекаются "; }

            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            String str =Convert.ToString(ptr1.square());
            label37.Text = (Convert.ToString(ptr1.square()));
            ((Control)label19).Visible = true;
            if (Operations.compare(ptr1, ptr2) == 1)
            {
                label19.Text = "Площадь первой фигуры больше ";
            }
            if (Operations.compare(ptr1, ptr2) == 2)
            {
                label19.Text = "Площадь второй фигуры больше ";
            }
            if (Operations.compare(ptr1, ptr2) == 0)
            {
                label19.Text = "Площади фигур одинаковы ";
            }
                ((Control)label38).Visible = true;
            if (Operations.isInclude(ptr1, ptr2) == true)
            {
                label38.Text = "Первая фигура включена во вторую ";
            }
            else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
            if (Operations.inTersect(ptr1, ptr2) == true)
            {
                label39.Text = "Фигуры пересекаются ";
            }
            else { label39.Text = "Фигуры не пересекаются "; }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label29.Text = Convert.ToString(ptr2.square());
            ((Control)label19).Visible = true;
            if (Operations.compare(ptr1, ptr2) == 1)
            {
                label19.Text = "Площадь первой фигуры больше ";
            }
            if (Operations.compare(ptr1, ptr2) == 2)
            {
                label19.Text = "Площадь второй фигуры больше ";
            }
            if (Operations.compare(ptr1, ptr2) == 0)
            {
                label19.Text = "Площади фигур одинаковы ";
            }
                ((Control)label38).Visible = true;
            if (Operations.isInclude(ptr1, ptr2) == true)
            {
                label38.Text = "Первая фигура включена во вторую ";
            }
            else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
            if (Operations.inTersect(ptr1, ptr2) == true)
            {
                label39.Text = "Фигуры пересекаются ";
            }
            else { label39.Text = "Фигуры не пересекаются "; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox20.Text != "")
            {

                ptr2.rotate(Convert.ToInt32(textBox20.Text));
                richTextBox2.Clear();
                richTextBox2.Text += "x1 - "; richTextBox2.Text += ptr2.getx1(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y1 - "; richTextBox2.Text += ptr2.gety1(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x2 - "; richTextBox2.Text += ptr2.getx2(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y2 - "; richTextBox2.Text += ptr2.gety2(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x3 - "; richTextBox2.Text += ptr2.getx3(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y3 - "; richTextBox2.Text += ptr2.gety3(); richTextBox2.Text += "\n";

                richTextBox2.Text += "x4 - "; richTextBox2.Text += ptr2.getx4(); richTextBox2.Text += "\n";
                richTextBox2.Text += "y4 - "; richTextBox2.Text += ptr2.gety4(); richTextBox2.Text += "\n";
                label32.Text = ""; label32.Text += "x - "; label32.Text += Convert.ToString(ptr2.getCenterOfGravityX());
                label33.Text = ""; label33.Text += "x - "; label33.Text += Convert.ToString(ptr2.getCenterOfGravityY());
                ((Control)label19).Visible = true;
                if (Operations.compare(ptr1, ptr2) == 1)
                {
                    label19.Text = "Площадь первой фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 2)
                {
                    label19.Text = "Площадь второй фигуры больше ";
                }
                if (Operations.compare(ptr1, ptr2) == 0)
                {
                    label19.Text = "Площади фигур одинаковы ";
                }
                ((Control)label38).Visible = true;
                if (Operations.isInclude(ptr1, ptr2) == true)
                {
                    label38.Text = "Первая фигура включена во вторую ";
                }
                else { label38.Text = "Первая фигура не включена во вторую "; }
                ((Control)label39).Visible = true;
                if (Operations.inTersect(ptr1, ptr2) == true)
                {
                    label39.Text = "Фигуры пересекаются ";
                }
                else { label39.Text = "Фигуры не пересекаются "; }
                label29.Text = Convert.ToString(ptr1.square());
            }
        }
    }
}
