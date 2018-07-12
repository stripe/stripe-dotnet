using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeLevel3Options : INestedOptions
    {
        [JsonProperty("level3[customer_reference]")]
        public string CustomerReference { get; set; }

        // this will actually send `line_items`. this is to flag it for the middleware
        // to process it as a plugin
        [JsonProperty("level3[line_items]")]
        public List<StripeChargeLevel3LineItemOptions> LineItems { get; set; }

        [JsonProperty("level3[merchant_reference]")]
        public string MerchantReference { get; set; }

        [JsonProperty("level3[shipping_address_zip]")]
        public string ShippingAddressZip { get; set; }

        [JsonProperty("level3[shipping_from_zip]")]
        public string ShippingFromZip { get; set; }

        [JsonProperty("level3[shipping_amount]")]
        public int ShippingAmount { get; set; }
    }
}
