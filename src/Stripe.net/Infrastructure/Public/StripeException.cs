namespace Stripe
{
    using System;
    using System.Net;
    using Newtonsoft.Json.Linq;

    public class StripeException : Exception
    {
        public StripeException()
        {
        }

        public StripeException(string message)
            : base(message)
        {
        }

        public StripeException(string message, Exception err)
            : base(message, err)
        {
        }

        public StripeException(HttpStatusCode httpStatusCode, StripeError stripeError, string message)
            : base(message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.StripeError = stripeError;
        }

        internal StripeException(HttpStatusCode httpStatusCode, StripeError stripeError)
            : base(stripeError.Message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.StripeError = stripeError;
        }

        public HttpStatusCode HttpStatusCode { get; set; }

        public StripeError StripeError { get; set; }

        public StripeResponse StripeResponse { get; set; }

        internal static StripeException ParseV2Exception(string type, StripeResponse response, JToken body)
        {
            var httpStatusCode = response.StatusCode;
            StripeException ret;
            switch (type)
            {
                // The beginning of the section generated from our OpenAPI spec
                case "temporary_session_expired":
                    ret = Stripe.V2.TemporarySessionExpiredException.Parse(httpStatusCode, body);
                    break;

                case "financial_account_not_open":
                    ret = Stripe.V2.FinancialAccountNotOpenException.Parse(httpStatusCode, body);
                    break;

                case "blocked_by_stripe":
                    ret = Stripe.V2.BlockedByStripeException.Parse(httpStatusCode, body);
                    break;

                case "already_canceled":
                    ret = Stripe.V2.AlreadyCanceledException.Parse(httpStatusCode, body);
                    break;

                case "not_cancelable":
                    ret = Stripe.V2.NotCancelableException.Parse(httpStatusCode, body);
                    break;

                case "insufficient_funds":
                    ret = Stripe.V2.InsufficientFundsException.Parse(httpStatusCode, body);
                    break;

                case "quota_exceeded":
                    ret = Stripe.V2.QuotaExceededException.Parse(httpStatusCode, body);
                    break;

                case "recipient_not_notifiable":
                    ret = Stripe.V2.RecipientNotNotifiableException.Parse(httpStatusCode, body);
                    break;

                case "feature_not_enabled":
                    ret = Stripe.V2.FeatureNotEnabledException.Parse(httpStatusCode, body);
                    break;

                case "invalid_payment_method":
                    ret = Stripe.V2.InvalidPaymentMethodException.Parse(httpStatusCode, body);
                    break;

                case "controlled_by_dashboard":
                    ret = Stripe.V2.ControlledByDashboardException.Parse(httpStatusCode, body);
                    break;

                // The end of the section generated from our OpenAPI spec
                default:
                    return null;
            }

            ret.StripeResponse = response;
            ret.StripeError.StripeResponse = response;
            return ret;
        }
    }
}
