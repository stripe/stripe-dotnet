namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use AccountExternalAccountListOptions instead.")]
    public class ExternalAccountListOptions : ListOptions, IHasObject
    {
        /// <summary>
        /// Filter external accounts according to a particular object type.
        /// One of: <c>bank_account</c>, or <c>card</c>.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
