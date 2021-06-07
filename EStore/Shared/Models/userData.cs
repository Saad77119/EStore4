using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Shared.Models
{
    public class userData
    {
        List<User> all_users = new List<User>()
        {
            new User {Id = 1 , Fname="Saad ",Lname="Raza",Email="Saadas@sfasd.csc",Password="123123"},
             new User {Id =2 , Fname="Saad ",Lname="Raza",Email="Saadas@sfasd.csc",Password="123123"},
              new User {Id = 3 , Fname="Saad ",Lname="Raza",Email="Saadas@sfasd.csc",Password="123123"}
        };
        public List<User> get_all_users()
        {
            return all_users;
        }
    }
}
