//using Microsoft.AspNetCore.Hosting.Internal;
//using Microsoft.AspNetCore.Http;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace techyprakash.Models
//{
//    public class PostManager
//    {
//        // Define the members
//        private static string PostsFile = Path.Combine.MapPath("~/App_Data/Posts.json");
//        (HttpRuntime.AppDomainAppPath, "email/teste.html");
//        private static List<BlogPostModel> posts = new List<BlogPostModel>();

//        // The CRUD functions
//        public static void Create(string postJson)
//        {
//            var obj = JsonConvert.DeserializeObject<BlogPostModel>(postJson);

//            if (posts.Count > 0)
//            {
//                posts = (from post in posts
//                         orderby post.CreateTime
//                         select post).ToList();
//                obj.ID = posts.Last().ID + 1;
//            }
//            else
//            {
//                obj.ID = 1;
//            }
//        }

//        posts.Add(obj);
//          save();
//    }
//}
