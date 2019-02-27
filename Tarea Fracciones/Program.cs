using System;

namespace divisiones
{
    class Fraccion
    {
        //numerador
        private int num;
        //denominador
        private int den;

        //Constructor
        public Fraccion(int num, int den)
        {
            this.num = num; this.den = den;
        }
        
        public Fraccion()
        {
            num = 1;
            den = 1;
        }

        public static Fraccion operator +(Fraccion x, Fraccion y)
        {
           Fraccion result= new Fraccion(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;   
        }
        public static Fraccion operator -(Fraccion x, Fraccion y)
        {
           Fraccion resultResta= new Fraccion(x.num * y.den - x.den * y.num, x.den * y.den);
            return resultResta; 
        }
        public static Fraccion operator *(Fraccion x, Fraccion y)
        {
           Fraccion resultMult= new Fraccion(x.num*y.num,x.den*y.den);
            return resultMult;   
        }
         public static Fraccion operator /(Fraccion x, Fraccion y)
        {
           Fraccion resultDiv= new Fraccion(x.num*y.den,y.num*x.den);
            return resultDiv;   
        }
        //No regresa nada
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);   
        }

        

    class Program
    {
        static void Main(string[] args)
        {
            float Sumas;
            //Sumas
            Fraccion a = new Fraccion(1,5);
            Fraccion b = new Fraccion(2,2);
            Fraccion c = a + b;
            
            //Resta
            Fraccion d = new Fraccion(1,5);
            Fraccion e = new Fraccion(2,2);
            Fraccion f = d - e;
            //Multiplicacion
            Fraccion g = new Fraccion(1,5);
            Fraccion h = new Fraccion(2,2);
            Fraccion i = g * h;
            //Division
            Fraccion j = new Fraccion(1,5);
            Fraccion k = new Fraccion(2,2);
            Fraccion l = j / k;

            //Imprimiendo objetos
            Console.WriteLine("SUMA");
            a.imprime();
            b.imprime();
            c.imprime();
            Console.WriteLine("Resta");
            d.imprime();
            e.imprime();
            f.imprime();
            Console.WriteLine("Multiplicacion");
            g.imprime();
            h.imprime();
            i.imprime();
            Console.WriteLine("Division");
            j.imprime();
            k.imprime();
            l.imprime();

            Console.WriteLine("Proceso terminado");
            
        }
    }
}
}

