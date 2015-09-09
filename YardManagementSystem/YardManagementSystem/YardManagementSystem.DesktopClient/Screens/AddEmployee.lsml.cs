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
    public partial class AddEmployee
    {
        partial void AddEmployee_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.EmployeeProperty = new Employee();
        }

        partial void AddEmployee_Saved()
        {
            // Write your code here.
            this.ShowMessageBox("Employee has been added successfully.");
            this.Close(true);
        }
    }
}