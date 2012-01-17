using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeWebhookService
    {
        public StripeInvoiceReady InvoiceReady(string json)
        {
            return Mapper<StripeInvoiceReady>.MapFromJson(json);
        }

        public StripeRecurringPayment FailedRecurringPayment(string json)
        {
            return Mapper<StripeRecurringPayment>.MapFromJson(json);
        }

        public StripeRecurringPayment SuccessfulRecurringPayment(string json)
        {
            return Mapper<StripeRecurringPayment>.MapFromJson(json);
        }

        public StripeTrialEnding TrialEnding(string json)
        {
            return Mapper<StripeTrialEnding>.MapFromJson(json);
        }

        public StripeFinalPaymentAttempt FinalPaymentAttempt(string json)
        {
            return Mapper<StripeFinalPaymentAttempt>.MapFromJson(json);
        }
    }
}