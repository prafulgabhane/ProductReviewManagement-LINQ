
namespace ProductReviewManagement
{
    public class Management
    {
        public static void TopThreeByRating(List<ProductReview> productReview)
        {

            var Record = (from productreview in productReview orderby productreview.Rating descending select productreview).Take(3);

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductID, element.UserID, element.Rating, element.Review, element.isLike);
            }
        }
    }
}
