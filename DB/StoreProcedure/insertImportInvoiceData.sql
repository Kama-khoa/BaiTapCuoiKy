CREATE PROC InsertImportInvoiceData
@provider_id INT,
@staff_id INT,
@import_time DATETIME 
AS
BEGIN
	INSERT INTO import_invoices(provider_id,staff_id,import_time,accountant_id) 
	VALUES(@provider_id,@staff_id,@import_time,0);
END;
drop proc InsertImportInvoiceData