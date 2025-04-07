use master
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'EventEaseDB')
DROP DATABASE EventEaseDB
CREATE DATABASE EventEaseDB
use EventEaseDB

CREATE TABLE Venue (
VenueID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
VenueName VARCHAR (250) NOT NULL,
VenueLocation VARCHAR(250) NOT NULL,
VenueCapacity INT NOT NULL,
ImageURL VARCHAR (MAX) NOT NULL
);

CREATE TABLE [Event] (
EventID INT IDENTITY (1,1) PRIMARY KEY NOT  NULL,
EventName VARCHAR(250) NOT NULL,
EventDate DATE NOT NULL,
EventDescription VARCHAR (MAX) NOT NULL
);

CREATE TABLE Booking (
BookingID INT IDENTITY (1,1) PRIMARY KEY NOT  NULL,
VenueID INT FOREIGN KEY REFERENCES Venue (VenueID),
EventID INT FOREIGN KEY REFERENCES [Event] (EventID),
BookingDate DATE NOT NULL,
);

INSERT INTO Venue (VenueName,VenueLocation,VenueCapacity,ImageURL)
VALUES ('Dullstroom','Mpumalanga',30,'https://url')

INSERT INTO [Event] (EventName,EventDate,EventDescription)
VALUES ('Wedding','2025-03-11','Celebrate a union')

INSERT INTO Booking(VenueID,EventID,BookingDate)
VALUES (1,1,'2025-03-11')

SELECT * FROM Venue
SELECT * FROM [Event]
SELECT * FROM Booking