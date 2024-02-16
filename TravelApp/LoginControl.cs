using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TravelApp
{
    public partial class LoginControl : UserControl
    {
        private FormHome parentForm;

        GetDataBase getItems = new GetDataBase();
        public LoginControl()
        {
            InitializeComponent();

            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void getData()
        {


            IReadOnlyList<object[]> items = Travels.Instance.GetItemList();
            foreach (var item in items)
            {
                string displayText = $"ID:{item[0]} - Kraj:{item[1]} - Region:{item[2]} - Data:{item[3]} - Cena:{item[4]}";
                listBox1.Items.Add(displayText);
            }

            List<object[]> getClients = getItems.Connect("SELECT IDClient, Name, Surname, PhoneNumber, IDTravel FROM Clients");
            Client.Instance.AddUser(getClients);
            IReadOnlyList<object[]> clients = Client.Instance.GetItemList();
            foreach (var item in clients)
            {
                string displayText = $"ID:{item[0]} - Imie:{item[1]} - Nazwisko:{item[2]} - Number:{item[3]} - IDTravel:{item[4]}";
                listBox2.Items.Add(displayText);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               
                List<object[]> employee = getItems.Connect("SELECT IDEmloyee, Name, Surname, Login, Password FROM Employees");
                Employee.Instance.AddUser(employee);

                string login = Employee.Instance.GetLogin();
                string password = Employee.Instance.GetPassword();

                if (login != null && password != null && login.Trim() == textBoxLogin.Text.Trim() && password.Trim() == textBoxPassword.Text.Trim())
                {
                    panelEmployee.Visible = true;
                    panelLogin.Visible = false;
                }
                else
                {
                    labelError.Text = "Błędne dane";
                    labelError.Visible = true;
                    return; 
                }

                labelWelcome.Text = $"Zalogowano, Cześć {Employee.Instance.GetName()}";

                getData();
    


            }
            catch (SqlException ex)
            {
                labelError.Text = "Błąd bazy " + ex.Message;
                labelError.Visible = true;
            }


        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonRemoveTravel_Click(object sender, EventArgs e)
        {
            try
            {
                IReadOnlyList<object[]> items = Travels.Instance.GetItemList();
                RemoveDataBase removeTravelBase = new RemoveDataBase();
                foreach (var item in items)
                {
                    if ($"ID:{item[0]} - Kraj:{item[1]} - Region:{item[2]} - Data:{item[3]} - Cena:{item[4]}" == listBox1.SelectedItem?.ToString())
                    {
                        removeTravelBase.RemoveTravel((int)item[0]);
                        break;
                    }
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception ex)
            {
                labelError.Text = "Problem " + ex.Message;
                labelError.Visible = true;
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = true;
        }

        private void buttonAddUserExit_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCountry.Text == "" || textBoxRegion.Text == "" || textBoxPrice.Text == "" )
                {
                    label8.Text = "Podaj prawidłowe dane";

                } else {
                    GetDataBase getDataBase = new GetDataBase();
                    SetDataBase setDataBase = new SetDataBase();

                    int idTravel = Travels.Instance.GetLastID() +1;

                    int idEmployee = Employee.Instance.GetLastUserID();

                    setDataBase.AddTravel(idTravel, textBoxCountry.Text, textBoxRegion.Text, dateTimePicker1.Value, idEmployee, int.Parse(textBoxPrice.Text));
                    GetDataBase getTravels = new GetDataBase();

                    List<object[]> data = getTravels.Connect("SELECT IDTravel, TravelsName, Address, CONVERT(varchar, Date, 104) AS FormattedDate, Price FROM Travels");

                    Travels.Instance.AddItems(data);
                    listBox1.Items.Clear();

                    foreach (var item in data)
                    {
                        string displayText = $"ID:{item[0]} - Kraj:{item[1]} - Region:{item[2]} - Data:{item[3]} - Cena:{item[4]}";
                        listBox1.Items.Add(displayText);
                    }
                    textBoxCountry.Text = "";
                    textBoxRegion.Text = "";
                    textBoxPrice.Text = "";
                    panelAddUser.Visible = false;
                }
            }
            catch (Exception ex)
            {
                label8.Text = "Problem " + ex.Message;
                label8.Visible = true;
            }
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            try
            {
       
                IReadOnlyList<object[]> items = Client.Instance.GetItemList();
                RemoveDataBase removeClientBase = new RemoveDataBase();
                foreach (var item in items)
                {
                    if ($"ID:{item[0]} - Imie:{item[1]} - Nazwisko:{item[2]} - Number:{item[3]} - IDTravel:{item[4]}" == listBox2.SelectedItem?.ToString())
                    {
                        removeClientBase.RemoveClient((int)item[0]);
                    
                    }
          
                }
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception ex)
            {
                labelError.Text = "Problem " + ex.Message;
                labelError.Visible = true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<object[]> getClients = getItems.Connect("SELECT IDClient, Name, Surname, PhoneNumber, IDTravel FROM Clients");

            foreach (var item in getClients)
            {
                string displayText = $"ID:{item[0]} - Imie:{item[1]} - Nazwisko:{item[2]} - Number:{item[3]} - IDTravel:{item[4]}";
                listBox2.Items.Add(displayText);
            }
        }
        private void SaveClientsToCSV(List<object[]> clientsData)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\damia\Desktop\Clients.csv")) 
                {
             
                    sw.WriteLine("ID,Name,Surname,PhoneNumber,IDTravel");

                    foreach (var client in clientsData)
                    {
                        sw.WriteLine($"{client[0]},{client[1]},{client[2]},{client[3]},{client[4]}");
                    }
                }

                MessageBox.Show("Dane klientów zostały zapisane do pliku CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku CSV: " + ex.Message);
            }
        }

        private void buttonSaveClients_Click(object sender, EventArgs e)
        {
            List<object[]> clientsData = getItems.Connect("SELECT IDClient, Name, Surname, PhoneNumber, IDTravel FROM Clients");
            SaveClientsToCSV(clientsData);
        }


        private void SaveTravelsToCSV(List<object[]> TravelsData)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\damia\Desktop\Travels.csv"))
                {

                    sw.WriteLine("IDTravel, TravelsName, Address, Date, Price");

                    foreach (var travel in TravelsData)
                    {
                        sw.WriteLine($"{travel[0]},{travel[1]},{travel[2]},{travel[3]},{travel[4]}");
                    }
                }

                MessageBox.Show("Dane klientów zostały zapisane do pliku CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania danych do pliku CSV: " + ex.Message);
            }
        }
        private void buttonSaveTravels_Click(object sender, EventArgs e)
        {

            List<object[]> clientsData = getItems.Connect("SELECT IDTravel, TravelsName, Address, CONVERT(varchar, Date, 104) AS FormattedDate, Price FROM Travels");
            SaveTravelsToCSV(clientsData);
        }
    }
}
