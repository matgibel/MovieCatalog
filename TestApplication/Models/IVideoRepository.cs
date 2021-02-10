using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetAllVideos();
        Video GetVideoById(int idVideo);
    }
}
