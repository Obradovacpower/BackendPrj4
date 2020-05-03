using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VareDatabase.Interfaces
{
    public interface IImageRepository
    {
        public void AddImage(int itemId, string image);
        public void DeleteImage(int itemId, int imageId);
        void Delete()
    }
}
