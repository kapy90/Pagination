using System;
using System.Collections.Generic;
using System.Text;

namespace Pagination
{
    public class PageListException : Exception
    {
        public PageListException(string message)
            : base(message)
        {

        }
    }
}
