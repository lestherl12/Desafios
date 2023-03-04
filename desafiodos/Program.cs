namespace Operaciones_basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedirDatos();
            Calculadora calculadora = new Calculadora();

            int total = calculadora.Sumar(10, 20);
            int diferencia = calculadora.Restar(10, 20);
            int producto = calculadora.Multiplicar(10, 20);
            int cociente = calculadora.Dividir(100, 20);


            Console.WriteLine("Los resultados son suma={0}, resta={1}, multiplicacion={2}, division={3}", total, diferencia, producto, cociente);
            Console.ReadKey();

        }
    }
}