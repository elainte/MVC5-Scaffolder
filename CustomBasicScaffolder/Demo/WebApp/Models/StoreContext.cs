﻿using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class StoreContext:DataContext
    {
        public StoreContext()
            : base("Name=DefaultConnection")
        { 
        }
         
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Work> Works { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.BaseCode> BaseCodes { get; set; }
        public System.Data.Entity.DbSet<WebApp.Models.CodeItem> CodeItems { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.MenuItem> MenuItems { get; set; }

        public DbSet<RoleMenu> RoleMenus { get; set; }

        public DbSet<DataTableImportMapping> DataTableImportMappings { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.BASE_CIQCODE> BASE_CIQCODE { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.BASE_COMPANY> BASE_COMPANY { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.AUTO_CHECKRESULT> AUTO_CHECKRESULT { get; set; }

        public System.Data.Entity.DbSet<WebApp.Models.LIST_ORDER> LIST_ORDER { get; set; }
    }
}