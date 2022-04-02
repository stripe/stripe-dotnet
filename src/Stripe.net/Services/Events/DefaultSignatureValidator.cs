namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    using Stripe.Infrastructure;

    /// <summary>
    ///  Use to validate a payload against the signing key.
    /// </summary>
    public class DefaultSignatureValidator : ISignatureValidator
    {
        private static readonly UTF8Encoding SafeUTF8
           = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        private readonly string secret;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSignatureValidator"/> class.
        /// </summary>
        /// <param name="secret">secret to use for validation.</param>
        public DefaultSignatureValidator(string secret)
        {
            this.secret = secret;
        }

        /// <summary>
        /// Validate signature and timestamp.
        /// </summary>
        /// <param name="json">payload.</param>
        /// <param name="stripeSignatureHeader">header found in http headers.</param>
        /// <param name="tolerance">timestamp margin, default = 300.</param>
        /// <param name="utcNow">current time.</param>
        /// <exception cref="StripeException">reason for failure.</exception>
        public void Validate(string json, string stripeSignatureHeader, long tolerance, long utcNow)
        {
            var signatureItems = ParseStripeSignature(stripeSignatureHeader);

            string signature;
            try
            {
                signature = ComputeSignature(this.secret, signatureItems["t"].FirstOrDefault(), json);
            }
            catch (EncoderFallbackException ex)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the signature cannot be safely calculated.",
                    ex);
            }

            var webhookUtc = Convert.ToInt64(signatureItems["t"].FirstOrDefault());

            if (Math.Abs(utcNow - webhookUtc) > tolerance)
            {
                throw new StripeException(
                    "The webhook cannot be processed because the current timestamp is outside of the allowed tolerance.");
            }

            if (!IsSignaturePresent(signature, signatureItems["v1"]))
            {
                throw new StripeException(
                    "The signature for the webhook is not present in the Stripe-Signature header.");
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

        internal static string ComputeSignature(string secret, string timestamp, string payload)
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