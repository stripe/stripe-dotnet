using System;

namespace Stripe
{
    public abstract class StripeService
    {
        public string ApiKey { get; set; }

        protected StripeService(string apiKey)
        {
            ApiKey = apiKey;
        }

        protected StripeRequestOptions SetupRequestOptions(StripeRequestOptions requestOptions)
        {
            if(requestOptions == null) requestOptions = new StripeRequestOptions();

            if (!String.IsNullOrEmpty(ApiKey))
                requestOptions.ApiKey = ApiKey;

            return requestOptions;
        }
    }
}
