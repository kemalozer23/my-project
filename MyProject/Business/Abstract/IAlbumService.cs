using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAlbumService
    {
        Album GetByAlbumId(int albumId);
        List<Album> GetList();
        List<Album> GetListByArtistName(string artistName);
        void Add(Album album);
        void Update(Album album);
        void Delete(Album album);
    }
}
