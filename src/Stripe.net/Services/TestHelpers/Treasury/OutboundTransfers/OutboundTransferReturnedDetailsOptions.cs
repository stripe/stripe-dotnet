// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundTransferReturnedDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Reason for the return.
        /// One of: <c>account_closed</c>, <c>account_frozen</c>, <c>bank_account_restricted</c>,
        /// <c>bank_ownership_changed</c>, <c>declined</c>, <c>incorrect_account_holder_name</c>,
        /// <c>invalid_account_number</c>, <c>invalid_currency</c>, <c>no_account</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }
    }
}
