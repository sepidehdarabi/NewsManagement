using NewsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NewsManagement.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<News> news = new List<News>();
            news.Add(new News()
            {
                Image = "/Uploads/1.jpg",
                Id = "1",
                Title = "خبر اول",
                Subtitle = "زیرعنوان اول",
                Summary = "خلاصه خبرها 1",
                Body = "خبر خبر خبر خبر خبر خبر خبرخ",
                CategoryId=1,

            });
            news.Add(new News()
            {
                Image = "/Uploads/4.jpg",
                Id = "4",
                Title = "خبر چهارم",
                Subtitle = "زیرعنوان چهارم",
                Summary = "خلاصه خبرها 4",
                Body = "خبر خبر خبر خبر خبر خبر خبر4",
                CategoryId = 1,

            });
            news.Add(new News()
            {
                Image = "/Uploads/2.jpg",
                Id = "2",
                Title = "خبر دوم",
                Subtitle = "زیرعنوان دوم",
                Summary = "خلاصه خبرها 2",
                Body = "خبر خبر خبر خبر خبر خبر خبر2",
                CategoryId = 1,

            });
            news.Add(new News()
            {
                Image = "/Uploads/3.jpg",
                Id = "3",
                Title = "خبر سوم",
                Subtitle = "زیرعنوان سوم",
                Summary = "خلاصه خبرها 3",
                Body = "خبر خبر خبر خبر خبر خبر خبر3",
                CategoryId = 2,
            });
            var NewsFeature = news.Where(x => x.CategoryId == 1).ToList();
            ViewBag.NewsFeature = NewsFeature;
            return View(news);
        }

        public ActionResult ShowNews(string Id)
        {
            List<News> news = new List<News>();
            news.Add(new News()
            {
                Image = "/Uploads/1.jpg",
                Id = "1",
                Title = "خبر اول",
                Subtitle = "زیرعنوان اول",
                Summary = "خلاصه خبرها 1",
                Body = "خبر خبر خبر خبر خبر خبر خبرخ",

            });
            news.Add(new News()
            {
                Image = "/Uploads/4.jpg",
                Id = "4",
                Title = "خبر چهارم",
                Subtitle = "زیرعنوان چهارم",
                Summary = "خلاصه خبرها 4",
                Body = "خبر خبر خبر خبر خبر خبر خبر4",

            });
            news.Add(new News()
            {
                Image = "/Uploads/2.jpg",
                Id = "2",
                Title = "خبر دوم",
                Subtitle = "زیرعنوان دوم",
                Summary = "خلاصه خبرها 2",
                Body = "خبر خبر خبر خبر خبر خبر خبر2",

            });
            news.Add(new News()
            {
                Image = "/Uploads/3.jpg",
                Id = "3",
                Title = "خبر سوم",
                Subtitle = "زیرعنوان سوم",
                Summary = "خلاصه خبرها 3",
                Body = "خبر خبر خبر خبر خبر خبر خبر3",
            });
            News selectNews = news.SingleOrDefault(x=>x.Id == Id); 
            return View(selectNews);
        }  

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}