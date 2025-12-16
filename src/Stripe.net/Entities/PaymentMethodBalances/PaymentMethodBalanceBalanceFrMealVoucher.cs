// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodBalanceBalanceFrMealVoucher : StripeEntity<PaymentMethodBalanceBalanceFrMealVoucher>
    {
        /// <summary>
        /// The hashes of balances and amounts for available balances.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public List<PaymentMethodBalanceBalanceFrMealVoucherAvailable> Available { get; set; }
    }
}
