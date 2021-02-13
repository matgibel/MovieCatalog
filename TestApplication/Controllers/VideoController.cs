using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.ViewModels;


namespace TestApplication.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoRepository _videoRepository;
        private readonly ICategoryRepository _categoryRepository;
        public VideoController(IVideoRepository videoRepository, ICategoryRepository categoryRepository)
        {
            _videoRepository = videoRepository;
            _categoryRepository = categoryRepository;

        }

        public ViewResult List()
        {
            var videoListViewModel = new VideoListViewModel();
            videoListViewModel.Videos = _videoRepository.GetAllVideos();
            return View(videoListViewModel);
        }

        public IActionResult Details(int id)
        {
            var video = _videoRepository.GetVideoById(id);
            if(video == null)
            {
                return NotFound();
            }
            else
            {
                return View(video);
            }
        }

    }
}
