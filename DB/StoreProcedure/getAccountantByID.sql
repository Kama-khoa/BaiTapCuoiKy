CREATE PROC GetAccountantByID
@accountant_id INT
AS
BEGIN
	SELECT * FROM staffs
	WHERE staff_id = @accountant_id
END;
EXEC GetAccountantByID 4;
DROP PROC GetAccountantByID;