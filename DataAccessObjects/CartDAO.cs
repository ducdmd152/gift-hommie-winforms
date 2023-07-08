using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CartDAO
    {


        // Singleton Pattern
        private CartDAO() { }
        private static CartDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CartDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CartDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Cart> GetAllCartItemsByUsername(string username)
        {
            try
            {

                using(var context = new HommieStoreContext())
                {
                    return context.Carts.Where(c => c.Username == username).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
