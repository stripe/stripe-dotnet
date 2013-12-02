using Newtonsoft.Json;

namespace Stripe
 {
     public class StripeAmount 
     {
         [JsonProperty("amount")]
         public int Amount { get; set; }

         [JsonProperty("currency")]
         public string Currency { get; set; }
     }
 }