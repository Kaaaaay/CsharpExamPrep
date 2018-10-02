using System;
using System.Collections;

namespace PassLeader
{
    public class LoanCollection : IEnumerable
    {

        private readonly Loan[] _loanCollection;


        public LoanCollection(Loan[] loanArray)
        {
            for (int i = 0; i < loanArray.Length; i++)
            {
                _loanCollection[i] = loanArray[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _loanCollection.GetEnumerator();
        }
    }
}
