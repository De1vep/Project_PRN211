using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhuongDat.DAO
{
    internal class ArtistDAO
    {
        public Artist GetArtistByID(int Id)
        {
            Artist artist = new Artist();
            MusicStoreContext musicStoreContext = new MusicStoreContext();
            artist = musicStoreContext.Artists.ToList().Where(p => p.ArtistId == Id).FirstOrDefault();
            return artist;
        }
    }
}
