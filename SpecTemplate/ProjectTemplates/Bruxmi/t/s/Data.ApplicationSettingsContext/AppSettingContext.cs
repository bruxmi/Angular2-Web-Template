namespace Data.ApplicationSettingsContext
{
    using Core.Entities.Application;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppSettingContext : DbContext
    {
        public AppSettingContext()
            : base("name=AppSettingContext")
        {
        }

        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual DbSet<ConnectionString> ConnectionStrings { get; set; }
        public virtual DbSet<Log> Log { get; set; }

    }
}