using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class PurchasePayment
    {
        partial void TotalAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Purchase != null)
            {
                double amount = this.Purchase.TotalAmount;
                result = amount;
            }
        }

        partial void PaidAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Purchase != null)
            {
                result = this.Purchase.PaidAmount;
            }
        }

        partial void DueAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = 0;
            result = TotalAmount - this.PaidAmount;
        }
    }
}
