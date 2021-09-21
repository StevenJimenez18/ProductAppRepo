using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public interface IProductRepository
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();
    }
}
