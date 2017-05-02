using Newtonsoft.Json;
using Stripe;

public class BankAccountOptions : INestedOptions
{
    [JsonProperty("bank_account")]
    public string TokenId { get; set; }

    [JsonProperty("bank_account[account_holder_name]")]
    public string AccountHolderName { get; set; }

    [JsonProperty("bank_account[account_holder_type]")]
    public string AccountHolderType { get; set; }

    [JsonProperty("bank_account[account_number]")]
    public string AccountNumber { get; set; }

    [JsonProperty("bank_account[country]")]
    public string Country { get; set; }

    [JsonProperty("bank_account[currency]")]
    public string Currency { get; set; }

    [JsonProperty("bank_account[routing_number]")]
    public string RoutingNumber { get; set; }
}