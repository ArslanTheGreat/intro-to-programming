# Our Links API

## Adding a Link

- Define the Resource
- Select proper method (GET POST PUT DELETE)
- Define our "representation" - how we are going to pass data from the client to the server, and how the server is going to send us data.

```http
POST http://localhost:1337/links
Content-Type: application/json
Authorization: bearer SOME_VALUE_YOU_GET_FROM_ANOTHER_SERVICE

{
    "href": "https://www.hypertheory.com",
    "description": "Best danged training available ANYWHERE!"
}
```

```http
201 Created
Content-Type: application/json
Location: /links/85923459094563468
{
    "id": 859234590945634689,
    "href": "https://www.hypertheory.com",
    "description": "Best danged training available ANYWHERE!",
    "addedBy": "me",
    "date": "today"
}

```


```http
GET http://localhost:1337/links/6956f376-b04b-4611-8b66-110eb5843726
```


here is some sample code

Http Status Codes:

200 - 299: Worked!
    201 - Created
300 - 399: Need more info or redirects
400 - 499: The user agent (the client making the request) did something wrong
    401 - You need to be authenticated, Who are you?
    403 - I know who you are and you SPECIFICALLY cant do this
    404 - 
500 - 599: We screwed up! (sever error)