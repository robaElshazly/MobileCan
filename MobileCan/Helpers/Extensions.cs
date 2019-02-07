using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MobileCan.Helpers
{
    public static class Extesnions
    {
        public static string ToStars(this double rating)
        {
            StringBuilder result = new StringBuilder();
            //★★★★☆
            for(int i=0; i< rating;i++)
                result.Append("★");
            for (int i = 0; i < 5-rating; i++)
                result.Append("☆");
            return result.ToString();

        }
    }
}