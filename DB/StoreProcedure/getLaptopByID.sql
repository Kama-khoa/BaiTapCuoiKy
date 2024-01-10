CREATE PROCEDURE getLaptopByID
@ID int
AS
BEGIN
	SELECT *
	FROM laptops
	WHERE laptop_id=@ID;
END;
