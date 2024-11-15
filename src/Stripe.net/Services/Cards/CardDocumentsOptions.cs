// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that support the <a
        /// href="https://support.stripe.com/questions/bank-account-ownership-verification">Bank
        /// account ownership verification</a> requirement. Must be a document associated with the
        /// bank account that displays the last 4 digits of the account number, either a statement
        /// or a check.
        /// </summary>
        [JsonProperty("bank_account_ownership_verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_ownership_verification")]
#endif

        public CardDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification { get; set; }
    }
}
