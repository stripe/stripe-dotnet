using Stripe.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stripe
{
    public class StripeBase
    {
        public override string ToString()
        {
            return StripeObjectFormatter.FormatToString(this);
        }
    }
}
