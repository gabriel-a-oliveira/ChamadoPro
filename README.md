# Gerenciamento de Chamados

> **Status do Projeto: Em Andamento**  
> Este projeto está em desenvolvimento e poderá sofrer alterações e melhorias contínuas.

Este backend, desenvolvido em C# utilizando ASP.NET Core e estruturado segundo os princípios da Clean Architecture, tem como objetivo principal a criação e gerenciamento de chamados, abrangendo módulos para a administração de usuários, categorias, anexos e tickets.

## Visão Geral

O sistema permite a criação, atualização e gerenciamento de chamados, integrando de forma organizada os módulos de:
- **Usuários:** Gerenciamento dos dados dos usuários do sistema.
- **Categorias:** Organização e classificação dos chamados.
- **Anexos:** Upload e gerenciamento de arquivos relacionados aos chamados.
- **Tickets:** Criação, edição e acompanhamento do status dos chamados.

## Status do Projeto

**Em andamento:** Este projeto está atualmente em desenvolvimento. As funcionalidades estão sendo implementadas e podem passar por alterações até a versão final.

## Estrutura do Projeto

O projeto está organizado seguindo a Clean Architecture, separando claramente as responsabilidades:

- **Domain:** Contém as entidades, interfaces e regras de negócio fundamentais.
- **Application:** Implementa os casos de uso e orquestra a lógica de negócio.
- **Infrastructure:** Responsável pela comunicação com o banco de dados, implementação de repositórios e serviços externos.
- **WebApi:** Exposição dos endpoints via ASP.NET Core, servindo como a camada de apresentação.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** ASP.NET Core
- **ORM:** Entity Framework Core
- **Banco de Dados:** SQL Server
- **Padrão Arquitetural:** Clean Architecture

## Funcionalidades

- **Gerenciamento de Usuários:** Operações CRUD para cadastro e atualização de usuários.
- **Gerenciamento de Categorias:** Criação e manutenção de categorias para organizar os chamados.
- **Gerenciamento de Anexos:** Upload, visualização e remoção de arquivos associados aos chamados.
- **Gerenciamento de Tickets:** Criação, atualização, listagem e acompanhamento do status dos chamados.

