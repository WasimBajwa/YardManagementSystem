using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Export
    {
        partial void TotalAmount_Compute(ref decimal result)
        {
            // Set result to the desired field value
            if (this.Rate != 0 && this.Weight != 0)
            {
                result = Convert.ToInt32((double)this.Rate * this.Weight);
            }
        }

        partial void Weight_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (this.Item != null)
            {
                if (this.Weight > this.Item.Stock)
                {
                    results.AddPropertyError("Not enough stock available.");
                }
            }
        }
    }
}
