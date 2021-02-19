using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class VideoRepository: IVideoRepository
    {
        private readonly AppDbContext _appDbContext;
        public VideoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Video> GetAllVideos()
        {

            return _appDbContext.Videos.Include(c => c.Category);
        }

        public Video GetVideoById(int idVideo)
        {
            return _appDbContext.Videos.FirstOrDefault(v => v.VideoId == idVideo);
        }
    }
}
