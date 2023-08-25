//using System;

namespace media_notas
{
    public class Program
    {
        static void Main(string[] args)
        {

            double[] array;

            Console.WriteLine("Qual o número de notas que deseja salvar?: ");
            double user_value = double.Parse(Console.ReadLine());

            double array_size = user_value;

            array = new double [(int)array_size];

            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Digite o valor que deseja inserir na posição {0}:", i+1);
                double user_data = double.Parse(Console.ReadLine());
                array[i] = user_data;
                
                Console.WriteLine("Valor armazenado na posição {0}, {1}", i+1, user_data);
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Essas foram as notas armazenadas na memória: {0}", array[i]);
            }

            Console.WriteLine("Deseja calcular a média das notas inseridas?");

            char user_calc = char.Parse(Console.ReadLine());

            if (user_calc == 'S')
            {
                double somaTotal = 0.0;
                for(int i = 0; i < array_size; i++)
                {
                   somaTotal += array[i]; 
                }

                double media = somaTotal / array_size;

                Console.WriteLine("A média dos alunos foi: {0}", media);
            }
        }
    }
}


   

