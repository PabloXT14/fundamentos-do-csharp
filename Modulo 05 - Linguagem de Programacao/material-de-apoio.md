# Linguagem de Programação com C#

## Notas importantes

- Não utilize espaços nem caracteres especiais na criação do programa:
    - Bons: `MeuApp`, `Pedidos`, `MinhaApp`
    - Ruins: `Meu App`, `$APP`, `App #Test`
- Tentar utilizar caminhos curtos e sem caracteres especiais:
    - Bons: `C:\dev`, `C:\apps`
    - Ruins: `C:\Caminho com espaços e caracteres especiais\Meu App`
- Evite caminhos de rede:
    - Se possível utilize o `C:\`
- O C# é Code Sensitive:
    - Isto significa que ele diferencia maiúsculas de minúsculas
    - Ex: `Teste` é diferente de `test`

## Escopo de um programa

- O escopo de um programa refere-se ao contexto em que as variáveis e funções são definidas e podem ser acessadas.
- Ele determina onde no código uma variável ou função pode ser usada e se outras partes do código podem interagir com ela.
- O escopo pode ser global (acessível em todo o programa) ou local (restrito a partes específicas do código)
- Em C# o fluxo de um escopo possui basicamente a seguinte estrutura:
    - Importações
    - Namespaces
    - Classe
    - Método Principal

Aqui temos um exemplo da Sequência Fibonacci implementada em C#:

```cs
using System;
using System.Linq;

namespace FibonacciTest
{
    public class Program
    {
        public static void Main()
        {
            // CODE CHANGES
            foreach (var i in FibonacciGenerator.Fibonacci().Take(20))
            {
                Console.WriteLine(i);
            }
        }
    }
}
```

## Namespace

- Enquanto as pastas e arquivos são as divisões físicas
- Os namespaces são as divisões lógicas
- Assim como não podemos ter dois arquivos com mesmo nome nas pastas
- Não podemos ter duas classes com o mesmo nome em um namespace
- O ideal é ter apenas um namespace e uma classe por arquivo
- O escopo de um namespace é definido entre CHAVES
    - Classes e métodos também
- Um namespace pode ser reutilizado
    - Pode estar presente em diversos arquivos
- Podemos criar quantos namespaces quisermos
- Não devem conter espaços ou caracteres especiais
- Toda palavra no namespace começa com maiúsculo
- Podemos ter um namespace dentro de outro usando `.`
- A importação que vimos anteriormente é feita pelos namespaces
- Normalmente acompanham os nomes das pastas
- Durante a execução/compilação, todos os arquivos do C# serão unificados
- A divisão física se perderá
- Sobrará apenas a divisão lógica, que são os namespaces

## Using

- Importações definem as bibliotecas que nosso programa irá utilizar
- Por padrão só o básico vem incluso
- Precisamos importar o que desejamos para poder trabalhar
- Isto é feito no começo do programa
- Utilizamos a palavra-chave reservada `using` para isso
- Organizar nosso código em pastas e namespaces é fundamental
- Em aplicações grandes, o volume de código é alto
- A quantidade de arquivos é alta
- E o número de pessoas trabalhando no mesmo projeto também
- Entender bem esta organização é fundamental
- Use e abuse da criação de arquivos e namespaces

## Variáveis

- Uma variável é algo que utilizamos para armazenar uma informação
- Ser variável significa que seu valor pode ser alterado a qualquer momento
- Ou seja, ele pode variar
- Sempre que "criamos"/"instanciamos" uma variável, dizemos que estamos inicializando ela
- Podemos usar um TIPO ou palavra-chave reservada `var` para criar uma variável
- Vamos aprender ainda sobre tipos de dados
- No C# o tipo vem sempre antes do nome da variável
- Podemos informar um valor já na criação da variável
- Se não informado o valor padrão será aplicado

Exemplo:
```cs
int idade; // Correto, inicia com ZERO
int idade = 25; // Correto, inicia com 25
var idade = 25; // Correto, inicia com 25
var idade; // Errado
```

Padronização de Nomes:
- Utilize nomes coesos
- Não utilize caracteres especiais ou espaços
- Não comece com números
- A primeira letra de cada palavra é **SEMPRE** minúscula 

## Constantes

- Assim como as variáveis, também utilizamos uma constante para armazenar uma informação
- As constantes NÃO PODEM ser alteradas
- Uma vez criadas somos obrigados a atribuir um valor
- Feito isso elas não poderão ser modificadas novamente
- Não funcionam com a utilização de `var`
- São mais otimizadas que as variáveis
- Recomendadas para usos frequentes
- A definição de constante é dada pela palavra-chave reservada `const` antes do tipo
- Caso não seja informado um valor, o valor padrão será atribuído

Exemplo:
```cs
const int IDADE_MINIMA; // Correto inicia com ZERO
const int IDADE_MINIMA = 25; // Correto inicia com 25
const var IDADE_MINIMA = 25; // Errado
const var IDADE_MINIMA; // Errado
```

Padronização de Nomes:
- Utilize nomes coesos
- Não utilize caracteres especiais ou espaços
- Não comece com números
- É comum vermos constantes todas em maiúsculas, separadas por `_`
- A ideia é bater o olho no código e saber que aquilo é uma constante

## Palavras reservadas

- Também chamados de **keywords** (palavras-chave)
- São palavras de uso exclusivo do C#
- Não podemos utilizar como nomes de variáveis ou constantes
- O Visual Studio Code vai te avisar sobre elas

Tabela de keywords:
![Tabela de keywords do C# 01](./assets/keywords.png)
![Tabela de keywords do C# 02](./assets/keywords-02.png)

## Comentários

- Em diversos cenários você precisará deixar uma mensagem
- Essa mensagem não deve ser executada pelo programa
- É comum utilizarmos comentários em linhas que não desejamos executar também
- Podemos ter comentários de:
    - Uma linha
    - Múltiplas linhas
    - XML (Metadata)

Exemplo:
```cs
// Comentário em uma linha

/*
    Comentário em várias
    linhas
*/

/// Notação XML (Metadata)
```

## Tipos primitivos

- Também conhecidos como `build-in-types`
- São tipos de dados base cujo os outros tipos (`complexos`) irão derivar
- Definir o tipo correto otimiza a execução do programa
- Também são chamados de **Tipos de Valor**
- Armazenam um valor e não a referência para um item na memória
- São classificados em:
    - Tipos Simples (`Simple Types`)
    - Enumeradores (`Enums`)
    - Estruturas (`Structs`)
    - Tipos Nulos (`Nullable Types`) 
- Cada tipo possui uma capacidade (de quando de dado ele consegue conter/guardar)
- Caso esta capacidade exceda, o programa gera um erro
- Esta capacidade pré-definida ajuda na otimização do seu programa
- Por exemplo, o `int` que usamos previamente:
    - `-2,147,483,648` até `2,147,483,647`

## System

- No .NET tudo começa de um tipo base chamado `system`
- Todo e qualquer tipo, seja `build-in` ou `complexo` deriva dele
- Ele é a base de todos os objetos no .NET
- Não precisamos nos preocupar em usá-lo ou qualquer coisa similar
- Seu uso já é implícito

## Byte

- É um tipo primitivo (`build-in`)
- O tipo `byte` é utilizado para representar um byte de fato (ou seja, qualquer combinação de 8 bits)
- Em diversos casos precisamos da cadeia de bytes de um arquivo, por exemplo
    - Também chamado de `byte array`
- Temos também o `sbyte`, que permite valores negativos

> **Signed** e **Unsigned**
>
> Valores com sinal como `-` por exemplo, são chamados de signed. 

- 1 byte (8-bit)
    - 0 até 255
- 1 sbyte (8-bit)
    - -128 até 127

> Note que o `sbyte` permite valores negativos, por isso no nome `sbyte`, que significa **Signed Byte**

## Números Inteiros

- Números inteiros, ou seja, sem pontuação, podem ser definidos pelos tipos:
    - `short/ushort`
    - `int/uint`
    - `long/ulong`
- Assim como temos o `signed` nos `bytes`, nos números por padrão são permitidos valores negativos
- Então usamos o `unsigned` para definir que o mesmo não pode receber valores negativos
- O tipo `int` é o mais comum a ser encontrado
- short (16-bit)
    - `-32,768` até `32,767`
- ushort (16-bit)
    - `0` até `65,535`
- int (32-bit)
    - `-2,147,483,648` até `2,147,483,647`
- uint (32-bit)
    - `0` até `4,294,967,295`
- long (64-bit)
    - `-9,223,372,036,854,775,808` até `9,223,372,036,854,775,807`
- long (64-bit)
    - `0` até `18,446,744,073,709,551,615`

## Números Reais

- São números que exigem uma maior precisão, ou seja, com pontuação:
    - `float` (Notação F)
    - `double`
    - `decimal` (Notação M)
- Possuem assimilação negativa e positiva por padrão, dispensando o uso do signed/unsigned em seus tipos
- Ocupação:
    - float (32-bit)
        - `-3.402823e38` até `3.402823e38`
    - double (64-bit)
        - `-1.79769313486232e308` até `1.79769313486232e308`
    - decimal (128-bit)
        - (+ ou -) `1.0 x 10e-28` até `7.9 x 10e28`

## Boolean

- Tipo booliano, armazena apenas `true` ou `false` (verdadeiro ou falso)
- Definido pela palavra reservada `bool`
- bool (8-bit)
    - `true` ou `false`

## Char

- Utilizado para armazenar apenas um caractere no formato Unicode
- Definido pela palavra reservada `char`
- A atribuição de um valor char é dado por **aspas simples**
- char (16-bit)
    - Qualquer caractere

## String

- Armazena uma cadeia de caracteres
- Podemos pensar nele como uma lista de `char`
- Definido pela palavra reservada `string`
- A atribuição de um valor string é dado por **aspas duplas**
- string (?)
    - Como é uma cadeia de caracteres seu tamanho pode variar

## Var

- Substitui o nome de um tipo
- Será do tipo do primeiro valor atribuído
- Recomendado o uso
    - Deixe para usar o `var` somente quando dominar os tipos de dados básicos

Exemplo:
```cs
var idade = 25; // Será do tipo int
var nome = "André"; // Será do tipo string
```

## Object

- Tipo genérico que recebe qualquer valor ou objeto
- Para caso não saiba o tipo da informação ou ela seja de vários tipos diferentes
- Não possui intellisense (ajuda/autocomplete do editor) por ser um tipo desconhecido
- Evite usar

Exemplo:
```cs
object idade = 25; // Será do tipo object
object nome = "André"; // Será do tipo object
```

## Nullable Types

- Significa vazio, nada
- Diferente de zero ou uma string vazia
- Todo tipo, primitivo ou complexo pode receber o valor `null`
- O tipo deve ser marcado como Nullable Type
- Podemos atribuir `null` a um objeto
- Desde que o mesmo seja marcado como nullable
    Usando **interrogação** na frente do tipo
- Se uma chamada a um valor nulo for feita um erro será apresentado

Exemplo:
```cs
int? idade = null;
```

## Alias

- Alias é um **apelido** que todo tipo no .NET tem
- Por exemplo:
    - `System.String` tem o alias `string`
    - E como você já percebeu nós vimos e utilizamos esse alias anteriormente
- Como o C# é Case Sensitive, tanto faz escrevermos um ou outro
- Porém, o recomendado é sempre usar o `alias`
- No caso abaixo o resultado é o mesmo
    - Com alias escrevemos menos

Exemplo:
```cs
int idade = 25; // Alias
Int32 idade = 25; // Tipo
```

## Valores Padrões

- Todo tipo `built-in` (primitivo), já possui um valor padrão
- Se nenhum valor for informado, seu valor padrão será utilizado:
    - int => `0`
    - float => `0`
    - decimal => `0`
    - bool => `false`
    - char => `\0`
    - string => `""`

## Conversão Implícita

- É comum precisarmos transformar um dado do tipo X para o tipo Y
- Exitem dois tipos de conversão, as implícitas e explícitas
- As implícitas são conversões que:
    - Podem ser executas apenas com passagem de dados
    - Possuem tipos compatíveis

Exemplo:
```cs
float number1 = 25.8f;
int number2 = 25;

number1 = number2; // Conversão implícita 
```

- A conversão anterior ocorreu pois um número real pode receber um número inteiro
- Porém, o contrário não aconteceria, pois:
    - Um número inteiro não tem pontuação
    - Logo ele não poderia receber um número real
- A conversão só ocorrerá se:
    - O tipo de dado for compatível
    - O tamanho do dado for compatível
- Em caso de números a precisão pode ser alterada
- Qualquer situação adversa causará erro
- Tipos compatíveis:
    - `sbyte`:
        - Aceita: short, int, long, float, double, decimal
    - `byte`:
        - Aceita: short, ushort, int, uint, long, ulong, float, double, decimal
    - `short`:
        - Aceita: int, long, float, double, decimal
    - `ushort`:
        - Aceita: int, uint, long, ulong, float, double, decimal
    - `int`:
        - Aceita: long, float, double, decimal 
    - `uint`:
        - Aceita: long, ulong, float, double, decimal
    - `long`:
        - Aceita: float, double, decimal
    - `ulong`:
        - Aceita: float, double, decimal
    - `char`:
        - Aceita: ushort, int, uint, long, ulong, float, double, decimal
    - `float`:
        - Aceita: double 

## Conversão Explicita

- Ocorre quando os tipos não são compatíveis
- É dada pelo uso do tipo entre parênteses antes da atribuição
- Segue as mesma regras anteriores de compatibilidade
- Caso haja alguma incompatibilidade, gera um erro (em tempo de execução, ou seja, em produção ou quando nosso código já passou pelo processo de compilação)
- Por conta disso, esse tipo e conversão não é tão recomendado

Exemplo:
```cs
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro; // Conversão explícita
```

## Parse

- Método presente em todo tipo primitivo
- Usado para converter um caractere ou string para um tipo qualquer
- Caso haja alguma incompatibilidade, gera um erro (somente em tempo de execução), por isso devemos tomar cuidado com o seu uso.

Exemplo:
```cs
int inteiro = int.Parse("100")
```

## Convert

- Similar ao `parse` visto anteriormente
- Porém permite converter vários tipos de valor
    - Não apenas string
- Devemos informar o tipo na chamada da conversão
- Caso haja alguma incompatibilidade, gera um erro (somente em tempo de execução), por isso devemos tomar cuidado com o seu uso.

Exemplo:
```cs
int inteiro = Convert.ToInt32("100");
```

## Operadores Aritméticos

- Soma => `+`
- Subtração => `-`
- Multiplicação => `*`
- Divisão => `/`
- Multiplicação e divisão são executadas primeiro
- Caso queira executar em outra ordem, utilizar parênteses
- Aceita `short`, `int`, `long`, `float`, `double` e `decimal`
- Em caso de uso de números inteiros
    - Se o valor for real, será arredondado
    - 4.4 => 5

Exemplo:
```cs
int sum = 25 + 22; // 47
int subtraction = 25 - 22; // 3
int multiplication = 25 * 22; // 550
int division = 22 / 5; // 4 - Foi arredondado 
```

- Utilizamos parênteses para redefinir a ordem de execução

Exemplo:
```cs
int x = 2 + 2 * 2; // 6
int y = 2 + (2 * 2); // 6 - Mesmo do anterior
int z = (2 + 2) * 2; // 8 - Executou a soma primeiro
```

## Operadores de Atribuição

- Utilizamos o igual (`=`) para atribuir um valor
- Porém, podemos utilizar o igual junto a um operador aritmético
- `x += 5` é o mesmo que `x = x + 5`

Exemplo:
```cs
int x = 0; // Atribuição
x += 5; // x = x + 5
x -= 1; // x = x - 1
x *= 10; // x = x * 10
x /= 2; // x = x / 2
```

## Operadores de Comparação

- Podemos comparar qualquer tipo de dado
    - Números, strings, byte, ...
- A comparação **SEMPRE** retorna verdadeiro ou false
    - `True` ou `False`
- Operações:
    - Igual => `==`
    - Diferente => `!=`
    - Maior que => `>`
    - Menor que => `<`
    - Maior ou igual a => `>=`
    - Menor ou igual que => `<=`

Exemplo:
```cs
int x = 25;
x == 0; // False
x != 0; // True
x > 0; // True
x < 0; // False
x >= 0; // True
x <= 0; // False
```

## Operadores Lógicos

- Usados para operações condicionais
- Retorna **SEMPRE** verdadeiro ou falso
- AND (E):
    - Deve atender todas as condições para dar verdadeiro
    - Símbolo => `&&`
- OR (OU):
    - Se atender pelo menos uma condição já retorna verdadeiro
    - Símbolo => `||`
- NOT (NEGAÇÃO):
    - Símbolo => `!`

Exemplo:
```cs
int x = 12;
bool between = (x > 25) && (x < 40); // False
bool or = (x > 25) || (x < 40); // True
bool not = !(x < 25); // False
```

## Estrutura Condicional: If e Else

### If

- Tradução: "SE", ou seja, "caso alguma condição seja atendida"
- Utilizado para a tomada de decisões
- Utiliza os operadores lógicos

### Else

- Complemento ao `if`
- Caso a condição no `if` não seja atendida
- Podemos ter também:
    - `else if(condição)`
    - Não tem limites (Mas cuidado)
- Podemos ter apenas um `else` para executar algo caso a condição seja atendida

### Exemplos

Exemplo `if`:
```cs
if(condicao) { // Executa caso seja verdadeiro
    ...
}

if(condicao) // Caso só haja uma linha, não precisa de chaves
    ...
``` 

Exemplo `else`:
```cs
if(condicao) { // Executa caso seja verdadeiro
    ...
} else { // Executa caso seja falso
    ...
}

if(condicao) // Caso só haja uma linha, não precisa de chaves
    ...
else // Caso só haja uma linha, não precisa de chaves
    ...
```

Exemplo `else if`:
```cs
if(condicao) { // Executa caso seja verdadeiro
    ...
} else if(outraCondicao) { // Senão, testa outra condição 
    ...
} else if(outraCondicao) { // Senão, testa outra condição
    ...
} else { // Se não acontecer nenhuma das anteriores
    ...
}
```

## Estrutura Condicional: Switch

- Utilizado quando temos muitas decisões
- Executado em cascata
- Devemos parar manualmente a execução com o comando `break`
- Possui uma execução padrão chamada `default`

Exemplo:
```cs
int value = 1;
switch(value)
{
    case 1: Console.WriteLine("1"); break;
    case 2: Console.WriteLine("2"); break;
    case 3: Console.WriteLine("3"); break;
    default: Console.WriteLine("4"); break; // Se não for 1, 2 ou 3
}
```

## Laços de Repetição: For

- Um **laço de repetição** consiste em executar uma determinada ação várias vezes
- Neste tópico vamos abordar o laço de repetição `for` (definido por essa mesma palavra-chave)
- Tradução de `for` é "para", ou seja, para cada item em um valor...
- Exige 3 parâmetros:
    - `Contador`
    - `Condição`
    - `Incremento`

Exemplo de sintaxe:
```cs
for (var i = 0; i <= 5; i++)
{
    // Condição que irá executar para cada item
}
```

Exemplos de utilização:
```cs
// Conta de 0 a 5
for (var i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Conta de 1 a 5
for (var i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Conta de 0 a 4
for (var i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// Conta de 5 a 0
for (var i = 5; i >= 0; i--)
{
    Console.WriteLine(i);
}
```

## Laços de Repetição: While

- Definido pela palavra-chave `while`
- Tradução: "Enquanto"(while), ou seja, enquanto uma condição for verdadeira...
- Exige apenas uma condição
- Checa a condição **ANTES** de executar
- **Atenção:** preste atenção à condição, pois pode cair em um loop infinito

Exemplos:
```cs
var value = 0;

// Conta de 0 a 5
// Exibe de 0 a 5 na tela
while (value <= 5)
{
    Console.WriteLine(value);
    value++;
}

// Conta de 0 a 5
// Exibe de 1 a 6 na tela
value = 0;
while (value <= 5)
{
    value++;
    Console.WriteLine(value);
}

// Loop Infinito
value = 0;
while (true)
{
    valor++;
    Console.WriteLine(value);
}
```

## Laços de Repetição: Do/While

- Definido pela palavra-chave `do/while`
- Tradução: "Faça", ou seja, realiza uma ação enquanto...
- Exige apenas uma condição no `while`
- Checa a condição **DEPOIS** de executar pelo menos uma vez

Exemplo:
```cs
var value = 0;

// Conta de 0 a 5
do
{
    Console.WriteLine(value);
    value++;
} while (value <= 5);
```

## Funções ou Métodos

- Podemos segmentar nosso programa em funções
- Também conhecidos como métodos
- O `main` é um exemplo de método
- Possui um `retorno`, um `nome` e `parâmetros`
- Esta composição é chamada de assinatura
- Padronização de nomenclatura: Começam sempre com maiúsculas

Exemplo 1:
```cs
static void Main(string[] args)
{
    // Invocação do método
    MeuMetodo("C# é legal!");
}

// Definição do método
static void MeuMetodo(string parametro)
{
    Console.WriteLine(parametro);
}
```

Exemplo 2:
```cs
static void Main(string[] args)
{
    // Invocando método
    // Armazenando o valor em uma variável
    var nome = RetornaNome("John", "Doe");

    // Imprime o nome na tela
    Console.WriteLine(nome);
}

// Definição de método
// Retorna uma string e recebe vários parâmetros
static string RetornaNome(string nome, string sobrenome)
{
    // Retorna o nome e sobrenome
    return $"{nome} {sobrenome}";
}
```

## Value Types & Reference Types

### Heap e Stack

- A memória é dividida em duas partes,  `Heap`(monte) e `Stack`(pilha)
- `Heap` armazena os dados
- `Stack` armazena as referências para os dados

### Value Types

- Qualquer tipo no .NET é tratado como:
    - Tipo de Referência (`Reference Type`)
    - Tipo de Valor (`Value Type`)
- Tipos de valor armazenam dados
- São armazenados em um local da memória chamada `Stack`
- Quando armazenamos um valor, a memória é alocada
- Este espaço armazena o dado criado
- Nossa variável acessa esta dado diretamente
- Se assimilarmos uma variável do tipo de valor (`Value Types`) a outra:
    - O valor será **COPIADO**
    - Ambas serão independentes
- Exemplos de `Value Types`: `Built-in`, `Structs`, `Enums`
- O `Garbage Collector` não acessa a `Stack`

> Garbage Collector(Coletor de lixL): ferramenta de uma linguagem de programação para desalocar da memória valores/dados que não estão sendo mais utilizados. São importantes para otimizar a nossa aplicação, deixando-a mais performática.

Exemplo:
```cs
// Exemplos de Value Types
int x = 25;
int y = x; // Y é uma cópia de X (mas tem um lugar independente para sí na memória)
Console.WriteLine(x); // 25
Console.WriteLine(y); // 25
x = 32; // Somente X foi alterado
Console.WriteLine(x); // 32
Console.WriteLine(y); // 25
```

### Reference Types

- Armazenam o endereço do objeto que contém os dados
- Não armazena os dados em si
- São armazenados em um local da memória chamado `Heap`(monte)
- Ao assimilar um variável:
    - Criará uma **referência**
    - Aponta para a mesma informação (mesmo local na memória)
    - Não são independentes
- Quando não mais utilizados são marcados para exclusão
- `Garbage Collector` passa removendo todos eles
- Exemplos de `Reference Types`: `Classes`, `Objects`, `Arrays`, ...

Exemplo:
```cs
var arr = new string[2];

arr[0] = "Item 1";
var arr2 = arr; // Não cria uma cópia

Console.WriteLine(arr[0]); // Item 1
Console.WriteLine(arr2[0]); // Item 1

// Altera as duas listas
arr[0] = "Item alterado";
Console.WriteLine(arr[0]); // Item alterado
Console.WriteLine(arr2[0]); // Item alterado 
```
