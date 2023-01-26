using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankADM.Livro
{
    public class Livro
    {
        public string Autor { get; set; }
        public string Titulo { get; private set; }
        public string PaisPublicacao { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }
        public string Isbn { get; private set; }

        public Livro(string isbn, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
        }
    }
}
