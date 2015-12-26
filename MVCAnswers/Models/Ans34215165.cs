namespace MVCAnswers.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Ans34215165 : DbContext
    {
        // Your context has been configured to use a 'Ans34215165' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCAnswers.Models.Ans34215165' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Ans34215165' 
        // connection string in the application configuration file.
        public Ans34215165()
            : base("name=Ans34215165")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ctTerminalTimeZone> ctTerminalTimeZoneEntities { get; set; }
        public virtual DbSet<ctTerminalTimeZoneChangeLog> ctTerminalTimeZoneChangeLogEntities { get; set; }
        public override int SaveChanges()
        {

            var selectedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is ctTerminalTimeZone &&
                                    (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entity in selectedEntityList)
            {
                this.ctTerminalTimeZoneChangeLogEntities.Add(new ctTerminalTimeZoneChangeLog()
                {
                    DateModified = DateTime.Now.ToShortDateString(),
                    TerminalLocationCode = ((ctTerminalTimeZone)entity.Entity).TerminalLocationCode,
                    TimeModified = DateTime.Now.ToLongTimeString()

                });
                if (((ctTerminalTimeZone)entity.Entity).HiddenValue == null)
                {
                    this.Entry(((ctTerminalTimeZone)entity.Entity)).Property(x => x.HiddenValue).IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }

    public class ctTerminalTimeZone
    {
        public int Id { get; set; }
        public string TerminalName { get; set; }
        public string TerminalLocationCode { get; set; }
        public string BranchPlantCode { get; set; }
        public string TimeZoneStandardName { get; set; }
        public string HiddenValue { get; set; }
    }
    public class ctTerminalTimeZoneChangeLog
    {
        public int Id { get; set; }
        public string TerminalLocationCode { get; set; }
        public string DateModified { get; set; }
        public string TimeModified { get; set; }
    }
}