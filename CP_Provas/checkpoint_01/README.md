
# CP1 - Advanced Business Development with .NET - 2026 (Fundamentos de Programação Orientada a Objetos)

===========================

Este projeto faz parte do CP1 da disciplina de desenvolvimento com .NET e tem como objetivo aplicar conceitos fundamentais de **Programação Orientada a Objetos (POO)** utilizando uma aplicação **Console em C#**.

O aluno deverá implementar um sistema simples de cálculo de impostos para diferentes tipos de pessoas, utilizando boas práticas de organização de código.

---

## 📜 Instruções Básicas

- 🔹 A checkpoint deverá ser desenvolvido individualmente
- 🔹 O tema é fixo: **Sistema de cálculo de imposto (Pessoa Física e Jurídica)**
- ❌ Se utilizar código de outro aluno sua nota será 0 (zero)
- ❌ Projetos iguais terão nota 0 (zero)
- ⚠️ O projeto deverá compilar, caso não compile sua nota será 0 (zero)
- 🤖 IA pode ser usada como apoio, mas o aluno deve entender o código

---

## 📽️ Criação do Projeto

### 🛠️ Passo a passo

1. 1. Realizar o clone do repositório da turma:

git clone https://gitlab.com/fiap-dotnet/2tdspo/2026/primeiro-semestre/checkpoint/checkpoint_01.git

2. Criar uma nova branch com seu RM:

```bash
git checkout -b RM123456
```

3. Certifique-se de que está na sua branch:

```bash
git branch
```

4. Desenvolver o projeto conforme os requisitos da CP1
5. Após finalizar, realizar o commit das alterações:
```bash
git add .  
git commit -m "CP1 - Implementação completa"
```

6. Enviar o código para o repositório:
```bash
git push origin RM123456
```

#### ⚠️ Observações importantes

- Cada aluno deve trabalhar **exclusivamente em sua própria branch**
- O nome da branch deve seguir o padrão: `RM + seu número`
- Não realizar commits na branch principal (`main` ou `master`)
- Certifique-se de que o projeto **compila antes de subir**

#### Criar a estrutura de pastas:
    
```
/Entities
    Pessoa.cs
    PessoaFisica.cs
    PessoaJuridica.cs
```

> **Desenvolver o projeto conforme os requisitos**

---

# 🎯 O QUE VOCÊ DEVE FAZER

===========================

## ✅ Criar uma aplicação Console que contenha:

- Um **menu interativo com `while`**
- Leitura de dados do usuário via `Console.ReadLine()`
- Deve conter as seguintes opções para o usuário:
    
    - `1` → Pessoa Física
    - `2` → Pessoa Jurídica
    - `0` → Sair

> **Obs:** Utilize `break` para sair do while e `continue` para seguir com processo.
        
---

## ✅ Implementar estrutura orientada a objetos:

### 🔹 Classe abstrata

- Criar uma classe:

```csharp
abstract class Pessoa
```

#### Requisitos:

- Propriedades **Devem ser protegidos**
    - Nome
    - Renda
- Método abstrato:

```csharp
public abstract decimal CalcularImposto();
```

---

### 🔹 Classes filhas

Criar:
- `PessoaFisica`
- `PessoaJuridica`

#### Requisitos:
- Devem herdar da classe `Pai`
- Devem ser `Protegidas para que outras classes não herdem de uma classe filha`
- Devem implementar `CalcularImposto()`

---

## ✅ Regras de negócio (OBRIGATÓRIO)

### 👤 Pessoa Física

A tabela fictícia apresentada deve ser utilizada como base para a implementação da regra de cálculo do imposto da **Pessoa Física**.

Observe as faixas de renda e aplicar a porcentagem correspondente para realizar o cálculo do imposto. Após o cálculo, o sistema deve **retornar o valor final do imposto e exibi-lo na tela** para o usuário.

Fluxo esperado é:

1. Receber a renda informada pelo usuário
2. Identificar em qual faixa da tabela essa renda se encaixa
3. Aplicar a porcentagem correspondente
4. Retornar o valor calculado
5. Exibir o resultado no console

|Renda|Imposto|
|---|---|
|Até 2000|0%|
|2001 até 5000|15%|
|Acima de 5000|27%|

---

### 🏢 Pessoa Jurídica

A tabela fictícia apresentada deve ser utilizada como base para a implementação da regra de cálculo do imposto da **Pessoa Jurídica**.

Observe as faixas de renda e aplicar a porcentagem correspondente para realizar o cálculo do imposto. Após o cálculo, o sistema deve **retornar o valor final do imposto e exibi-lo na tela** para o usuário.

Fluxo esperado é:

1. Receber a renda informada pelo usuário
2. Identificar em qual faixa da tabela essa renda se encaixa
3. Aplicar a porcentagem correspondente
4. Retornar o valor calculado
5. Exibir o resultado no console

|Renda|Imposto|
|---|---|
|Até 10000|16%|
|Acima de 10000|22%|

---

## ✅ Lógica do Programa

- Utilizar `while` para manter o sistema rodando e solicitando informações para o usuário
- Utilizar `switch` ou `if` para decisões
- Validar entradas do usuário
- Exibir o valor do imposto calculado
- Permitir saída com opção `0`

---

# 📊 O QUE SERÁ AVALIADO

============================

| Critério                               | Pontos  |
| -------------------------------------- | ------- |
| Uso correto de POO (Herança, Abstract) | 30      |
| Implementação do cálculo de imposto    | 20      |
| Uso de `while` e controle de fluxo     | 15      |
| Organização do código (pastas)         | 10      |
| Uso de Encapsulamento                  | 10      |
| Validação de entrada                   | 10      |
| Clareza e legibilidade                 | 5       |
| **Total**                              | **100** |

---

# 💡 DICAS IMPORTANTES

===============================

- Use nomes claros para classes e métodos
- Separe bem as responsabilidades
- Teste todas as opções do menu
- Evite repetir código
- Garanta que o sistema não quebre com entradas inválidas

---

# 📚 TECNOLOGIAS UTILIZADAS

===============================

- C#
- .NET 10
- IDE: `Visual Studio`  ou `Rider`
- Editor: `VsCode` ou qualquer um de sua preferência

---

# 📅 PRAZO DE ENTREGA

===============================

26 de Março de 2026

Entrega via portal FIAP com link do GitLab

---

# 📌 Fechamento

Esse CP avalia a base que você vai usar no resto da sua carreira em .NET:

- Herança
- Abstração
- Polimorfismo
- Estrutura de controle e Decisão
