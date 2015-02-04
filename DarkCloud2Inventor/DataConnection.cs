using System;
using System.Collections.Generic;
using System.Linq;


namespace DarkCloud2Inventor
{
    class DataConnection
    {
        private DarkCloudDataContext _db;

        public DataConnection()
        {
            _db = new DarkCloudDataContext();

            //open a connection for me to decrease load time, but don't keep me busy
            _db.Connection.OpenAsync();
        }

        public bool LogIn(string user, string pass)
        {
            return 0 != _db.VerifyUser(user, pass).Count();
        }

        public bool AddUser(string user, string pass)
        {
         
            if (String.IsNullOrEmpty(pass)) return false;

            _db.users.InsertOnSubmit(new user
            {
                username = user,
                userpass = pass
            });

            try
            {
                _db.SubmitChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<photo> UserGallery(string user)
        {
            return (from u in _db.photostakens from p in _db.photos where u.username == user && u.photoID == p.id select p).ToList();
        }

        public photo GetPictureInfo(string picName)
        {
           return (from p in _db.photos where p.name == picName select p).FirstOrDefault();
        }

        public bool DeletePhoto(string user, string photo)
        {
            if (String.IsNullOrEmpty(photo)) return false;

            var r = from p in _db.photos from pt in _db.photostakens where p.name == photo && p.id == pt.photoID && pt.username == user select pt;
            _db.photostakens.DeleteAllOnSubmit(r);

            try
            {
                _db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                _db = new DarkCloudDataContext();
                return false;
            }
        }

        public bool AddPhoto(string user, string photo)
        {
            if (String.IsNullOrEmpty(photo)) return false;

            _db.photostakens.InsertOnSubmit(new photostaken
            {
                username = user,
                photoID = (from p in _db.photos where p.name == photo select p.id).FirstOrDefault()
            });

            try
            {
                _db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                _db = new DarkCloudDataContext();
                return false;
            }
        }

        public List<string> GetInventionsFromPhoto(string photo)
        {
            return (from p in _db.photos
                from ip in _db.inventions_have_photos
                from i in _db.inventions
                where p.name == photo && p.id == ip.photoID && ip.inventID == i.id
                select i.name).ToList();

        }

        public List<photo> PhotoGallery()
        {
            return (from p in _db.photos select p).ToList();
        }
    }
}
