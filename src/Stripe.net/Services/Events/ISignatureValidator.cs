namespace Stripe
{
    /// <summary>
    ///  Encapsulate signature validation.
    /// </summary>
    public interface ISignatureValidator
    {
        /// <summary>
        /// Use to validate a payload against the signing key.
        /// </summary>
        /// <param name="json">payload.</param>
        /// <param name="stripeSignatureHeader">header found in http headers.</param>
        /// <param name="tolerance">timestamp margin, default = 300.</param>
        /// <param name="utcNow">current time.</param>
        /// <exception cref="StripeException">reason for failure.</exception>
        void Validate(string json, string stripeSignatureHeader, long tolerance, long utcNow);
    }
}