namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderCompanyOptions : INestedOptions
    {
        /// <summary>
        /// The entity's business ID number.
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }
}
