# Develop for Azure Storage - Azure Cosmos DB

## SQL API

You need to create an **Azure Cosmos DB for NoSQL** in order to be able to query the data in SQL-fashion

### Play with data in the Azure Portal

- create account
<img src="/pictures/cosmos.png" title="create cosmos account"  width="900">

- create container. Choose *appdb* for database id (database will automatically created). Choose *customer* for container id and *customerid* for partition key.
<img src="/pictures/cosmos2.png" title="create cosmos account"  width="900">

- add new items to the *customer* container
<img src="/pictures/cosmos3.png" title="create cosmos account"  width="900">

- query the data in SQL-like fashion
<img src="/pictures/cosmos4.png" title="create cosmos account"  width="900">

### .NET create database and container

- add nuget packages
```
Microsoft.Azure.Cosmos
```

- in the azure portal, grab the primary connection string
<img src="/pictures/cosmos_helper.png" title="cosmos helper"  width="900">

- run the program and the database and course container have been created
<img src="/pictures/cosmos_helper2.png" title="cosmos helper"  width="900">

