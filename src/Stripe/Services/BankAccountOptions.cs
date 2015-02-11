using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public interface IBankAccountOptions
    {
    }

    public class BankAccountOptions : IBankAccountOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("routing_number")]
        public string RoutingNumber { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }
    }

    [QueryStringParameterConverter(typeof(BankAccountTokenQueryStringParameterConverter))]
    public class BankAccountToken : IBankAccountOptions
    {
        public string Token { get; set; }
    }

    internal class BankAccountTokenQueryStringParameterConverter
        : QueryStringParameterConverter<BankAccountToken>
    {
        public override string ConvertToQueryStringValue(BankAccountToken @object)
        {
            return @object.Token;
        }
    }
}