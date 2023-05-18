// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsBlikMandateOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Expiry date of the mandate.
        /// </summary>
        [JsonProperty("expires_after")]
        public long? ExpiresAfter { get; set; }

        /// <summary>
        /// Details of off-session mandate.
        /// </summary>
        [JsonProperty("off_session")]
        public SetupIntentPaymentMethodOptionsBlikMandateOptionsOffSessionOptions OffSession { get; set; }
    }
}
