# TP Déploiement Docker : ASP.NET Core Products API

# Initialiser le projet

1. Ouvrir la solution **Products.Api** dans Visual Studio.
2. Restaurer les packages Nuget si nécessaire.

# Tester l'application en local

Avant de créer les conteneurs, vérifier le bon fonctionnement de l'application sur votre machine de travail.

1. Dans Visual Studio, démarrer l'application en mode **Debug**.
2. L'application se lance dans le navigateur sur le port **5091**.
    - Au 1er lancement, la base de données est créée et alimentée avec 5 produits.
3. A l'aide de **l'explorateur de serveurs** de Visual Studio, vérifier la présence de la table **Products** dans la base de données **db_products**. La table **Products**  doit contenir 5 produits.
4. Utiliser swaggerUI pour afficher la liste des produits.


# Travail à réaliser

## Créer le conteneur pour la base de données

Pour créer le conteneur de la base de données, suivez les étapes suivantes : 

1. Ouvrir PowerShell
2. Entrer la commande suivante pour créer et lancer le conteneur : 

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MyPassword1234" -p 1433:1433 --name products_sqlserver --hostname products_sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```

Vous devriez voir aparaitre le conteneur "**products_sqlserver**" dans Docker Desktop.
- Vous pouvez maintenant démarrer et arrêter le conteneur avec les commandes : 
    - `docker stop products_sqlserver` pour arrêter le conteneur
    - `docker start products_sqlserver` pour démarrer le conteneur
    - ou directement depuis l'interface de Docker Desktop

Pour tester le bon fonctionnement du serveur SQL, connectez-vous à la base de données avec **SQL Server Managment Studio** en utilisant les informations d'identification suivantes : 
- **Server Type :** Database Engine
- **Server Name :** localhost
- **Authentication :** SQL Server Authentication
    - **Login :** sa 
    - **Password :** MyPassword1234
- **Connection Security**
    - **Encryption :** Optional
    - **Trust Server Certificate** : case cochée 

> Une fois la connexion réussie, vous pouvez passer à la suite

### Simplifier l'utilisation du conteneur de la base de données

Dans le répertoire "**/Db/**" de la solution, complétez le fichier **docker-compose.yml** afin de pouvoir démarrer/arrêter le conteneur plus simplement.

Le **docker-compose** doit contenir les éléments suivants : 
- Un service **products_sqlserver** configuré avec les informations suivantes : 
    - **Nom du conteneur :** products_sqlserver
    - **Nom d'hôte :** products_sqlserver
    - **Image :** mcr.microsoft.com/mssql/server:2019-latest
    - **Port**: Associer le port externe **1433** au port interne **1433**
    - **Les variables d'environnement :** 
        - ACCEPT_EULA=Y
        - MSSQL_SA_PASSWORD=MyPassword1234
- Un volume nommé **mssql_data**
    - Lier ce volume au répertoire **/var/opt/mssql/** du conteneur
- Un réseau de type **Brigde** nommé **app-products-network**
    - Associer le service **products_sqlserver** à ce réseau


> Vérifier le bon fonctionnement de votre docker-compose avant de passer à la suite.


## Créer le conteneur pour l'application

1. Ajouter un `Dockerfile` à la racine du projet **Products.Api**.
2. Dans le répertoire principal de la solution, éditer le fichier `Dockerfile` pour encapsuler l'application dans un conteneur Docker.
    - L'image doit compiler et démarrer l'application
    - L'application doit être accessible via le port **8080**.
    - L'application doit se lancer en mode **Production**.
        - Utiliser les variables d'environnement **ASPNETCORE_ENVIRONMENT** et **DOTNET_ENVIRONMENT**
    - Le nom du conteneur doit être **products_api**
3. Tester l'application avec Docker.
    - L'URL de l'application une fois le conteneur démarré: [localhost:8080](http://localhost:8080)
4. Créer un fichier **USAGE.md** qui contiendra:
    - La commande Docker permettant de lancer un conteneur à partir du Dockerfile que vous avez implémenté.
    - La commande Docker permettant d'arrêter le conteneur

### Simplifier l'utilisation du conteneur de l'application

Dans le répertoire principal de la solution, complétez le fichier **docker-compose.yml** afin de pouvoir démarrer/arrêter le conteneur plus simplement.

Le **docker-compose** doit contenir les éléments suivants : 
- Un service **products_api** configuré avec les informations suivantes : 
    - **Nom du conteneur :** products_api
    - **Nom d'hôte :** products_api
    - **Image :** Le `Dockerfile` que vous avez créé à l'étape précédente
    - **Port**: Associer le port externe **4500** au port interne **8080**
- Un réseau de type **Brigde** nommé **app-products-network**
    - Associer le service **products_api** à ce réseau


## Tester l'ensemble : 

1. Lancer le docker-compose de la base de données
2. Lorsque le conteneur products_sqlserver est démarré
    - Lancer le docker-compose de l'application
3. Démarrer l'application dans un navigateur Web : [localhost:4500](http://localhost:4500)

> Validez votre travail avec un formateur
