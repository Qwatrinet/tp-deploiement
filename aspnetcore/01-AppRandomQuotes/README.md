# TP Déploiement Docker : ASP.NET Core RandomQuotes API

# Initialisation du projet

1. Ouvrir la solution **AppRandomQuotes** dans Visual Studio.
2. Restaurer les packages Nuget si nécessaire.

# Tester l'application en local

Avant de créer le conteneur, vérifier le bon fonctionnement de l'application sur votre machine de travail.

1. Dans Visual Studio, démarrer l'application en mode **Debug**.
2. L'application se lance dans le navigateur sur le port **5120**.

# Travail à réaliser

## Créer le conteneur pour l'application Web
 
1. Dans le répertoire du projet **RandomQuotes**, créer un fichier nommé `Dockerfile`.
2. Éditer le `Dockerfile` pour encapsuler l'application dans un conteneur Docker.
    - Le conteneur doit exploser l'application sur le port **8000**.
3. Tester l'application avec Docker.
4. Dans le répertoire du projet **RandomQuotes**, créer un fichier `README.md` qui contiendra les instructions et la commande Docker permettant de lancer un container à partir du `Dockerfile` que vous avez créé.
5. Créer un fichier `docker-compose.yml` permettant de démarrer le conteneur plus simplement.

> /!\ Vous ne devez en aucun cas modifier le code de l'application !

---

## Routes de l'API : 

- **/**
    - Page d'accueil, affiche l'interface de Swagger.
- **/api/Quotes**
    - Affiche toutes les citations.
- **/api/Quotes/random**
    - Affiche une citation au hasard.
