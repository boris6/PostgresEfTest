using Microsoft.EntityFrameworkCore;
using Postgres.Domain.Entities;
using Postgres.Persistance;

namespace PostgresqlTestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (FrcContext context = new FrcContext(new DbContextOptionsBuilder<FrcContext>().UseNpgsql(
                "Host = localhost; Port = 5442; Database = FrcTest; Username = postgres; Password = postgres").Options))
            {
                FrcContextInitializer.Initialize(context);
            }
        }
    }
}