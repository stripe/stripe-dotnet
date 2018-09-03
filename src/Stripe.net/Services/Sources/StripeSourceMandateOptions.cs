namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeSourceMandateOptions : INestedOptions
    {
        public DateTime? MandateAcceptanceDate { get; set; }

        [JsonProperty("mandate[acceptance][date]")]
        internal long? MandateAcceptanceDateInternal
        {
            get
            {
                if (!this.MandateAcceptanceDate.HasValue)
                {
                    return null;
                }

                return EpochTime.ConvertDateTimeToEpoch(this.MandateAcceptanceDate.Value);
            }
        }

        [JsonProperty("mandate[acceptance][ip]")]
        public string MandateAcceptanceIp { get; set; }

        [JsonProperty("mandate[acceptance][status]")]
        public string MandateAcceptanceStatus { get; set; }

        [JsonProperty("mandate[acceptance][user_agent]")]
        public string MandateAcceptanceUserAgent { get; set; }

        [JsonProperty("mandate[notification_method]")]
        public string MandateNotificationMethod { get; set; }
    }
}
