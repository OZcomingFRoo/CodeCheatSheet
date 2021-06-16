namespace CommonCSharpUtils.MethodExtension
{
    public static class NumberExtension
    {
        public static bool IsWhole(this double num)
        {
            return num % 1 == 0;
        }
        public static bool IsWhole(this decimal num)
        {
            return num % 1 == 0;
        }
        public static bool IsWhole(this float num)
        {
            return num % 1 == 0;
        }
        public static bool IsNatural(this float num)
        {
            return num > 0 && num % 1 == 0;
        }
        public static bool IsNatural(this double num)
        {
            return num > 0 && num % 1 == 0;
        }
        public static bool IsNatural(this decimal num)
        {
            return num > 0 && num % 1 == 0;
        }
        public static bool IsNatural(this int num)
        {
            return num > 0;
        }
        public static bool IsNatural(this short num)
        {
            return num > 0;
        }
        public static bool IsNatural(this long num)
        {
            return num > 0;
        }
    }
}
