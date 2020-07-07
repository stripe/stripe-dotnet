namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodAttachOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
