namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodAttachOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the customer to which to attach the PaymentMethod.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
