namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceFinalizeOptions : BaseOptions
    {
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
