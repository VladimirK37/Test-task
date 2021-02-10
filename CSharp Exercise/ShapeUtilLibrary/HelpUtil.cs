namespace ShapeUtilLibrary
{
    public static class HelpUtil
    {
        public static void SwapVariables(ref double var1, ref double var2)
        {
            double buff = var1;
            var1 = var2;
            var2 = buff;
        }
    }
}
