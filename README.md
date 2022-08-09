# ProjectLiquid
Exemplo de geração de um projeto utilizando o framework Liquid da Avanade

## Exemplo passo a passo para gerar uma WebApi com "crud" completo:

1. Crie um diretório com o nome do projeto, neste caso ProjectLiquid;
2. Abra o PowerShell no novo diretório criado e execute o comando:<br>dotnet new liquidcrudsolution --projectName "ProjectLiquid" --entityName "Product" --entityIdType "int"
3. Execute o comando no PowerShell:<br>cd src
4. Execute o comando no PowerShell:<br>dotnet new liquiddbcontextproject --projectName ProjectLiquid --entityName Product
5. Execute o comando no PowerShell:<br>dotnet sln add ProjectLiquid.Repository/ProjectLiquid.Repository.csproj
6. Execute o comando no PowerShell:<br>cd ProjectLiquid.WebApi
7. Execute o comando no PowerShell:<br>dotnet add reference ../ProjectLiquid.Repository/ProjectLiquid.Repository.csproj
8. Execute o comando no PowerShell:<br>dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 5.0.13
9. Abra no Visual Studio a solução que está no diretório src: ProjectLiquid.Microservice.sln
10. Adicione no inicio do arquivo Startup.cs a seguinte linha:<br>using Microsoft.EntityFrameworkCore;
11. Adicione dentro do método ConfigureServices do arquivo Startup.cs a seguinte linha:<br>Action\<DbContextOptionsBuilder\> options = (opt) => opt.UseInMemoryDatabase("CRUD");
12.  Execute o comando no PowerShell:<br>dotnet add package Liquid.Repository.EntityFramework --version 2.*
13.  Adicione no inicio do arquivo Startup.cs a seguinte linha:<br>using Liquid.Repository.EntityFramework.Extensions;
14.  Adicione no inicio do arquivo Startup.cs a seguinte linha:<br>using ProjectLiquid.Repository;
15.  Adicione dentro do método ConfigureServices(abaixo da linha inserida no passo 10) do arquivo Startup.cs a seguinte linha:<br>services.AddLiquidEntityFramework<LiquidDbContext, ProductEntity, int>(options);
16.  Pronto, agora já pode executar no Visual Studio, a aplicação será aberta no browser, acrescente na url aberta no browser: /swagger para ver a documentação da api criada e também testá-la.
	
