using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
>>>>>>> 797cad643e9bcba066fd937af93222a7e2ea83e0
using System.Linq;
using System.Text;
using FormUI.Data;
using FormUI.Models;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Service.WarehouseService
{
    class WarehouseService : IWarehouseService
    {
        private readonly IGenericRepository<Warehouse> _genericRepository;

        public WarehouseService(IGenericRepository<Warehouse> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Warehouse AddWarehouse(Warehouse value)
        {
            var newWarehouse = new Warehouse() { WarehouseName = value.WarehouseName };
            _genericRepository.AddEntity(newWarehouse);
            return newWarehouse;
        }

        public Warehouse GetWarehouseById(int id)
        {
            return _genericRepository.GetEntityById(id);
        }

    }
}
