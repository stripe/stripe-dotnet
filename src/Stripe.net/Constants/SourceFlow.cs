namespace Stripe
{
    public static class SourceFlow
    {
        public static string Redirect => "redirect";

        public static string Receiver => "receiver";

        public static string CodeVerification => "code_verification";

        public static string None => "none";
    }
}
