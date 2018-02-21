using System;
using System.Net;

namespace Stripe
{
    public class StripeException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public StripeError StripeError { get; set; }
        public StripeResponse StripeResponse { get; set; }

        public StripeException() 
        { 
        }

        public StripeException(string message) : base(message)
        {
        }

        public StripeException(string message, Exception err) : base(message, err)
        {
        }

        public StripeException(HttpStatusCode httpStatusCode, StripeError stripeError, string message) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            StripeError = stripeError;
        }
    }
}