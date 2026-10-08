// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsCardPresentFleetOptions : INestedOptions, IHasSetTracking
    {
        private List<PaymentIntentPaymentMethodOptionsCardPresentFleetTransactionDatumOptions> transactionData;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Fleet prompts and values collected for this transaction.
        /// </summary>
        [JsonProperty("transaction_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("transaction_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<PaymentIntentPaymentMethodOptionsCardPresentFleetTransactionDatumOptions> TransactionData
        {
            get => this.transactionData;
            set
            {
                this.transactionData = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
