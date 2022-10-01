namespace Partial_Clases
{
    public class MyClass
    {

        #region Fields
        private int myInt;
        #endregion Fields


        #region Constructor
        public MyClass() { myInt = 99; }
        #endregion

        #region Properties
        public int MyInt
        {

            get { return myInt; }
            set { myInt = value; }
        }
        #endregion
        #region Methods
        public void DoSomething()
        {
            //Do something
        }
        #endregion


    }
}
