using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Stripe.Infrastructure;

namespace Stripe
{
    public static class StripeEventUtility
    {
        internal static readonly UTF8Encoding SafeUTF8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

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
            return ConstructEvent(json, stripeSignatureHeader, secret, tolerance, DateTime.UtcNow.ConvertDateTimeToEpoch());
        }

        public static StripeEvent ConstructEvent(string json, string stripeSignatureHeader, string secret, int tolerance, long utcNow)
        {
            var signatureItems = parseStripeSignature(stripeSignatureHeader);
            var signature = string.Empty;

            try
            {
               signature = computeSignature(secret, signatureItems["t"].FirstOrDefault(), json);
            }
            catch (EncoderFallbackException ex)
            {
               throw new StripeException("The webhook cannot be processed because the signature cannot be safely calculated.", ex);
            }

            if (!isSignaturePresent(signature, signatureItems["v1"]))
                throw new StripeException("The signature for the webhook is not present in the Stripe-Signature header.");

            var webhookUtc = Convert.ToInt32(signatureItems["t"].FirstOrDefault());

            if (utcNow - webhookUtc > tolerance)
                throw new StripeException("The webhook cannot be processed because the current timestamp is above the allowed tolerance.");

            return Mapper<StripeEvent>.MapFromJson(json);
        }

        private static ILookup<string, string> parseStripeSignature(string stripeSignatureHeader)
        {
            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => item.Trim().Split('='))
                .ToLookup(item => item[0], item => item[1]);
        }

        private static bool isSignaturePresent(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => secureCompare(key, signature));
        }

        private static string computeSignature(string secret, string timestamp, string payload)
        {
            var secretBytes = SafeUTF8.GetBytes(secret);
            var payloadBytes = SafeUTF8.GetBytes($"{timestamp}.{payload}");

            using (var cryptographer = new HMACSHA256(secretBytes))
            {
                var hash = cryptographer.ComputeHash(payloadBytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }      
        }

        private static bool secureCompare(string a, string b)
        {
            if (a.Length != b.Length) return false;

            var result = 0;

            for (var i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }
    }
}
