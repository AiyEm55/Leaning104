using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CL_ProviderContainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Menu 클레스 바로 호출
            List<Menu> menus = new List<Menu>() { 
                new Menu{ MenuID="m01", MenuName="메뉴1" },
                new Menu{ MenuID="m02", MenuName="메뉴2" },
                new Menu{ MenuID="m03", MenuName="메뉴3" }
            };
            //ProviderContainer

            var menuIn = new MenuProviderContainer(new ManuDataInMemory());
            foreach (var item in menuIn.GetAll())
            {
                System.Console.WriteLine(item.ToString());
            }
            
            var menuSql = new MenuProviderContainer(new ManuDataInSQL());
            foreach (var item in menuSql.GetAll())
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }

    public abstract class MenuBase
    {
        public abstract List<Menu> GetAll();
    }

    public class ManuDataInMemory : MenuBase
    {
        public override List<Menu> GetAll()
        {
            List<Menu> menus = new List<Menu>() {
                new Menu{ MenuID="mIn01", MenuName="메뉴(메모리)1" },
                new Menu{ MenuID="mIn02", MenuName="메뉴(메모리)2" },
                new Menu{ MenuID="mIn03", MenuName="메뉴(메모리)3" }
            };
            return menus;
        }
    }
    public class ManuDataInSQL : MenuBase
    {
        //미니프로젝트메뉴카테고리관리자구현-OOP상속의존성 07 XML,  08 SQL
        //public ManuDataInSQL(string connectionString)
        //{
        //    _connectionString = connectionString 
        //}
        public override List<Menu> GetAll()
        {
            List<Menu> menus = new List<Menu>() {
                new Menu{ MenuID="mSql01", MenuName="메뉴(SQL)1" },
                new Menu{ MenuID="mSql02", MenuName="메뉴(SQL)2" },
                new Menu{ MenuID="mSql03", MenuName="메뉴(SQL)3" }
            };
            return menus;
        }
    }
    public class Menu
    {
        public string MenuID { get; set; }
        public string MenuName { get; set; }

        public List<Menu> menus { get; set; } = new List<Menu>();
        public override string ToString()
        {
            return $"{MenuID}/{MenuName}";
        }
    }

    public class MenuProviderContainer
    {
        private MenuBase _repository;
        public MenuProviderContainer(MenuBase menub)
        {
            _repository = menub;
        }
        public List<Menu> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
