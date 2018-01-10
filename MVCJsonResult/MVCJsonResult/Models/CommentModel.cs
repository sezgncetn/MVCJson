using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsonResult.Models
{
    public class CommentModel
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime PostDate { get; set; }
        public UserModel User { get; set; }
    }
}