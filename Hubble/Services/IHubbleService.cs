using Hubble.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubble.Services
{
    interface IHubbleService
    {
        Task<IEnumerable<HubbleImage>> GetAllImages();
        Task<HubbleImage> GetVideo(int Id);

    }
}
