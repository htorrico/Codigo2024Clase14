using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public interface ITransaction
    {
        public void Create();   
        public void Update();
        public void Delete();
    }

    public interface INTransaction
    {      
        public void Read();      
    }

    public class Producto : ITransaction, INTransaction
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class Pais : INTransaction
    {      
        public void Read()
        {
            throw new NotImplementedException();
        }       
    }
}
