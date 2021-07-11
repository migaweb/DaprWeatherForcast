#Weather app with dapr
Installation
https://docs.dapr.io/getting-started/install-dapr-cli/

## Run weather api using dapr

dapr run --app-id weatherapi --app-port 5001 --dapr-http-port 50001 dotnet run

### Browser/Postman
http://localhost:50001/v1.0/invoke/weatherapi/method/weatherforecast

### Powershell
Invoke-RestMethod -Method Get -Uri 'http://localhost:50001/v1.0/invoke/weatherapi/method/weatherforecast'

## Run the frontend

dapr run --app-id frontend --app-port 5002 --dapr-http-port 50002 dotnet run

## Dapr dashboard
Start with: dapr dashboard
Dashboard: http://localhost:8080/
Zipkin: http://localhost:9411/zipkin
