namespace Stripe.Reporting
{
    using Newtonsoft.Json;

    public class ReportRunListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }
    }
}
