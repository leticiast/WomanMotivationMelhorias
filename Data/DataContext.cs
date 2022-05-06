//DbContext é o contexto aonde vai encapsular todas as entidades.
using Microsoft.EntityFrameworkCore;
using WomanMotivation_.Models;

namespace WomanMotivation_.Data
{
    public class DataContext : DbContext
    {
        //construtor para configurar a conexão com banco de dados. 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //DbSet para acessar as propriedades da classe FraseMotivacional, definir a tabela.  
        public DbSet<FraseMotivacional> FrasesMotivacionais {get; set;}
    }
}   