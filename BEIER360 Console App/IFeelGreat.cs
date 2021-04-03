using System;
using System.Collections.Generic;
using System.Text;

namespace BEIER360_Console_App
{
    class IFeelGreat
    {
        private int NumberOfUsers; //private variable users cannot gain access to directly
        private int MaleUsers;
        private int FemaleUsers;
        public IFeelGreat(int TotalUsers, int MaleUsers, int FemaleUsers)//constructor for IFeelGreat class to set:
        {
            this.NumberOfUsers = TotalUsers; //-to set total user
            this.MaleUsers = MaleUsers; //-male users
            this.FemaleUsers = FemaleUsers;//and female users
        }

        //getters and setters for the total users, male and female users
        public void SetTotalUsers(int value)
        {
            this.NumberOfUsers = value;
        }
        public int GetTotalUsers()
        {
            return this.NumberOfUsers;
        }
        public void SetFemaleUsers(int value)
        {
            this.FemaleUsers = value;
        }
        public int GetFemaleUsers()
        {
            return this.FemaleUsers;
        }
        public void SetMaleUsers(int value)
        {
            this.MaleUsers = value;
        }
        public int GetMaleUsers()
        {
            return this.MaleUsers;
        }

        //@unused method
        public User[] GetUsers()
        {
            User[] Users = new User[NumberOfUsers];

            for (int i = 0; i < NumberOfUsers; i++)
            {
                Users[i] = new User(i, GetUserGender());
            }

            return Users;
        }

        public User GetUser()
        {
            int rand;
            Random random = new Random();
            rand = random.Next();

            User user = new User(rand, GetUserGender());
            return user;
        }
        /*method to assign gender based on modulus
         * If random number is even then assign this user as female, else assign this user as a male
         */
        public Gender GetUserGender()
        {
            int randomNumber;

            if (MaleUsers + FemaleUsers != NumberOfUsers)
            {
                Console.WriteLine("Conversion not possible");
            }

            if (MaleUsers != 0 && FemaleUsers != 0)
            {
                Random random = new Random();
                randomNumber = random.Next();

                if (randomNumber % 2 == 0)
                {
                    FemaleUsers--;
                    NumberOfUsers--;
                    return Gender.Female;
                }
                else
                    MaleUsers--;
                    NumberOfUsers--;
                    return Gender.Male;
            }

            if (MaleUsers != 0 && FemaleUsers == 0)
            {
                MaleUsers--;
                NumberOfUsers--;
                return Gender.Male;
            }else
                FemaleUsers--;
                NumberOfUsers--;
                return Gender.Female;
            
        }

    }
}
