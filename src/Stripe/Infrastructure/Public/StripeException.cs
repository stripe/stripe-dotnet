using System;
using System.Net;

namespace Stripe
{
    public class StripeException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public StripeError StripeError { get; set; }

        public StripeException() 
        { 
        }

        public StripeException(HttpStatusCode httpStatusCode, StripeError stripeError, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            StripeError = stripeError;
        }
    }
}