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

CREATE TABLE Stays (
    StayId INTEGER PRIMARY KEY AUTOINCREMENT,
    PetId INTEGER NOT NULL,
    StartDate TEXT NOT NULL,
    EndDate TEXT NOT NULL,
    KennelNumber TEXT NOT NULL,
    Status TEXT NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pets(PetId)
);


CREATE TABLE CareSchedules (
    CareScheduleId INTEGER PRIMARY KEY AUTOINCREMENT,
    PetId INTEGER NOT NULL,
    Feeding TEXT NOT NULL,
    Medication TEXT NOT NULL,
    Notes TEXT NOT NULL,
    FOREIGN KEY (PetId) REFERENCES Pets(PetId)
);


CREATE TABLE Users (
    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL,
    Password TEXT NOT NULL,
    Role TEXT NOT NULL
);

CREATE TABLE Cages (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Size TEXT NOT NULL CHECK (Size IN ('S', 'M', 'L'))
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


INSERT INTO Stays
(StayId, PetId, StartDate, EndDate, KennelNumber, Status)
VALUES
(1, 1, '2026-07-01', '2026-07-07', 'A01', 'Reserved'),
(2, 2, '2026-07-03', '2026-07-10', 'B02', 'Active'),
(3, 3, '2026-07-12', '2026-07-18', 'A03', 'Completed'),
(4, 4, '2026-07-15', '2026-07-20', 'C04', 'Reserved'),
(5, 5, '2026-07-18', '2026-07-25', 'B05', 'Reserved'),
(6, 6, '2026-07-20', '2026-07-27', 'A06', 'Reserved');


INSERT INTO CareSchedules
(CareScheduleId, PetId, Feeding, Medication, Notes)
VALUES
(1, 1, 'Twice a day', 'None', 'Walk after breakfast'),
(2, 2, 'Three times a day', 'Allergy medication', 'No chicken food'),
(3, 3, 'Twice a day', 'Joint supplements', 'Gentle exercise only'),
(4, 4, 'Once a day', 'Daily medication', 'Keep indoors'),
(5, 5, 'Twice a day', 'None', 'Enjoys long walks'),
(6, 6, 'Small portions', 'Stomach medication', 'Sensitive stomach');


INSERT INTO Users (UserId, Username, Password, Role)
VALUES
(1, 'admin', 'admin123', 'Administrator'),
(2, 'employee1', 'welcome123', 'Employee'),
(3, 'employee2', 'welcome123', 'Employee');


INSERT INTO Cages (Id, Name, Size)
VALUES
(1, 'Large cage', 'L'),
(2, 'Medium cage', 'M'),
(3, 'Large cage', 'L'),
(4, 'Small cage', 'S'),
(5, 'Medium cage', 'M');

