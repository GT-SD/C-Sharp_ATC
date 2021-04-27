using System;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class query1 : Form
    {
        public query1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") || (maskedTextBox3.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
            else
            {
                Global.dateTimeDurStart = maskedTextBox1.Text.Substring(6, 4) + "/" + maskedTextBox1.Text.Substring(3, 2) + "/" + maskedTextBox1.Text.Substring(0, 2) + " " + maskedTextBox1.Text.Substring(11, 2) + ":" + maskedTextBox1.Text.Substring(14, 2) + ":" + maskedTextBox1.Text.Substring(17, 2);
                Global.dateTimeDurEnd = maskedTextBox2.Text.Substring(6, 4) + "/" + maskedTextBox2.Text.Substring(3, 2) + "/" + maskedTextBox2.Text.Substring(0, 2) + " " + maskedTextBox2.Text.Substring(11, 2) + ":" + maskedTextBox2.Text.Substring(14, 2) + ":" + maskedTextBox2.Text.Substring(17, 2);
                Global.number = maskedTextBox3.Text;
                Global.flag = false;
                query_result fr4 = new query_result();
                fr4.ShowDialog();
            }

        }
    }
}
