using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class Customer
    {
        partial void State_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (State != null)
            {
                State = State.ToUpper();
            }
        }

        partial void FullName_Compute(ref string result)
        {
            // Set result to the desired field value
            result = LastName + ", " + FirstName;
        }
    }
}