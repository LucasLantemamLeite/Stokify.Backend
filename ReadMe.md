# Stokify.Backend

Stokify.Backend é o servidor da aplicação de mesmo nome, um gerenciador/simulador de estoque criado para simular um ambiente SaaS sem necessariamente ser um. A primeira versão foi feita em Python utilizando quatro arquivos de texto como "banco" de dados. Esta nova versão foi reescrita do zero, adotando padrões e arquiteturas mais avançadas para aplicar o conhecimento adquirido ao longo do último ano.

# Características

- **Monolítico**: Orquestrado por um único servidor central.
- **Multi-Tenant**: Suporte a múltiplas empresas/instâncias de forma isolada.

# Arquitetura

- **Clean Architecture**: Separação clara das camadas, responsabilidades e casos de uso.
- **Vertical Slice Architecture**: Organização de features por pasta ao invés de projetos.

# Patterns

- **Repository Pattern**: Abstração de serviços externos e acesso a dados.
- **Mediator**: Responsável por mediar handlers de forma desacoplada e dinâmica.

# Princípios

- **SOLID**: Para uma codificação mais robusta, escalável e sustentável.
- **CQRS**: Separação entre Command (escrita) e Query (leitura).

# Banco de dados

- Utiliza **PostgreSQL** pela simplicidade, confiabilidade e performance.

# Tecnologias

- Visual Studio Code
- ASP.NET 10
- Entity Framework Core
- Docker
- Beekeeper Studio
- Swagger
