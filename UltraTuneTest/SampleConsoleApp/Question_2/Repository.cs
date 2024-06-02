using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp.Question_2
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProductContext context;

        public Repository()
        {
            this.context = new ProductContext();
        }
        public void AddItems(List<T> items)
        {
            foreach (var item in items)
            {
                context.Set<T>().Add(item);
                context.SaveChanges();
            }
        }
        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
