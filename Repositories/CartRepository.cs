using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        public List<Cart> GetAllCartItemsByUsername(string username) => CartDAO.Instance.GetAllCartItemsByUsername(username);
    }
}
