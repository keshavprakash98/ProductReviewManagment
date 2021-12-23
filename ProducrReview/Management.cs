using System;
using System.Collections.Generic;
using System.Text;

namespace ProducrReview
{
    class Management
    {
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReview in listProductReview orderby ProductReview.Rating descending select ProductReview).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId + "-" + "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review + "-" + "isLike" + list.isLike);
            }
        }
        public void SelectRecords(List<ProductReview> listproductReview)
        {
            var recordedData = from ProductReviews in listproductReview where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating >= 3 select ProductReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId + "-" + "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review + "-" + "isLike" + list.isLike);
            }
        }
        public void RetriveRecords(List<ProductReview> listproductReview)
        {
            var recordedData = listproductReview.GroupBy(A => A.ProductId).Select(A => new { ProductId = A.Key, Count = A.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "_____" + list.Count);
            }
        }

        public void CustomRetrive(List<ProductReview> listproductReview)
        {
            var recordedData = from A in listproductReview orderby A.ProductId, A.Review select new { ProductId = A.ProductId, Review = A.Review };

            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "_____" + list.Review);
            }

        }
        public void SkipRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReviews in listProductReview where (ProductReviews.ProductId > 5) select ProductReviews);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId + "-" + "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review);
            }
        }

        DataTable dataTable = new DataTable();
        public void ProductReviewDataTale(List<ProductReview> listproductReview)
        {
            var recordedData = from ProductReviews in listproductReview select ProductReviews;
            dataTable.Columns.Add("ProductId").DataType = typeof(Int32);
            dataTable.Columns.Add("UserId").DataType = typeof(Int32);
            dataTable.Columns.Add("Rating").DataType = typeof(int);
            dataTable.Columns.Add("Review");
            dataTable.Columns.Add("isLike").DataType = typeof(bool);
            foreach (var product in listproductReview)
            {
                dataTable.Rows.Add(product.ProductId, product.UserId, product.Rating, product.Review, product.isLike);
            }
            var productTable = from ProductReview in dataTable.AsEnumerable() select ProductReview;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserID") + " " + product.Field<int>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("isLike"));
            }
        }
        public void RetriveRecordsFromDataTable()
        {
            var productTable = from ProductReview in dataTable.AsEnumerable() where ProductReview.Field<bool>("IsLike").Equals(true) select ProductReview;
            foreach (DataRow product in productTable)
            {
                Console.WriteLine(product.Field<int>("ProductId") + " " + product.Field<int>("UserID") + " " + product.Field<int>("Rating") + " " + product.Field<string>("Review") + " " + product.Field<bool>("isLike"));
            }
        }
        public void AvgRecords(List<ProductReview> listproductReview)
        {
            var recordedData = listproductReview.GroupBy(A => A.ProductId).Select(A => new { ProductId = A.Key, AverageRating = A.Average(A => A.Rating) });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "_____" + list.AverageRating);
            }
        }
    }
}
