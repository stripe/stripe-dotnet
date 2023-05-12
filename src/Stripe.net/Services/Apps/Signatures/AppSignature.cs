namespace Stripe.Apps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Stripe.Infrastructure;

    public static class AppSignature
    {
        internal const int DefaultTimeTolerance = 300;

        internal static readonly UTF8Encoding SafeUTF8
            = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long? tolerance = DefaultTimeTolerance)
            => ValidateSignature(json, stripeSignatureHeader, secret, tolerance, DateTimeOffset.UtcNow.ToUnixTimeSeconds());

        public static void ValidateSignature(string json, string stripeSignatureHeader, string secret, long? tolerance, long utcNow)
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
                    "The webhook or app signature cannot be processed because the signature cannot be safely calculated.",
                    ex);
            }

            if (!IsSignaturePresent(signature, signatureItems["v1"]))
            {
                throw new StripeException(
                    "The expected signature was not found in the Stripe-Signature header. " +
                    "Make sure you're using the correct webhook secret (whsec_) or app secret (apsec_) and confirm the incoming request came from Stripe.");
            }

            if (tolerance != null)
            {
                var webhookUtc = Convert.ToInt64(signatureItems["t"].FirstOrDefault());
                if (Math.Abs(utcNow - webhookUtc) > tolerance)
                {
                    throw new StripeException(
                        "The webhook or app signature cannot be processed because the current timestamp is outside of the allowed tolerance.");
                }
            }
        }

        private static ILookup<string, string> ParseStripeSignature(string stripeSignatureHeader)
        {
            static (string Key, string Value) ParseItem(string item)
            {
                var parts = item.Trim().Split(new[] { '=' }, 2);
                return parts.Length != 2
                    ? throw new StripeException(
                        "The signature header format is unexpected.")
                    : ((string Key, string Value))(parts[0], parts[1]);
            }

            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => ParseItem(item))
                .ToLookup(item => item.Key, item => item.Value);
        }

        private static bool IsSignaturePresent(string signature, IEnumerable<string> signatures)
            => signatures.Any(key => StringUtils.SecureEquals(key, signature));

        private static string ComputeSignature(string secret, string timestamp, string payload)
        {
            var secretBytes = SafeUTF8.GetBytes(secret);
            var payloadBytes = SafeUTF8.GetBytes($"{timestamp}.{payload}");
            using var cryptographer = new HMACSHA256(secretBytes);
            var hash = cryptographer.ComputeHash(payloadBytes);
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
        }
    }
}
