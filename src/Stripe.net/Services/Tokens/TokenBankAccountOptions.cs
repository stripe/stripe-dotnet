// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The name of the person or business that owns the bank account. This field is required
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
        /// The bank account type. This can only be <c>checking</c> or <c>savings</c> in most
        /// countries. In Japan, this can only be <c>futsu</c> or <c>toza</c>.
        /// One of: <c>checking</c>, <c>futsu</c>, <c>savings</c>, or <c>toza</c>.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// The country in which the bank account is located.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The currency the bank account is in. This must be a country/currency pairing that <a
        /// href="https://stripe.com/docs/payouts">Stripe supports.</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of a Payment Method with a <c>type</c> of <c>us_bank_account</c>. The Payment
        /// Method's bank account information will be copied and returned as a Bank Account Token.
        /// This parameter is exclusive with respect to all other parameters in the
        /// <c>bank_account</c> hash. You must include the top-level <c>customer</c> parameter if
        /// the Payment Method is attached to a <c>Customer</c> object. If the Payment Method is not
        /// attached to a <c>Customer</c> object, it will be consumed and cannot be used again. You
        /// may not use Payment Methods which were created by a Setup Intent with
        /// <c>attach_to_self=true</c>.
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

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
