# TP Déploiement Docker : ASP.NET Core RandomQuotes API

# Travail à réaliser

## Initialisation du projet

1. Ouvrir un terminal dans le répertoire "AppRandomQuotes"
2. Restaurer les packages Nuget

## Créer le conteneur pour l'application Web
 
1. Ajouter un `Dockerfile`.
2. Éditer le `Dockerfile` pour encapsuler l'application dans un conteneur Docker.
    - L'application doit être disponible via le port **8000**.
3. Tester l'application.
4. Créer un fichier "USAGE.md" qui contiendra:
    - La commande Docker permettant de lancer un container à partir du Dockerfile que vous avez implémenté.
5. Créer un fichier `docker-compose.yml` permettant de simplifier le démarrage du conteneur.

> /!\ Vous ne devez en aucun cas modifier le code de l'application !

---

## Routes de l'API : 

- [http://localhost](http://localhost)
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
