namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use AccountExternalAccountDocumentsOptions instead.")]
    public class ExternalAccountDocumentsOptions : INestedOptions
    {
        /// <summary>
        /// One or more documents that support the <a
        /// href="https://support.stripe.com/questions/bank-account-ownership-verification">Bank
        /// account ownership verification</a> requirement. Must be a document associated with the
        /// bank account that displays the last 4 digits of the account number, either a statement
        /// or a voided check.
        /// </summary>
        [JsonProperty("bank_account_ownership_verification")]
        public ExternalAccountDocumentsBankAccountOwnershipVerificationOptions BankAccountOwnershipVerification { get; set; }
    }
}
