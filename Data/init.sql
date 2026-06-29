CREATE TABLE Clients (
    ClientId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Address TEXT NOT NULL,
    PhoneNumber TEXT NOT NULL,
    Email TEXT NOT NULL
);

CREATE TABLE Pets (
    PetId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Species TEXT NOT NULL,
    Breed TEXT NOT NULL,
    DateOfBirth TEXT,
    Gender TEXT NOT NULL,
    ChipNumber TEXT NOT NULL,
    MedicalHistory TEXT NOT NULL,
    ClientId INTEGER NOT NULL,
    FOREIGN KEY (ClientId) REFERENCES Clients(ClientId)
);

INSERT INTO Clients (ClientId, Name, Address, PhoneNumber, Email)
VALUES
(1, 'Jan Jansen', 'Hoofdstraat 1', '0612345678', 'jan@email.nl'),
(2, 'Piet Pieters', 'Dorpsstraat 5', '0623456789', 'piet@email.nl'),
(3, 'Marie de Vries', 'Stationsweg 10', '0634567890', 'marie@email.nl'),
(4, 'Kees Bakker', 'Schoolstraat 15', '0645678901', 'kees@email.nl'),
(5, 'Sophie Jansen', 'Parklaan 8', '0656789012', 'sophie@email.nl'),
(6, 'Tom Visser', 'Molenweg 22', '0667890123', 'tom@email.nl');

INSERT INTO Pets
(PetId, Name, Species, Breed, DateOfBirth, Gender, ChipNumber, MedicalHistory, ClientId)
VALUES
(1, 'Max', 'Dog', 'Labrador', '2020-03-12', 'Male', '123456789', 'No medical issues', 1),
(2, 'Luna', 'Cat', 'European Shorthair', '2021-05-10', 'Female', '987654321', 'Allergic to certain food', 2),
(3, 'Bella', 'Dog', 'Golden Retriever', '2019-08-22', 'Female', '456789123', 'Vaccinations up to date', 3),
(4, 'Milo', 'Cat', 'Maine Coon', '2022-01-15', 'Male', '321654987', 'Needs daily medication', 4),
(5, 'Rocky', 'Dog', 'German Shepherd', '2018-09-30', 'Male', '654987321', 'No medical issues', 5),
(6, 'Nala', 'Cat', 'British Shorthair', '2021-11-05', 'Female', '789123456', 'Sensitive stomach', 6);