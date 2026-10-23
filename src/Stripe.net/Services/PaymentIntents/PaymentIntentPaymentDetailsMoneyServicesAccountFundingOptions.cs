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
        /// The merchant of record for this account funding transaction. Can only be set when
        /// creating a PaymentIntent.
        /// One of: <c>stripe</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("merchant_of_record")]
        [STJS.JsonPropertyName("merchant_of_record")]
        public string MerchantOfRecord { get; set; }

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
