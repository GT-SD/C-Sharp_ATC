using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class query2 : Form
    {
        public query2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (comboBox1.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка");
            }
            else
            {               
                Global.number = maskedTextBox1.Text;
                Global.cType = comboBox1.Text;
                Global.flag = true;
                query_result fr4 = new query_result();
                fr4.ShowDialog();
            }
        }
    }
}
