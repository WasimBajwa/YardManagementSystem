using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class PurchaseDetail
    {
        partial void Purchase_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Purchase);
        }

        partial void Purchase_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Purchase);
        }

        partial void PurchaseDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Purchase);
        }
    }
}