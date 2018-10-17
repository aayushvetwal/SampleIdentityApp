using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMongo.Models
{
    public class User : IUser<int>
    {
        public int Id => ()
    
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}