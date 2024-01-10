CREATE PROCEDURE insertStaffData
@staff_name NVARCHAR(50),
@username VARCHAR(50),
@password VARCHAR(50),
@role INT
AS
BEGIN
	INSERT INTO staffs(staff_name,username,password,role)
	VALUES(@staff_name,@username,@password,@role);
END;
DROP PROC insertStaffData;