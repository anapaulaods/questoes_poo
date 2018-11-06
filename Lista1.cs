// 1. Ler o nome de uma pessoa e mostrar a mensagem: “Bem-vindo ao C#, <xxx>”, onde <xxx> é o nome informado 

// pela pessoa. 

 
using System; 

class MainClass { 
public static void Main (string[] args) { 

Console.WriteLine("Digite seu nome: "); 

string nome = Console.ReadLine(); 

Console.WriteLine("Bem vindo ao C#, "+ nome); 

} 

} 

 

// 2. Ler o valor do raio de um círculo, calcular a sua circunferência e sua área com duas casas decimais. 
 

using System; 

class MainClass { 

public static void Main (string[] args) { 

Console.WriteLine("Digite o raio de um circulo:"); 

double numero = double.Parse(Console.ReadLine()); 

double c = 2 * Math.PI * numero; 

double a = Math.PI * numero * numero; //Math.Pow(r, 2); significa elevar ao quadrado 

 

Console.WriteLine($"Circunferência = {c:0.00} "); 

Console.WriteLine($"Área = {a:0.00} "); 

} 

} 

 

// 4. Ler a data de nascimento de uma pessoa (no formato dd/mm/aaaa) e informar quantos anos esta pessoa terá 

// em 31/12/2018. 

 

using System; 

class MainClass { 

public static void Main (string[] args) { 

Console.WriteLine("Digite sua data de nascimento:"); 

string data = Console.ReadLine(); 

string ano = data.Substring(6); 

int a = 2018 - int.Parse(ano); 

Console.WriteLine($"Em 31/12/2018 você terá {a} anos."); 

} 

} 

 

// 5. Calcular o índice de massa corporal (IMC) de uma pessoa, dados a sua massa (peso) e sua altura. O IMC é 

// obtido pela razão entre a massa e o quadrado da altura da pessoa. 

 

using System; 

class MainClass { 

public static void Main (string[] args) { 

double massa, altura, imc; 

Console.WriteLine ("Informe sua massa em kg:"); 

massa = double.Parse(Console.ReadLine()); 

Console.WriteLine("Informe sua altura em metros:"); 

altura = double.Parse(Console.ReadLine()); 

imc = (massa / (altura*altura)); 

Console.WriteLine($"Seu imc é: {imc:0.00}"); 

} 

} 

 

// 6. Calcular a quantia gasta por um fumante, dados o no de anos que ele fuma, o no de cigarros fumados por dia e 

// o preço de uma carteira de cigarros. Admitir que a carteira possui 20 cigarros. 

 

using System; 

class MainClass { 

public static void Main (string[] args) { 

double anos, dias, preco, total; 

Console.WriteLine ("Há quantos anos você fuma?"); 

anos = double.Parse(Console.ReadLine()); 

Console.WriteLine("Quantos cigarros por dia?"); 

dias = double.Parse(Console.ReadLine()); 

Console.WriteLine("Qual o preço da carteira de cigarros?"); 

preco = double.Parse(Console.ReadLine()); 

total = ((anos*365*dias)/20) * preco; 

Console.WriteLine($"Total gasto = R$ {total:0.00}");  

} 

} 

// 7. Calcular área, perímetro e diagonal de um retângulo, dados sua base e sua altura. 

 

using System; 

class MainClass { 

public static void Main (string[] args) { 

double Base, altura, area, perimetro, diagonal, diagonal2;  

Console.WriteLine ("Digite a base e a altura do retângulo"); 

Base = int.Parse(Console.ReadLine()); 

altura = int.Parse(Console.ReadLine()); 

area = Base * altura; 

perimetro = (Base + altura) * 2; 

diagonal = (Base * Base) + (altura * altura); 

diagonal2 = Math.Sqrt(diagonal); 

Console.WriteLine ("Área = {0} - Perimetro = {1} - Diagonal = {2}", area, perimetro, diagonal2); 

} 

} 

 

// 8. Ler um valor monetário (reais e centavos) e mostrar um texto informando a quantidade de reais e a quantidade 

// de centavos do valor lido. 

 

using System; 

class MainClass { 

public static void Main (string[] args) { 

string valor;  

Console.WriteLine("Digite um valor monetário:"); 

valor = Console.ReadLine(); 

string[] reais = valor.Split(','); 

string[] centavos = valor.Split(','); 

Console.WriteLine("{0} Reais e {1} centavos", reais[0], centavos[1]); 

} 

} 