namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerInvoiceSettingsOptions : INestedOptions
    {
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }
    }
}
