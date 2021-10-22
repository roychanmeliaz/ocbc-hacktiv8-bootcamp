using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class ItemDataContext : DbContext
    {
        public ItemDataContext(DbContextOptions<ItemDataContext> options) : base(options)
        {

        }
        public DbSet<ItemData> Items { get; set; }
        //Table Name StudentDetails
    }
}