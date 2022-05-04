# Play.Trading

Play Economy Trading microservice.

## Build the docker image

```powershell
$version="1.0.1"
$env:GH_OWNER="icodedotnetmicroservices"
$env:GH_PAT="[PAT HERE]"
$containerregisteryname = "acrplayeconomy"
docker build --secret id=GH_OWNER --secret id=GH_PAT -t "$containerregisteryname.azurecr.io/play.trading:$version"  .
```

## Run the docker image

```powershell
$cosmoDbConnString= "[CONN STRING HERE]"
$serviceBusConnString= "[CONN STRING HERE]"
docker run -it --rm -p 5006:5006 --name trading -e MongoDbSettings__ConnectionString=$cosmoDbConnString -e ServiceBusSettings__ConnectionString=$serviceBusConnString -e ServiceSettings__MessageBroker="SERVICEBUS" play.trading:$version
```

## Publishing The Docker Image

```powershell
az acr login --name $containerregisteryname
docker push "$containerregisteryname.azurecr.io/play.trading:$version"
```
