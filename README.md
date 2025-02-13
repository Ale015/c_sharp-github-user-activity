# CLI GitHub User Activity

Uma aplicação CLI desenvolvida em C# que utiliza a API pública do GitHub para buscar e exibir informações de um usuário, incluindo detalhes do perfil e lista de repositórios.

## Funcionalidades
- Busca informações de perfil de um usuário do GitHub.
- Exibe lista de repositórios públicos do usuário.
- Informações detalhadas como nome, bio, email, localização, número de seguidores, repositórios, entre outros.

## Tecnologias Utilizadas

- C#
- .NET 7
- HttpClient para requisições HTTP
- Newtonsoft.Json para serialização e desserialização de JSON
- xUnit para testes unitários

## Estrutura do Projeto

### Models/: 
Contém os modelos GitHubUser e GitHubRepository que representam os dados retornados pela API.

### Services/: 
Contém o GitHubService responsável pelas requisições e obtenção de dados da API.

### Program.cs: 
Arquivo principal onde o usuário insere o nome do perfil e visualiza as informações formatadas.

## Como Executar

1. Clone o repositório:
`git clone https://github.com/SeuUsuario/github-user-activity.git`

2. Navegue até a pasta do projeto:
`cd github-user-activity`

3. 
Restaure as dependências:

`dotnet restore`

4. Execute o projeto:
`dotnet run`

### Exemplo de Saída

Digite o nome de usuário do GitHub: Ale015

Informações do Usuário:
Nome: Alexandre Júnior
Bio: Não informada
Email: Não informado
...

Testes

Para executar os testes, utilize o comando:
`dotnet test ./GitHubUserActivitySolution.sln`