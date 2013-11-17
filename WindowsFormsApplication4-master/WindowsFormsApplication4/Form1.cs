using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string sex;
            string leval;
            string str;
            

         

            if (optMale.Checked == true)
            {
                sex = "ชาย";
            }
            else
            {
                sex = "หญิง";
            }


            if (apt1.Checked == true)
            {
                leval = "ตำกว่าปริญญาตรี";
            }
            if (apt2.Checked == true)
            {
                leval = "ปริญญาตรี";
            }
            else if(apt3.Checked == true)
            {
                leval = "สูงกว่าปริญญาตรี";
            }
            else if (radioButton1.Checked == true)
            {

                if (textSex.Text == "")
                {
                    leval = "ไม่ได้กรอกข้อมูล ";
                }
                else
                {
                   leval = "อื่น ๆ : " + textSex.Text;
                }

            }
            else
            {
                leval = "ต่ำกว่าปริญญาตรี ";
            }
            //11.สถานภาพการทำงานปัจจุบัน
            if (radioButton3.Checked == true)
            {
                str = "ทำงานแล้ว";
            }
            else if (radioButton2.Checked == true)
            {
                    str = "ทำงานแล้วและกำลังศึกษาต่อ";
            }
            else if (radioButton4.Checked == true)
            {
                str = "ยังไม่ได้ทำงานและไม่ได้ศึกษาต่อ";
            }
            else
            {
                str = "กำลังศึกษาต่อ"; 
            }


                Form2 Frm = new Form2();
                Frm.SettextBox1 = txtSource.Text ;
                Frm.SetBox4 = textBox4.Text;
                Frm.SettextBox6 = textBox6.Text;
                Frm.SettextBox7 = textBox7.Text;
                Frm.SettextBox8 = textBox8.Text;
                Frm.SetDMY = textBox9.Text;
                Frm.SetBox10 = textBox10.Text;
                Frm.SetBox13 = sex;
                Frm.SettextBox2 = leval;
                Frm.SetBox11 = textBox11.Text;
                Frm.SettextBox12 = textBox12.Text;
                Frm.SettextBox3 = textBox3.Text;
                Frm.SettextBox5 = comboBox1.Text;
                Frm.SetstrBox = str;
                Frm.Show();
            }
      
        private void txtSource_TextChanged(object sender, EventArgs e)
        {
           
             {
             }

        }


        }

    }

