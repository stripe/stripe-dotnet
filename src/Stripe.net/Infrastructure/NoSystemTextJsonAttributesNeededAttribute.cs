namespace Stripe
{
    using System;

    internal class NoSystemTextJsonAttributesNeededAttribute : Attribute
    {
        public NoSystemTextJsonAttributesNeededAttribute(string reason)
        {
            this.Reason = reason;
        }

        public string Reason { get; }
    }
}
