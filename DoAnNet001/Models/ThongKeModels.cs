using DoAnNet001.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNet001.Models
{
    class ThongKeModels
    {
        DoAnNetEntities1 db = new DoAnNetEntities1();
        private static ThongKeModels thongke = null;

        internal static ThongKeModels TaiKhoanCons
        {
            get
            {
                if (thongke == null)
                {
                    thongke = new ThongKeModels();
                }
                return thongke;
            }
            set => thongke = value;
        }
        public List<ThongKe1> getdata()
        {
            List<ThongKe1> thongke = (from c in db.ThongKe1 orderby c.Id descending select c).ToList();
            return thongke;
        }
        public bool addThang(ThongKe1 a)
        {
            db.ThongKe1.Add(a);
            db.SaveChanges();
            return true;
        }

    }
}
