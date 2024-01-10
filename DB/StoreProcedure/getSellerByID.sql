CREATE PROC GetSellerByID
@seller_id INT
AS
BEGIN
	SELECT * FROM staffs
	WHERE staff_id = @seller_id
END;
EXEC GetSellerByID 2