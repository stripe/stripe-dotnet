// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSupplementaryPurchaseDataVoucherOptions : INestedOptions
    {
        /// <summary>
        /// Name of associated or partner company for this voucher.
        /// </summary>
        [JsonProperty("affiliate_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("affiliate_name")]
#endif
        public string AffiliateName { get; set; }

        /// <summary>
        /// The voucher validity end time.
        /// </summary>
        [JsonProperty("ends_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ends_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// The voucher validity start time.
        /// </summary>
        [JsonProperty("starts_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("starts_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// The issuer or provider of this voucher.
        /// </summary>
        [JsonProperty("voucher_company")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("voucher_company")]
#endif
        public string VoucherCompany { get; set; }

        /// <summary>
        /// The name or reference to identify the voucher.
        /// </summary>
        [JsonProperty("voucher_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("voucher_name")]
#endif
        public string VoucherName { get; set; }

        /// <summary>
        /// The type of this voucher.
        /// One of: <c>digital_product</c>, <c>discount</c>, <c>gift_card</c>,
        /// <c>physical_product</c>, or <c>services</c>.
        /// </summary>
        [JsonProperty("voucher_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("voucher_type")]
#endif
        public string VoucherType { get; set; }
    }
}
