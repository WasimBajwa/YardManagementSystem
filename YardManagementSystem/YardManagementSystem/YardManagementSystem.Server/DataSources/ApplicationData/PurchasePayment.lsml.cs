using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class PurchasePayment
    {
       

        partial void PaidAmount_Compute(ref decimal result)
        {
            // Set result to the desired field value
            if (this.Purchase != null)
            {
                result = this.Purchase.PaidAmount;
            }
        }

        partial void DueAmount_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = 0;
            result = this.TotalAmount - this.PaidAmount;
        }


        partial void Deposit_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(this.Deposit>this.DueAmount || this.Deposit<=0)
            {
                results.AddPropertyError("Invalid payment.");
            }
        }

        partial void TotalAmount_Compute(ref decimal result)
        {
            // Set result to the desired field value
            if (this.Purchase != null)
            {
                result = this.Purchase.TotalAmount;
            }
        }
    }
}
