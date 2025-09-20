namespace DVLD_BusinessLayer.Events
{
    public static  class PersonEvents
    {
        public delegate void PersonChangedHandler();
        public static  event PersonChangedHandler PersonChanged;

        public static void OnPersonChanged()
        {
            PersonChanged?.Invoke();
        }
    }
}
