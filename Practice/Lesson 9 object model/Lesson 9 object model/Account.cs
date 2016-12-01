using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_9_object_model
{
    public class Account
    {
        protected int balance;
        protected int owner;

        public Account(string owner, string balance)
        {
            throw new System.NotImplementedException();
        }

        public int CurrentState()
        {
            throw new System.NotImplementedException();
        }

        public string GetOwner()
        {
            throw new System.NotImplementedException();
        }

        public int CloseAccount()
        {
            throw new System.NotImplementedException();
        }
    }
}
