// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions : INestedOptions
    {
        /// <summary>
        /// Name of associated or partner company for this voucher.
        /// </summary>
        [JsonProperty("affiliate_name")]
        [STJS.JsonPropertyName("affiliate_name")]
        public string AffiliateName { get; set; }

        /// <summary>
        /// The voucher validity end time.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// The voucher validity start time.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// The issuer or provider of this voucher.
        /// </summary>
        [JsonProperty("voucher_company")]
        [STJS.JsonPropertyName("voucher_company")]
        public string VoucherCompany { get; set; }

        /// <summary>
        /// The name or reference to identify the voucher.
        /// </summary>
        [JsonProperty("voucher_name")]
        [STJS.JsonPropertyName("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// The type of this voucher.
        /// One of: <c>digital_product</c>, <c>discount</c>, <c>gift_card</c>,
        /// <c>physical_product</c>, or <c>services</c>.
        /// </summary>
        [JsonProperty("voucher_type")]
        [STJS.JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
