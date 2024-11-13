using BookReviewer.Core.Enums;

namespace BookReviewer.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public EGenre Genre { get; set; }
        public int YearOfPublication { get; set; }
        public int QuantityOfPages { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal AverageRating { get; set; }
        public byte CoverBook { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
