namespace Execises
{
    public abstract class MyClass
    {
        protected string myString;

        public string ContainedString
        {

            set
            {
                myString = value;
            }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }
}