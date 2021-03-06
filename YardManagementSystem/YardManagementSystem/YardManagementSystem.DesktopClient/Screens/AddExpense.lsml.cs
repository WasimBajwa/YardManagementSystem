﻿using System;
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
    public partial class AddExpense
    {
        partial void AddExpense_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ExpenseProperty = new Expense();
        }

        partial void AddExpense_Saved()
        {
            // Write your code here.
            this.ShowMessageBox("Expense has been added successfully.");
            this.Close(true);
        }
    }
}