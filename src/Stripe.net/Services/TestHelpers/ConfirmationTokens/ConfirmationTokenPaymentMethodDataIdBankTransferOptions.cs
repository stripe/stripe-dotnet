// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodDataIdBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// Bank where the account is held.
        /// One of: <c>bca</c>, <c>bni</c>, <c>bri</c>, <c>cimb</c>, or <c>permata</c>.
        /// </summary>
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
