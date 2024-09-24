using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studeant_regestration_form
{
    public partial class Form1 : Form
    {
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, f_name, age, gender, year, address, email, course, deapartment, program, group,  section, gpa, payment;
            long phone;
            
            name = textBox1.Text;
            f_name = textBox2.Text;
            age = numericUpDown1.Text;
            address = comboBox1.Text;
            email = textBox4.Text;
            deapartment = comboBox4.Text;
            group=textBox6.Text;
            year = textBox5.Text;
            section = comboBox2.Text;
            gpa = textBox7.Text;
            payment = comboBox3.Text;
            if (radioButton1.Checked==true)
                gender = radioButton1.Text;
            else if (radioButton2.Checked == true)
                gender = radioButton2.Text;
            else
                gender=radioButton3.Text;
            if (checkBox1.Checked == true)
                course = checkBox1.Text;
            else if (checkBox2.Checked == true)
                course = checkBox2.Text;
             else if( (checkBox1.Checked == true) &&(checkBox2.Checked==true))
                 course="english and amharic";
            else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                course = "english and other language";
            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                course = " amharic and other language";

            else
                course = checkBox3.Text;
            if (checkBox1.Checked == true)
                program = checkBox1.Text;
            else if (checkBox2.Checked == true)
                program = checkBox2.Text;
            else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                program = "english and amharic";
            else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                program = "english and other language";
            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                program = " amharic and other language";

            else
                program = checkBox3.Text;
            phone = long.Parse(textBox3.Text);

            MessageBox.Show(" "+name+"\n "+f_name+"\n "+gender+"\n "+age+"\n "+phone+"\n "+address+"\n "+email+"\n "+course+"\n "+deapartment+"\n "+program+"\n "+group+"\n "+year+"\n "+section+"\n "+gpa+"\n "+payment);
             

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
