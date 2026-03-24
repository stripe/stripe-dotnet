// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodBalanceBalanceFrMealVoucher : StripeEntity<PaymentMethodBalanceBalanceFrMealVoucher>
    {
        /// <summary>
        /// The hashes of balances and amounts for available balances.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public List<PaymentMethodBalanceBalanceFrMealVoucherAvailable> Available { get; set; }
    }
}
