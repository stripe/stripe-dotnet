// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return credit notes for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return credit notes for the invoice specified by this invoice ID.
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}
