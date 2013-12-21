using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe.Infrastructure
{
    public class StripeObjectFormatter
    {
        public static string FormatToString (object item)
        {
            StringBuilder sb = new StringBuilder();
                var props = item.GetType().GetProperties();

                foreach (var prop in props)
                {
                    sb.AppendFormat("{0}\t{1}", prop.Name,prop.GetValue(item,null));
                    sb.AppendLine();
                }
                return sb.ToString();
        }
    }
}
