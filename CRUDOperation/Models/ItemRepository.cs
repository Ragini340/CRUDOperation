using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperation.Models
{
    public interface ItemRepository
    {
        IEnumerable<Item> GetAll();
        Item Get(int id);
        Item Add(Item item);
        void Remove(int id);
        bool Update(Item item);
    }
}
