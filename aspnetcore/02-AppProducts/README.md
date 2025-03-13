# TP Déploiement Docker : ASP.NET Core Products API

# Initialiser le projet

1. Ouvrir la solution **AppProducts** dans Visual Studio.
2. Restaurer les packages Nuget si nécessaire.

# Tester l'application en local

Avant de créer les conteneurs, vérifier le bon fonctionnement de l'application sur votre machine de travail.

1. Dans Visual Studio, démarrer l'application en mode **Debug**.
2. L'application se lance dans le navigateur sur le port **5091**.
    - Au 1er lancement, la base de données est créée et alimentée avec 5 produits.
3. A l'aide de **l'explorateur de serveurs** de Visual Studio, vérifier la présence de la table **Products** dans la base de données **db_products**. La table **Products**  doit contenir 5 produits.

3. Utiliser swaggerUI pour afficher la liste des produits.


# Travail à réaliser

## Créer le conteneur pour la base de données

Pour créer le conteneur de la base de données, suivez les étapes suivantes : 

1. Le Docker engine doit être démarré
2. Ouvrir PowerShell
3. Entrer la commande suivante pour créer et lancer le conteneur : 

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MyPassword1234" -p 1433:1433 --name products_sqlserver --hostname products_sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
```

4. Vous devriez voir aparaitre le conteneur "products_sqlserver" dans Docker Desktop.
    - Vous pouvez maintenant démarrer et arrêter le conteneur avec les commandes : 
        - `docker stop products_sqlserver` pour arrêter le conteneur
        - `docker start products_sqlserver` pour démarrer le conteneur
5. Connectez vous à la base de données avec **SQL Server Managment Studio** en utilisant les informations d'identification suivantes : 
- **Server Type :** Database Engine
- **Server Name :** localhost
- **Authentication :** SQL Server Authentication
    - **Login :** sa 
    - **Password :** MyPassword1234
- **Connection Security**
    - **Encryption :** Optional
    - **Trust Server Certificate** : case cochée 
8. Vérifier la présence de la table **Products** dans la base de données **db_products**
    - Cette table doit contenir 5 produits
9. Depuis Visual Studio, lancer l'application en mode Debug
    - L'application se lance dans le navigateur:  [localhost:5091/](http://localhost:5091/).
10. Utiliser SwaggerUI pour afficher la liste des produits (opération GET /api/Products)
    - Ou tester directement l'URL : [localhost:5091/api/Products](http://localhost:5091/api/Products)


## Créer le conteneur pour l'application

1. Ajouter un `Dockerfile` à la racine du projet **Products.Api**.
2. Éditer le `Dockerfile` pour encapsuler l'application dans un conteneur Docker.
    - L'application doit être accessible via le port **8000**.
3. Tester l'application avec Docker.
    - URL de l'application une fois démarrée: [localhost:8000](http://localhost:8000)
4. Créer un fichier **USAGE.md** qui contiendra:
    - La commande Docker permettant de lancer un conteneur à partir du Dockerfile que vous avez implémenté.


## Mettre en réseau les 2 conteneurs

Pour que les 2 conteneurs communiquent efficacement, il est nécessaire de les ajouter à un réseau commun.

1. Avec Docker, créer un réseau de type **Bridge** nommé "**products_network**"
2. Ajouter les 2 conteneurs à ce réseau
3. Éditer la **ligne 16** du fichier **Program.cs** pour que l'application utilise la chaine de connexion "composeConnection"
    - Remplacez `containerConnection` par `composeConnection` 
4. Refaites un "build" de l'image de l'application
5. Relancer les 2 conteneurs
6. Tester le bon fonctionnement de l'application (tester TOUTES les opérations)
    - URL de l'application une fois démarrée: [localhost:8000](http://localhost:8000)
    - URL de l'opération **GET /api/Products**: [localhost:8000/api/Products](http://localhost:8000/api/Products)

---
