using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32SetNoModelo
{
    internal class Curso
    {
        //Implementando um dicionário de alunos
        private IDictionary<int, Aluno> DicionarioAlunos = new Dictionary<int, Aluno>();


        //Alunos deve ser ISet. Alunos deve retornar ReadOnlyCollection

        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }


        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }

        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //	total += aula.Tempo;
                //}
                //return total;

                //LINQ = LANGUAGE INTEGRATED QUERY
                //CONSULTA INTEGRADA Á LINGUAGEM  ------>

                return aulas.Sum(aula => aula.Tempo);


            }
        }
        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            DicionarioAlunos.Add(aluno.numeroMatricula, aluno);
        }

        public override string ToString()
        {
            return $"Curso: {nome} , Tempo: {TempoTotal} , Aulas: {string.Join(",", aulas)} ";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //foreach (var aluno in alunos)
            //{
            //    if (aluno.numeroMatricula == numeroMatricula)
            //    {
            //        return aluno;

            //    }
            //}
            //throw new Exception("Matrícula não encontrada: " + numeroMatricula);


            Aluno aluno = null;
             this.DicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;

        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.DicionarioAlunos[aluno.numeroMatricula] = aluno;
        }
    }
}
