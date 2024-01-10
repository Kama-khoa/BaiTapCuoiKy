CREATE PROC InsertOrderDetail
@order_id INT,
@laptop_id INT,
@quantity_bought INT
AS
BEGIN
	INSERT INTO order_details(order_id,laptop_id,quantity) VALUES (@order_id,@laptop_id,@quantity_bought);
	UPDATE laptops
	SET quantity=quantity-@quantity_bought
	WHERE laptop_id=@laptop_id;
END;
EXEC InsertOrderDetail 2,5,188