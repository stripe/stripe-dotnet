// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CollectionSettingPaymentMethodOptions : StripeEntity<CollectionSettingPaymentMethodOptions>
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public CollectionSettingPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public CollectionSettingPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public CollectionSettingPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public CollectionSettingPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public Dictionary<string, object> Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public Dictionary<string, object> SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public CollectionSettingPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
