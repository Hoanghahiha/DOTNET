using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDien.Model;
using QuanLyDien.Helper;
using SQLitePCL;

namespace QuanLyDien.Services
{
    interface IStudentService
    {
        List<Customer> All();

        void Create(Customer s);

        void Update(Customer s);

        void Delete(Customer s);
    }
    class CustomerServices: IStudentService
    {
        public List<Customer> All()
        {
            string sql_txt = "select * from Customer;";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            var list = new List<Customer>();
            while (SQLiteResult.ROW == statement.Step())
            {
                Customer s = new Customer()
                {
                    Id = Convert.ToInt32(statement[0]),
                    Name = statement[1] as string,
                    Date = Convert.ToDateTime(statement[2]),
                    SLTieuThu = Convert.ToInt32(statement [3]),
                    DonGia = Convert.ToInt32(statement[4]),
                    DinhMuc = Convert.ToInt32(statement[5]),
                };
                list.Add(s);
            }
            return list;
        }

        public void Create(Customer s)
        {
            string sql_txt = "insert into Customer(Id,Name,Date,SLTieuThu,DonGia,DinhMuc) values(?,?,?,?,?,?)";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Bind(2, s.Name);
            statement.Bind(3, s.Date);
            statement.Bind(4, s.SLTieuThu);
            statement.Bind(5, s.DonGia);
            statement.Bind(6, s.DinhMuc);
            statement.Step();

        }

        public void Update(Customer s)
        {
            string sql_txt = "update Customer set Name=?, Date=?, SLTieuThu=?, DonGia=?, DinhMuc=? where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Name);
            statement.Bind(2, s.Date);
            statement.Bind(3, s.SLTieuThu);
            statement.Bind(4, s.DonGia);
            statement.Bind(5, s.DinhMuc);
            statement.Bind(6, s.Id);
            statement.Step();

        }

        public void Delete(Customer s)
        {
            string sql_txt = "delete from Customer where Id=?";
            SQLiteHelper helper = SQLiteHelper.GetInstance();
            var statement = helper.SQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, s.Id);
            statement.Step();

        }
    }
}
