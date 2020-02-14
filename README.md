# Lista de tarefas - API Rest .NET Core

A API foi publicada no Azure,link: https://crudmouraapi.azurewebsites.net/swagger/index.html

## A aplicação foi dividida em 3 camadas:

## API:
Nessa camada foi usada o AutoMapper para relacionar as ViewModels(DTOs) às entidades.</br>
Injeção de dependencia nativa.</br>
Versioning.</br>
Swagger.</br>

## Business:
Nessa camada foi escrita a Entidade, validação dessa entidade com FluentValidation.</br>
Também foi criado um conjunto de classes para armazenar notificações. Essas notificações serão usadas numa resposta customizada para a requisição.

## Data:
Para essa camada foi usado EntityFrameworkCore. </br>
Foi feito o mapeamento da entidade, gerado a migration através do DbContext e criado o banco de dados pela migration.
