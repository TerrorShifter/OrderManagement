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
    public partial class Application
    {
        partial void EditableSortedProductsGrid_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = this.User.HasPermission(Permissions.CanAccessProductScreen);
        }

        partial void SearchCustomers_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = this.User.HasPermission(Permissions.CanViewCustomer);
        }

        partial void EditableProductsGrid_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = this.User.HasPermission(Permissions.CanAccessProductScreen);
        }

        partial void CreateNewCustomer_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = this.User.HasPermission(Permissions.CanAddCustomer);
        }

    }
}