using System;
using System.Windows.Forms;
using static WormDelegateApp.CalculateResult;

namespace WormDelegateApp
{
    public partial class Radius : Form
    {
        public Radius()
        {
            InitializeComponent();
        }
        bool checkBoxOne;
        bool checkBoxTwo;
        bool checkBoxThree;
        bool checkBoxFour;
        bool checkBoxFive;
        

        public void button1_Click(object sender, EventArgs e)
        {
            OperationDelegate operationDel = null;
            
            double.TryParse(textBox1.Text, out double radius);
            if (string.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Вы не ввели радиус");
            chekBoxes();
            if (checkBoxOne == true)
            {
                operationDel = countS;
                listBox1.Items.Add(operationDel(radius));
            }
            if (checkBoxTwo == true) 
            {
                operationDel = countL;
                listBox1.Items.Add(operationDel(radius));
            }
            if (checkBoxThree == true)
            {
                operationDel = countP;
                listBox1.Items.Add(operationDel(radius));
            }
            if (checkBoxFour == true)
            {
                operationDel = countV;
                listBox1.Items.Add(operationDel(radius));
            }
            if (checkBoxFive == true)
            {
                operationDel = countD;
                listBox1.Items.Add(operationDel(radius));
            }
        }
        public void chekBoxes() 
        {
            checkBoxOne = checkBox1.Checked;
            checkBoxTwo = checkBox2.Checked;
            checkBoxThree = checkBox3.Checked;
            checkBoxFour = checkBox4.Checked;
            checkBoxFive = checkBox5.Checked;
        }
    }  
}