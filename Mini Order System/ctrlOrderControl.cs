using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Mini_Order_System
{
    public partial class ctrlOrderControl : UserControl
    {
        public event EventHandler<OrderEventArgs> OnOrderProcessed;

        private string _ProductName;
        private int _ProductQuantity;
        private int _UnitPrice;
        private int _TotalPrice;

        public ctrlOrderControl()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public int ProductQuantity
        {
            get { return _ProductQuantity; }
            set { _ProductQuantity = value; }
        }

        public int UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        public void UpdateUI()
        {
            lblProductName.Text = _ProductName;
            lblQuantity.Text = _ProductQuantity.ToString();
            lblPrice.Text = _UnitPrice.ToString() + "$";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            _TotalPrice = _ProductQuantity * _UnitPrice;

            lblTotal.Text = _TotalPrice.ToString() + "$";

            RaiseOrderProcessed(new OrderEventArgs(_ProductName, _ProductQuantity, _UnitPrice, _TotalPrice));
        }

        protected virtual void RaiseOrderProcessed(OrderEventArgs e)
        {
            OnOrderProcessed?.Invoke(this, e);
        }


    }
}
