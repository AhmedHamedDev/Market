using Infragistics.Win.UltraWinGrid;
using Market.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class OrderGridTotalDetails : MetroForm
    {
        private decimal _orderSell = 0;
        private decimal _deliveryResturant = 0;
        private decimal _deliveryPilot = 0;
        private decimal _total = 0;

        public OrderGridTotalDetails(decimal orderSell, decimal deliveryResturant, decimal deliveryPilot, decimal total)
        {
            this._orderSell = orderSell;
            this._deliveryResturant = deliveryResturant;
            this._deliveryPilot = deliveryPilot;
            this._total = total;

            InitializeComponent();


            OrderSellLable.Text = this._orderSell.ToString();
            DeliveryResturantLable.Text = this._deliveryResturant.ToString();
            deliveryPilotLable.Text = this._deliveryPilot.ToString();
            TotalLable.Text = this._total.ToString();
        }

    }
}
