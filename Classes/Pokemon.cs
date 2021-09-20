using System.Collections.Generic;

namespace Pokedex.Classes
{
    public class Pokemon{

        //Atributos
        public int Numero { get; set; }
        public string Nome { get; set; }
        public List<string> Tipo { get; set; }
        public string Altura { get; set; }    
        public string Peso { get; set; }
        public string Imagem { get; set; }
        public List<string> Fraqueza { get; set; }
    
        //Método Construtor
        public Pokemon()
        {
            Tipo= new List<string>();
            Fraqueza = new List<string>();
        }
    }


}

