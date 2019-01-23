namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe.Infrastructure;

    public static class EventUtility
    {
        internal static readonly UTF8Encoding SafeUTF8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public static Event ParseEvent(string json, bool throwOnApiVersionMismatch = true)
        {
            var stripeEvent = JsonConvert.DeserializeObject<Event>(
                json,
                StripeConfiguration.SerializerSettings);

            if (throwOnApiVersionMismatch &&
                stripeEvent.ApiVersion != StripeConfiguration.ApiVersion)
            {
                throw new StripeException(
                    $"Received event with API version {stripeEvent.ApiVersion}, but Stripe.net "
                    + $"{StripeConfiguration.StripeNetVersion} expects API version "
                    + $"{StripeConfiguration.ApiVersion}. We recommend that you create a "
                    + "WebhookEndpoint with this API version. Otherwise, you can disable this "
                    + "exception by passing `throwOnApiVersionMismatch: false` to "
                    + "`Stripe.EventUtility.ParseEvent` or `Stripe.EventUtility.ConstructEvent`, "
                    + "but be wary that objects may be incorrectly deserialized.");
            }

            return stripeEvent;
        }

        public static T ParseEventDataItem<T>(dynamic dataItem)
        {
            return JsonConvert.DeserializeObject<T>((dataItem as JObject).ToString());
        }

        public static Event ConstructEvent(string json, string stripeSignatureHeader, string secret, long tolerance = 300, bool throwOnApiVersionMismatch = true)
        {
            return ConstructEvent(json, stripeSignatureHeader, secret, tolerance, DateTime.UtcNow.ConvertDateTimeToEpoch(), throwOnApiVersionMismatch);
        }

        public static Event ConstructEvent(string json, string stripeSignatureHeader, string secret, long tolerance, long utcNow, bool throwOnApiVersionMismatch = true)
        {
            var signatureItems = ParseStripeSignature(stripeSignatureHeader);
            var signature = string.Empty;

            try
            {
               signature = ComputeSignature(secret, signatureItems["t"].FirstOrDefault(), json);
            }
            catch (EncoderFallbackException ex)
            {
               throw new StripeException("The webhook cannot be processed because the signature cannot be safely calculated.", ex);
            }

            if (!IsSignaturePresent(signature, signatureItems["v1"]))
            {
                throw new StripeException("The signature for the webhook is not present in the Stripe-Signature header.");
            }

            var webhookUtc = Convert.ToInt32(signatureItems["t"].FirstOrDefault());

            if (Math.Abs(utcNow - webhookUtc) > tolerance)
            {
                throw new StripeException("The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.");
            }

            return ParseEvent(json, throwOnApiVersionMismatch);
        }

        private static ILookup<string, string> ParseStripeSignature(string stripeSignatureHeader)
        {
            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => item.Trim().Split('='))
                .ToLookup(item => item[0], item => item[1]);
        }

        private static bool IsSignaturePresent(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => SecureCompare(key, signature));
        }

        private static string ComputeSignature(string secret, string timestamp, string payload)
        {
            var secretBytes = SafeUTF8.GetBytes(secret);
            var payloadBytes = SafeUTF8.GetBytes($"{timestamp}.{payload}");

            using (var cryptographer = new HMACSHA256(secretBytes))
            {
                var hash = cryptographer.ComputeHash(payloadBytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        private static bool SecureCompare(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var result = 0;

            for (var i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }
    }
}
