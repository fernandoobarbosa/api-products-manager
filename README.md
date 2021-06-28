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

`POST /thing/`

    curl -i -H 'Accept: application/json' -d 'name=Bar&junk=rubbish' http://localhost:7000/thing

### Response

    HTTP/1.1 201 Created
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 201 Created
    Connection: close
    Content-Type: application/json
    Location: /thing/2
    Content-Length: 35

    {"id":2,"name":"Bar","status":null}

## Get list of Things again

### Request

`GET /thing/`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 74

    [{"id":1,"name":"Foo","status":"new"},{"id":2,"name":"Bar","status":null}]

## Change a Thing's state

### Request

`PUT /thing/:id/status/changed`

    curl -i -H 'Accept: application/json' -X PUT http://localhost:7000/thing/1/status/changed

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40

    {"id":1,"name":"Foo","status":"changed"}

## Get changed Thing

### Request

`GET /thing/id`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 40

    {"id":1,"name":"Foo","status":"changed"}

## Change a Thing

### Request

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'name=Foo&status=changed2' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:31 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41

    {"id":1,"name":"Foo","status":"changed2"}

## Attempt to change a Thing using partial params

### Request

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'status=changed3' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41

    {"id":1,"name":"Foo","status":"changed3"}

## Attempt to change a Thing using invalid params

### Request

`PUT /thing/:id`

    curl -i -H 'Accept: application/json' -X PUT -d 'id=99&status=changed4' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41

    {"id":1,"name":"Foo","status":"changed4"}

## Change a Thing using the _method hack

### Request

`POST /thing/:id?_method=POST`

    curl -i -H 'Accept: application/json' -X POST -d 'name=Baz&_method=PUT' http://localhost:7000/thing/1

### Response

    HTTP/1.1 200 OK
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 200 OK
    Connection: close
    Content-Type: application/json
    Content-Length: 41

    {"id":1,"name":"Baz","status":"changed4"}

## Change a Thing using the _method hack in the url

### Request

`POST /thing/:id?_method=POST`

    curl -i -H 'Accept: application/json' -X POST -d 'name=Qux' http://localhost:7000/thing/1?_method=PUT

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: text/html;charset=utf-8
    Content-Length: 35

    {"status":404,"reason":"Not found"}

## Delete a Thing

### Request

`DELETE /thing/id`

    curl -i -H 'Accept: application/json' -X DELETE http://localhost:7000/thing/1/

### Response

    HTTP/1.1 204 No Content
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 204 No Content
    Connection: close


## Try to delete same Thing again

### Request

`DELETE /thing/id`

    curl -i -H 'Accept: application/json' -X DELETE http://localhost:7000/thing/1/

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:32 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: application/json
    Content-Length: 35

    {"status":404,"reason":"Not found"}

## Get deleted Thing

### Request

`GET /thing/1`

    curl -i -H 'Accept: application/json' http://localhost:7000/thing/1

### Response

    HTTP/1.1 404 Not Found
    Date: Thu, 24 Feb 2011 12:36:33 GMT
    Status: 404 Not Found
    Connection: close
    Content-Type: application/json
    Content-Length: 35

    {"status":404,"reason":"Not found"}

## Delete a Thing using the _method hack

### Request

`DELETE /thing/id`

    curl -i -H 'Accept: application/json' -X POST -d'_method=DELETE' http://localhost:7000/thing/2/

### Response

    HTTP/1.1 204 No Content
    Date: Thu, 24 Feb 2011 12:36:33 GMT
    Status: 204 No Content
    Connection: close


