-- Usar la base de datos creada
USE pokemon;
GO

-- Crear la tabla 'tipos'
CREATE TABLE tipos (
    id INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL
);
GO

INSERT INTO tipos (id, nombre) VALUES (1, 'Normal');
INSERT INTO tipos (id, nombre) VALUES (2, 'Water');
INSERT INTO tipos (id, nombre) VALUES (3, 'Grass');
INSERT INTO tipos (id, nombre) VALUES (4, 'Rock');
INSERT INTO tipos (id, nombre) VALUES (5, 'Fire');
INSERT INTO tipos (id, nombre) VALUES (6, 'Ground');
INSERT INTO tipos (id, nombre) VALUES (7, 'Poison');
INSERT INTO tipos (id, nombre) VALUES (8, 'Bug');
INSERT INTO tipos (id, nombre) VALUES (9, 'Electric');
INSERT INTO tipos (id, nombre) VALUES (10, 'Dragon');
INSERT INTO tipos (id, nombre) VALUES (11, 'Steel');
INSERT INTO tipos (id, nombre) VALUES (12, 'Dark');
INSERT INTO tipos (id, nombre) VALUES (13, 'Fighting');
INSERT INTO tipos (id, nombre) VALUES (14, 'Psychic');
INSERT INTO tipos (id, nombre) VALUES (15, 'Ghost');
INSERT INTO tipos (id, nombre) VALUES (16, 'Fairy');
INSERT INTO tipos (id, nombre) VALUES (17, 'Ice');
INSERT INTO tipos (id, nombre) VALUES (18, 'Flying');