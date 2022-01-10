using System;
using System.Collections.Generic;

namespace ProducrReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to product review management using LINQ\n");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=2,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=4,UserId=4,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=5,UserId=5,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=6,UserId=6,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=7,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=8,UserId=8,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=9,UserId=9,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=10,UserId=10,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=11,UserId=11,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=12,UserId=12,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=13,UserId=13,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=14,UserId=14,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=15,UserId=15,Rating=2,Review="Poor",isLike=true},
                new ProductReview(){ProductId=16,UserId=16,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=17,UserId=17,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=18,UserId=18,Rating=2,Review="Poor",isLike=true},
                new ProductReview(){ProductId=19,UserId=19,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=20,UserId=20,Rating=5,Review="Excellent",isLike=true}
            };
            Management management = new Management();
            //UC1
            //management.TopRecords(productReviewList);
            //UC3
            //management.SelectRecords(productReviewList);
            //UC4
            //management.RetriveRecords(productReviewList);
            //UC5
            //management.CustomRetrive(productReviewList);
            //Uc6
            //management.SkipRecords(productReviewList);
            //UC8

            //UC9
            management.AvgRecords(productReviewList);
        }
    }
}
