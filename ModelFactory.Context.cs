﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SewingFactory
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FurnitureEntities : DbContext
    {
        public FurnitureEntities()
            : base("name=FurnitureEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cloth> Cloth { get; set; }
        public virtual DbSet<FabricWarehouse> FabricWarehouse { get; set; }
        public virtual DbSet<Furniture> Furniture { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WarehouseOfFittings> WarehouseOfFittings { get; set; }
        public virtual DbSet<OrderedProducts> OrderedProducts { get; set; }
        public virtual DbSet<ProductFittings> ProductFittings { get; set; }
        public virtual DbSet<Entrance> Entrance { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
    }
}