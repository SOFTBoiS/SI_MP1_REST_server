# SI_MP1_REST_server

### REST server for saving and getting image-URLs in a local in-memory database

### Guide:
Start program and use POSTMAN with the following endpoints
Use the port from the url in the browser that starts up.

#### Endpoints:

##### GET all images : https://localhost:{PORT}/api/Images


##### Get images for user : https://localhost:{PORT}/api/Images/?username={username}


##### POST image for user : https://localhost:{PORT}/api/Images/
###### Include body: 
{
"userName":{myUserName},
"url": {myImageURL}
}


##### Put image : https://localhost:{PORT}/api/Images/{id}
###### Include body: 
{
"id":{myImageId},
"userName":{myUserName},
"url":{myImageURL}
}


##### Delete image : https://localhost:{PORT}/api/Images/{id}