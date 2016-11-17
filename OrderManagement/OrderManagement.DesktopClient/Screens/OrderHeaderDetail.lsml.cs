using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class OrderHeaderDetail
    {
        partial void OrderHeader_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.OrderHeader);
        }

        partial void OrderHeader_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.OrderHeader);
        }

        partial void OrderHeaderDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.OrderHeader);
        }
    }
}