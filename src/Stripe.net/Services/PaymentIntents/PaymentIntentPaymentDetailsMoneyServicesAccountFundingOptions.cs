// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsMoneyServicesAccountFundingOptions : INestedOptions, IHasSetTracking
    {
        private PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions senderDetails;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// ID of the Account representing the sender in this account funding transaction.
        /// </summary>
        [JsonProperty("sender_account")]
        [STJS.JsonPropertyName("sender_account")]
        public string SenderAccount { get; set; }

        /// <summary>
        /// Inline identity details for the sender of this account funding transaction.
        /// </summary>
        [JsonProperty("sender_details", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("sender_details")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public PaymentIntentPaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions SenderDetails
        {
            get => this.senderDetails;
            set
            {
                this.senderDetails = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
