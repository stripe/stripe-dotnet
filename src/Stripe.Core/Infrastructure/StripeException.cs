using System;
using System.Net;

namespace Stripe
{

#if PORTABLE
    public class StripeException : Exception
#else
    [Serializable]
    public class StripeException : ApplicationException
#endif
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