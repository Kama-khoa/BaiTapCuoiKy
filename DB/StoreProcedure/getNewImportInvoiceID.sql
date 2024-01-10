CREATE PROCEDURE getNewImportInvoiceID

AS
BEGIN
	SELECT MAX(invoice_id)as max_id
	FROM import_invoices;
END;
EXEC getNewImportInvoiceID