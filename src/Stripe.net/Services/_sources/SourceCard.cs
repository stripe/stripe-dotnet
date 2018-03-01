using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class SourceCard : INestedOptions, ISupportMetadata
    {
        /// <summary>
        /// The type of payment source. Should be "card".
        /// </summary>
        [JsonProperty("source[object]")]
        internal string Object => "card";

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [JsonProperty("source[address_city]")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [JsonProperty("source[address_country]")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [JsonProperty("source[address_line1]")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [JsonProperty("source[address_line2]")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [JsonProperty("source[address_state]")]
        public string AddressState { get; set; }

        /// <summary>
        /// Zip/Postal Code.
        /// </summary>
        [JsonProperty("source[address_zip]")]
        public string AddressZip { get; set; }

        /// <summary>
        /// USUALLY REQUIRED: Card security code. Highly recommended to always include this value, but it's only required for accounts based in European countries.
        /// </summary>
        [JsonProperty("source[cvc]")]
        public string Cvc { get; set; }

        /// <summary>
        /// REQUIRED: Two digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("source[exp_month]")]
        public int ExpirationMonth { get; set; }

        /// <summary>
        /// REQUIRED: Two or four digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("source[exp_year]")]
        public int ExpirationYear { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a card object. It can be useful for storing additional information about the card in a structured format.
        /// </summary>
        [JsonProperty("source[metadata]")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder's full name.
        /// </summary>
        [JsonProperty("source[name]")]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED: The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("source[number]")]
        public string Number { get; set; }
    }
}
