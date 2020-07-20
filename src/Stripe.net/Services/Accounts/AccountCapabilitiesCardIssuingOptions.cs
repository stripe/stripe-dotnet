namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesCardIssuingOptions : INestedOptions
    {
        /// <summary>
        /// Passing <c>true</c> requests the capability for the account, if it
        /// is not already requested. A requested capability may not
        /// immediately become active. Any requirements to activate the
        /// capability are returned in the requirements arrays.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
