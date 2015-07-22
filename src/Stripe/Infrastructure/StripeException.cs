using System;
using System.Net;

namespace Stripe
{
#if !WINDOWS_UAP
    [Serializable]
#endif
    public class StripeException :
#if WINDOWS_UAP
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