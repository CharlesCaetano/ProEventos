using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

//using Microsoft.EntityFrameworkCore;
using PropEventos.API.Models;

///using Microsoft.AspNetCore.Identity;


namespace PropEventos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public  DbSet<Evento> Eventos { get; set;}
        
    }
}