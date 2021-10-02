using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PS_213020_Aleksevnin.Models;

namespace PS_213020_Aleksevnin.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {
            
        }
        public DbSet<Note> Notes { get; set; }

    }
}
