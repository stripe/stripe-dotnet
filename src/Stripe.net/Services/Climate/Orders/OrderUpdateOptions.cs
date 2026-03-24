// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderUpdateOptions : BaseOptions, IHasMetadata
    {
        private OrderBeneficiaryOptions beneficiary;

        /// <summary>
        /// Publicly sharable reference for the end beneficiary of carbon removal. Assumed to be the
        /// Stripe account if not set.
        /// </summary>
        [JsonProperty("beneficiary")]
        [STJS.JsonPropertyName("beneficiary")]
        public OrderBeneficiaryOptions Beneficiary
        {
            get => this.beneficiary;
            set
            {
                this.beneficiary = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
