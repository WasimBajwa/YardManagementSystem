using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Sale
    {
        partial void TotalAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = 0;
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.SaleItems.Where(x => x.Sale.Id == Id).Select(x => x);

                foreach (dynamic a in arr)
                {
                    result = result + a.Price;
                }
            }
        }

        partial void PaidAmount_Compute(ref double result)
        {
            // Set result to the desired field value
            result = 0;
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.SalePayments.Where(x => x.Sale.Id == this.Id).Select(x => x);

                foreach (dynamic a in arr)
                {
                    result += a.CurrentPayment;
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
            else if (this.PaidAmount == this.TotalAmount && this.TotalAmount != 0)
            {
                result = "Cleared";
            }
            else
            {
                result = "Pending";
            }
        }
    }
}
