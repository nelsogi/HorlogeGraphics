# Horloge en Graphics C# WinForm

Ce projet est une application d'horloge analogique développée en C# avec Windows Forms. L'horloge utilise le dessin graphique pour afficher un cadran et trois aiguilles (heure, minute et seconde) qui se mettent à jour en temps réel.

---

## Fonctionnalités

- **Affichage du cadran** : Un cercle avec 12 graduations représentant les heures.
- **Aiguilles personnalisées** : Trois aiguilles colorées pour l'heure (rouge), la minute (bleu) et la seconde (vert), avec des longueurs proportionnelles à la taille du cadran.
- **Rafraîchissement automatique** : Utilisation d'un `Timer` pour rafraîchir l'horloge chaque seconde.
- **Double buffering** : Pour un rendu graphique fluide sans scintillement.
- **Redimensionnement dynamique** : L'horloge s'adapte automatiquement à la taille de la fenêtre.

---

## Structure du Projet

Le projet est organisé en plusieurs classes :

- **`Cadran`**  
  Gère le dessin du cercle de l'horloge et des graduations horaires.

- **`Aiguille`**  
  Représente une aiguille de l'horloge. Chaque instance possède une longueur, une couleur et une épaisseur. La méthode `Dessiner` calcule et trace l'aiguille selon l'angle donné.

- **`Vecteur`**  
  Fournit une méthode statique pour la rotation, utile pour le calcul des positions des aiguilles.

- **`Horloge`**  
  Contrôle l'affichage de l'horloge. Elle initialise les aiguilles, le cadran et le timer pour mettre à jour l'affichage en fonction de l'heure actuelle. Elle utilise également le double buffering pour éviter les scintillements lors du rendu.

- **`Form1`**  
  Fenêtre principale de l'application qui contient l'horloge. La fenêtre définit un fond noir et ajoute le contrôle horloge en mode plein écran.

---

## Prérequis

- **.NET Framework** (version compatible avec Windows Forms)
- **Visual Studio** ou tout autre environnement de développement C# supportant Windows Forms

---

## Compilation et Exécution

1. **Cloner le dépôt :**

   ```bash
   git clone https://votre-repository-url.git
   cd nom-du-repertoire
   ```

2. **Ouvrir le projet dans Visual Studio :**

   - Lancez Visual Studio.
   - Ouvrez le fichier de solution (*.sln*) correspondant au projet.

3. **Compiler le projet :**

   - Cliquez sur **Build > Build Solution** ou utilisez le raccourci `Ctrl+Shift+B`.

4. **Exécuter l'application :**

   - Cliquez sur **Debug > Start Debugging** (ou `F5`) pour lancer l'application.

---

## Personnalisation

- **Couleurs et styles** :  
  Vous pouvez modifier les couleurs des aiguilles et du cadran dans le code des classes `Aiguille` et `Cadran`.
  
- **Dimensions** :  
  La taille de l'horloge est dynamique et s'adapte à la taille de la fenêtre. Pour fixer une taille particulière, modifiez les propriétés du contrôle `Horloge` dans `Form1`.

- **Intervalle du Timer** :  
  Par défaut, l'horloge se rafraîchit toutes les secondes (1000 ms). Vous pouvez ajuster cet intervalle dans le constructeur de la classe `Horloge`.

---

## Remarques

- Assurez-vous d'avoir un environnement de développement compatible avec Windows Forms.
- Pour toute question ou suggestion, n'hésitez pas à ouvrir une issue dans le dépôt Git.

Profitez de ce projet et bon codage !
