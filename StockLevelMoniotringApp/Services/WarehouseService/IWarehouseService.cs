using FormUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Service.WarehouseService
{
    public interface IWarehouseService
    {
        public Warehouse GetWarehouseById(int id);
        public Warehouse AddWarehouse(Warehouse value);
    }
}
