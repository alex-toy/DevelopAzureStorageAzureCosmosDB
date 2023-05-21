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


## Labs

### Data

- add item
<img src="/pictures/add.png" title="add item"  width="900">

- bulk insert
<img src="/pictures/data.png" title="add items bulk"  width="900">

- read data
<img src="/pictures/data2.png" title="add items bulk"  width="900">

- update data
<img src="/pictures/data3.png" title="add items bulk"  width="900">

- delete data
<img src="/pictures/data4.png" title="add items bulk"  width="900">


### Change Feed

- choose **Cosmos DB Trigger**
<img src="/pictures/feed.png" title="change feed"  width="900">

- grab the connection string in the azure portal
<img src="/pictures/feed2.png" title="change feed"  width="900">

- run the program

- in the azure portal, make any change on a course item.
<img src="/pictures/feed3.png" title="change feed"  width="900">

- verify the azure function has been triggered
<img src="/pictures/feed4.png" title="change feed"  width="900">


### Stored procedure

- in the azure portal, create new stored procedure
<img src="/pictures/stored_procedure.png" title="stored procedure"  width="900">


### Triggers

- in the azure portal, create new trigger

- use the code from *AddTimestamp.txt*
<img src="/pictures/trigger.png" title="trigger"  width="900">

- create course with timestamp
<img src="/pictures/trigger2.png" title="trigger"  width="900">


### Embedding data

- run the code and see that the course is created with embedded orders
<img src="/pictures/embedded.png" title="embedded data"  width="900">
