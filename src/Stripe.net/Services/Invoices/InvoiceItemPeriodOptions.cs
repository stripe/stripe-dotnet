namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceItemPeriodOptions : INestedOptions
    {
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; set; }
    }
}
