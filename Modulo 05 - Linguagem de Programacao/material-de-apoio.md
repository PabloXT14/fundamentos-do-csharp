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
