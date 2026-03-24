// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentMethodOptionsSepaDebitMandateOptionsOptions : INestedOptions, IHasSetTracking
    {
        private string referencePrefix;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// Prefix used to generate the Mandate reference. Must be at most 12 characters long. Must
        /// consist of only uppercase letters, numbers, spaces, or the following special characters:
        /// '/', '_', '-', '&amp;', '.'. Cannot begin with 'STRIPE'.
        /// </summary>
        [JsonProperty("reference_prefix")]
        [STJS.JsonPropertyName("reference_prefix")]
        public string ReferencePrefix
        {
            get => this.referencePrefix;
            set
            {
                this.referencePrefix = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
