using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class SaleItem
    {
        partial void Price_Compute(ref decimal result)
        {
            // Set result to the desired field value
            if (Rate != 0 && GrossWeight != 0 && TearWeight != 0)
            {
                result = Convert.ToInt32((GrossWeight - TearWeight) * (double)Rate);
            }
        }

        partial void GrossWeight_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (this.TearWeight != 0)
            {
                if (this.GrossWeight <= this.TearWeight)
                {
                    results.AddPropertyError("Tear Weight can not exceed Gross weight.");
                }
            }

            if(this.Item!=null)
                if (this.GrossWeight - this.TearWeight > this.Item.Stock)
                {
                    results.AddPropertyError("Stock is not sufficient.");
                }
        }
    }
}
