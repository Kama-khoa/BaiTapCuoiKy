CREATE PROCEDURE DeleteProvider
@id INT
AS
BEGIN
	DELETE FROM providers 
	WHERE provider_id = @id
END;