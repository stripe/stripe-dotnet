using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeWebhookService
    {
        public virtual StripeInvoiceReady InvoiceReady(string json)
        {
            return Mapper<StripeInvoiceReady>.MapFromJson(json);
        }

        public virtual StripeRecurringPayment FailedRecurringPayment(string json)
        {
            return Mapper<StripeRecurringPayment>.MapFromJson(json);
        }

        public virtual StripeRecurringPayment SuccessfulRecurringPayment(string json)
        {
            return Mapper<StripeRecurringPayment>.MapFromJson(json);
        }

        public virtual StripeTrialEnding TrialEnding(string json)
        {
            return Mapper<StripeTrialEnding>.MapFromJson(json);
        }

        public virtual StripeFinalPaymentAttempt FinalPaymentAttempt(string json)
        {
            return Mapper<StripeFinalPaymentAttempt>.MapFromJson(json);
        }
    }
}