CREATE PROCEDURE getStaffData
AS
BEGIN
	SELECT *
	FROM staffs;
END;
exec getStaffData