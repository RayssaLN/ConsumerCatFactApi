# ConsumerCatFactApi

## Informações Acadêmicas

- **Aluno:** Rayssa Leal Nascimento
- **RA:** 12419301
- **Unidade Curricular:** UDWMJ
- **Instituição:** UniBH – Engenharia de Software
- **Período:** 6º Período

---

## Descrição

Aplicação console desenvolvida em **C# (.NET 10)** que consome a API pública [Cat Fact Ninja](https://catfact.ninja/fact) para obter curiosidades aleatórias sobre gatos.

O programa realiza uma requisição HTTP GET à API, deserializa a resposta JSON e exibe no terminal o fato retornado junto com o seu tamanho em caracteres.

## Tecnologias Utilizadas

- C# / .NET 10
- `System.Net.Http` (HttpClient)
- `System.Text.Json` (serialização/deserialização JSON)

## Como Executar

```bash
dotnet run
```

## Exemplo de Saída

```
--- Fato sobre Gatos ---
Fato: Cats have over 20 vocalizations, including the purr, chirp, and hiss.
Tamanho: 72 caracteres
```

## Estrutura do Projeto

| Arquivo | Descrição |
|---|---|
| `Program.cs` | Ponto de entrada da aplicação; realiza a chamada à API e exibe o resultado |
| `CatFact.cs` | Classe modelo que representa a resposta JSON da API |
| `ConsumerCatFactApi.csproj` | Arquivo de projeto .NET |
