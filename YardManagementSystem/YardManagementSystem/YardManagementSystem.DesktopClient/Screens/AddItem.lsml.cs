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
    public partial class AddItem
    {
        partial void AddItem_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ItemProperty = new Item();
        }

        partial void AddItem_Saved()
        {
            // Write your code here.
            this.ShowMessageBox("Item has been added successfully.");
            this.Close(true);
        }
    }
}