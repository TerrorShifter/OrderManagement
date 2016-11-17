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
    public partial class SearchCustomers
    {
        partial void gridAddAndEditNew_CanExecute(ref bool result)
        {
            // Write your code here.
            result = this.Application.User.HasPermission(Permissions.CanAddCustomer);
        }

        partial void gridAddAndEditNew_Execute()
        {
            // Write your code here.
            this.Application.ShowCreateNewCustomerEdit(null);
        }
    }
}