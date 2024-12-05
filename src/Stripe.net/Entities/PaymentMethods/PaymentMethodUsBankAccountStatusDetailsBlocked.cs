// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodUsBankAccountStatusDetailsBlocked : StripeEntity<PaymentMethodUsBankAccountStatusDetailsBlocked>
    {
        /// <summary>
        /// The ACH network code that resulted in this block.
        /// One of: <c>R02</c>, <c>R03</c>, <c>R04</c>, <c>R05</c>, <c>R07</c>, <c>R08</c>,
        /// <c>R10</c>, <c>R11</c>, <c>R16</c>, <c>R20</c>, <c>R29</c>, or <c>R31</c>.
        /// </summary>
        [JsonProperty("network_code")]
        public string NetworkCode { get; set; }

        /// <summary>
        /// The reason why this PaymentMethod's fingerprint has been blocked.
        /// One of: <c>bank_account_closed</c>, <c>bank_account_frozen</c>,
        /// <c>bank_account_invalid_details</c>, <c>bank_account_restricted</c>,
        /// <c>bank_account_unusable</c>, or <c>debit_not_authorized</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
