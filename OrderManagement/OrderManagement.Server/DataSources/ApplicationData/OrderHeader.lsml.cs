using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class OrderHeader
    {
        partial void OrderTotal_Compute(ref decimal result)
        {
            // Set result to the desired field value
            decimal total = 0;
            foreach(OrderDetail d in this.OrderDetails)
            {
                total += d.LineItemTotal;
            }
            result = total;
        }

        partial void OrderDate_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(this.OrderDate > DateTime.Today)
            {
                results.AddPropertyError("Order date can't be in the future.");
            }
            if(this.ShipDate.HasValue && this.OrderDate > this.ShipDate)
            {
                results.AddPropertyError("Order date can't be greater than the ship date.");
            }
        }

        partial void ShipDate_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if (this.ShipDate.HasValue && this.OrderDate > this.ShipDate)
            {
                results.AddPropertyError("Shipped date can't be less than the order date.");
            }
        }
    }
}