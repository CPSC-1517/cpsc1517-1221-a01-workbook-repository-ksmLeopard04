using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindSystem.DAL
{
    internal class WestWindContext : DbContext
    {
        public WestWindContext(DbContextOptions<WestWindContext> options) : base(options)
        {

        }
    }
}
