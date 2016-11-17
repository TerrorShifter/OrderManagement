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
    public partial class OpenOrdersListDetail
    {
        partial void OpenOrders_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach(OrderHeader o in e.NewItems)
                {
                    o.Customer = this.Customer;
                }
            }
        }

        partial void OrderDetails_Changed(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if(this.OrderDetails.Count > 1 && e.NewItems.Count == 1)
                {
                    try
                    {
                        OrderDetail newDetail = e.NewItems(0);
                    }
                }
            }
        }
    }
}