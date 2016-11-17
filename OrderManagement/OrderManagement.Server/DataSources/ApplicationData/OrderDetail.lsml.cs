using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class OrderDetail
    {
        partial void LineItemTotal_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = this.Quantity * this.Price;
        }

        partial void Product_Validate(EntityValidationResultsBuilder results)
        {
            // results.AddPropertyError("<Error-Message>");
            if(this.Product != null)
            {
                var dupes = from detail in this.OrderHeader.OrderDetails
                            where detail.Product != null &&
                            detail.Product.Id == this.Product.Id &&
                            !object.ReferenceEquals(detail, this)
                            select detail;
                               

                if(dupes.Any())
                {
                    results.AddPropertyError(this.Product.ProductName + " is a duplicate product.");
                }
            }
        }

        partial void OrderDetail_Created()
        {
            this.Quantity = 1;
        }
    }
}