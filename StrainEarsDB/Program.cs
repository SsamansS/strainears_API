using StrainEarsDB.Data;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrainEarsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StrainEarsContext context = new StrainEarsContext())
            {
                //User user1 = new User()
                //{
                //    UserName = "user1",
                //    Password = "pass1",
                //    Email = "email1",
                //    CreatedDate = new DateTime()
                //};
                //User userBef = context.Users.Find();
                //Playlist playlist1 = new Playlist()
                //{
                //    PlaylistName = "playlist1",
                //    UserId = context.Users..Find(x => x.Id == user1.Id)
                //};

                var users = context.Users.Where(x => x.Id == 2);
                foreach(User user in users)
                {
                    Console.WriteLine(user.UserName);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
