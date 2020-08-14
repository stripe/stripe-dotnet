namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderCompany : StripeEntity<CardholderCompany>
    {
        /// <summary>
        /// Whether the company's business ID number was provided.
        /// </summary>
        [JsonProperty("tax_id_provided")]
        public bool TaxIdProvided { get; set; }
    }
}
