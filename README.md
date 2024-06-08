# CleanArchMvc

![.NET Core](https://img.shields.io/badge/.NET-5/6/7/8-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Build Status](https://img.shields.io/badge/build-passing-brightgreen)

## Sobre o Projeto

Este projeto demonstra a implementação da arquitetura limpa (Clean Architecture) com ASP.NET Core, utilizando versões do .NET 5, 6, 7 e 8. O projeto é parte do curso oferecido pelo mestre José Macoratti.

## Estrutura do Projeto

O projeto é organizado em várias camadas para separar as preocupações e manter a arquitetura limpa:

- **CleanArchMvc.API**: Contém os controladores e a configuração da API.
- **CleanArchMvc.Application**: Contém a lógica de aplicação, incluindo interfaces, DTOs, serviços e mapeamentos.
- **CleanArchMvc.Domain**: Define as entidades do domínio, interfaces e regras de validação.
- **CleanArchMvc.Infra.Data**: Implementa o contexto de dados, configuração de entidades, migrações e repositórios.
- **CleanArchMvc.Infra.IoC**: Configura a injeção de dependências para o projeto.
- **CleanArchMvc.WebUI**: Contém a interface do usuário para o projeto web.

## Configuração e Execução do Projeto

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (5, 6, 7 ou 8)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

### Passos para Configuração

1. **Clone o repositório**

    ```bash
    git clone git@github.com:AndreFirstOrDefault/CleanArchitecture_Csharp.git
    cd CleanArchMvc
    ```

2. **Restaure os pacotes NuGet**

    ```bash
    dotnet restore
    ```

3. **Configure a string de conexão no arquivo `appsettings.json` do projeto `CleanArchMvc.API`**

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "YourConnectionStringHere"
      }
    }
    ```

4. **Execute as migrações**

    ```bash
    dotnet ef database update --project CleanArchMvc.Infra.Data
    ```

5. **Compile e execute o projeto**

    ```bash
    dotnet run --project CleanArchMvc.API
    ```

## Documentação

### CleanArchMvc.API

Esta camada contém os controladores e configurações específicas da API.

### CleanArchMvc.Application

- **DTOs**: Objetos de transferência de dados.
- **Interfaces**: Contratos para os serviços da aplicação.
- **Mappers**: Configuração de mapeamento entre entidades e DTOs.
- **Services**: Implementações dos serviços da aplicação.

### CleanArchMvc.Domain

- **Entities**: Entidades do domínio.
- **Interfaces**: Contratos de repositórios e outras abstrações do domínio.
- **Validation**: Regras de validação para as entidades do domínio.

### CleanArchMvc.Infra.Data

- **Context**: Configuração do contexto do Entity Framework.
- **EntitiesConfiguration**: Configurações específicas das entidades.
- **Identity**: Configuração da identidade do ASP.NET Core.
- **Migrations**: Migrações do banco de dados.
- **Repositories**: Implementações dos repositórios.

### CleanArchMvc.Infra.IoC

- **DependencyInjection**: Configuração da injeção de dependências para o projeto.

### CleanArchMvc.WebUI

Esta camada contém a interface do usuário para o projeto web.

## Contribuição

Contribuições são bem-vindas! Por favor, abra uma issue ou envie um pull request para discutir mudanças que você gostaria de fazer.

## Agradecimentos

Agradecimentos especiais ao mestre José Macoratti por fornecer o curso e compartilhar seu conhecimento sobre Clean Architecture.

---

Esse README deve fornecer uma visão geral clara do projeto, orientações de configuração e detalhes sobre a estrutura do projeto. Se você precisar de mais alguma informação ou ajuste, sinta-se à vontade para perguntar!
