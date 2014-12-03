using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeDiscount : StripeObject
    {
        [JsonProperty("start")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? End { get; set; }

        [JsonProperty("coupon")]
        public StripeCoupon StripeCoupon { get; set; }

        public string CustomerId { get; set; }

        /*
         * If the user is using the CamelCasePropertyNamesContractResolver and we don't tell the serializer to ignore this property,
         * the exception 'A member with the name 'customer' already exists on 'Stripe.StripeDiscount'. Use the JsonPropertyAttribute to specify another name.'
         * will be thrown
         */
        [JsonIgnore]
        public StripeCustomer Customer { get; set; }

        [JsonProperty("customer")]
        internal object InternalCustomer
        {
            set
            {
                ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
            }
        }
    }
}
