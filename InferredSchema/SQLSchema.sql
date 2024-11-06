-- Crear la base de datos
CREATE DATABASE pokemon;
GO

-- Usar la base de datos creada
USE pokemon;
GO

-- Crear la tabla 'tipos'
CREATE TABLE tipos (
    id INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL
);
GO

-- Crear la tabla 'pokemones'
CREATE TABLE pokemones (
    id INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    tipo_primario INT NOT NULL,
    tipo_secundario INT NULL,
    FOREIGN KEY (tipo_primario) REFERENCES tipos(id),
    FOREIGN KEY (tipo_secundario) REFERENCES tipos(id)
);
GO

-- Crear la tabla 'entrenadores'
CREATE TABLE entrenadores (
    idEntrenador INT PRIMARY KEY,
    nombreEntrenador VARCHAR(255) NOT NULL
);
GO

-- Crear la tabla 'pokemon_entrenador'
CREATE TABLE pokemon_entrenador (
    idEntrenador INT NOT NULL,
    idPokemon INT NOT NULL,
    nivelPokemon INT NOT NULL,
    hp INT NOT NULL,
    hp_max INT NOT NULL,
    ataque INT NOT NULL,
    defensa INT NOT NULL,
    ataque_especial INT NOT NULL,
    defensa_especial INT NOT NULL,
    velocidad INT NOT NULL,
    PRIMARY KEY (idEntrenador, idPokemon),
    FOREIGN KEY (idEntrenador) REFERENCES entrenadores(idEntrenador),
    FOREIGN KEY (idPokemon) REFERENCES pokemones(id)
);
GO


