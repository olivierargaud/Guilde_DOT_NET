-- Création de la base de données --
CREATE DATABASE guilde_des_heros
GO
USE guilde_des_heros
-- Création de la table héros --
CREATE TABLE dbo.hero (
	her_id INT IDENTITY(1,1) NOT NULL,
	her_nom VARCHAR(50) NOT NULL,
	her_prenom VARCHAR(50) NOT NULL,
	her_specialite VARCHAR(50) NOT NULL,
	her_classe VARCHAR(50) NOT NULL,
	her_level INT NOT NULL,
	her_puissance INT NOT NULL,
	her_nb_mission INT NOT NULL,
	her_reputation INT NOT NULL,
    CONSTRAINT PK_hero PRIMARY KEY (her_id)
)
-- Création de la table objets --
CREATE TABLE dbo.objet (
	obj_id INT IDENTITY(1,1) NOT NULL,
	obj_nom VARCHAR(50) NOT NULL,
	obj_level INT NOT NULL,
	obj_quantite INT NOT NULL,
	obj_description VARCHAR(150) NOT NULL,
	obj_prix FLOAT NOT NULL,
	obj_hero_id INT NOT NULL,
    CONSTRAINT PK_objet PRIMARY KEY (obj_id),
    CONSTRAINT FK_objet_hero FOREIGN KEY (obj_hero_id) REFERENCES dbo.hero(her_id)
)
-- Insertion d'un heros --
INSERT INTO dbo.hero ( her_nom, her_prenom, her_specialite, her_classe, her_level, her_puissance, her_nb_mission, her_reputation)
VALUES ('nom', 'prenom', 'specialite', 'classe', 0, 0, 0, 0)
-- Insertion d'un objet --
INSERT INTO dbo.objet (obj_nom, obj_level, obj_quantite, obj_description, obj_prix, obj_hero_id)
 VALUES ('nom', 0, 0, 'description', 0.00, 1)