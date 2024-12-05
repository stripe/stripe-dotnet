// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargeLevel3Options : INestedOptions
    {
        [JsonProperty("customer_reference")]
        public string CustomerReference { get; set; }

        [JsonProperty("line_items")]
        public List<ChargeLevel3LineItemOptions> LineItems { get; set; }

        [JsonProperty("merchant_reference")]
        public string MerchantReference { get; set; }

        [JsonProperty("shipping_address_zip")]
        public string ShippingAddressZip { get; set; }

        [JsonProperty("shipping_amount")]
        public long? ShippingAmount { get; set; }

        [JsonProperty("shipping_from_zip")]
        public string ShippingFromZip { get; set; }
    }
}
