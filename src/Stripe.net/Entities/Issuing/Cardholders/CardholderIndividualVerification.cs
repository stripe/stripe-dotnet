namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualVerification : StripeEntity<CardholderIndividualVerification>
    {
        [JsonProperty("document")]
        public CardholderIndividualVerificationDocument Document { get; set; }
    }
}
