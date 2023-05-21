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


### Composite Indexes

- do a bulk insert with *coursename* as partition key and run the query bellow
```
select c.id,c.courseid from c order by c.coursename,c.rating
```

You will get the following error :
<img src="/pictures/index.png" title="composite indexes"  width="900">

This is because you need a composite index.

- go to *scale & settings* / *indexing policy* and add the index policy form *policy.txt* 
<img src="/pictures/index2.png" title="composite indexes"  width="900">

- run the above query again and see that it works
<img src="/pictures/index3.png" title="composite indexes"  width="900">


### Time To Live

- on one of the items, add a ttl of 20 seconds
<img src="/pictures/ttl.png" title="time to live"  width="900">

- for the ttl to take effect, go to *scale & settings* / *settings*, and set it on *On (no default)*
<img src="/pictures/ttl2.png" title="time to live"  width="900">

- wait 20 seconds and you will see that item disappear

- you can also apply the settings for the entire container
<img src="/pictures/ttl3.png" title="time to live"  width="900">


### Azure CLI with Cosmos DB

- run first commands in *commands.ps1*. This will result in the account *alexeinewaccount* available in two regions
<img src="/pictures/cli.png" title="azure cli"  width="900">

- run second commands in *commands.ps1*. This will result in the account *alexeinewaccount2* based on *Table API*
<img src="/pictures/cli2.png" title="azure cli"  width="900">


### Table API

- go to *alexeinewaccount2* and add a table *customer*
<img src="/pictures/table_api.png" title="table api"  width="900">

- add an entity in *customer*
<img src="/pictures/table_api2.png" title="table api"  width="900">

- in section *Connection String*, grab a connection string

- run the program to add a new customer
<img src="/pictures/table_api3.png" title="table api"  width="900">
