using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaOtrosTrucos.Cursos
{
    public enum Categoria
    {
        Frontend,
        Backend,
        Movil,
        Devops,
        ML
    }
    class Curso
    {
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        public int Capitulos { get; set; }
    }
}
