namespace Model
{
    public static class ExtensionInt
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
