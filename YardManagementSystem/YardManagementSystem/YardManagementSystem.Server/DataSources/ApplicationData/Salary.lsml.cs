using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Salary
    {
        partial void SalaryType_Compute(ref string result)
        {
            // Set result to the desired field value
            if(this.Employee!=null)
            {
                result = this.Employee.SalaryType;
            }
        }
    }
}
