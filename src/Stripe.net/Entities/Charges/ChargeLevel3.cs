namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ChargeLevel3 : StripeEntity<ChargeLevel3>
    {
        [JsonProperty("customer_reference")]
        public string CustomerReference { get; set; }

        [JsonProperty("line_items")]
        public List<ChargeLevel3LineItem> LineItems { get; set; }

        [JsonProperty("merchant_reference")]
        public string MerchantReference { get; set; }

        [JsonProperty("shipping_address_zip")]
        public string ShippingAddressZip { get; set; }

        [JsonProperty("shipping_from_zip")]
        public string ShippingFromZip { get; set; }

        [JsonProperty("shipping_amount")]
        public long ShippingAmount { get; set; }
    }
}
