namespace Stripe
{
    /// <summary>
    /// Specifies which API mode to use.
    /// </summary>
    public enum ApiMode
    {
        /// <summary>
        /// Use the standard mode for V1 Stripe APIs.
        /// </summary>
        Standard,

        /// <summary>
        /// Use the preview mode with JSON request body.
        /// </summary>
        Preview,
    }
}