using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class query_result : Form
    {
        public query_result()
        {
            InitializeComponent();
            loadData();               //ф-я загрузки из БД
        }

        private void loadData()
        {
            OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database11.accdb");  //с помощью чего подключаемся к БД; файл лежит в папке программы
            myConnection.Open(); //откр бд
            string query;
            if (Global.flag)
            {
                query = "SELECT * FROM [Телефонные переговоры] WHERE ((([Номер звонящего]) = '" + Global.number + "') AND (([Тип вызова]) = '" + Global.cType + "'))";
            }
            else
            {
                query = "SELECT * FROM[Телефонные переговоры] WHERE((([Дата переговоров]) Between #"+ Global.dateTimeDurStart +"# And #" + Global.dateTimeDurEnd + "#) AND(([Номер звонящего]) ='" + Global.number + "'))";   //дата записывается с #
            }
            OleDbCommand command = new OleDbCommand(query, myConnection);  //связывает подключение и текстовую часть запроса
            command.CommandType = CommandType.Text;
            OleDbDataAdapter ada = new OleDbDataAdapter(command);  //Представляет набор команд данных и подключение к базе данных, которые используются для заполнения DataSet и обновления источника данных
            DataTable conversation = new DataTable();       
            ada.Fill(conversation);
            dataGridView1.DataSource = conversation;   //Grid... отображает данные, DataSo.. возвращает или задает источник данных
        }
    }
}
