namespace Stripe
{
    using System;
    using System.Net;

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

        public HttpStatusCode HttpStatusCode { get; set; }

        public StripeError StripeError { get; set; }

        public StripeResponse StripeResponse { get; set; }
    }
}
