// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions : INestedOptions, IHasSetTracking
    {
        private string collectionMethod;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The method used to collect offline mandate customer acceptance.
        /// </summary>
        [JsonProperty("collection_method", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("collection_method")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string CollectionMethod
        {
            get => this.collectionMethod;
            set
            {
                this.collectionMethod = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
