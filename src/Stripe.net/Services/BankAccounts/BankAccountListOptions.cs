namespace Stripe
{
    using Newtonsoft.Json;

    public class BankAccountListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "bank_account";
    }
}
