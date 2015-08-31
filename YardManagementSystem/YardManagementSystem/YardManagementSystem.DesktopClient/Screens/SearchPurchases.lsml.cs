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
    public partial class SearchPurchases
    {
        partial void Print_Execute()
        {
            // Write your code here.
            this.Application.ShowPrintPurchase(this.Purchases.SelectedItem.Id);
        }

        partial void Payment_Execute()
        {
            // Write your code here.
            if(this.Purchases.SelectedItem.Status=="Cleared")
            {
                this.ShowMessageBox("Payment for this purchase has been cleared.");
            }
            else
            {
                this.Application.ShowMakePurchasePayment(this.Purchases.SelectedItem.Id);
            }
        }
    }
}
