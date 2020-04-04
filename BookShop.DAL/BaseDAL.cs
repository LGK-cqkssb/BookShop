using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DAL
{
    public static class BaseDAL
    {
        public static List<T> Select<T>() where T : class
        {
            BookShopContext db = new BookShopContext();
            return db.Set<T>().ToList();
        }


        public static bool Any<T>(Expression<Func<T, bool>> expression) where T : class
        {
            BookShopContext db = new BookShopContext();
            return db.Set<T>().Any(expression);
        }

        public static T Find<T>(Expression<Func<T, bool>> expression) where T : class
        {
            BookShopContext db = new BookShopContext();
            return db.Set<T>().FirstOrDefault(expression);
        }

        public static List<T> FindAll<T>(Expression<Func<T, bool>> expression) where T : class
        {
            BookShopContext db = new BookShopContext();
            return db.Set<T>().Where(expression).ToList();
        }

        public static bool Update<T>(T model) where T : class
        {
            BookShopContext db = new BookShopContext();
            db.Entry<T>(model).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public static bool Insert<T>(T model) where T : class
        {
            BookShopContext db = new BookShopContext();
            db.Set<T>().Add(model);

            return db.SaveChanges() > 0;
        }
    }
}
