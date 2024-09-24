namespace Stripe
{
    internal class ApiModeUtils
    {
        internal static ApiMode GetApiMode(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return ApiMode.V1;
            }

            return path.StartsWith("/v2") ? ApiMode.V2 : ApiMode.V1;
        }
    }
}
