CREATE PROC InsertProvider
@name NVARCHAR(100),
@phone VARCHAR(20),
@address NVARCHAR(100)
AS
BEGIN
	INSERT INTO providers(provider_name,phone,address)
	VALUES(@name,@phone,@address);
END;