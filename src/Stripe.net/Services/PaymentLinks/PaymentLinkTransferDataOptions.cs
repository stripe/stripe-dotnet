// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkTransferDataOptions : INestedOptions, IHasSetTracking
    {
        private long? amount;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The amount that will be transferred automatically when a charge succeeds.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? Amount
        {
            get => this.amount;
            set
            {
                this.amount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// If specified, successful charges will be attributed to the destination account for tax
        /// reporting, and the funds from charges will be transferred to the destination account.
        /// The ID of the resulting transfer will be returned on the successful charge's
        /// <c>transfer</c> field.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
