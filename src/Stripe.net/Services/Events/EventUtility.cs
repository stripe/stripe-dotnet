namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using Stripe.Infrastructure;

    /// <summary>
    /// This class contains utility methods to process event objects in Stripe's webhooks.
    /// </summary>
    public static class EventUtility
    {
        internal static readonly UTF8Encoding SafeUTF8
            = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public const int DefaultTimeTolerance = 300;

        public static bool IsCompatibleApiVersion(string sdkApiVersion, string eventApiVersion)
        {
            // If the event api version is from before we started adding
            // a release train, there's no way its compatible with this
            // version
            if (!eventApiVersion.Contains("."))
            {
                return false;
            }

            // versions are yyyy-MM-dd.train
            var currentReleaseTrain = sdkApiVersion.Split('.')[1];

            // Beta SDKs should match event versions exactly when deserializing
            if (currentReleaseTrain == "preview")
            {
                return eventApiVersion == sdkApiVersion;
            }

            var eventReleaseTrain = eventApiVersion.Split('.')[1];
            return eventReleaseTrain == currentReleaseTrain;
        }

        public static bool IsCompatibleApiVersion(string eventApiVersion)
        {
            return IsCompatibleApiVersion(ApiVersion.Current, eventApiVersion);
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
                    "The expected signature was not found in the Stripe-Signature header. " +
                    "Make sure you're using the correct webhook secret (whsec_) and confirm the incoming request came from Stripe.");
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
            (string Key, string Value) ParseItem(string item)
            {
                string[] parts = item.Trim().Split(new[] { '=' }, 2);
                if (parts.Length != 2)
                {
                    throw new StripeException(
                        "The signature header format is unexpected.");
                }

                return (parts[0], parts[1]);
            }

            return stripeSignatureHeader.Trim()
                .Split(',')
                .Select(item => ParseItem(item))
                .ToLookup(item => item.Key, item => item.Value);
        }

        private static bool IsSignaturePresent(string signature, IEnumerable<string> signatures)
        {
            return signatures.Any(key => StringUtils.SecureEquals(key, signature));
        }

        /// <summary>
        /// Computes the signature for a given payload.
        /// </summary>
        /// <param name="secret">The webhook endpoint's signing secret.</param>
        /// <param name="timestamp">The timestamp of the payload.</param>
        /// <param name="payload">The payload to compute the signature for.</param>
        /// <returns>The computed signature.</returns>
        public static string ComputeSignature(string secret, string timestamp, string payload)
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
