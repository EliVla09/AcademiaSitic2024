--Si vas a modificar datos de un cliente, engas las instrucciones en rollback

BEGIN TRAN 
	UPDATE Students
	SET Name = 'Hola'
	SELECT * FROM Students
ROLLBACK 