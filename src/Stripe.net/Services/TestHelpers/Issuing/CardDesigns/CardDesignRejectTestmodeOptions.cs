// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class CardDesignRejectTestmodeOptions : BaseOptions
    {
        /// <summary>
        /// The reason(s) the card design was rejected.
        /// </summary>
        [JsonProperty("rejection_reasons")]
        public CardDesignRejectionReasonsOptions RejectionReasons { get; set; }
    }
}
