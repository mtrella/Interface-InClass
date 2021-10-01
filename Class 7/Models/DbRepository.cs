using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_7.Models
{
    public class DbRepository : IRepository
    {
        public void Add(Movie movie)
        {
            //open the database
            //insert to database
            //close database
        }

        public Movie Get(int id)
        {
            //open the database
            //select from database where id = id
            //close the database
        }

        public List<Movie> GetAll()
        {
            //open the database
            //select * from database
            //close the database
        }
    }
}