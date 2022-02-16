using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AlbumManager : IAlbumService
    {
        protected IAlbumDal _albumDal;
        public void Add(Album album)
        {
            throw new NotImplementedException();
        }

        public void Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public Album GetByAlbumId(int albumId)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Album> GetListByArtistName(string artistName)
        {
            throw new NotImplementedException();
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
