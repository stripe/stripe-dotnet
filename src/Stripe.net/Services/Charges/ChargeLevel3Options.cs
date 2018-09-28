namespace Stripe
{
    using System.Collections.Generic;
    using Stripe.Infrastructure;

    public class ChargeLevel3Options : INestedOptions
    {
        [FormProperty("customer_reference")]
        public string CustomerReference { get; set; }

        [FormProperty("line_items")]
        public List<ChargeLevel3LineItemOptions> LineItems { get; set; }

        [FormProperty("merchant_reference")]
        public string MerchantReference { get; set; }

        [FormProperty("shipping_address_zip")]
        public string ShippingAddressZip { get; set; }

        [FormProperty("shipping_from_zip")]
        public string ShippingFromZip { get; set; }

        [FormProperty("shipping_amount")]
        public int? ShippingAmount { get; set; }
    }
}
