using System;
using System.Threading.Tasks;
using GitHubUserActivity.Services;
using GitHubUserActivity.Models;

            // Solicitar o nome de usuário ao usuário
            Console.Write("Digite o nome de usuário do GitHub: ");
            string username = Console.ReadLine();

            // Instanciar o GitHubService
            var gitHubService = new GitHubService();

            // Obter informações do usuário
            GitHubUser usuario = await gitHubService.ObterInformacoesUsuario(username);

            if (usuario != null)
            {
                // Exibir as informações filtradas
                Console.WriteLine("\nInformações do Usuário:");
                Console.WriteLine($"Nome: {usuario.Name ?? "Não informado"}");
                Console.WriteLine($"Bio: {usuario.Bio ?? "Não informada"}");
                Console.WriteLine($"Email: {usuario.Email ?? "Não informado"}");
                Console.WriteLine($"Tipo: {usuario.Type ?? "Não informado"}");
                Console.WriteLine($"Repositórios: {usuario.NumRepos}");
                Console.WriteLine($"Seguidores: {usuario.NumFollowers}");
                Console.WriteLine($"Seguindo: {usuario.NumFollowing}");
                Console.WriteLine($"Perfil: {usuario.HtmlUrl}");
                Console.WriteLine($"Localização: {usuario.Location ?? "Não informada"}");
                Console.WriteLine($"Repositórios URL: {usuario.ReposUrl}");
                Console.WriteLine($"Criado em: {usuario.CreatedAt:dd/MM/yyyy}");
                Console.WriteLine($"Última atualização: {usuario.UpdatedAt:dd/MM/yyyy}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado ou erro na requisição.");
            }

            System.Console.WriteLine("----------------------------------------------------------");

            List<GitHubRepository> repositories = await gitHubService.ObterRepositorios(username); 

            if(repositories != null && repositories.Count>0){
                Console.WriteLine($"Repositórios de {username}: ");

                foreach (var repo in repositories){
                     Console.WriteLine($"Nome: {repo.Name}");
                Console.WriteLine($"Descrição: {repo.Description}");
                Console.WriteLine($"URL: {repo.HtmlUrl}");
                Console.WriteLine($"Linguagem: {repo.Language}");
                Console.WriteLine($"Estrelas: {repo.StargazersCount}");
                Console.WriteLine($"Forks: {repo.ForksCount}");
                Console.WriteLine($"Criado em: {repo.CreatedAt}");
                Console.WriteLine($"Atualizado em: {repo.UpdatedAt}");
                Console.WriteLine("--------------");
                }


            } 
            else {
                
                Console.WriteLine("Nenhum repositório encontrado.");
            }
