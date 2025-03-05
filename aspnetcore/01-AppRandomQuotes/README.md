# TP Déploiement Docker : ASP.NET Core RandomQuotes API

# Initialisation du projet

1. Ouvrir un terminal dans le répertoire "01-AppRandomQuotes".
2. Restaurer les packages Nuget si nécessaire.

# Utiliser l'application en local

Avant de créer le conteneur, vérifier le bon fonctionnement de l'application sur votre machine de travail.

1. Ouvrir la solution dans Visual Studio.
2. Restaurer les pakages Nuget si nécessaire.
3. Démarrer l'application en mode "Debug".
    - L'application se lance dans le navigateur sur le port 5120.

# Travail à réaliser

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
