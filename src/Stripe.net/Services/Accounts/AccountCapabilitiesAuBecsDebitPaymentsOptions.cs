namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesAuBecsDebitPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Passing true requests the capability for the account, if it is not already requested. A
        /// requested capability may not immediately become active. Any requirements to activate the
        /// capability are returned in the <c>requirements</c> arrays.
        /// </summary>
        [JsonProperty("requested")]
        public bool? Requested { get; set; }
    }
}
