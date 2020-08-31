namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The name of the person or business that owns the bank account.This field is required
        /// when attaching the bank account to a <c>Customer</c> object.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. It can be <c>company</c> or
        /// <c>individual</c>. This field is required when attaching the bank account to a
        /// <c>Customer</c> object.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The account number for the bank account, in string form. Must be a checking account.
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The country in which the bank account is located.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The currency the bank account is in. This must be a country/currency pairing that <a
        /// href="docs/payouts">Stripe supports.</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The routing number, sort code, or other country-appropriateinstitution number for the
        /// bank account. For US bank accounts, this is required and should bethe ACH routing
        /// number, not the wire routing number. If you are providing an IBAN
        /// for<c>account_number</c>, this field is not required.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
