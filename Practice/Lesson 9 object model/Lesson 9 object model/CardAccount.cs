using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_9_object_model
{
    public class CardAccount : Account, IChargeble, IFreeAccesseble
    {
        private int interestRate;

        public void SetPercentage()
        {
            throw new NotImplementedException();
        }

        public void AccruedInterest()
        {
            throw new NotImplementedException();
        }

        public void PutMoney()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
