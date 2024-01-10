CREATE PROC InsertInvoiceDetail
@invoice_id INT,
@quantity_import INT,
@laptop_id INT,
@price DECIMAL
AS
BEGIN
	INSERT INTO invoice_detail(invoice_id,quantity,laptop_id,unit_price) VALUES (@invoice_id,@quantity_import,@laptop_id,@price);
	UPDATE laptops
	SET quantity=quantity+@quantity_import
	WHERE laptop_id=@laptop_id;
END;
drop proc InsertInvoiceDetail
EXEC InsertOrderDetail 2,5,188	