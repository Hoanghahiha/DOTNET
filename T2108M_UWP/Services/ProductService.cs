using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_UWP.Models;
using T2108M_UWP.Helpers;
using SQLitePCL;

namespace T2108M_UWP.Services
{
    interface IProductService
    {
        List<Product> All();

        void Create(Product s);

        void Update(Product s);

        void Delete(Product s);
    }

    class ProductService : IProductService
    {
        public List<Product> All()
        {
            string sql_txt = "select * from Student;";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            var list = new List<Product>();
            while (SQLiteResult.ROW == statement.Step())
            {
                Product s = new Product()
                {
                    Id = Convert.ToInt32(statement[0]),
                    Name = statement[1] as string,
                    Price = Convert.ToInt32(statement[2]),
                };
                list.Add(s);
            }
            return list;
        }

        public void Create(Product s)
        {
            string sql_txt = "insert into Product(Id,Name,Price) values(?,?,?)";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Bind(2, s.Name);
            statement.Bind(3, s.Price);
            statement.Step();
       
        }

        public void Update(Product s)
        {
            string sql_txt = "update Product set Name=?, Price=? where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Name);
            statement.Bind(2, s.Price);
            statement.Bind(4, s.Id);
            statement.Step();

        }

        public void Delete(Product s)
        {
            string sql_txt = "delete from Product where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Step();

        }
    }
}
