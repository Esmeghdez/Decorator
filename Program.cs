using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class TecnmComponent
    {
        public abstract string Clave { get; }
        public abstract string Descripcion { get; }
    }

    public class IngSC : TecnmComponent
    {
        public override string Clave => "ISC";
        public override string Descripcion => "Ingenieria en Sistemas Computacionales";
    }
    public class IngI : TecnmComponent
    {
        public override string Clave => "IF";
        public override string Descripcion => "Ingenieria en Informatica";
    }
    public class IngC : TecnmComponent
    {
        public override string Clave => "IC";
        public override string Descripcion => "Ingenieria en CiberSeguridad";
    }
    public abstract class AgregadoDecorator : TecnmComponent
    {
        protected TecnmComponent _tecnm;
        public AgregadoDecorator(TecnmComponent Tecnm)
        {
            _tecnm = Tecnm;
        }
    }
    public class Fisica : AgregadoDecorator
    {
        public Fisica(TecnmComponent Tecnm) : base(Tecnm) { }
        public override string Clave => _tecnm.Clave + "F1S";
        public override String Descripcion => string.Format($"{_tecnm.Descripcion}, Materia: Fisica");
    }
    public class Tutoria : AgregadoDecorator
    {
        public Tutoria(TecnmComponent Tecnm) : base(Tecnm) { }
        public override string Clave => _tecnm.Clave + "T1S";
        public override String Descripcion => string.Format($"{_tecnm.Descripcion}, Materia: Tutoria");
    }
    public class Ingles : AgregadoDecorator
    {
        public Ingles(TecnmComponent Tecnm) : base(Tecnm) { }
        public override string Clave => _tecnm.Clave + "I1S";
        public override String Descripcion => string.Format($"{_tecnm.Descripcion}, Materia: Ingles");
    }
    public class Programacion : AgregadoDecorator
    {
        public Programacion(TecnmComponent Tecnm) : base(Tecnm) { }
        public override string Clave => _tecnm.Clave + "P1S";
        public override String Descripcion => string.Format($"{_tecnm.Descripcion}, Materia: Programacion");
    }
    public class Calculo : AgregadoDecorator
    {
        public Calculo(TecnmComponent Tecnm) : base(Tecnm) { }
        public override string Clave => _tecnm.Clave + "C1S";
        public override String Descripcion => string.Format($"{_tecnm.Descripcion}, Materia: Calculo Diferencial");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TecnmComponent carrera = new IngSC();
            carrera = new Fisica(carrera);
            carrera = new Calculo(carrera);
            Console.WriteLine($"Carrera: {carrera.Descripcion} la clave es la siguiente: $ {carrera.Clave}");
            Console.ReadKey();
        }
    }
}
