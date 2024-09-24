namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Obsolete("Use AccountPersonDocumentsPassportOptions instead.")]
    public class PersonDocumentsPassportOptions : INestedOptions
    {
        /// <summary>
        /// One or more document ids returned by a <a
        /// href="https://stripe.com/docs/api#create_file">file upload</a> with a <c>purpose</c>
        /// value of <c>account_requirement</c>.
        /// </summary>
        [JsonProperty("files")]
        public List<string> Files { get; set; }
    }
}
