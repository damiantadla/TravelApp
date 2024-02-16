using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelApp
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
            RefreshHome();
        }

        public void RefreshHome()
        {
            GetDataBase getTravels = new GetDataBase();

            try
            {
                List<object[]> data = getTravels.Connect("SELECT [TravelsName], [Address], FORMAT([Date], 'dd-MM-yyyy') AS [Date], [Price] FROM [TravelBase].[dbo].[Travels]\r\n");

                int maxRecords = Math.Min(data.Count, 4); 

                for (int i = 0; i < maxRecords; i++)
                {
                    SetTravelInfo((Label)Controls.Find($"labelTravelsName{i}", true)[0],
                                  (Label)Controls.Find($"labelAddress{i}", true)[0],
                                  (Label)Controls.Find($"labelData{i}", true)[0],
                                  (Label)Controls.Find($"labelCena{i}", true)[0],
                                  data[i]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Błąd połączenia z bazą danych:");
                Console.WriteLine(ex.Message);
            }
        }

        private void SetTravelInfo(Label nameLabel, Label addressLabel, Label dateLabel, Label priceLabel, object[] travelData)
        {
            nameLabel.Text = travelData[0].ToString();
            addressLabel.Text = travelData[1].ToString();
            dateLabel.Text = travelData[2].ToString();
            priceLabel.Text = $"{travelData[3]} zł";
        }

    }
}