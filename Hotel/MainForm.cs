using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection.Emit;

namespace Hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer1 = new Timer();
            timer1.Interval = 1000;            
            timer1.Tick += Timer_Tick;        
            timer1.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");    
        }

        private void guestCardButton_Click(object sender, EventArgs e)
        {
            GuestCardForm guestCardForm = new GuestCardForm();
            guestCardForm.Show();
        }
        private void CreateDataGridColumns()
        {
            dgwGuests.Columns.Clear();
            
            DataGridViewTextBoxColumn columnFullName = new DataGridViewTextBoxColumn();
            columnFullName.HeaderText = "ФИО";
            columnFullName.DataPropertyName = "ФИО";
            dgwGuests.Columns.Add(columnFullName);

            DataGridViewTextBoxColumn columnRoom = new DataGridViewTextBoxColumn();
            columnRoom.HeaderText = "Номер";
            columnRoom.DataPropertyName = "Номер";
            dgwGuests.Columns.Add(columnRoom);

            DataGridViewTextBoxColumn columnStatus = new DataGridViewTextBoxColumn();
            columnStatus.HeaderText = "Статус";
            columnStatus.DataPropertyName = "Статус";
            dgwGuests.Columns.Add(columnStatus);

            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            columnDate.HeaderText = "Дата заезда";
            columnDate.DataPropertyName = "Дата заезда"; 
            dgwGuests.Columns.Add(columnDate);

            DataGridViewTextBoxColumn columnDateOut = new DataGridViewTextBoxColumn();
            columnDateOut.HeaderText = "Дата выезда";
            columnDateOut.DataPropertyName = "Дата выезда";
            dgwGuests.Columns.Add(columnDate);

            DataGridViewCheckBoxColumn columnTravelWithPets = new DataGridViewCheckBoxColumn();
            columnTravelWithPets.HeaderText = "Путешествую с животным";
            columnTravelWithPets.DataPropertyName = "Путешествую с животным"; 
            dgwGuests.Columns.Add(columnTravelWithPets);

            DataGridViewCheckBoxColumn columnPay = new DataGridViewCheckBoxColumn();
            columnPay.HeaderText = "Оплата";
            columnPay.DataPropertyName = "Оплата";
            dgwGuests.Columns.Add(columnPay);
        }
        private void DisplayDataInDataGrid()
        {
            string connectionString = "Data Source=db_hotel.sqlite";
            string query = "SELECT * FROM guests";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgwGuests.DataSource = dataTable;
                        }
                    }
                }

                if (dgwGuests.Columns.Contains("Дата заезда"))
                {
                    dgwGuests.Columns["Дата заезда"].HeaderText = "Дата заезда";
                }

                if (dgwGuests.Columns.Contains("Путешествую с животным"))
                {
                    dgwGuests.Columns["Путешествую с животным"].HeaderText = "Путешествую с животным";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayDataInDataGrid();
            CreateDataGridColumns();
        }
    }
}
