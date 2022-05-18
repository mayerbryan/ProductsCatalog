
# Catálogo  de Produtos
Projeto de API criado usando ASP.Net

## Instalando os componentes necessários para executar a aplicação:

- Instalar Visual Studio ou Visual Studio Code https://visualstudio.microsoft.com/pt-br/downloads/
- Instalar DotNet Runtime https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime
- Instalar o `dotnet-ef`:
```
dotnet tool install --global dotnet-ef
```
- Instalar o Postman https://www.postman.com/downloads/

## Executando as migrações
Este app utiliza SQL lite para armazenar os dados durante o desenvolvimento. Para executar as migrações utilize o seguinte comando:
```
dotnet ef database update
```
Um arquivo chamado `app.db` será criado com o banco SQL lite.

## Executando a aplicação
Para iniciar a aplicação, execute o seguinte comando no terminal:
```
dotnet run
```
O resultado desse comando incluirá as URLs a serem utilizadas para acessar a API. Exemplo abaixo:
```
Now listening on: https://localhost:7143
Now listening on: http://localhost:5133
```

# Documentação da API

## Criação de produtos

Rota: `/v1/products`
Método: `POST`
Exemplo do corpo requisição para criar um novo produto:
```json
{
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```
Exemplo de resposta:
```
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Listar todos os produtos
Rota: `/v1/products`
Método: `GET`
```
Exemplo de resposta:
```
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```

## Listar produtos pelo Id
Rota: `/v1/products/{int:id}`
Método: `GET`
```
Exemplo de resposta:
```
{
    "Id": 1,
    "Name": "Produto teste",
    "SKU": "UTV12U1D2",
    "Price": "12.99",
    "Description": "Produto de teste"
}
```


