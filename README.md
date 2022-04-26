# Play.Trading

Trading uses by Play Economy services.

## Build the docker image

```powershell
$version="1.0.0"
$env:GH_OWNER="icodedotnetmicroservices"
$env:GH_PAT="[PAT HERE]"

docker build --secret id=GH_OWNER --secret id=GH_PAT -t play.trading:$version .
```

## Run the docker image

```powershell
docker run -it --rm -p 5006:5006 --name trading -e MongoDbSettings__Host=mongo -e RabbitMqSettings__Host=rabbitmq --network playinfra_default play.trading:$version
```
