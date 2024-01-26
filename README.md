 You can make request this way:

 curl -X POST -H "Content-Type: application/json" -d '{
    "Latitude": 37.7749,
    "Longitude": -122.4194,
    "NumberOfResults": 5,            
    "PreferredFood": "burrito"         
}' http://localhost:5032/FoodTruck | jq
