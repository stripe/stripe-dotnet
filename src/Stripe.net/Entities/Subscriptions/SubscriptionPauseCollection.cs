namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionPauseCollection : StripeEntity<SubscriptionPauseCollection>
    {
      [JsonProperty("behavior")]
      public string Behavior { get; set; }

      [JsonProperty("resumes_at")]
      [JsonConverter(typeof(DateTimeConverter))]
      public DateTime? ResumesAt { get; set; }
    }
}
