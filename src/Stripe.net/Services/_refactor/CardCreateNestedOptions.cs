namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class CardCreateNestedOptions : INestedOptions, ISupportMetadata
    {
        /// <summary>
        /// The type of payment source. Should be "card".
        /// </summary>
        [FormProperty("object")]
        internal string Object => "card";

        /// <summary>
        /// City/District/Suburb/Town/Village.
        /// </summary>
        [FormProperty("address_city")]
        public string AddressCity { get; set; }

        /// <summary>
        /// Billing address country, if provided when creating card.
        /// </summary>
        [FormProperty("address_country")]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Address line 1 (Street address/PO Box/Company name).
        /// </summary>
        [FormProperty("address_line1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2 (Apartment/Suite/Unit/Building).
        /// </summary>
        [FormProperty("address_line2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// State/County/Province/Region.
        /// </summary>
        [FormProperty("address_state")]
        public string AddressState { get; set; }

        /// <summary>
        /// Zip/Postal Code.
        /// </summary>
        [FormProperty("address_zip")]
        public string AddressZip { get; set; }

        /// <summary>
        /// USUALLY REQUIRED: Card security code. Highly recommended to always include this value, but it's only required for accounts based in European countries.
        /// </summary>
        [FormProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// REQUIRED: Two digit number representing the card's expiration month.
        /// </summary>
        [FormProperty("exp_month")]
        public int? ExpirationMonth { get; set; }

        /// <summary>
        /// REQUIRED: Two or four digit number representing the card's expiration year.
        /// </summary>
        [FormProperty("exp_year")]
        public int? ExpirationYear { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a card object. It can be useful for storing additional information about the card in a structured format.
        /// </summary>
        [FormProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Cardholder's full name.
        /// </summary>
        [FormProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED: The card number, as a string without any separators.
        /// </summary>
        [FormProperty("number")]
        public string Number { get; set; }
    }
}
