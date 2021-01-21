using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryList
{
    class MyDictionaryList<Name, UserNumber, UserPhoneNumber>
    {
        Name[] items1;
        UserNumber[] items2;
        UserPhoneNumber[] items3;
        //constructor
        public MyDictionaryList()
        {
            items1 = new Name[0];
            items2 = new UserNumber[0];
            items3 = new UserPhoneNumber[0];
        }

        public void Add(Name UserName, UserNumber UserNumber, UserPhoneNumber UserPhoneNumber)
        {
            Name[] tempArray1 = items1;
            UserNumber[] tempArray2 = items2;
            UserPhoneNumber[] tempArray3 = items3;
            items1 = new Name[items1.Length + 1];
            items2 = new UserNumber[items2.Length + 1];
            items3 = new UserPhoneNumber[items3.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            for (int i = 0; i < tempArray3.Length; i++)
            {
                items3[i] = tempArray3[i];
            }

            items1[items1.Length - 1] = UserName;
            items2[items2.Length - 1] = UserNumber;
            items3[items3.Length - 1] = UserPhoneNumber;
        }

        public Name[] Items1
        {
            get { return items1; }
        }

        public UserNumber[] Items2
        {
            get { return items2; }
        }

        public UserPhoneNumber[] Items3
        {
            get { return items3; }
        }
    }
}
