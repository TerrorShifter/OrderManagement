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
    public partial class CreateNewCustomerEdit
    {
        partial void CreateNewCustomerEdit_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            if(this.CustomerID.HasValue)
            {
                this.CustomerProperty = this.Customer;
            }
            else
                this.CustomerProperty = new Customer();
        }

        partial void CreateNewCustomerEdit_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.CustomerProperty);
        }

        partial void OpenOrders_CanExecute(ref bool result)
        {
            // Write your code here.
            //this.Application.ShowOpenOrdersListDetail(Customer.Id);
        }

        partial void OpenOrders_Execute()
        {
            // Write your code here.
            this.Application.ShowOpenOrdersListDetail(Customer.Id);
        }
    }
    
}