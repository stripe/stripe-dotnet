namespace Stripe
{
    using Stripe.Infrastructure;

    public class ProductCreateOptions : ProductSharedOptions
    {
        /// <summary>
        /// The identifier for the product. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [FormProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the product. Either 'service' or 'good'.
        /// </summary>
        [FormProperty("type")]
        public string Type { get; set; }
    }
}
