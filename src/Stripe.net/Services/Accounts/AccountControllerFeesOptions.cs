// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountControllerFeesOptions : INestedOptions
    {
        /// <summary>
        /// Controls who pays Stripe fees for direct charges and other pricing-control-eligible
        /// Stripe products. Setting <c>controller.losses.payments=application</c> requires
        /// <c>controller.fees.payer=application</c>. For destination charges and separate charges
        /// and transfers, Stripe bills the platform regardless of this setting. Defaults to
        /// <c>account</c>. Learn more about <a
        /// href="https://docs.stripe.com/connect/direct-charges-fee-payer-behavior">fee behavior on
        /// connected accounts</a>, including application fees and pricing considerations.
        /// One of: <c>account</c>, or <c>application</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public string Payer { get; set; }
    }
}
