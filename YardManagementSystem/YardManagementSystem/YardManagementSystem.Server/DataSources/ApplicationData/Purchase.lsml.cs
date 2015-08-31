using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Purchase
    {
        partial void TotalAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = 0;
            if (this.Id != 0)
            {
                dynamic aar = this.DataWorkspace.ApplicationData.PurchaseItems.Where(x => x.Purchase.Id == this.Id).Select(x => x);

                foreach (dynamic a in aar)
                {
                    result = result + ((a.GrossWeight - a.TearWeight) * a.Rate);
                }
            }
        }

        partial void PaidAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = 0;
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.PurchasePayments.Where(x => x.Purchase.Id == this.Id).Select(x => x);

                foreach (dynamic a in arr)
                {
                    result += a.Deposit;
                }
            }
        }

        partial void DueAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = this.TotalAmount - this.PaidAmount;
        }

        partial void Status_Compute(ref string result)
        {
            // Set result to the desired field value
            if (this.Id == 0)
            {
                result = "Disabled";
            }

            else if (this.TotalAmount > this.PaidAmount && this.TotalAmount != 0)
            {
                result = "Pending";
            }
            else
            {
                result = "Cleared";
            }
        }
    }
}
