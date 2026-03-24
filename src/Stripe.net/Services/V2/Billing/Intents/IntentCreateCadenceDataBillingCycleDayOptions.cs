// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateCadenceDataBillingCycleDayOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the billing cycle ends. This field is optional, and if not provided,
        /// it will default to the time at which the cadence was created in UTC timezone.
        /// </summary>
        [JsonProperty("time")]
        [STJS.JsonPropertyName("time")]
        public IntentCreateCadenceDataBillingCycleDayTimeOptions Time { get; set; }
    }
}
