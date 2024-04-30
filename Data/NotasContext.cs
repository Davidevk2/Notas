using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class NotasContext: DbContext
    {

        //Constructor de conexion 
        public NotasContext(DbContextOptions<NotasContext> options):base(options){}

        //Modelos a utilizar
    }
}