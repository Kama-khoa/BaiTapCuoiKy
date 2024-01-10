CREATE PROCEDURE updateProvider
@id INT,
@name NVARCHAR(100),
@phone VARCHAR(20),
@address NVARCHAR(100)
AS
BEGIN
	UPDATE providers
	SET
		provider_name=@name,
		phone=@phone,
		address=@address
	WHERE provider_id=@id;
END;