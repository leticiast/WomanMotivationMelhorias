//Criei uma classe com 5 propriedades. 
using System.ComponentModel.DataAnnotations;

namespace WomanMotivation_.Models
{
    public class FraseMotivacional
    {
        //Propriedas 
        [Key] // chave para o id 
        public int Id { get; set; } //add a propriedade id como padrão. 
        public string Frase { get; set; }
        public string Autora { get; set; }
        public string Foto { get; set; }
    }    
}
