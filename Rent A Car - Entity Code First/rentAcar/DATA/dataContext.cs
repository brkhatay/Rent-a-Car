using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentAcar.DATA 
{
    class dataContext : DbContext
    {
        
        public dataContext()
        {
            Database.Connection.ConnectionString = "Server=************; Database=RentAcar; uid=*****; pwd=*****";
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<Hire> Hires { get; set; }



    }

}
