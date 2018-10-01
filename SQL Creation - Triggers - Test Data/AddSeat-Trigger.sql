CREATE TRIGGER AddSeat on Flight
AFTER INSERT
AS
BEGIN

--SELECT CapacityFirstClass, CapacityEconomy, PriceFirstClass, PriceEconomy, FlightId FROM inserted;
	DECLARE @r int;
	DECLARE @c int;
	DECLARE @spot int;
	
	DECLARE @cfc int;
	DECLARE @ce int;
	DECLARE @fi int;
	
	SET @r = 1;
	SET @c = 1;
	SET @spot = 1;
	
	SELECT @cfc = CapacityFirstClass FROM INSERTED 
	SELECT @ce = CapacityEconomy FROM INSERTED
	SELECT @fi = FlightId FROM INSERTED

	WHILE @spot <= @cfc
	BEGIN
		IF @c > 2
			BEGIN
				SET @r = @r + 1;
				SET	@c = 1;
			END
		INSERT INTO Seat ([Available], [FirstClass], [RowNumber], [ColNumber], [FlightId]) VALUES (1,1,@r,@c,@fi);
		SET @spot = @spot + 1;
		SET @c = @c + 1;
	END;

	SET @c = 1;
	WHILE @spot <= @ce + @cfc
	BEGIN
		IF @c > 2
			BEGIN
				SET @r = @r + 1;
				SET	@c = 1;
			END
		INSERT INTO Seat ([Available], [FirstClass], [RowNumber], [ColNumber], [FlightId]) VALUES (1,0,@r,@c,@fi);
		SET @spot = @spot + 1;
		SET @c = @c + 1;
	END;
END;
GO;





