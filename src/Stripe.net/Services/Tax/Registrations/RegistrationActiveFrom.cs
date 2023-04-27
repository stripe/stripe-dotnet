namespace Stripe.Tax
{
    public class RegistrationActiveFrom : StringEnum
    {
        /// <summary>
        /// Indicates that registration becomes active now.
        ///</summary>
        public static readonly RegistrationActiveFrom Now
            = new RegistrationActiveFrom("now");

        private RegistrationActiveFrom(string value)
            : base(value)
        {
        }
    }
}
