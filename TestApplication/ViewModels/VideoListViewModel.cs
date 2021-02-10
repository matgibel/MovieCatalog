using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.ViewModels
{
    public class VideoListViewModel
    {
        public IEnumerable<Video> Videos { get; set; }
    }
}
