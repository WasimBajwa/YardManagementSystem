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
    public partial class ExpenseDetail
    {
        partial void Expense_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Expense);
        }

        partial void Expense_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Expense);
        }

        partial void ExpenseDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Expense);
        }
    }
}