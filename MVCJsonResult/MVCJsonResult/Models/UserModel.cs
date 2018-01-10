using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCJsonResult.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<CommentModel>Comments { get; set; }
    }
}