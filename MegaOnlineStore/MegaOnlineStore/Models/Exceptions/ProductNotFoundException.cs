using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaOnlineStore.Models.Exceptions
{
    public class ProductNotFoundException : ApplicationException
    {
        public ProductNotFoundException(string msg=null):base(msg)
        {

        }
    }
}