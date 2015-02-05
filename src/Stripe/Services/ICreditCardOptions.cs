using Newtonsoft.Json;

namespace Stripe
{
    public interface ICreditCardOptions
    {
        [JsonProperty(Properties.CARD_NUMBER)]
        string CardNumber { get; set; }

        [JsonProperty(Properties.CARD_EXP_MONTH)]
        string CardExpirationMonth { get; set; }

        [JsonProperty(Properties.CARD_EXP_YEAR)]
        string CardExpirationYear { get; set; }

        [JsonProperty(Properties.CARD_CVC)]
        string CardCvc { get; set; }

        [JsonProperty(Properties.CARD_NAME)]
        string CardName { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_LINE_ONE)]
        string CardAddressLine1 { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_LINE_TWO)]
        string CardAddressLine2 { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_ZIP)]
        string CardAddressZip { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_CITY)]
        string CardAddressCity { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_STATE)]
        string CardAddressState { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_COUNTRY)]
        string CardAddressCountry { get; set; }

        [JsonProperty(Properties.CARD_TOKEN_ID)]
        string TokenId { get; set; }
    }
}
