// See https://aka.ms/new-console-template for more information

void primeiroPrograma()
{
    Console.WriteLine("primeira linha");
    Console.WriteLine("segunda linha");
    Console.Write("terceira linha");
    Console.Write("quarta linha");
    Console.WriteLine("/n quebrando linha");
}

//primeiroPrograma();


void segundoPrograma()
{

    //declaração das variáveis 
    string nome;
    int idade;
    double altura;

    //atribuição dos valores nas variaveis
    nome = "jurineide";
    idade = 38;
    altura = 1.72;


    Console.WriteLine($"Nome = {nome} \t Idade = {idade}\t altura = {altura}");


    //entrada de dados 

    int valor;
    valor = Convert.ToInt16(Console.ReadLine());  //converter para inteiro 
    Console.WriteLine($"Você digitou {valor}");

    /*Readline sempre le um valor texto(string)
     * é necessário convertermos este valor
     * Antes de pedir a digitação do usuario, exibe uma informação sobre o que digitar
     * */
}
void operadoresAritmeticos()
{

    int a = 17, b = 7;
    double x = 15.5, y = 1.5;

    Console.WriteLine($" a = {a}, b = {b}, y = {y}");

    Console.WriteLine($"Soma = {a + b} | {x + y}");
    Console.WriteLine($"Soma = {a - b} | {x - y}");
    Console.WriteLine($"Soma = {a / b} | {x / y}");
    Console.WriteLine($"Soma = {a * b} | {x * y}");

    Console.WriteLine($"Módulo = {a % b} | {x % y}"); // resto da divisão
}

int a = 7, b = 3, c;

a++; // a+1
b++; // b+1

c = ++a + ++b;
Console.WriteLine($"a = {a} | b = {b} | c = {c}");


//a++; soma 1 depois do ;
//++a; soma 1 antes do ;