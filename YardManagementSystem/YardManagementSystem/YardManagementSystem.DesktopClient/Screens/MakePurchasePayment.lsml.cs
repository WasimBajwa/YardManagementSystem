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
    public partial class MakePurchasePayment
    {
        partial void MakePurchasePayment_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.PurchasePaymentProperty = new PurchasePayment();
        }

        partial void MakePurchasePayment_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.PurchasePaymentProperty);
        }

        partial void MakePurchasePayment_Activated()
        {
            // Write your code here.
            int Id = this.PurchaseId;
            Purchase obj = this.DataWorkspace.ApplicationData.Purchases.Where(x => x.Id == Id).Select(x => x).First();
            this.PurchasePaymentProperty.Purchase = obj;
        }
    }
}