using System;
using System.Collections.Generic;
using System.Text;

namespace BEIER360_Console_App
{        
    public enum Gender{ Male, Female }
    public class User
    {
        private int id;
        private Gender gender;

        public User(int ID, Gender gender)
        {
            this.id = ID;
            this.gender = gender;
        }

        public void SetID(int value)
        {
            this.id = value;
        }

        public int GetID()
        {
            return this.id;
        }

        public void SetGender(Gender value)
        {
            this.gender = value;
        }

        public Gender GetGender()
        {
            return gender;
        }
    }
}
