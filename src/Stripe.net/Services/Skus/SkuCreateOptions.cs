namespace Stripe
{
    using Stripe.Infrastructure;

    public class SkuCreateOptions : SkuSharedOptions
    {
        /// <summary>
        /// The identifier for the SKU. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [FormProperty("id")]
        public string Id { get; set; }
    }
}
