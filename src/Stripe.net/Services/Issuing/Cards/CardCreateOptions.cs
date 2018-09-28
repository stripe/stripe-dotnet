namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardCreateOptions : CardSharedOptions
    {
        [FormProperty("cardholder")]
        public string Cardholder { get; set; }

        [FormProperty("currency")]
        public string Currency { get; set; }

        [FormProperty("name")]
        public string Name { get; set; }

        [FormProperty("shipping")]
        public CardShippingOptions Shipping { get; set; }

        [FormProperty("type")]
        public string Type { get; set; }
    }
}
