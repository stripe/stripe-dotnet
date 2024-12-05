// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateNotificationAcssDebit : StripeEntity<SourceMandateNotificationAcssDebit>
    {
        /// <summary>
        /// The statement descriptor associate with the debit.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
