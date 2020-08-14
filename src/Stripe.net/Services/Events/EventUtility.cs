namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Stripe.Infrastructure;

    public static class EventUtility
    {
        internal static readonly UTF8Encoding SafeUTF8
            = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        private const int DefaultTimeTolerance = 300;

        public static Event ParseEvent(string json, bool throwOnApiVersionMismatch = true)
        {
            var stripeEvent = JsonUtils.DeserializeObject<Event>(
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

        public static Event ConstructEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance = DefaultTimeTolerance,
            bool throwOnApiVersionMismatch = true)
        {
            return ConstructEvent(
                json,
                stripeSignatureHeader,
                secret,
                tolerance,
                DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                throwOnApiVersionMismatch);
        }

        public static Event ConstructEvent(
            string json,
            string stripeSignatureHeader,
            string secret,
            long tolerance,
            long utcNow,
            bool throwOnApiVersionMismatch = true)
        {
            ValidateSignature(json, stripeSignatureHeader, secret, tolerance, utcNow);
            return ParseEvent(json, throwOnApiVersionMismatch);
        }

        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long tolerance = DefaultTimeTolerance)
        {
            ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        }

        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long tolerance, long utcNow)
        {
            var signatureItems = ParseStripeSignature(stripeSignatureHeader);
            var signature = string.Empty;

            try
            {
                signature = ComputeSignature(secret, signatureItems["t"].FirstOrDefault(), json);
            }
            catch (EncoderFallbackException ex)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the signature cannot be safely calculated.",
                    ex);
            }

            if (!IsSignaturePresent(signature, signatureItems["v1"]))
            {
                throw new StripeException(
                    "The signature for the webhook is not present in the Stripe-Signature header.");
            }

            var webhookUtc = Convert.ToInt32(signatureItems["t"].FirstOrDefault());

            if (Math.Abs(utcNow - webhookUtc) > tolerance)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.");
            }
        }

        private static ILookup<string, string> ParseStripeSignature(string stripeSignatureHeader)
        {
            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => item.Trim().Split(new[] { '=' }, 2))
                .ToLookup(item => item[0], item => item[1]);
        }

        private static bool IsSignaturePresent(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => StringUtils.SecureEquals(key, signature));
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
    }
}
