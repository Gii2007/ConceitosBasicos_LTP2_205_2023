// See https://aka.ms/new-console-template for more information

// Exercicios com Vetores 
/*
 * crie um vetor para armazenar as ideias de 5 pessoas e ao final imprima:
 * 1 a pssoa mais nova 
 * 2 a pessoa mais velha
 * 3 a media das idades
 * 4 todas as idades ímpares
 * 5 todas as idades pares
 */
Byte[] idades = new byte[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"informe a {i+1}ª idade:");
    idades[i] = byte.Parse(Console.ReadLine());
}

foreach(int idade in idades)
{
    Console.WriteLine(idade);
}





