namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceThreeDSecure : StripeEntity<SourceThreeDSecure>
    {
        /// <summary>
        /// If `address_line1` was provided, results of the check: `pass`, `fail`, `unavailable`, or `unchecked`.
        /// </summary>
        [JsonProperty("address_line1_check")]
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// If `address_zip` was provided, results of the check: `pass`, `fail`, `unavailable`, or `unchecked`.
        /// </summary>
        [JsonProperty("address_zip_check")]
        public string AddressZipCheck { get; set; }

        /// <summary>
        /// True if the cardholder went through the authentication flow and their bank indicated that authentication succeeded.
        /// </summary>
        [JsonProperty("authenticated")]
        public bool? Authenticated { get; set; }

        /// <summary>
        /// Card brand. Can be `American Express`, `Diners Club`, `Discover`, `JCB`, `MasterCard`, `UnionPay`, `Visa`, or `Unknown`.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The card used to create this 3DS source.
        /// </summary>
        [JsonProperty("card")]
        public string Card { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The ID of the customer to which the card belongs, if any.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// If a CVC was provided, results of the check: `pass`, `fail`, `unavailable`, or `unchecked`.
        /// </summary>
        [JsonProperty("cvc_check")]
        public string CvcCheck { get; set; }

        /// <summary>
        /// This is an internal property that is not returned in standard API requests.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        /// <summary>
        /// The expiration month of the card.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// The expiration year of the card.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check whether two customers who've signed up with you are using the same card number, for example.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be `credit`, `debit`, `prepaid`, or `unknown`.
        /// </summary>
        [JsonProperty("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// This is an internal property that is not returned in standard API requests.
        /// </summary>
        [JsonProperty("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// This is an internal property that is not returned in standard API requests.
        /// </summary>
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The card's 3D Secure support status. Can be one of `not_supported`, `required`, `recommended` or `optional`.
        /// </summary>
        [JsonProperty("three_d_secure")]
        public string ThreeDSecure { get; set; }

        /// <summary>
        /// If the card number is tokenized, this is the method that was used. Can be `apple_pay` or `android_pay`.
        /// </summary>
        [JsonProperty("tokenization_method")]
        public string TokenizationMethod { get; set; }
    }
}
