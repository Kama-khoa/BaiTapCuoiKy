CREATE PROCEDURE deleteStaffData
@staff_id INT
AS
BEGIN
	DELETE FROM staffs
	WHERE staff_id=@staff_id;
END;