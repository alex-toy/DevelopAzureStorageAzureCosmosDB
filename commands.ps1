# Create a new Azure Cosmos DB database account with two regions
# az cosmosdb create `
#     --name alexeinewaccount `
#     --resource-group alexeirg `
#     --default-consistency-level Session `
#     --locations regionName=francecentral failoverPriority=0 isZoneRedundant=False `
#     --locations regionName=uksouth failoverPriority=1 isZoneRedundant=False 
    


# Create an Azure Cosmos DB account with the Table API
az cosmosdb create `
    --name alexeinewaccount2 `
    --resource-group alexeirg `
    --default-consistency-level Session `
    --locations regionName=francecentral failoverPriority=0 isZoneRedundant=False `
    --capabilities EnableTable
