using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class SalePayment
    {
        partial void TotalAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Sale != null)
            {
                result = this.Sale.TotalAmount;
            }
        }

        partial void PaidAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Sale != null)
            {
                result = this.Sale.PaidAmount;
            }
        }

        partial void DueAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = this.TotalAmount - this.PaidAmount;
        }

        partial void Deposit_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(this.Deposit>this.DueAmount)
            {
                results.AddPropertyError("Invalid payment");
            }
        }
    }
}
