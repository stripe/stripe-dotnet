namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class SkuListOptions : ListOptions
    {
        [FormProperty("active")]
        public bool? Active { get; set; }

        [FormProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        [FormProperty("ids")]
        public string[] Ids { get; set; }

        [FormProperty("in_stock")]
        public bool? InStock { get; set; }

        [FormProperty("product")]
        public string Product { get; set; }
    }
}
