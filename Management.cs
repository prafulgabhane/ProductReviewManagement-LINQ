
namespace ProductReviewManagement
{
    public class Management
    {
        public static void TopThreeByRating(List<ProductReview> productReview)
        {

            var Record = from productreview in productReview
                         where (productreview.ProductID == 1 || productreview.ProductID == 4 || productreview.ProductID == 9)
                         && productreview.Rating > 3
                         select productreview;

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductID, element.UserID, element.Rating, element.Review, element.isLike);
            }
        }
    }
}
