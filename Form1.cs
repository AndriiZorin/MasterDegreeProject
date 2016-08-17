using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Decision_tree
{


    public partial class Form1 : Form
    {


        //Функция расчета аддитивной свертки
        public static String res(String strChance, String strPositiveIncome, 
        	String strPositivePrice, String strNegativeIncome, String strNegativePrice) {
            double chance = Convert.ToDouble(strChance);
            double PositiveIncome = Convert.ToDouble(strPositiveIncome);
            double PositivePrice = Convert.ToDouble(strPositivePrice);
            double NegativeIncome = Convert.ToDouble(strNegativeIncome);
            double NegativePrice = Convert.ToDouble(strNegativePrice);

            double positiveDifference = PositiveIncome - PositivePrice;
            double negativeDifference = NegativeIncome - NegativePrice;

            double res = chance / 100 * positiveDifference + (1 - chance / 100) * negativeDifference;
            res = Math.Round(res, 2);
            String str = res.ToString("R");
            return str;
        }

        public Form1() {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e) {

            bool flag = true;

            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";

            ///////////
            //Branch #1
            ///////////

            if (groupBox1.Visible == true) {


            	bool key1 = true;

                if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "" || comboBox1.Text == "" || textBox3.Text == "") {
                   
                    if (groupBox4.Visible == true && groupBox5.Visible == true && comboBox1.Text != "" && textBox3.Text != ""){
                        
                        key1 = true;
                        textBox7.Text = res(comboBox4.Text, maskedTextBox13.Text, maskedTextBox14.Text, maskedTextBox15.Text, maskedTextBox16.Text);
	                    textBox9.Text = res(comboBox5.Text, maskedTextBox17.Text, maskedTextBox18.Text, maskedTextBox19.Text, maskedTextBox20.Text);
	                    textBox4.Text = res(comboBox1.Text, textBox7.Text, "0", textBox9.Text, "0");
                   
                    } else if (groupBox4.Visible == true && maskedTextBox3.Text != "" && maskedTextBox4.Text != "" && comboBox1.Text != "" && textBox3.Text != ""){

                        textBox7.Text = res(comboBox4.Text, maskedTextBox14.Text, maskedTextBox15.Text, maskedTextBox15.Text, maskedTextBox16.Text);
            	        textBox4.Text = res(comboBox1.Text, textBox7.Text, "0", maskedTextBox3.Text, maskedTextBox4.Text);

                    } else if (groupBox5.Visible == true && maskedTextBox1.Text != "" && maskedTextBox2.Text != "" && comboBox1.Text != "" && textBox3.Text != ""){
                       
	                    textBox9.Text = res(comboBox5.Text, maskedTextBox17.Text, maskedTextBox18.Text, maskedTextBox19.Text, maskedTextBox20.Text);
	                    textBox4.Text = res(comboBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text, textBox9.Text, "0");

                    } else {

                        flag = false;
                        key1 = false;
                        MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                } else {

                    key1 = true;
                    textBox4.Text = res(comboBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text, maskedTextBox3.Text, maskedTextBox4.Text);

                }

                if(key1 == true) {

		            textBox4.Visible = true;
	                textBox3.ReadOnly = true;

	                comboBox1.Visible = false;
	                maskedTextBox1.Visible = false;
	                maskedTextBox2.Visible = false;
	                maskedTextBox3.Visible = false;
	                maskedTextBox4.Visible = false;
	                button1.Visible = false;
	                button2.Visible = false;


                }
            }

            ///////////
            //Branch #2
            ///////////

            if (groupBox2.Visible == true ){

            	bool key2 = true;

                if (maskedTextBox5.Text == "" || maskedTextBox6.Text == "" || maskedTextBox7.Text == "" || maskedTextBox8.Text == "" || comboBox2.Text == "" || textBox8.Text == "") {
                   
                    if (groupBox6.Visible == true && groupBox7.Visible == true && comboBox2.Text != "" && textBox8.Text != ""){
                        
                        key2 = true;
                        textBox10.Text = res(comboBox6.Text, maskedTextBox21.Text, maskedTextBox22.Text, maskedTextBox23.Text, maskedTextBox24.Text);
	                    textBox11.Text = res(comboBox7.Text, maskedTextBox25.Text, maskedTextBox26.Text, maskedTextBox27.Text, maskedTextBox28.Text);

	                    textBox5.Text = res(comboBox2.Text, textBox10.Text, "0", textBox11.Text, "0");
                   
                    } else if (groupBox6.Visible == true && maskedTextBox7.Text != "" && maskedTextBox8.Text != "" && comboBox2.Text != "" && textBox8.Text != ""){

                        textBox10.Text = res(comboBox6.Text, maskedTextBox21.Text, maskedTextBox22.Text, maskedTextBox23.Text, maskedTextBox24.Text);
                   		textBox5.Text = res(comboBox2.Text, textBox10.Text, "0", maskedTextBox7.Text, maskedTextBox8.Text);

                    } else if (groupBox7.Visible == true && maskedTextBox5.Text != "" && maskedTextBox6.Text != "" && comboBox2.Text != "" && textBox8.Text != ""){
                       
                       textBox11.Text = res(comboBox7.Text, maskedTextBox25.Text, maskedTextBox26.Text, maskedTextBox27.Text, maskedTextBox28.Text);
                   		textBox5.Text = res(comboBox2.Text, maskedTextBox5.Text, maskedTextBox6.Text, textBox11.Text, "0");

                    } else {

                        flag = false;
                        key2 = false;
                        MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                } else {

                    key2 = true;
                    textBox5.Text = res(comboBox2.Text, maskedTextBox5.Text, maskedTextBox6.Text, maskedTextBox7.Text, maskedTextBox8.Text);

                }

                if(key2 == true) {

	                textBox5.Visible = true;
	                textBox8.ReadOnly = true;

	                comboBox2.Visible = false;
	                maskedTextBox5.Visible = false;
	                maskedTextBox6.Visible = false;
	                maskedTextBox7.Visible = false;
	                maskedTextBox8.Visible = false;
	                button3.Visible = false;
	                button4.Visible = false;

                }
              
            }
            
            ///////////
            //Branch #3
            ///////////

            if (groupBox3.Visible == true){
              
                bool key3 = true;

                if (maskedTextBox9.Text == "" || maskedTextBox10.Text == "" || maskedTextBox11.Text == "" || maskedTextBox12.Text == "" || comboBox3.Text == "" || textBox13.Text == "") {
                   
                    if (groupBox8.Visible == true && groupBox9.Visible == true && comboBox3.Text != "" && textBox13.Text != ""){
                        
                        textBox12.Text = res(comboBox8.Text, maskedTextBox29.Text, maskedTextBox30.Text, maskedTextBox31.Text, maskedTextBox32.Text);
                        textBox14.Text = res(comboBox9.Text, maskedTextBox33.Text, maskedTextBox34.Text, maskedTextBox35.Text, maskedTextBox36.Text);

                        textBox6.Text = res(comboBox3.Text, textBox12.Text, "0", textBox14.Text, "0");
                   
                    } else if (groupBox8.Visible == true && maskedTextBox11.Text != "" && maskedTextBox12.Text != "" && comboBox3.Text != "" && textBox13.Text != ""){

                        textBox12.Text = res(comboBox8.Text, maskedTextBox29.Text, maskedTextBox30.Text, maskedTextBox31.Text, maskedTextBox32.Text);
                        textBox6.Text = res(comboBox3.Text, textBox12.Text, "0", maskedTextBox11.Text, maskedTextBox12.Text);

                    } else if (groupBox9.Visible == true && maskedTextBox9.Text != "" && maskedTextBox10.Text != "" && comboBox3.Text != "" && textBox13.Text != ""){
                       
                        textBox14.Text = res(comboBox9.Text, maskedTextBox33.Text, maskedTextBox34.Text, maskedTextBox35.Text, maskedTextBox36.Text);
                        textBox6.Text = res(comboBox3.Text, maskedTextBox9.Text, maskedTextBox10.Text, textBox14.Text, "0");

                    } else {

                        flag = false;
                        key3 = false;
                        MessageBox.Show("Заполнены не все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                } else {

                    key3 = true;
                    textBox6.Text = res(comboBox3.Text, maskedTextBox9.Text, maskedTextBox10.Text, maskedTextBox11.Text, maskedTextBox12.Text);

                }

                if (key3 == true) {

                    textBox6.Visible = true;
                    textBox13.ReadOnly = true;

                    comboBox3.Visible = false;
                    maskedTextBox9.Visible = false;
                    maskedTextBox10.Visible = false;
                    maskedTextBox11.Visible = false;
                    maskedTextBox12.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                }
            }
          
            ///////
            //Tier2
            ///////

            if (groupBox4.Visible == true) {

                textBox7.Visible = true;
                textBox18.ReadOnly = true;

                comboBox4.Visible = false;
                maskedTextBox13.Visible = false;
                maskedTextBox14.Visible = false;
                maskedTextBox15.Visible = false;
                maskedTextBox16.Visible = false;
            }

            if (groupBox5.Visible == true) {

                textBox9.Visible = true;
                textBox23.ReadOnly = true;

                comboBox5.Visible = false;
                maskedTextBox17.Visible = false;
                maskedTextBox18.Visible = false;
                maskedTextBox19.Visible = false;
                maskedTextBox20.Visible = false;
            }

            if (groupBox6.Visible == true) {

                textBox10.Visible = true;
                textBox28.ReadOnly = true;

                comboBox6.Visible = false;
                maskedTextBox21.Visible = false;
                maskedTextBox22.Visible = false;
                maskedTextBox23.Visible = false;
                maskedTextBox24.Visible = false;
            }

            if (groupBox7.Visible == true) {
                textBox11.Visible = true;
                textBox33.ReadOnly = true;

                comboBox7.Visible = false;
                maskedTextBox25.Visible = false;
                maskedTextBox26.Visible = false;
                maskedTextBox27.Visible = false;
                maskedTextBox28.Visible = false;
            }

            if (groupBox8.Visible == true){
                textBox12.Visible = true;
                textBox38.ReadOnly = true;

                comboBox8.Visible = false;
                maskedTextBox29.Visible = false;
                maskedTextBox30.Visible = false;
                maskedTextBox31.Visible = false;
                maskedTextBox32.Visible = false;

                
            }
            
            if (groupBox9.Visible == true) {
                textBox14.Visible = true;
                textBox43.ReadOnly = true;

                comboBox9.Visible = false;
                maskedTextBox33.Visible = false;
                maskedTextBox34.Visible = false;
                maskedTextBox35.Visible = false;
                maskedTextBox36.Visible = false;                
            }
           
            //////////////
            //FINAL RESULT
            //////////////

            if (flag == true){
                groupBox11.Visible = true;

                double opt1 = Convert.ToDouble(textBox4.Text);
                double opt2 = Convert.ToDouble(textBox5.Text);
                double opt3 = Convert.ToDouble(textBox6.Text);
                if (opt1 > opt2 && opt1 > opt3)
                {
                    textBox1.Text = textBox3.Text;
                    textBox2.Text = textBox4.Text;
                }
                else if (opt2 > opt1 && opt2 > opt3)
                {
                    textBox1.Text = textBox8.Text;
                    textBox2.Text = textBox5.Text;
                }
                else
                {
                    textBox1.Text = textBox13.Text;
                    textBox2.Text = textBox6.Text;
                }
            }
        }

        //Switcher for groupBox
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true){
                if (groupBox2.Visible == true){

                    groupBox3.Visible = true;
                    maskedTextBox9.Text = "";
	            	maskedTextBox10.Text = "";
	            	maskedTextBox11.Text = "";
	           		maskedTextBox12.Text = "";
	           		textBox13.Text = "";
	           		comboBox3.Text = "";
                }
                else{
                    groupBox2.Visible = true;

                    maskedTextBox5.Text = "";
	            	maskedTextBox6.Text = "";
	            	maskedTextBox7.Text = "";
	           		maskedTextBox8.Text = "";
	           		textBox8.Text = "";
	           		comboBox2.Text = "";

                }
            }
            else {

                groupBox1.Visible = true;

                maskedTextBox1.Text = "";
            	maskedTextBox2.Text = "";
            	maskedTextBox3.Text = "";
           		maskedTextBox4.Text = "";
           		textBox3.Text = "";
           		comboBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e){
            groupBox4.Visible = true;

            maskedTextBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;

            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e){
            groupBox5.Visible = true;

            maskedTextBox3.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;

            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e){
            groupBox6.Visible = true;
            maskedTextBox5.ReadOnly = true;
            maskedTextBox6.ReadOnly = true;

            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)  {
            groupBox7.Visible = true;
            maskedTextBox7.ReadOnly = true;
            maskedTextBox8.ReadOnly = true;

            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e){
            groupBox8.Visible = true;
            maskedTextBox9.ReadOnly = true;
            maskedTextBox10.ReadOnly = true;

            maskedTextBox9.Text = "";
            maskedTextBox10.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) {
            groupBox9.Visible = true;
            maskedTextBox11.ReadOnly = true;
            maskedTextBox12.ReadOnly = true;

            maskedTextBox11.Text = "";
            maskedTextBox12.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void NewTree_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл загружен", "О программе", MessageBoxButtons.OK, MessageBoxIcon.None);
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox8.Visible = true;
            groupBox9.Visible = true;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename,"Оптимальное решение: " + textBox1.Text + " Вероятный доход: " + textBox2.Text + " тыс.грн.");
            MessageBox.Show("Файл сохранен", "О программе", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дерево принятия решений – это средство поддержки принятия решений при прогнозировании, широко применяющееся в статистике и анализе данных. \nНа основании введенных данных строится дерево решений, структура которого содержит узлы, представляющие собой ключевые события и вероятности события", "О программе", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

    }
}
