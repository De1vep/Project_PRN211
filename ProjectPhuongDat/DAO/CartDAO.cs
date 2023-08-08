using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhuongDat.DAO
{
    internal class CartDAO
    {
        MusicStoreContext context = new MusicStoreContext();
        public List<Cart> GetCartsByUser(string username)
        {
            List<Cart> carts = context.Carts.Where(c => c.CartId == username).ToList();
            return carts;
        }
    }
}
