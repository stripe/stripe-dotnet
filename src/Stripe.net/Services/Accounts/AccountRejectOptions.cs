namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRejectOptions : BaseOptions
    {
        /// <summary>
        /// The reason for rejecting the account. Can be <c>fraud</c>, <c>terms_of_service</c>, or
        /// <c>other</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
