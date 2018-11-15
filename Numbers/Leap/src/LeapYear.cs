namespace LeapProject
{
    public static class LeapYear
    {
        public static bool IsLeapYear(int year)
            => (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }
}
