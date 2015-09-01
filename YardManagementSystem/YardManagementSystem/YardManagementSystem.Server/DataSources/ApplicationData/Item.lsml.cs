using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Item
    {
        partial void Stock_Compute(ref double result)
        {
            // Set result to the desired field value
            if (this.Id != 0)
            {
                dynamic arr = this.DataWorkspace.ApplicationData.PurchaseItems.Where(x => x.Item.Id == this.Id).Select(x => x);
                foreach (dynamic a in arr)
                {
                    result += (a.GrossWeight - a.TearWeight);
                }

                dynamic arr1 = this.DataWorkspace.ApplicationData.SaleItems.Where(x => x.Item.Id == this.Id).Select(x => x);
                foreach (dynamic a1 in arr1)
                {
                    result -= (a1.GrossWeight - a1.TearWeight);
                }

                dynamic arr2 = this.DataWorkspace.ApplicationData.Exports.Where(x => x.Item.Id == this.Id).Select(x => x);
                foreach (dynamic a1 in arr2)
                {
                    result -= a1.Weight;
                }
            }
        }
    }
}
