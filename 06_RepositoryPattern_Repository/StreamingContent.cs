using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        RomCom,
        SciFi,
        Documentry,
        Drama,
        Action
    }
    //Plain Old C# Object -- POCO
    public class StreamingContent
    {
        public string Title { get; set; }       //prop tab tab will give a set up for creating a field
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly {get; set;} 
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { } // two contruct one will be and over load, one will be empty 

        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)   // ctor tab tab new contructor base on the named content ex;"Streaming Content"
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;

        }
    }
}
