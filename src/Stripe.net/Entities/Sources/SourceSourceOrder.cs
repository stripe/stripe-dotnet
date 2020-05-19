namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSourceOrder : StripeEntity<SourceSourceOrder>
    {
      [JsonProperty("amount")]
      public long Amount { get; set; }

      [JsonProperty("currency")]
      public string Currency { get; set; }

      [JsonProperty("email")]
      public string Email { get; set; }

      [JsonProperty("items")]
      public List<SourceSourceOrderItem> Items { get; set; }

      [JsonProperty("shipping")]
      public Shipping Shipping { get; set; }
    }
}
