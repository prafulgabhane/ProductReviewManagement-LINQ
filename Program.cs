using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINQ Product Review Management Program.");
            
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", isLike = true},
            new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 3, UserId = 2, Rating = 5, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 4, UserId = 2, Rating = 4, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 5, UserId = 3, Rating = 2, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 6, UserId = 4, Rating = 1, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 11, UserId = 3, Rating = 4, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 7, UserId = 10, Rating = 2, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 8, UserId = 10, Rating = 4, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 10, UserId = 7, Rating = 5, Review = "Good", isLike = true},
            new ProductReview() { ProductId = 12, UserId = 9, Rating = 4, Review = "Bad", isLike = false },
            new ProductReview() { ProductId = 13, UserId = 2, Rating = 5, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 14, UserId = 5, Rating = 4, Review = "Good", isLike = true },
            new ProductReview() { ProductId = 15, UserId = 3, Rating = 2, Review = "Bad", isLike = false },

            };
                        Management.TopThreeByRating(list);           
        }
    }
}
