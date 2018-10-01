CREATE TABLE Seat (
	[SeatId] int NOT NULL IDENTITY,
	[Available] bit NOT NULL,
	[FirstClass] bit NOT NULL,
	[RowNumber] int NOT NULL,
	[ColNumber] int NOT NULL,
	[FlightId] int REFERENCES Flight(FlightID),
	PRIMARY KEY (SeatId)
	);