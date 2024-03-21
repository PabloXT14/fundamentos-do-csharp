# .NET

## Instalação

Basta acessar o site oficial do .NET da Microsoft e baixar a versão compatível com a sua máquina.

## dotnet CLI

### CLI

- **CLI** é a sigla para Command Line Interface (Interface de Linha de Comando)
- Permite executar comandos adicionais pelo nosso terminal

### dotnet CLI

- Já vem por padrão quando instalamos o SDK do .NET em nossa máquina
- Definido pelo comando `dotnet`:
    - `dotnet --version`: verifica a versão atual
    - `dotnet --list-sdks`: lista os SDKs instalados
    - `dotnet --list-runtimes`: lista os runtimes instalados
    - `dotnet help`:
        - Exibe a ajuda
        - Lista os commandos disponíveis  

## VS Code

Editor de código que utilizaremos, mas você pode escolher outro de sua escolha que tenha suporte a linguagem C# e ao .NET

Link para baixar o Visual Studio Code (VS Code): [https://code.visualstudio.com/](https://code.visualstudio.com/)

Além disso, é recomendado você instalar também no VS Code a extensão para C# da Microsoft, para ter um melhor suporte a essa linguagem no VS Code.

## Tipos de projeto

- **Class Library**:
    - O resultado final é uma DLL
    - Não possui interface (pois é só uma biblioteca de classes)
- **Console Application**:
    - O resultado final é uma aplicação que roda no terminal
    - O resultado final é um EXE
    - Pode receber dados, e esperar inputs do usuário
- **Projeto Web**:
    - ASP.NET Web
    - ASP.NET MVC
    - ASP.NET WebAPI
- **Projeto Testes**:
    - Microsoft Tests
    - Ex: criar projetos de teste para o nosso app antes de mandar para o cliente, além de possibilitar deixar todos os testes automatizados. 

### Criando um novo projeto

- dotnet cli:
    - `dotnet new console`: Novo Console Application
    - `dotnet new classlib`: Novo Class Library
    - `dotnet new web`: Novo projeto ASP.NET Core
    - `dotnet new mvc`: Novo projeto ASP.NET Core
    - `dotnet new webapi`: Novo projeto ASP.NET Core
    - `dotnet new mstest`: Novo projeto Microsoft Test

- Definições:
    - Criar um projeto é o mesmo que gerar os arquivos iniciais de uma aplicação
    - Vai sempre gerar os arquivos na pasta atual
    - Para especificar uma pasta, podemos utilizar o `-o`
        - Ex: `dotnet new console -o MeuApp`
        - Vai criar uma nova pasta chamada `MeuApp` com os arquivos dentro

## Fluxo de execução

- `dotnet restore`: Restaura todos os pacotes que a aplicação precisa ser executada (baixa os pacotes necessários para a nossa aplicação executar)
- `dotnet build`: Compila a aplicação
- `dotnet clean`: Limpa as compilações anteriores
- `dotnet run`: Compila e executa a aplicação 

## Variáveis de ambiente

- É comum termos vários ambientes para as nossas aplicações:
    - Desenvolvimento (nossa máquina)
    - Homologação (ambiente de teste)
    - Produção (rodar a aplicação no cliente)
- Cada ambiente possui suas configurações:
    - Chaves de acesso externo
    - Conexões com banco de dados
- Desta forma, podemos dizer ao .NET qual ambiente estamos utilizando
    - `dotnet run --environment=$SEU_AMBIENTE`
        - `dotnet run --environment=development`
        - `dotnet run --environment=production`
    - O comando `run` não executa depuração (Debug)
        - Neste modo sua aplicação não vai parar nos Break Points (explicando adiante)

## Estrutura de um Console App

- Arquivo `.csproj`:
    - Formato XML
    - Definições do projeto
    - Presente em todo projeto .NET
- `Program.cs`:
    - Arquivo principal (C#)
    - Posta de entrada
    - Será o primeiro a ser executado

## Debug

- Veja a aula para mais detalhes práticos. 
