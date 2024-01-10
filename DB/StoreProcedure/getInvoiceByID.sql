CREATE PROCEDURE getInvoiceByID
@ID int
AS
BEGIN
	SELECT *
	FROM import_invoices
	WHERE invoice_id=@ID;
END;
exec getOrderByID 6