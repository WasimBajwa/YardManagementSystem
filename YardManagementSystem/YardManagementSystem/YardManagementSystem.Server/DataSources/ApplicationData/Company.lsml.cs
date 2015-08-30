using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Company
    {
        partial void TotalPurchase_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.Purchases.Where(x => x.Company.Id == this.Id).Select(x => x);
                foreach (dynamic a in arr)
                {
                    result += a.TotalAmount;
                }
            }
        }

        partial void TotalSale_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.Sales.Where(x => x.Company.Id == this.Id).Select(x => x);
                foreach (dynamic a in arr)
                {
                    result += a.TotalPayment;
                }
            }
        }
    }
}
