using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Question_2
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public void AddItems(List<T> items);
    }
}
