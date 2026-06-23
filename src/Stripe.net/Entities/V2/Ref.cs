namespace Stripe.V2
{
  using System;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;
  using Newtonsoft.Json;
  using Stripe.Infrastructure;
  using STJS = System.Text.Json.Serialization;

  /// <summary>
  /// A reference to a Stripe object. Holds the object's <c>id</c>, <c>type</c>
  /// </summary>
  [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
  public class Ref : StripeEntity<Ref>, IHasId
  {
    /// <summary>
    /// Unique identifier for the referenced object.
    /// </summary>
    [JsonProperty("id")]
    [STJS.JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// The type of the referenced object.
    /// </summary>
    [JsonProperty("type")]
    [STJS.JsonPropertyName("type")]
    public string Type { get; set; }

  }
}
