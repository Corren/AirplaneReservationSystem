DECLARE @err int
BEGIN TRANSACTION


DECLARE @seat_id int
DECLARE @open_seat int
SET @seat_id = 195146

DECLARE @free int
SET @free = 0
IF (SELECT Available FROM Seat WHERE SeatId = @seat_id) = 1
BEGIN  
	set @free = 1
	UPDATE Seat SET Available = 0 WHERE SeatId = @seat_id
END
SET @err = @@ERROR

IF @err = 0
BEGIN
IF @free = 1
BEGIN  
	INSERT INTO Ticket ([Username],[FirstName],[LastName],[DOB],[SeatId]) VALUES (@@Username,@FirstName,@LastName,@DOB,@SeatId)
END
SET @err = @@ERROR
END
IF @err = 0
COMMIT 