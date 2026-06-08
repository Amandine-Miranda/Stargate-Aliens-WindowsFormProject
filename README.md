# 🚀 Stargate Aliens — Windows Forms Project

> Application de bureau C# inspirée de l'univers **Stargate**, permettant de gérer des espèces extraterrestres, des planètes et la composition de missions intergalactiques.

---

## 📋 Description

**SAE24STARGATE** est un projet réalisé en C# avec **Windows Forms** sous Visual Studio. Il s'articule autour d'une base de données SQLite locale (`Stargate.db`) et permet de naviguer dans un tableau de bord interactif pour :

- Explorer les races extraterrestres (alliées ou ennemies)
- Consulter des informations détaillées sur les planètes
- Composer et suivre des missions intergalactiques
- Consulter des statistiques sur les membres d'équipe et les budgets

---

## ✨ Fonctionnalités

### 🛸 Tableau de bord
Vue d'ensemble principale de l'application, point d'entrée de la navigation.

### 👽 Découverte des Races
- Affichage de toutes les espèces extraterrestres sous forme de **UserControls** dynamiques
- Chaque fiche alien affiche : nom, couleur, planète(s) d'origine, type (allié / ennemi), arme ou instrument, niveau de bienveillance ou de dangerosité
- Les **alliés** sont affichés en vert, les **ennemis** en violet
- **Filtres de recherche** par nom (saisie texte) et par couleur (liste déroulante)

### 🌍 Infos Planètes
- Affichage de toutes les planètes connues sous forme de UserControls
- Chaque planète est cliquable et ouvre une fiche détaillée (`frmPlanete`) avec :
  - Gravité (en g)
  - Température (en °C, colorée selon la valeur : bleu < 0°, violet 0–100°, rouge-orange > 100°)
  - Présence d'une DataBaz (oui / non / inconnu)
  - Liste des espèces habitant la planète

### 🚀 Nouvelle Mission
- Création et composition de missions vers des planètes
- Suivi du nombre de participants (missions ouvertes à moins de 10 membres)

### 📊 Statistiques
- **Coéquipiers** : sélection d'un membre pour afficher tous les coéquipiers de ses missions (civils ou militaires), triés alphabétiquement
- **Budget** : sélection d'une mission pour afficher le budget initial, le détail des dépenses (libellé, motif, date, montant) et le solde restant

---

## 🗂️ Structure du projet

```
SAE24STARGATE/
├── Form1.cs / Form1.Designer.cs     # Formulaire principal (frmAccueil) — navigation par TabControl
├── Alien.cs / Alien.Designer.cs     # UserControl représentant une fiche alien
├── Planete.cs / Planete.Designer.cs # UserControl représentant une fiche planète (aperçu)
├── frmPlanete.cs / frmPlanete.Designer.cs # Formulaire détail d'une planète
├── Program.cs                       # Point d'entrée de l'application
├── Resources/                       # Images des aliens (par couleur) et des planètes
├── Properties/                      # Paramètres de l'application
├── App.config                       # Configuration applicative
├── packages.config                  # Dépendances NuGet
└── SAE24STARGATE.csproj             # Fichier projet Visual Studio
```

---

## 🗄️ Modèle de données (SQLite)

La base de données `Stargate.db` contient les tables suivantes :

| Table | Description |
|---|---|
| `Espece` | Espèces extraterrestres (nom, couleur) |
| `Allie` | Espèces alliées (instrument de musique, degré de bienveillance) |
| `Ennemi` | Espèces ennemies (type d'arme, degré d'agressivité) |
| `Planete` | Planètes (nom, gravité, température, présence DataBaz) |
| `Habiter` | Relation espèce ↔ planète |
| `Membre` | Membres de l'équipe (matricule, prénom, nom) |
| `Mission` | Missions (numéro, planète cible, budget) |
| `Composer` | Relation membre ↔ mission |
| `Depense` | Dépenses liées à une mission (motif, date, montant) |
| `TypeDepense` | Catégories de dépenses (libellé) |

---

## 🛠️ Technologies utilisées

- **Langage** : C# (.NET Framework)
- **Interface** : Windows Forms
- **Base de données** : SQLite via `System.Data.SQLite`
- **IDE** : Visual Studio
- **Accès aux données** : mode déconnecté (`DataSet` / `DataAdapter`)

---

## ⚙️ Prérequis

- Windows
- Visual Studio 2019 ou supérieur
- .NET Framework 4.x
- Package NuGet : `System.Data.SQLite`

---

## 🚀 Installation & Lancement

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/Amandine-Miranda/Stargate-Aliens-WindowsFormProject.git
   ```

2. Ouvrir `SAE24STARGATE.slnx` dans Visual Studio.

3. Restaurer les packages NuGet (clic droit sur la solution → *Restaurer les packages NuGet*).

4. S'assurer que le fichier `Stargate.db` est présent à la racine du projet et que le dossier `Resources/` contient les images nécessaires.

5. Lancer l'application avec `F5` ou le bouton **Démarrer**.

> ⚠️ Les images des aliens sont chargées dynamiquement depuis `../../Resources/<couleur>.png` — veillez à ne pas modifier la structure des dossiers.

---

## 👤 Auteurs

**Amandine Miranda et Léo Galien** — Projet réalisé dans le cadre d'une SAE (Situation d'Apprentissage et d'Évaluation).
