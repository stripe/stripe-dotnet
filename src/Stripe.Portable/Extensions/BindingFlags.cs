using System;

namespace Stripe
{

    [Flags]
    public enum BindingFlags
    {
        None = 0,
        Instance = 1,
        Public = 2,
        Static = 4,
        FlattenHierarchy = 8,
        NonPublic = 32,
        SetProperty = 8192
    }

}
