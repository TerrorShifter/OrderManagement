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
    public partial class CustomerDetail
    {
        partial void Customer_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Customer);
        }

        partial void Customer_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Customer);
        }

        partial void CustomerDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Customer);

            foreach (var order in this.Customer.OrderHeaders)
            {
                if(!order.OrderDetails.Any())
                {
                    this.ShowMessageBox("Warning: One or more empty orders were found. Please enter details for these orders.");
                    this.Application.ShowOrderHeaderDetail(order.Id);
                }
            }
        }

        partial void OpenOrders_Execute()
        {
            // Write your code here.
            this.Application.ShowOpenOrdersListDetail(Customer.Id);
        }
    }
}