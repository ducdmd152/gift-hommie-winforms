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
        public List<Cart> GetAllCartItems()
        {
            try
            {
                using(var context = new HommieStoreContext())
                {
                    return context.Carts.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCartQuantityById(int id, int quantity)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Cart cart = context.Carts.SingleOrDefault(c => c.Id == id);
                    cart.Quantity = quantity;
                    context.Carts.Update(cart);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCartById(int id)
        {
            try
            {
                using (var context = new HommieStoreContext())
                {
                    Cart cart = context.Carts.SingleOrDefault(c => c.Id == id);
                    context.Carts.Remove(cart);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
