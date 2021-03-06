﻿namespace MaintenanceManagement.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;

    using MaintenanceManagement.Core;
    using MaintenanceManagement.DataAccess.Entities;
    using MaintenanceManagement.DataAccess.Migrations;

    /// <summary>
    /// Polaczenie z baza danych
    /// </summary>
    public class MainContext : DbContext
    {
        static MainContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MainContext, Configuration>());
        }

        public MainContext()
            : base("Name=MainConnectionString")
        {
        }

        public IDbSet<Area> Areas { get; set; }

        public IDbSet<Employee> Employees { get; set; }

        public IDbSet<EmployeeTask> EmployeeTasks { get; set; }

        public IDbSet<EmployeeTool> EmployeeTools { get; set; }

        public IDbSet<ToolType> ToolTypes { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<TaskBoard> TaskBoards { get; set; }

        public async Task<int> Insert<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            this.Set<TEntity>().Add(entity);
            await this.SaveChangesAsync();

            return entity.Id;
        }

        public async Task DeleteById<TEntity>(int id) where TEntity : BaseEntity
        {
            var entity = await this.Set<TEntity>().SingleOrDefaultAsync(e => e.Id == id);
            this.Set<TEntity>().Remove(entity);
            await this.SaveChangesAsync();
        }

        public async Task<TEntity> Update<TEntity, TModel>(TModel model, Action<TModel, TEntity> mapper)
            where TEntity : BaseEntity
            where TModel : IIdentifiable
        {
            var entity = await this.Set<TEntity>().SingleOrDefaultAsync(e => e.Id == model.Id);

            mapper(model, entity);

            await this.SaveChangesAsync();

            return entity;
        }
    }
}
