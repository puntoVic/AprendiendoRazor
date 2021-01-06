﻿using Entities;
using System.Collections.Generic;
using DataAccess;
using System.Linq;


namespace Bussines
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
        public static WarehouseEntity WarehouseById(string Id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(p => p.WarehouseId == Id);
            }
        }
    }
}
