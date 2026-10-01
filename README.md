# 🎮 GamerProfile

Um projeto simples em **C# .NET** desenvolvido para demonstrar a implementação de **testes unitários básicos** utilizando a framework **xUnit**. O projeto simula a lógica de negócio associada ao perfil de um jogador de videojogos.

## 🛠 Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET 10.0
- **Testes:** xUnit

## 📂 Estrutura do Projeto

A solução é composta por dois projetos principais:

```
GamerProfile.slnx
├── GamerProfile.App/          # Biblioteca de classes com a lógica principal
│   └── PerfilJogadorService.cs
└── GamerProfile.Tests/        # Projeto de testes xUnit
    └── PerfilJogadorServiceTests.cs
```

- **GamerProfile.App:** biblioteca de classes que contém a lógica principal. Inclui a classe `PerfilJogadorService.cs`.
- **GamerProfile.Tests:** projeto de testes em xUnit que verifica o correto funcionamento da aplicação, centralizado no ficheiro `PerfilJogadorServiceTests.cs`.

## ✨ Funcionalidades (`PerfilJogadorService`)

O serviço base da aplicação implementa as seguintes regras de negócio:

| Método | Descrição |
|---|---|
| `GerarTagUsuario` | Recebe um nome (nickname) e um código, concatenando-os com um `#` para gerar a tag oficial do utilizador (ex: `Aragorn#1042`). |
| `CalcularXPTotal` | Soma a experiência (XP) obtida na fase 1 e na fase 2, adicionando um bónus fixo de conclusão de **100 pontos**. |
| `ElegivelParaRanked` | Valida se um jogador atingiu o nível mínimo necessário (**nível 15 ou superior**) para participar em partidas classificativas. |

## 🚀 Como Executar os Testes

### Pré-requisitos

Certifica-te de que tens o [.NET SDK](https://dotnet.microsoft.com/download) instalado na tua máquina.

### Passos

1. Abre o terminal ou a linha de comandos na **pasta raiz do projeto** (onde se encontra o ficheiro `GamerProfile.slnx`).

2. Para restaurar dependências e compilar o código, executa:

   ```bash
   dotnet build
   ```

3. Para correr a suite de testes unitários, utiliza:

   ```bash
   dotnet test
   ```
