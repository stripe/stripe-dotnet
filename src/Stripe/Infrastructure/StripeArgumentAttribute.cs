using System;

namespace Stripe
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class StripeArgumentAttribute : Attribute
    {
        public string Field { get; set; }

        public StripeArgumentAttribute(string field)
        {
            Field = field;
        }
    }
}
