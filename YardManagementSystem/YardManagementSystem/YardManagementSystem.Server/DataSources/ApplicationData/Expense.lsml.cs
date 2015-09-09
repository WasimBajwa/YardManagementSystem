using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;

namespace LightSwitchApplication
{
    public partial class Expense
    {
        partial void Amount_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (this.Amount <= 0)
            {
                results.AddPropertyError("Invalid Amount");
            }
        }
    }
}