using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_7.Models
{
    public interface IRepository
    {
        void Add(Movie movie);
        Movie Get(int id);
        List<Movie>  GetAll();
    }
}
    