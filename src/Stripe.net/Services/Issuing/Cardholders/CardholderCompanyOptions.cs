namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderCompanyOptions : INestedOptions
    {
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
