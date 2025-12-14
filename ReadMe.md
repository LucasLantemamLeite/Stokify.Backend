# Stokify.Backend

Stokify.Backend é a parte do servidor monolítico da aplicação de mesmo nome, é um projeto de portfólio que serve para simular um SaaS mult-tenant. O projeto nasceu a partir de uma versão experimental criada em Python com Streamlit e arquivos de texto como persistência, que nunca chegou à produção. Esta nova versão está sendo desenvolvida em ASP.NET com foco em boas práticas de backend e regras de negócio claras.

---

### Características

- **Monolítico**: Um único servidor central responsável por orquestrar as regras de negócio.
- **Single-tenant (inicial)**: Desenvolvimento inicial focado em um único tenant.
- **Preparado para multi-tenant**: Estrutura pensada para futura separação por empresa.
- **API-first**: O sistema não depende de frontend para funcionar.

---

### Arquitetura

- **Clean Architecture**

  - Separação clara de responsabilidades por camadas.
  - Dependências apontam de fora para dentro.
  - Regras de negócio isoladas da infraestrutura.

- **Vertical Slice Architecture**

  - Organização por feature ao invés de organização puramente técnica.
  - Cada funcionalidade concentra seus contratos, handlers e validações.

---

### Padrões de Projeto

- **Repository Pattern**

  - Abstração de acesso a dados e serviços externos.
  - Redução do acoplamento entre domínio e infraestrutura.

---

### Tecnologias e Ferramentas

- ASP.NET 10
- Docker
- Entity Framework Core
- Swagger / OpenAPI
- Beekeeper Studio

---

### Execução

### Rodando via Dockerfile

> Em progresso

### Rodando via Docker Compose

> Em progresso

---

### Status do Projeto

> Em desenvolvimento
