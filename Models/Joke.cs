namespace JokesWebApp.Models
{
    public class Joke
    {
        //property (prop) - object of a class. 
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //Contructor (ctor) - (function) 
        public Joke()
        {
            //leave empty for now. 
        }
    }
}
