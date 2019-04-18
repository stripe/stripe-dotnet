namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class CreditNoteListOptions : ListOptions
    {
        /// <summary>
        /// ID of the invoice.
        /// </summary>
        [JsonProperty("invoice")]
        public string InvoiceId { get; set; }
    }
}
