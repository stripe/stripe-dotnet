// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountCloseOptions : BaseOptions
    {
        /// <summary>
        /// A different bank account where funds can be deposited/debited in order to get the
        /// closing FA's balance to $0.
        /// </summary>
        [JsonProperty("forwarding_settings")]
        public FinancialAccountForwardingSettingsOptions ForwardingSettings { get; set; }
    }
}
