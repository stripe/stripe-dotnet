namespace Stripe
{
    using Stripe.Infrastructure;

    public class ProductListOptions : ListOptions
    {
        [FormProperty("active")]
        public bool? Active { get; set; }

        [FormProperty("ids")]
        public string[] Ids { get; set; }

        [FormProperty("shippable")]
        public bool? Shippable { get; set; }

        [FormProperty("url")]
        public string Url { get; set; }
    }
}
