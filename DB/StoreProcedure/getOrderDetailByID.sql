CREATE PROCEDURE getOrderDetailByID
@ID int
AS
BEGIN
	SELECT *
	FROM order_details
	WHERE order_id=@ID;
END;
exec getOrderDetailByID 7