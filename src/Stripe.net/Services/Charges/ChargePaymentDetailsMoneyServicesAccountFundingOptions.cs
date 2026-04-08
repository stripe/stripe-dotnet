// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsMoneyServicesAccountFundingOptions : INestedOptions, IHasSetTracking
    {
        private ChargePaymentDetailsMoneyServicesAccountFundingBeneficiaryDetailsOptions beneficiaryDetails;
        private ChargePaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions senderDetails;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// ID of the Account representing the beneficiary in this account funding transaction.
        /// </summary>
        [JsonProperty("beneficiary_account")]
        [STJS.JsonPropertyName("beneficiary_account")]
        public string BeneficiaryAccount { get; set; }

        /// <summary>
        /// Inline identity details for the beneficiary of this account funding transaction.
        /// </summary>
        [JsonProperty("beneficiary_details")]
        [STJS.JsonPropertyName("beneficiary_details")]
        public ChargePaymentDetailsMoneyServicesAccountFundingBeneficiaryDetailsOptions BeneficiaryDetails
        {
            get => this.beneficiaryDetails;
            set
            {
                this.beneficiaryDetails = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// ID of the Account representing the sender in this account funding transaction.
        /// </summary>
        [JsonProperty("sender_account")]
        [STJS.JsonPropertyName("sender_account")]
        public string SenderAccount { get; set; }

        /// <summary>
        /// Inline identity details for the sender of this account funding transaction.
        /// </summary>
        [JsonProperty("sender_details")]
        [STJS.JsonPropertyName("sender_details")]
        public ChargePaymentDetailsMoneyServicesAccountFundingSenderDetailsOptions SenderDetails
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
