using System;
using System.Net;

namespace Stripe
{
    [Serializable]
    public class StripeException : ApplicationException
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public StripeError StripeError { get; set; }

        public StripeException() {
        }

        internal StripeException(HttpStatusCode httpStatusCode, StripeError stripeError, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            StripeError = stripeError;
        }
    }
}