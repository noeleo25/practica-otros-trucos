using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaOtrosTrucos
{
    class Usuario
    {
        private string nombre;
        //public int Id { get; set; }
        
        public Guid Id { get; } = Guid.NewGuid();//Para auto-property initializer
        public string Nombre
        {
            get => nombre;
            //set => nombre; = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Nombre)} no admite valor nulo");
        }
        public int ModoDeRegistro { get; set; }
    }
}
