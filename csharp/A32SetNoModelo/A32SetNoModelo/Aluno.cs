using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32SetNoModelo
{
    internal class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int numeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.nome.Equals(outro.nome);
        }

        //Importante: rapidez da busca depende do CÓDIGO DE DISPERSÃO!

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

        //IMPORTANTE!
        //Dois objetos que são iguais possuem o mesmo hash code.
        //PORÉM, object contrário não é verdadeiro:
        //Dois objetos com mesmo hash codes não são necessariamente iguais!

    }
}
