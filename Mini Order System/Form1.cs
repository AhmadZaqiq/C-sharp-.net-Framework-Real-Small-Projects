using Mini_Order_System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Order_System
{
    public partial class Form1 : Form
    {
        private OrderEventArgs LastOrder;

        public Form1()
        {
            InitializeComponent();

            ctrlOrderControl1.OnOrderProcessed += ctrlOrderControl1_OnOrderProcessed;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ctrlOrderControl1.ProductName = string.IsNullOrEmpty(txtProductName.Text) ? "P1" : txtProductName.Text;
            ctrlOrderControl1.ProductQuantity = (int)numQuantity.Value;
            ctrlOrderControl1.UnitPrice = int.TryParse(txtProductPrice.Text, out int price) ? price : 1;
            lblStatus.Text = "Processing";
            ctrlOrderControl1.UpdateUI();
        }

        private void SaveJsonToFile(string Json)
        {
            File.AppendAllText("orders.json", Json + Environment.NewLine);
        }

        private string ConvertOrderEventArgsToJson(OrderEventArgs e)
        {
            return JsonConvert.SerializeObject(e, Formatting.Indented);
        }

        private string ReadJsonFromFile()
        {
            string FilePath = "orders.json";

            if (!File.Exists(FilePath))
            {
                return "";
            }

            return File.ReadAllText(FilePath);
        }

        private void ctrlOrderControl1_OnOrderProcessed(object sender, OrderEventArgs e)
        {
            LastOrder = e;

            string OrderJson = ConvertOrderEventArgsToJson(e);

            MessageBox.Show(OrderJson, "Order JSON");

            lblStatus.Text = "Done";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtLog.Text = ReadJsonFromFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LastOrder == null)
            {
                MessageBox.Show("No order to save yet!");
                return;
            }

            SaveJsonToFile(ConvertOrderEventArgsToJson(LastOrder));

            MessageBox.Show("Order saved!");
        }


    }
}
