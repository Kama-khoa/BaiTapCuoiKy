CREATE PROC RecoverLaptop2
@laptop_id INT,
@quantity INT

AS
BEGIN
    UPDATE laptops
	SET quantity=quantity-@quantity
	WHERE laptop_id=@laptop_id;
END;
exec RecoverLaptop 1, 6
drop proc RecoverLaptop
