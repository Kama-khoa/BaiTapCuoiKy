CREATE PROCEDURE updateStaffData
@staff_id INT,
@staff_name NVARCHAR(50),
@username VARCHAR(50),
@password VARCHAR(50),
@role INT
AS
BEGIN
	UPDATE staffs
	SET
		staff_name=@staff_name,
		username=@username,
		password=@password,
		role=@role
	WHERE staff_id=@staff_id;
END;