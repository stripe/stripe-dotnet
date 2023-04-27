namespace Stripe.Tax
{
    public class RegistrationExpiresAt : StringEnum
    {
        /// <summary>
        /// Indicates that registration expires now.
        ///</summary>
        public static readonly RegistrationExpiresAt Now
            = new RegistrationExpiresAt("now");

        private RegistrationExpiresAt(string value)
            : base(value)
        {
        }
    }
}
