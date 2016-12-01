using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_9_object_model
{
    public class CurrentAccount : Account, IFreeAccesseble
    {
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
