namespace Stripe.Reporting
{
    using Newtonsoft.Json;

    public class ReportRunListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}
