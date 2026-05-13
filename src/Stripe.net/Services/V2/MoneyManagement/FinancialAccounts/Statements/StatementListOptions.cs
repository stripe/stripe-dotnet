// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement.FinancialAccounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class StatementListOptions : V2.ListOptions
    {
        /// <summary>
        /// The field by which to sort results. Defaults to "created".
        /// One of: <c>created</c>, or <c>period_end_date</c>.
        /// </summary>
        [JsonProperty("order_by")]
        [STJS.JsonPropertyName("order_by")]
        public string OrderBy { get; set; }
    }
}
