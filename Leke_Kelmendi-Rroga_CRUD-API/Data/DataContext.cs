namespace Leke_Kelmendi_Rroga_CRUD_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
       
            public DbSet<Rroga> Rrogat { get; set; }
        }   
        }         
    
