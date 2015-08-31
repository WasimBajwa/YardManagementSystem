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
    public partial class AddSalePayment
    {
        partial void AddSalePayment_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SalePaymentProperty = new SalePayment();
        }

        partial void AddSalePayment_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.SalePaymentProperty);
        }

        partial void AddSalePayment_Activated()
        {
            // Write your code here.
            Sale obj = this.DataWorkspace.ApplicationData.Sales.Where(x => x.Id == this.SaleId).Select(x => x).First();
            this.SalePaymentProperty.Sale = obj;
        }
    }
}