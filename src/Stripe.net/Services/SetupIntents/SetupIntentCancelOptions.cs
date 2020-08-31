namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentCancelOptions : BaseOptions
    {
        /// <summary>
        /// Reason for canceling this SetupIntent. Possible values are <c>abandoned</c>,
        /// <c>requested_by_customer</c>, or <c>duplicate</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
