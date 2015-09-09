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
    public partial class AddPurchase
    {
        partial void AddPurchase_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.PurchaseProperty = new Purchase();
        }

        partial void AddPurchase_Saved()
        {
            // Write your code here.
            this.ShowMessageBox("Purchase has been added successfully.");
            this.Close(true);
        }
    }
}