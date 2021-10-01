namespace Class_7.Models
{
    public class FileRepository : IRepository
    {
        public void Add(Movie movie)
        {
            //Open the file
            //write the movie to the file
            //close the file
        }

        public Movie Get(int id)
        {
            //open the file
            //retrieve the record
            //return the record

            return new Movie();
        }

        public System.Collections.Generic.List<Movie> GetAll()
        {
            //open the file
            //retrieve ALL records
            //return the records

            return new List<Movie> 
        }
    }
}
    