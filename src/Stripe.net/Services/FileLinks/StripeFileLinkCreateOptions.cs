namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeFileLinkCreateOptions : StripeFileLinkSharedOptions
    {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [JsonProperty("file")]
        public string FileId { get; set; }
    }
}
