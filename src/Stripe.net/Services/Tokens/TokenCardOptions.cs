// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenCardOptions : INestedOptions
    {
        /// <summary>
        /// City / District / Suburb / Town / Village.
        /// </summary>
        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided.
        /// </summary>
        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address / PO Box / Company name).
        /// </summary>
        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment / Suite / Unit / Building).
        /// </summary>
        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State / County / Province / Region.
        /// </summary>
        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// Required in order to add the card to an account; in all other cases, this parameter is
        /// not used. When added to an account, the card (which must be a debit card) can be used as
        /// a transfer destination for funds in this currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Card security code. Highly recommended to always include this value.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public string ExpYear { get; set; }

        /// <summary>
        /// Cardholder's full name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Contains information about card networks used to process the payment.
        /// </summary>
        [JsonProperty("networks")]
        public TokenCardNetworksOptions Networks { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
