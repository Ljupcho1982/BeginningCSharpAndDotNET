﻿using System;

namespace CH10EX01
{
    public class MyClass
    {

        public readonly string Name;

        private int intVal;
        public int Val
        {

            get { return intVal; }
            set
            {

                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigened a value between 0  and 10."));

            }
        }

        public override string ToString() => "Name: " + Name + "\nVal: " + Val;
        private MyClass() : this("Default Name") { }

        public MyClass(string newName)
        {

            Name = newName;
            intVal = 0;
        }

        private int myDoubleInt = 5;
        public int myDoubleIntProp => (myDoubleInt + 2);

    }
}
