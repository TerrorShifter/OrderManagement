using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Customers_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.CanDeleteCustomer);
        }

        partial void Customers_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.CanAddCustomer);
        }

        partial void Customers_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.CanViewCustomer);
        }

        partial void Customers_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.CanEditCustomer);
        }
    }
}