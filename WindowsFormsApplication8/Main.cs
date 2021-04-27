using System;
using System.Data;
using System.Windows.Forms;
using System.IO;               //для работы с файлами
using System.Data.OleDb;       //для подклчения бд с помощью ОлеДБ, работающая с Access

namespace WindowsFormsApplication8
{
    public partial class Main : Form
    {
        public string fileName;
        public OleDbCommand command;        //переменная для SQL команд, которые отправляются в БД
        public OleDbConnection connection;  //подключ к БД
        public Main()        //ф-я, выполн-яся при запуске первой формы
        {
            InitializeComponent();
            ConnectTo();    
        }

        private void ConnectTo()     //ф-я создания подлюч-я к БД
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database11.accdb"); //с помощью чего подключаемся к БД; файл лежит в папке программы
            command = connection.CreateCommand(); //для создания экземпляра команды, знает, куда обратиться

        }

        private void Insert(Сonversation conv)  //метод для записи инф-ии в БД
        {
            try  //обработка ошибки
            {
                //С помощью свойства CommandText устанавливается SQL-выражение, которое будет выполняться
                command.CommandText =  
                "INSERT INTO [Телефонные переговоры] ([Дата переговоров], [Продолжительность], [Тип вызова], [Номер звонящего], [Номер вызываемого]) VALUES('" 
                + new DateTime(2000+Convert.ToInt32(conv.Date.Substring(4, 2)), Convert.ToInt32(conv.Date.Substring(2, 2)), Convert.ToInt32(conv.Date.Substring(0, 2)), Convert.ToInt32(conv.Date.Substring(6, 2)), Convert.ToInt32(conv.Date.Substring(8, 2)), Convert.ToInt32(conv.Date.Substring(10, 2))) 
                + "', '" + conv.Duration.Substring(0, 2) + ":" + conv.Duration.Substring(2, 2) + ":" + conv.Duration.Substring(4, 2) + "', '" 
                + conv.CallType + "', '" + conv.CallerNumber + "', '" + conv.CalledNumber + "')";  //SQL запрос
                command.CommandType = CommandType.Text;  //Возвращает или задает значение, определяющее, как будет интерпретироваться свойство CommandText
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)  //ошибка
            {
                throw;  //если ошибка
            }
            finally
            {
                if (connection != null)  //если есть подключение
                {
                    connection.Close();  //закрываем соединение
                }

            }
        }




        private void OpenFile()
        {
            try
            {
                using (StreamReader fs = new StreamReader(fileName))  //поток чтения файла в перемен fs
                    while (true)
                    {
                        string temp = fs.ReadLine();   //каждую строку в цикле в перем temp
                        if (temp == null) break;

                        string[] strArr = new string[5];  
                        strArr = temp.Split(' ');
                        if (strArr[2] == "Outgoing")
                        {
                            strArr[2] = "Исходящий";
                        }
                        else {
                            strArr[2] = "Входящий";
                        }

                        Сonversation conver = new Сonversation(strArr[0], strArr[1], strArr[2], strArr[3], strArr[4]);  //перем типа conversation
                        Insert(conver);  //отправляем перем conver в ф-ю insert
                    }
            }
            catch (IOException ex)  //обработка ошибки чтения файла, ex - перем
            {
                MessageBox.Show(ex.Message, "Simple Editor",    //выводится окно сообщения "стандартная ошибка"
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

 

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)    
        {
            OpenFileDialog dig = new OpenFileDialog();   //открываем станд диалог открытия файла
            dig.DefaultExt = "*.log";   //задаем расширенеие файла
            dig.Filter = "log|*.log";   //настраиваем фильтр файлов, чтобы другие нельзя было выбрать
            if (dig.ShowDialog() == DialogResult.OK)   //если нажали ОК
            {
                string directory = Environment.GetFolderPath(Environment.SpecialFolder.Templates);  //получаем путь к файлу
                dig.InitialDirectory = directory;
                fileName = dig.FileName;
                OpenFile();
                this.телефонные_переговорыTableAdapter.Fill(this.database11DataSet.Телефонные_переговоры);     //обновляет таблицу в окне после открытия файла
                MessageBox.Show("Файл считан!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database11DataSet.Телефонные_переговоры". При необходимости она может быть перемещена или удалена.
            this.телефонные_переговорыTableAdapter.Fill(this.database11DataSet.Телефонные_переговоры);
        }

        private void вывестиЗвонкиЗаОпределенныйПериодПоНомеруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query1 fr2 = new query1();
            fr2.ShowDialog();    //отображает форму как модельное диалоговое окно
        }

        private void вывестиВсеЗвонкиСНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query2 fr3 = new query2();
            fr3.ShowDialog();
        }
    }
}
