using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeCustomerCreateOptions : CreditCardOptions
    {
        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("account_balance")]
        public int? AccountBalance { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        public DateTime? TrialEnd { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("trial_end")]
        internal long? TrialEndInternal
        {
            get
            {
                if (!TrialEnd.HasValue) return null;

                return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value);
            }
        }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty(Properties.CARD_NUMBER)]
        public string CardNumber { get; set; }

        [JsonProperty(Properties.CARD_EXP_MONTH)]
        public string CardExpirationMonth { get; set; }

        [JsonProperty(Properties.CARD_EXP_YEAR)]
        public string CardExpirationYear { get; set; }

        [JsonProperty(Properties.CARD_CVC)]
        public string CardCvc { get; set; }

        [JsonProperty(Properties.CARD_NAME)]
        public string CardName { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_LINE_ONE)]
        public string CardAddressLine1 { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_LINE_TWO)]
        public string CardAddressLine2 { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_ZIP)]
        public string CardAddressZip { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_CITY)]
        public string CardAddressCity { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_STATE)]
        public string CardAddressState { get; set; }

        [JsonProperty(Properties.CARD_ADDRESS_COUNTRY)]
        public string CardAddressCountry { get; set; }

        [JsonProperty(Properties.CARD_TOKEN_ID)]
        public string TokenId { get; set; }
    }
}
