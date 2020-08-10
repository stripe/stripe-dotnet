namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
