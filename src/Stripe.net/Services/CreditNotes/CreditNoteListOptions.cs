namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteListOptions : ListOptions
    {
        /// <summary>
        /// ID of the customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// ID of the invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}
