namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceFinalizeInvoiceOptions : BaseOptions
    {
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
