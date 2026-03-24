// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAccountPaymentsBalanceByFundsType : StripeEntity<FinancialAccountPaymentsBalanceByFundsType>
    {
        /// <summary>
        /// Payment processing funds are those that are received for goods or services and may only
        /// be used for payouts to self. These funds may be converted to stored value funds.
        /// </summary>
        [JsonProperty("payment_processing")]
        [STJS.JsonPropertyName("payment_processing")]
        public FinancialAccountPaymentsBalanceByFundsTypePaymentProcessing PaymentProcessing { get; set; }

        /// <summary>
        /// Stored value funds may be used for either payouts to self or payments to others.
        /// </summary>
        [JsonProperty("stored_value")]
        [STJS.JsonPropertyName("stored_value")]
        public FinancialAccountPaymentsBalanceByFundsTypeStoredValue StoredValue { get; set; }
    }
}
