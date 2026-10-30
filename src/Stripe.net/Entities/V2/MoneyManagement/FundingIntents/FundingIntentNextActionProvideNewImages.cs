// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextActionProvideNewImages : StripeEntity<FundingIntentNextActionProvideNewImages>
    {
        /// <summary>
        /// Issues detected in the check amount.
        /// </summary>
        [JsonProperty("amount_issues")]
        [STJS.JsonPropertyName("amount_issues")]
        public List<FundingIntentNextActionProvideNewImagesAmountIssue> AmountIssues { get; set; }

        /// <summary>
        /// Issues detected in the back image of the check.
        /// </summary>
        [JsonProperty("back_image")]
        [STJS.JsonPropertyName("back_image")]
        public List<FundingIntentNextActionProvideNewImagesBackImage> BackImage { get; set; }

        /// <summary>
        /// Issues detected in the front image of the check.
        /// </summary>
        [JsonProperty("front_image")]
        [STJS.JsonPropertyName("front_image")]
        public List<FundingIntentNextActionProvideNewImagesFrontImage> FrontImage { get; set; }
    }
}
