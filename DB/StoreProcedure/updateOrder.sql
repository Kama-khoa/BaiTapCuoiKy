CREATE PROC UpdateOrder
@order_id INT,
@payment INT,
@status INT,
@update_status_date DATETIME,
@accountant_id INT
AS
BEGIN
    UPDATE orders 
	SET payment = @payment,
		status = @status,
		accoutant_id = @accountant_id,
		update_status_time=@update_status_date
	WHERE order_id = @order_id
END;
DROP PROC UpdateOrder