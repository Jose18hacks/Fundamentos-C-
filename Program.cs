// Comentário
//fddfdffd
/*
 * um comentario com varias linhas
 * AAAAAa
 */

//Mostrar texto na tela

//Toda INSTRUÇÃO termina com ;

//Console.WriteLine("Olá, José");

//Guardar informações
//1.VARiAVEIS

// TIPO NOME = VALOR

//int idade = 18;
//string nome = "Henrique";

//Console.WriteLine(nome);
//Console.WriteLine(idade);

//int - integer (numeros inteiros)
//double - numeros quebrados  
//float - tambem para numeros quebrados, mas com limite menor
//string - textos - ""

//constantes - Valor que não pode ser alterado

//const double pi = 3.14159;

//Console.WriteLine(pi);

//var

//var nome = "Jose"; //O C# entende que é uma string
//var preco = 19.55; //O C# entende que é double

//char inicialdoome = 'J';



//Console.WriteLine("Digite seu nome: ");
//string nomeUsuario = Console.ReadLine(); //Le o texto digitado (Ex: Prompt em JS, Input em Python)

//Console.WriteLine("informe sua idade: ");
//int idade = int.Parse(Console.ReadLine());

////Console.WriteLine("Olá, " + nomeUsuario + "! \nVoce tem " + idade + " anos.");

////Interpolacao de stings
//Console.WriteLine($"Olá, {nomeUsuario}! Voce tem {idade} Anos");


//Operacoes aritmeticas

//int soma = 10 + 5;
//int sub = 10 - 5;
//int mul = 10 * 5;
//int div = 10 / 5;

////resto da divisao - recebe o resto da divisao
//int modulo = 10 % 5;

//Console.WriteLine(soma);
//Console.WriteLine(sub);
//Console.WriteLine(mul);
//Console.WriteLine(div);
//Console.WriteLine(modulo);




//EXERCICIOS 



//NIVEl 1 FACIL

//1.Exibir uma Mensagem
//Escreva um programa que use o comando Console.WriteLine() para exibir a frase "Olá, Mundo!" no console.
//Console.WriteLine("Olá, Mundo");



//2. Declarar e Usar uma Variável**
//Crie um programa que declare uma variável inteira chamada `numero` com o valor 10. Em seguida, imprima o valor dessa variável no console.
//int numero = 10;
//Console.WriteLine(numero);



//3. Fazer uma Soma
//Escreva um programa que declare duas variáveis inteiras, a = 5 e b = 3. Calcule a soma das duas e imprima o resultado.
//int a = 5;
//int b = 3;
//Console.WriteLine(a + b);



//4.Produto de dois números
//Declare duas variáveis, num1 = 8 e num2 = 7. Calcule o produto (multiplicação) entre elas e imprima o resultado.
//int num1 = 8;
//int num2 = 7;
//Console.WriteLine(num1 * num2);





//NIVEL 2 INTERMEDIARIO

//**5.Saudação Personalizada**
//Crie um programa que declare uma variável `String` chamada `nome` com o valor `"Ana"`. Depois, exiba uma mensagem de boas-vindas, como `"Olá, Ana!"`.
//string nome = "Ana";
//Console.WriteLine($"Olá, {nome}!");




//**6. Calcular o Dobro**
//Declare uma variável inteira `valor`. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.
//int valor = 47;
//Console.WriteLine($"O dobro de {valor} é {valor * 2}");




//**7. Média de três números**
//Escreva um programa que recebe três números e imprime a média aritmética deles.
//Console.WriteLine("Digite o 1° numero: ");
//int num1 = int.Parse (Console.ReadLine());

//Console.WriteLine("Digite o 2° numero: ");
//int num2 = int.Parse (Console.ReadLine());

//Console.WriteLine("Digite o 3° numero: ");
//int num3 = int.Parse (Console.ReadLine());

//int resultado = (num1 + num2 + num3) / 3;

//Console.WriteLine($"A média aritmética de {num1}, {num2} e {num3} é {resultado}");




//**8. Ficha de Cadastro**
//Peça ao usuário que digite, um de cada vez, o seu **nome**, a sua **idade** e a sua **cidade**. Depois, monte uma única frase com as três informações.

//**Exemplo de execução:**
//```

//Digite seu nome: Bruno
//Digite sua idade: 27
//Digite sua cidade: Santo André

//Bruno tem 27 anos e mora em Santo André.
//```
//Console.WriteLine("Digite seu nome: ");
//string nome = Console.ReadLine();

//Console.WriteLine("Digite sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite seu cidade: ");
//string cidade = Console.ReadLine();

//Console.WriteLine($"{nome} mora em {cidade} e tem {idade} anos.");




//**9. Comparar Dois Números
//Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20. O programa deve comparar se `x` é menor que `y` (`<`) e imprimir o resultado (`true` ou `false`) no console.
//int x = 10;
//int y = 20;

////bool -> tipo que armazena true ou false (apenas)
//bool resultado = x < y;

//Console.WriteLine(resultado);



////**10.Verificação de Idade para Votar**

////Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (

////`true` ou `false`).

////- **Extra:**Adicione um comentário de uma linha (`//`) explicando o que a comparação faz.
//Console.WriteLine("Digite sua idade para votar: ");
//int idade = int.Parse(Console.ReadLine());
//Console.WriteLine(idade >= 16);



//Declare uma variável booleana temCartao = true e uma variável 
//double compra = 50.0. O cliente ganha um desconto se temCartao for 
//verdadeiro OU se o valor da compra for maior que 100.0. Escreva a expressão lógica e imprima o resultado (
//`true` ou `false`).
//bool temCartao = true;
//double compra = 50.0;
//if (temCartao || compra >100.0)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}









//Nomenclatura
//Variaveis - camelCase
//int idadeDoAluno = 19;

//Metodos, Classes - PascalCase
//Console.WriteLine();

//SNAKE Case
//idade_do_aluno = 9



//Operadores Lógicos e Condicionais (juntar perguntas)
//bool a = true;
//bool b = false;

////&& -E
////(True - se as duas condicoes forem verdadeiras)
////(False - se uma das condicoes for falsa)
//bool Resultado = a && b;
//Console.WriteLine(Resultado);

//// || -Ou
//// (se UM dos lados for verdade - retorna True)
//Resultado = a || b;
//Console.WriteLine(Resultado);

//// ! - Não (negação)
//// //Traz o oposto do que tiver na variavel (true -> false, false -> true)
//Resultado = !a;
//Console.WriteLine(Resultado);




//Condicionais
//Tomar uma ação se o cara é maior de idade
//Criança, Adulto e idoso
//int idade = 18;

//if (idade < 14)
//{
//    Console.WriteLine("Criança");
//}
//else if (idade >= 14 && idade <18)
//{
//    Console.WriteLine("Adolesente");
//}
//else if (idade >= 18 && idade < 60)
//{
//    Console.WriteLine("Adulto");
//}
//else
//{
//    Console.WriteLine("Idoso");
//}







//EXERCICIOS CONDICIONAIS


//**1.Verificador de Maioridade**

//Crie um programa que declare uma variável **`idade`**. 

//Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 

//O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira,
//e "*Você é menor de idade*" caso contrário
//int idade = 18;

//if (idade >= 18)
//{
//    Console.WriteLine("Maior de idade");
//}
//else
//{
//    Console.WriteLine("Menor de idade");
//}





//**2.Verificador de Número(Positivo, Negativo ou Zero)**

//Crie um programa que declare uma variável **`numero`**;

//Utilize uma estrutura **`if/else if/else`** para verificar e imprimir uma das
//seguintes mensagens: "*O número é positivo.*", "*O número é negativo.*" ou "*O número é zero.*".
//int numero = 351;

//if (numero > 0)
//{
//    Console.WriteLine("O numero é positivo");
//}
//else if (numero < 0)
//{
//    Console.WriteLine("O numero é negativo");
//}
//else
//{
//    Console.WriteLine("O numero é zero");






//**3.Classificação de Aluno**

//Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno (um valor **`double`**). 

//Em seguida, use uma estrutura **`if/else`** simples para imprimir "Aprovado" se a nota 
//for maior ou igual a 7.0, e "Reprovado" caso contrário

//Console.WriteLine("Digite a nota do aluno: ");
//double nota = double.Parse(Console.ReadLine());

//if (nota > 7.0)
//{
//    Console.WriteLine("Aluno Aprovado!");
//}
//else
//{
//    Console.WriteLine("Aluno Reprovado!");
//}





//**4.Classificação por Faixa Etária * *

//Peça a idade do usuário e classifique: até 12 anos → `"Criança"`, de 13 a 17 → `"Adolescente"`,
//18 ou mais → `"Adulto"`. Use condicional encadeada (`else if`).
//Console.WriteLine("Digite sua idade");
//int idade = int.Parse(Console.ReadLine());

//if (idade <= 12)
//{
//    Console.WriteLine("Criança");
//}
//else if (idade >= 13 && idade < 18)
//{
//    Console.WriteLine("Adolescente");
//}
//else
//{
//    Console.WriteLine("Adulto");
//}





//**5.Status de Tarefa**

//Declare uma variável **`boolean tarefaConcluida`**. 

//Usando uma estrutura **`if/else`**, exiba a mensagem "A tarefa está pendente!" 
//se a variável for **`false`**, e "A tarefa foi finalizada com sucesso!" se for **`true`**.
//Boolean tarefaConcluida = false;

//if (tarefaConcluida == true)
//{
//    Console.WriteLine("A tarefa está concluída!");

//}
//else
//{
//    Console.WriteLine("A tarefa está pendente!");
//}







//**6.Nota Válida(operador &&) * *

//Peça uma nota ao usuário. Use o operador `&&` para verificar se 
//    ela está dentro do intervalo válido (entre 0 e 10). Exiba `"Nota válida"` ou `"Nota inválida"`.
//Console.WriteLine("Digite uma nota: ");
//int nota = int.Parse(Console.ReadLine());

//if  (nota >= 0 && nota <= 10)
//{
//    Console.WriteLine("Nota Válida");
//}
//else
//{
//    Console.WriteLine("Nota Inválida");
//}





//**7.Aprovação de Empréstimo**

//Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e 
//não possua restrições de crédito. 

//Crie um programa com as variáveis **`double salarioMensal`**; 
//e * *`boolean possuiRestricao`** . Use o operador lógico "E" (**`&&`**) em uma estrutura **`if`** 
//    para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado."
//double salarioMensal = 4.700;
//Boolean possuiRestricao = false;

//if (salarioMensal >= 2.000 && possuiRestricao == false)
//{
//    Console.WriteLine("Empréstimo Aprovado");
//}
//else
//{
//    Console.WriteLine("Emprestimo Recusado");
//}





//**8.Classificação de Média Escolar Completa**

//Crie um programa que solicita ao usuário que digite uma nota (um valor

//**`double`**). Utilizando uma estrutura **`if/ else if /else`**, classifique a nota da seguinte forma:

//-Se a nota for 7.0 ou maior, imprima "Aprovado!".
//- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
//- Se a nota for menor que 5.0, imprima "Reprovado.".
//Console.WriteLine("Digite a Nota do aluno: ");
//double nota = double.Parse(Console.ReadLine());

//if (nota >= 7.0)
//{
//    Console.WriteLine("Aprovado!");
//}
//else if (nota >= 5.0 && nota < 7.0)
//{
//    Console.WriteLine("Recuperação!");
//}
//else
//{
//    Console.WriteLine("Reprovado!");
//}





//**9.Par ou Ímpar com Operador Ternário**

//Declare uma variável **`numero`**; Utilizando o operador ternário (**`? :`**), 
//crie uma variável String resultado que receba o texto "Par" se o número for par, 
//ou "Ímpar" se for ímpar. Ao final, imprima o resultado.
//**Dica:**O operador de módulo **`%`** (resto da divisão), apresentado no material, é perfeito para isso.
//Console.WriteLine("Digite um número: ");
//int numero = int.Parse(Console.ReadLine());
//string resultado = (numero %2 ==0) ? "Par" : "Ímpar";
//Console.WriteLine(resultado);







//**10.Cálculo de Desconto Progressivo * *

//Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável

//`double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:

//-Compras acima de R$ 200,00 têm 20% de desconto.
//- Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.
//- Compras abaixo de R$ 100,00 não têm desconto.

//    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.
//double valorCompra = 150.0;
//double resultado = 0;
//double desconto = 0;

//if (valorCompra > 200) {

//    resultado = (valorCompra * 20) / 100;
//    desconto = valorCompra - resultado;
//    Console.WriteLine($"20% de desconto aplicado! o produto custa R$ {desconto}");
//}

//else if (valorCompra >= 100 && valorCompra <= 200)
//{
//    resultado = (valorCompra * 10) / 100;
//    desconto = valorCompra - resultado;
//    Console.WriteLine($"10% de desconto aplicado! o produto custa R$ {desconto}");
//}
//else
//{
//    Console.WriteLine($"Valor final: R$ {valorCompra}");
//}






//Operador Ternário (if, else)
//int idadeAluno = 25;
//string mensagem;

//if (idadeAluno >18)
//{
//    mensagem = "Maior de idade";
//}
//else
//{
//    mensagem = "Menor de idade";
//}
//mensagem = (idadeAluno >18) ? "Maior de idade" : "Menor de idade";



//Estruturas Condicionais (if/else)
//Estrutras de Repetição (repetem)

//while
//enquanto (condicao for verdade) { faz algo }

//peço senha, enquanto senha estiver errada, pergunta de novo
Console.WriteLine("Digite a senha: ");
string senha = Console.ReadLine();

while (senha != "vini")
{
    Console.WriteLine("Senha errada! digite novamente");
    senha = Console.ReadLine();
}

//do while

//for