// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountExternalAccountBankAccountOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; } = "bank_account";

        /// <summary>
        /// The name of the person or business that owns the bank account.This field is required
        /// when attaching the bank account to a <c>Customer</c> object.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The type of entity that holds the account. It can be <c>company</c> or
        /// <c>individual</c>. This field is required when attaching the bank account to a
        /// <c>Customer</c> object.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_type")]
#endif
        public string AccountHolderType { get; set; }

        /// <summary>
        /// The account number for the bank account, in string form. Must be a checking account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// The country in which the bank account is located.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The currency the bank account is in. This must be a country/currency pairing that <a
        /// href="docs/payouts">Stripe supports.</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// The routing number, sort code, or other country-appropriate institution number for the
        /// bank account. For US bank accounts, this is required and should be the ACH routing
        /// number, not the wire routing number. If you are providing an IBAN for
        /// <c>account_number</c>, this field is not required.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
