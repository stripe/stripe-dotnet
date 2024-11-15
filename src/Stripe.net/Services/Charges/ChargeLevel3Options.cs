// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargeLevel3Options : INestedOptions
    {
        [JsonProperty("customer_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_reference")]
#endif

        public string CustomerReference { get; set; }

        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif

        public List<ChargeLevel3LineItemOptions> LineItems { get; set; }

        [JsonProperty("merchant_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_reference")]
#endif

        public string MerchantReference { get; set; }

        [JsonProperty("shipping_address_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_address_zip")]
#endif

        public string ShippingAddressZip { get; set; }

        [JsonProperty("shipping_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_amount")]
#endif

        public long? ShippingAmount { get; set; }

        [JsonProperty("shipping_from_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_from_zip")]
#endif

        public string ShippingFromZip { get; set; }
    }
}
