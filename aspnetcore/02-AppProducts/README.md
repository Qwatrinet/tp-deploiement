# TP Déploiement Docker : ASP.NET Core Products API

# Initialisation du projet

1. Ouvrir un terminal dans le répertoire "02-AppProducts".
2. Restaurer les packages Nuget.

# Utiliser l'application en local

Avant de créer le conteneur, vérifier le bon fonctionnement de l'application sur votre machine de travail.

1. Ouvrir la solution dans Visual Studio.
2. Restaurer les pakages Nuget.
3. Initialiser la base de données (La migration est déjà prête à être appliquée)
    1. Entrer la commande `update-database` dans la console du gestionnaire de Package Nuget
    2. La base de données est créée avec 5 produits
4. Démarrer l'application en mode "Debug".
    - L'application se lance dans le navigateur sur le port 5091.
5. Afficher la liste des produits (opération GET /products)

# Travail à réaliser

> **Avant de commencer**
> 
> Le fichier **appsettings.json** contient 3 chaines de connexion : 
> 
> - **localConnection**: à utiliser pour tester l'application en local
> - **containerConnection**: à utiliser pour connecter l'application locale au conteneur de la base de données
> - **composeConnection**: à utiliser lorsque l'application et la base de données sont dans leurs conteneurs respectifs

## Créer le conteneur pour l'application Web
 
1. Ajouter un `Dockerfile`.
2. Éditer le `Dockerfile` pour encapsuler l'application dans un conteneur Docker.
    - L'application doit être disponible via le port **8000**.
3. Tester l'application avec Docker.
4. Créer un fichier "USAGE.md" qui contiendra:
    - La commande Docker permettant de lancer un container à partir du Dockerfile que vous avez implémenté.
5. Créer un fichier `docker-compose.yml` permettant de simplifier le démarrage du conteneur.

> /!\ Vous ne devez en aucun cas modifier le code de l'application !

---

## Routes de l'API : 

- **/**
    - Page d'accueil, affiche l'interface de Swagger
- **/api/Quotes**
    - Affiche toutes les citations
- **/api/Quotes/random**
    - Affiche une citation au hasard




# Travail à réaliser

## Créer le conteneur pour l'application Web
 
1. Ajouter un `Dockerfile` 
2. Éditer le `Dockerfile` pour encapsuler l'application dans un conteneur Docker
    - L'application doit être disponible via le port **4500**.
3. Tester l'application 
4. Créer un fichier "USAGE.md" qui contiendra:
    - la commande Docker permettant de lancer un container à partir du Dockerfile que vous avez implémenté.
5. Créer un fichier `docker-compose.yml` permettant de simplifier le démarrage du conteneur

> /!\ Vous ne devez en aucun cas modifier le code de l'application !

## Créer un conteneur pour la base de données

2 chaînes de connexion sont présentes dans le fichier de configuration de l'application.

- "**localConnection**" : Chaine de connexion au serveur SQL local de Visual Studio
- **containerConnection**": Chaine de connexion à utiliser lorsque l'application et la base de données seront "conteneurisés". 

Par défaut, l'application Web utilise le serveur SQL local de Visual Studio.

Pour modifier la chaine de connexion utilisée par l'application, Ouvrir le fichier "Program.cs" de l'application web et modifier le nom de la chaine de connexion ligne 16 :

Pour utiliser le serveur SQL de Visual Studio : 
- `var connectionString = builder.Configuration.GetConnectionString("localConnection");`
Pour utiliser le serveur SQL conteneurisé à partir de l'application locale :
- `var connectionString = builder.Configuration.GetConnectionString("containerConnection");`
Pour utiliser le serveur SQL conteneurisé à partir du conteneur de l'application :
- `var connectionString = builder.Configuration.GetConnectionString("composeConnection");`


## Créer un docker-compose pour  rassembler l'application et la base de données

---

# Utilisation du projet en local

## Initialisation du projet

1. Créer un Fork du dépôt
2. Cloner le dépôt en local
3. Ouvrir un terminal dans le répertoire "AppCars"
4. lancer la commande `npm install` pour réinstaller les dépendances

## Utilisation de l'application 

Démarrer le serveur: 

1. Lancer la commande `npm run dev`. 
2. Le serveur démarre et affiche dans la console "App is listening on port 3000"
3. Laisser le terminal ouvert (fermer le terminal = arrêter le serveur)
3. Ouvrir un navigateur et entrer l'url : [http://localhost:3000](http://localhost:3000)

Stopper le serveur : 

- CTRL+C dans le terminal qui exécute l'application.
- OU
- Fermer le terminal qui exécute l'application (non reommandé)

## Routes : 

- [http://localhost:3000](http://localhost:3000)
    - Page d'accueil, affiche les routes disponibles
- [http://localhost:3000/cars](http://localhost:3000/cars)
    - Affiche la liste des voitures
- [http://localhost:3000/car/1](http://localhost:3000/car/1)
    - Affiche la voiture N°1
- [http://localhost:3000/car/2](http://localhost:3000/car/2)
    - Affiche la voiture N°2
- [http://localhost:3000/car/3](http://localhost:3000/car/3)
    - Affiche la voiture N°3
- [http://localhost:3000/car/4](http://localhost:3000/car/4)
    - Affiche la voiture N°4
- [http://localhost:3000/car/5](http://localhost:3000/car/5)
    - Affiche la voiture N°5
