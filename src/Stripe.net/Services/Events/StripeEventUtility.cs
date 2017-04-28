using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Stripe
{
    public static class StripeEventUtility
    {
        public static StripeEvent ParseEvent(string json)
        {
            return Mapper<StripeEvent>.MapFromJson(json);
        }
        
        public static T ParseEventDataItem<T>(dynamic dataItem)
        {
            return JsonConvert.DeserializeObject<T>((dataItem as JObject).ToString());
        }

        public static StripeEvent ConstructEvent(string json, string stripeSignatureHeader, string secret, int tolerance = 300)
        {
            var signatureItems = parseStripeSignature(stripeSignatureHeader);

            var ciphertext = Encipher(secret, signatureItems["t"].FirstOrDefault(), json);

            // make sure the ciphertext exists as a 'v1' key in signatureItems
            // throw an exception if not

            // make sure the timestamp is not above the tolerance (current utc - timestamp <= tolerance)
            // throw an exception if not

            return Mapper<StripeEvent>.MapFromJson(json);
        }

        private static ILookup<string, string> parseStripeSignature(string stripeSignatureHeader)
        {
            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => item.Trim().Split('='))
                .ToLookup(item => item[0], item => item[1]);
        }

        private static string Encipher(string secret, string timestamp, string payload)
        {
            var secretBytes = Encoding.UTF8.GetBytes(secret);
            var payloadBytes = Encoding.UTF8.GetBytes($"{timestamp}.{payload}");

            var cryptographer = new HMACSHA256(secretBytes);
            var hash = cryptographer.ComputeHash(payloadBytes);

            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}
