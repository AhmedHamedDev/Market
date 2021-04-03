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
    public partial class OrderDetailsForm : MetroForm
    {
        private User user;
        private Order order;
        public DataTable myDataTable;

        public OrderDetailsForm(User _user, Order _order)
        {
            user = _user;
            order = _order;

            InitializeComponent();

            PrepareColumns();
            FillWithData();

            // all columns auto resize
            OrderDetailsDataGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;

            // hide drag header area
            OrderDetailsDataGrid.DisplayLayout.ViewStyleBand = ViewStyleBand.Vertical;

            // center content
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[0].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[1].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[2].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[3].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[4].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[5].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;
            this.OrderDetailsDataGrid.DisplayLayout.Bands[0].Columns[6].CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center;

            // stop confirmation message on delete
            OrderDetailsDataGrid.DisplayLayout.ShowDeleteRowsPrompt = false;
        }

        private void PrepareColumns()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            myDataTable = new DataTable("My Table");

            DataColumn productNameColumn = new DataColumn();
            productNameColumn = new DataColumn();
            productNameColumn.DataType = System.Type.GetType("System.String");
            productNameColumn.ColumnName = "TypeName";
            productNameColumn.Caption =  "اسم الصنف";
            productNameColumn.ReadOnly = true;
            productNameColumn.Unique = false;

            DataColumn quantityColumn = new DataColumn();
            quantityColumn = new DataColumn();
            quantityColumn.DataType = System.Type.GetType("System.Int32");
            quantityColumn.ColumnName = "Quantity";
            quantityColumn.Caption = "الكميه";
            quantityColumn.ReadOnly = true;
            quantityColumn.Unique = false;

            DataColumn costPriceColumn = new DataColumn();
            costPriceColumn = new DataColumn();
            costPriceColumn.DataType = System.Type.GetType("System.Decimal");
            costPriceColumn.ColumnName = "CostPrice";
            costPriceColumn.Caption = "سعر التكلفه";
            costPriceColumn.ReadOnly = true;
            costPriceColumn.Unique = false;

            DataColumn sellPriceColumn = new DataColumn();
            sellPriceColumn = new DataColumn();
            sellPriceColumn.DataType = System.Type.GetType("System.Decimal");
            sellPriceColumn.ColumnName = "SellPrice";
            sellPriceColumn.Caption = "سعر البيع";
            sellPriceColumn.ReadOnly = true;
            sellPriceColumn.Unique = false;

            DataColumn generalTypeColumn = new DataColumn();
            generalTypeColumn = new DataColumn();
            generalTypeColumn.DataType = System.Type.GetType("System.String");
            generalTypeColumn.ColumnName = "GeneralType";
            generalTypeColumn.Caption = "النوع";
            generalTypeColumn.ReadOnly = true;
            generalTypeColumn.Unique = false;

            DataColumn totalColumn = new DataColumn();
            totalColumn = new DataColumn();
            totalColumn.DataType = System.Type.GetType("System.String");
            totalColumn.ColumnName = "Total";
            totalColumn.Caption = "المجموع";
            totalColumn.ReadOnly = true;
            totalColumn.Unique = false;

            DataColumn insertTimeColumn = new DataColumn();
            insertTimeColumn = new DataColumn();
            insertTimeColumn.DataType = System.Type.GetType("System.DateTime");
            insertTimeColumn.ColumnName = "InsertTime";
            insertTimeColumn.Caption = "التاريخ";
            insertTimeColumn.ReadOnly = true;
            insertTimeColumn.Unique = false;

            myDataTable.Columns.Add(productNameColumn);
            myDataTable.Columns.Add(quantityColumn);
            myDataTable.Columns.Add(costPriceColumn);
            myDataTable.Columns.Add(sellPriceColumn);
            myDataTable.Columns.Add(generalTypeColumn);
            myDataTable.Columns.Add(totalColumn);
            myDataTable.Columns.Add(insertTimeColumn);
        }

        private void FillWithData()
        {
      

            foreach (var orderDetail in order.OrderDetails)
            {
                DataRow theDataRow = myDataTable.NewRow();
                theDataRow[0] = orderDetail.ProductType.TypeName;
                theDataRow[1] = orderDetail.Quantity;
                theDataRow[2] = orderDetail.CostPrice;
                theDataRow[3] = orderDetail.SellPrice;
                theDataRow[4] = orderDetail.ProductType.GeneralProductTypes.Name;
                theDataRow[5] = orderDetail.Quantity * orderDetail.SellPrice;
                theDataRow[6] = orderDetail.InsertTime;
                myDataTable.Rows.Add(theDataRow);
            }

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(myDataTable);

            OrderDetailsDataGrid.DataSource = dataSet;
        }

    }
}
