# Products API Database

Commande Docker pour créer le conteneur hébergeant la base de données : 

```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MyPassword1234" -p 1433:1433 --name products_sqlserver --hostname products_sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```
