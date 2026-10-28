CREATE DATABASE school;
GO

USE school;
GO

CREATE TABLE curators (
    curator_id INT IDENTITY(1,1) PRIMARY KEY,
    full_name  NVARCHAR(150) NOT NULL,
    subject    NVARCHAR(100) NOT NULL
);

CREATE TABLE groups (
    group_id   INT IDENTITY(1,1) PRIMARY KEY,
    group_name NVARCHAR(100) NOT NULL,
    curator_id INT NULL,
    CONSTRAINT fk_group_curator
        FOREIGN KEY (curator_id) REFERENCES curators(curator_id)
        ON DELETE SET NULL
);

CREATE TABLE schoolchildren (
    student_id  INT IDENTITY(1,1) PRIMARY KEY,
    full_name   NVARCHAR(150) NOT NULL,
    age         INT NULL CHECK (age BETWEEN 5 AND 20),
    group_id    INT NULL,
    performance DECIMAL(3,2) NULL CHECK (performance BETWEEN 1 AND 5),
    CONSTRAINT fk_student_group
        FOREIGN KEY (group_id) REFERENCES groups(group_id)
        ON DELETE SET NULL
);

INSERT INTO curators (full_name, subject) VALUES
    ('Иванова Мария Петровна',   'Математика'),
    ('Сидоров Алексей Иванович', 'Физика'),
    ('Козлова Елена Сергеевна',  'Русский язык и литература');

INSERT INTO groups (group_name, curator_id) VALUES
    ('5-А', 1),
    ('6-Б', 2),
    ('7-В', 3);

INSERT INTO schoolchildren (full_name, age, group_id, performance) VALUES
    ('Петров Пётр',       11, 1, 4.50),
    ('Смирнова Анна',     11, 1, 4.80),
    ('Кузнецов Илья',     12, 2, 3.70),
    ('Орлова Дарья',      12, 2, 4.90),
    ('Морозов Максим',    13, 3, 4.10);
