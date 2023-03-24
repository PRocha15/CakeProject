using CakeDatabase.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeDatabase
{
    public class CakeDBContext : DbContext
    {   
        public CakeDBContext(DbContextOptions<CakeDBContext> options) : base(options)
        { 

        } 
        //após criar DbContext ---> necessário criar categoria da tabela na DataBase.
        //criar DbSet para cada classe ---> Sempre.
        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Cake> Cakes { get; set; }
        //Cake = classe; Cakes = Nome da Tabela
        //ex:Table --> com nome de Cakes e com 3 colunas

    }
}
