CREATE DATABASE [DbSchedulingSystem]
GO

USE [DbSchedulingSystem]
GO

CREATE TABLE [User] (
  [Id] INT PRIMARY KEY IDENTITY(1, 1),
  [Name] VARCHAR(50) NOT NULL,
  [Email] VARCHAR(100) NOT NULL,
  [Phone] VARCHAR(20) NOT NULL,
  [PasswordHash] VARCHAR(100) NOT NULL
);

CREATE TABLE [Professional] (
  [Id] INT PRIMARY KEY IDENTITY(1, 1),
  [Name] VARCHAR(50) NOT NULL,
  [Speciality] VARCHAR(50) NOT NULL,
  [Email] VARCHAR(100) NOT NULL,
  [Phone] VARCHAR(20) NOT NULL,
  [PasswordHash] VARCHAR(100) NOT NULL
);

CREATE TABLE [Diary_Professional] (
  [Id] INT PRIMARY KEY IDENTITY(1, 1),
  [Profissional_id] INT NOT NULL,
  [Day] DATE NOT NULL,
  [Timetable] TIME NOT NULL,
  [Local] VARCHAR(100) NOT NULL,
  FOREIGN KEY (Profissional_id) REFERENCES [professional](id)
);

CREATE TABLE [Scheduling] (
  [Id] INT PRIMARY KEY IDENTITY(1, 1),
  [User_id] INT NOT NULL,
  [Professional_id] INT NOT NULL,
  [Day] DATE NOT NULL,
  [Timetable] TIME NOT NULL,
  [Local] VARCHAR(100) NOT NULL,
  FOREIGN KEY (User_id) REFERENCES [User](id),
  FOREIGN KEY (Professional_id) REFERENCES [professional](id)
);