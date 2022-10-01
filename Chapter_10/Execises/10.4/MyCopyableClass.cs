namespace _10._4
{
    public class MyCopyableClass
    {
        public int SimpleProperty
        {
            get => default;
            set
            {
            }
        }

        public object GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}