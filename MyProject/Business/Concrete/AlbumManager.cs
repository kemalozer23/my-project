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
        // Dependency injection: used for not to be dependent to only one ORM
        protected IAlbumDal _albumDal;
        public AlbumManager(IAlbumDal albumDal)
        {
            _albumDal = albumDal;
        }

        // Add an album to the database
        public void Add(Album album)
        {
            _albumDal.Add(album);
        }

        // Delete an album from the databse
        public void Delete(Album album)
        {
            _albumDal.Delete(album);
        }

        // Get an album by album id
        public Album GetByAlbumId(int albumId)
        {
            return _albumDal.Get(p => p.AlbumId == albumId);
        }
        
        // Get a list of albums 
        public List<Album> GetList()
        {
            return _albumDal.GetList().ToList();
        }

        // Get a list of albums by artist name
        public List<Album> GetListByArtistName(string artistName)
        {
            return _albumDal.GetList(p => p.ArtistName == artistName).ToList();
        }

        // Update an album in the database
        public void Update(Album album)
        {
            _albumDal.Update(album);
        }
    }
}
