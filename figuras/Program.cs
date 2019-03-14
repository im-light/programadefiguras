using System;
using System.Collections.Generic;
namespace figuras
{
 class Vector2d
    {
        public int x, y;
        public Vector2d(int x, int y)
        {
            this.x=x; this.y=y;
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", x, y);
        }
    }
     abstract class Figura
    {
        public Vector2d position;
        public string fill ,border;

        public Figura():this( new Vector2d(100, 100))
        {
        
        }
        public Figura(Vector2d pos)
        {
            position= pos;
            border= "black";
        }

        public abstract void Dibuja();

    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
     public Circulo ():base()
     {
         this.radio= 10;
     }
     public override void Dibuja() 
     {
         fill="green";
         Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
     }
    }
 
    class Rectangulo : Figura
    {
     
     public Rectangulo(Vector2d pos):base(pos)
     {
         
     }
     public Rectangulo ():base()
     {
        
     }

     public override void Dibuja() 
     {
         fill="red";
         Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
     }
    }
    class Triangulo:Figura
    {
        public Triangulo (Vector2d pos):base(pos)
        {

        }
        public Triangulo():base()
        {

        }
        public override void Dibuja() 
     {
         fill="orange";
         Console.WriteLine("Se dibuja un triangulo en {0} de color {1}", position, fill);
     }
    }


    
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo());
            figuras.Add(new Rectangulo(new Vector2d(200,200) ));
            figuras.Add(new Triangulo(new Vector2d(300,300)));
            foreach(Figura f in figuras)
            f.Dibuja();
        }
    }
}
