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
    public partial class PaySalary
    {
        partial void PaySalary_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SalaryProperty = new Salary();
        }

        partial void PaySalary_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.SalaryProperty);
        }

        partial void PaySalary_Activated()
        {
            // Write your code here.

        }
    }
}