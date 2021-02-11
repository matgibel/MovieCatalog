using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.ViewModels;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVideoRepository _videoRepository;

        public HomeController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;

        }
        public IActionResult Index()
        {
            var listVideo = new VideoListViewModel();
            listVideo.Videos = _videoRepository.GetAllVideos().Take(3);
            return View(listVideo);
        }
    }
}
