using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class SearchSales
    {
        partial void Print_Execute()
        {
            // Write your code here.
            this.Application.ShowPrintSale(this.SalesFilter.SelectedItem.Id);
        }

        partial void Payment_Execute()
        {
            // Write your code here.
            if (this.SalesFilter.SelectedItem.Status == "Cleared")
            {
                this.ShowMessageBox("Payment is not allowed as sale has Due Amount= 0.");
            }
            else
            {
                this.Application.ShowAddSalePayment(this.SalesFilter.SelectedItem.Id);
            }
        }
    }
}
