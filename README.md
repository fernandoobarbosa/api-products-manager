# Api de Produtos

O cliente desta aplicação está no repositório : <br />
 https://github.com/fernandoobarbosa/cliente-products-manager <br /> 
assim como sua documentação

## Requisitos 

    * Visual Studio 2019 16.8 ou posterior com a carga de trabalho ASP.NET desenvolvimento para a Web
    * SDK do .NET 5,0 ou posterior

# API 

Exemplos de chamadas da API

## Obter lista de produtos

### Request

`GET api/Products/`

    curl --location --request GET 'https://localhost:44339/api/Products/'

### Response

[![Generic badge](https://img.shields.io/badge/200-Ok-<COLOR>.svg)](https://shields.io/)

      [
       {
           "id": "60d9c58851794d90f0f1d75a",
           "name": "MasterBall",
           "price": 12344,
           "description": "Master!",
           "imageUrl": "https://smallimg.pngkey.com/png/small/156-1564817_master-ball-master-ball-pokemon-icon.png",
           "tags": [
               {
                   "name": "Master"
               },
               {
                   "name": "Bola"
               }
           ]
       },
       {
           "id": "60d9faf4327e63346711b2d8",
           "name": "Pokebola",
           "price": 1222,
           "description": "Um belo produto",
           "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
           "tags": [
               {
                   "name": "pokemon"
               },
               {
                   "name": "bola"
               }
           ]
       }
    ]

## Criar um novo produto

### Request

`POST api/Products/`

        curl --location --request POST 'https://localhost:44339/api/Products' \
      --header 'Content-Type: application/json' \
      --data-raw '{
          "name": "Pokebola",
          "price": 1222,
          "description": "Um belo produto",
          "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
          "tags": [
              {
                  "name": "pokemon"
              },
              {
                  "name": "bola"
              }
          ]
      }'

### Response

[![Generic badge](https://img.shields.io/badge/201-Created-<COLOR>.svg)](https://shields.io/)


    {
    "id": "60d9faf4327e63346711b2d8",
    "name": "Pokebola",
    "price": 1222,
    "description": "Um belo produto",
    "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
    "tags": [
        {
            "name": "pokemon"
        },
        {
            "name": "bola"
        }
    ]
      }


## Criar 10.000 produtos

### Request

`POST api/Products/CreateBatch`

        curl --location --request POST 'https://localhost:44339/api/Products/CreateBatch' \
      --header 'Content-Type: application/json' \
      --data-raw '{
          "name": "Pokebola",
          "price": 1222,
          "description": "Um belo produto",
          "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
          "tags": [
              {
                  "name": "pokemon"
              },
              {
                  "name": "bola"
              }
          ]
      }'

### Response

[![Generic badge](https://img.shields.io/badge/201-Created-<COLOR>.svg)](https://shields.io/)


    {
    "id": "60d9faf4327e63346711b2d8",
    "name": "Pokebola",
    "price": 1222,
    "description": "Um belo produto",
    "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
    "tags": [
        {
            "name": "pokemon"
        },
        {
            "name": "bola"
        }
    ]
      }
      
      
## Obter um produto específico

### Request

`GET /api/Products/id`

    curl --location --request GET 'https://localhost:44339/api/Products/60da31e86319b657a23cd152' \
    --header 'Content-Type: application/json'

### Response

[![Generic badge](https://img.shields.io/badge/200-Ok-<COLOR>.svg)](https://shields.io/)

        {
        "id": "60da31e86319b657a23cd152",
        "name": "Pokebola",
        "price": 1222,
        "description": "Um belo produto",
        "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
        "tags": [
            {
                "name": "pokemon"
            },
            {
                "name": "bola"
            }
        ]
    }

## Atualizar as informações de um produto
### Request

`PUT api/Products/id`

    curl --location --request PUT 'https://localhost:44339/api/Products/60da31e86319b657a23cd152' \
    --header 'Content-Type: application/json' \
    --data-raw '{
        "name": "Pokebola Nova",
        "price": 1222,
        "description": "Um belo produto novo",
        "imageUrl": "https://gartic.com.br/imgs/mural/ca/carol4u/pokebola.png",
        "tags": [
            {
                "name": "pokemon novo"
            },
            {
                "name": "bola novo"
            }
        ]
    }'

### Response

   [![Generic badge](https://img.shields.io/badge/204-NoContent-<COLOR>.svg)](https://shields.io/)
 
 
## Create another new Thing

### Request

`DELETE /api/Products/id`

    curl --location --request DELETE 'https://localhost:44339/api/Products/60da31e86319b657a23cd152' \
    --header 'Content-Type: application/json'

### Response

    [![Generic badge](https://img.shields.io/badge/204-NoContent-<COLOR>.svg)](https://shields.io/)

### Author

Fernando Luiz de Carvalho Barbosa


