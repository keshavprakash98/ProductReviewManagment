using System;
using System.Collections.Generic;
using System.Text;

namespace ProducrReview
{
    class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }

        internal static string Field<T>(string v)
        {
            throw new NotImplementedException();
        }
    }
}
