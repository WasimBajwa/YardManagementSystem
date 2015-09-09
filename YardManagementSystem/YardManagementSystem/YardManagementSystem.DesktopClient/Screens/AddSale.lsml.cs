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
    public partial class AddSale
    {
        partial void AddSale_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SaleProperty = new Sale();
        }

        partial void AddSale_Saved()
        {
            // Write your code here.
            this.ShowMessageBox("Sale has been added successfully.");
            this.Close(true);
        }
    }
}