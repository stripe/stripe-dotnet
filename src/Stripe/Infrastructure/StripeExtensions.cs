using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Stripe
{
    internal static class StripeExtensions
    {
        public static StripeResponse<T> PostResponse<T>(this string url, string apiKey)
        {
            StripeError error;
            var result = Requestor.PostString(url, out error, apiKey);
            return new StripeResponse<T>(result, error);
        }

        public static StripeResponse<T> PostBearerResponse<T>(this string url, string apiKey)
        {
            StripeError error;
            var result = Requestor.PostStringBearer(url, out error, apiKey);
            return new StripeResponse<T>(result, error);
        }

        public static StripeResponse<T> GetResponse<T>(this string url, string apiKey)
        {
            StripeError error;
            var result = Requestor.GetString(url, out error, apiKey);
            return new StripeResponse<T>(result, error);
        }

        public static StripeResponse<T> DeleteResponse<T>(this string url, string apiKey)
        {
            StripeError error;
            var result = Requestor.DeleteString(url, out error, apiKey);
            return new StripeResponse<T>(result, error);
        }

        public static StripeResponse<List<T>> GetResponseList<T>(this string url, string apiKey)
        {
            StripeError error;
            var response = Requestor.GetString(url, out error, apiKey);
            var result = Mapper<T>.MapCollectionFromJson(response);
            return new StripeResponse<List<T>>(result, error);
        }
    }
}