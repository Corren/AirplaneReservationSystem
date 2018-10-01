CREATE TABLE Ticket (
	[TicketId] int NOT NULL IDENTITY,
	[Username] nvarchar(450) NOT NULL REFERENCES AspNetUsers(ID),
	[FirstName] nvarchar(255) NOT NULL,
	[LastName] nvarchar(255) NOT NULL,
	[DOB] datetime NOT NULL,
	[SeatId] int UNIQUE REFERENCES Seat(SeatId),
	PRIMARY KEY (TicketId)
	);

    