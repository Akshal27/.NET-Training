using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LoginApplication.Models
{
    public class LoginDBContext:DbContext
    {
        public DbSet<Login> Login { get; set; }
    }
}