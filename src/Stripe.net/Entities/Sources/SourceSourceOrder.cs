namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceSourceOrder : StripeEntity<SourceSourceOrder>
    {
      /// <summary>
      /// A positive integer representing the total amount for the order.
      /// </summary>
      [JsonProperty("amount")]
      public long Amount { get; set; }

      /// <summary>
      /// The currency associated with the order.
      /// </summary>
      [JsonProperty("currency")]
      public string Currency { get; set; }

      /// <summary>
      /// The email address of the customer placing the order.
      /// </summary>
      [JsonProperty("email")]
      public string Email { get; set; }

      /// <summary>
      /// List of items constituting the order.
      /// </summary>
      [JsonProperty("items")]
      public List<SourceSourceOrderItem> Items { get; set; }

      /// <summary>
      /// The shipping address for the order. Present if the order is for goods
      /// to be shipped.
      /// </summary>
      [JsonProperty("shipping")]
      public Shipping Shipping { get; set; }
    }
}
