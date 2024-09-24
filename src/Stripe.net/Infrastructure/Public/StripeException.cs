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
