# RadarFitAPI
Teste para o cargo de Tech Lead

Ambiente Dev:
Instalar o banco Postgress
https://www.enterprisedb.com/downloads/postgres-postgresql-downloads

Instalar o Visual Studio Community
https://visualstudio.microsoft.com/pt-br/vs/community/

Instalar O Docker Desktop
https://www.docker.com/products/docker-desktop/


Apos instalar todas as ferramentas, baixar o projeto no repositório
indico também utilizar o fork para melhorar a interação com o Git
https://git-fork.com/

Segue o link do repositório
https://github.com/miuchas/RadarFitAPI


Para rodar o projeto precisamos primeiro
Criar um banco no postgress

apos isso modifique a ConnectionString no arquivo "appsettings.json" do projeto API
e adicione os dados do banco ha ser utilizado

depois
Pelo Package Mananger Console
e rodar o comando "update-database"

se o Pelo Package Mananger Console não estiver visivel no visual Studio
Clique no menú View - Other Windows - Package Mananger Console

O projeto já esta configurado para buildar e rodar via docker
é só dar play e e tudo pronto


A Arquitetura do projeto é dividida até então em 4 camadas
A Camada Model Que é responsavel pelos modelos, entidades e view models
A camada DAO que é responsavel pela conexão e arquitetura do banco de dados
A camada BLL que é responsavel pela logica do sistema
A camada API que é responsavel por integrar as demais liberando as rotas da api
