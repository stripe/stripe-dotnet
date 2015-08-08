using System;
using System.Net;

namespace Stripe
{
#if !WINDOWS_UWP
    [Serializable]
#endif
    public class StripeException :
#if WINDOWS_UWP
        Exception
#else
        ApplicationException
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