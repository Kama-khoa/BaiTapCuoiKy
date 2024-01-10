CREATE DATABASE Laptop_Store

USE laptop_store

CREATE TABLE staffs (
	staff_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	staff_name NVARCHAR(50) NOT NULL,
	username VARCHAR(255) NOT NULL UNIQUE,
	password VARCHAR(255) NOT NULL,
	role int NOT NULL
);

CREATE TABLE customers(
	customer_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	customer_name NVARCHAR(50) NOT NULL,
	phone VARCHAR(10) NOT NULL UNIQUE,
	address NVARCHAR(100) 
);

CREATE TABLE manufactories(
	manufactory_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	manufactory_name VARCHAR(50) NOT NULL UNIQUE,
	website VARCHAR(255),
	address VARCHAR(255)
);

CREATE TABLE categories(
	category_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	category_name NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE orders (
	order_id INT NOT NULL IDENTITY(1,1),
	customer_id INT NOT NULL,
	accoutant_id INT NOT NULL,
	seller_id INT NOT NULL,
	order_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	status INT NOT NULL,
	update_status_time DATETIME,
	payment INT NOT NULL,
	PRIMARY KEY (order_id),
	FOREIGN KEY (accoutant_id)
	REFERENCES staffs(staff_id),
	FOREIGN KEY (customer_id)
	REFERENCES customers(customer_id),
	FOREIGN KEY (seller_id)
	REFERENCES staffs(staff_id)
); 

CREATE TABLE laptops(
	laptop_id INT NOT NULL IDENTITY(1,1),
	laptop_name VARCHAR(100) NOT NULL, 
	category_id INT NOT NULL,
	manufactory_id INT NOT NULL,
	CPU VARCHAR(100) NOT NULL,
	RAM VARCHAR(100) NOT NULL,
	hard_drive VARCHAR(100) NOT NULL,
	VGA VARCHAR(100) NOT NULL,
	display VARCHAR(255) NOT NULL,
	battery VARCHAR(255) NOT NULL,
	weight FLOAT NOT NULL,
	materials VARCHAR(100) NOT NULL,
	ports VARCHAR(2000) NOT NULL,
	network_and_connection VARCHAR(200) NOT NULL,
	security VARCHAR(100) NOT NULL,
	keyboard VARCHAR(100) NOT NULL,
	audio VARCHAR(100) NOT NULL,
	size VARCHAR(100) NOT NULL,
	OS VARCHAR(100) NOT NULL,
	warranty_period VARCHAR(100) NOT NULL,
	price DECIMAL NOT NULL,
	quantity INT NOT NULL DEFAULT 0,
	PRIMARY KEY(laptop_id),
	CONSTRAINT fk_laptops_manufactory_id
	FOREIGN KEY(manufactory_id)
	REFERENCES manufactories(manufactory_id) ON DELETE CASCADE,
	CONSTRAINT fk_laptops_category_id
	FOREIGN KEY(category_id)
	REFERENCES categories(category_id) ON DELETE CASCADE,
);

CREATE TABLE order_details(
	order_id INT NOT NULL,
	laptop_id INT NOT NULL,
	quantity INT NOT NULL DEFAULT 1,
	PRIMARY KEY(order_id,laptop_id),
	CONSTRAINT fk_order_detail_order_id
	FOREIGN KEY (order_id)
	REFERENCES orders(order_id) ON DELETE CASCADE,
	CONSTRAINT fk_order_detail_laptop_id
	FOREIGN KEY (laptop_id)
	REFERENCES laptops(laptop_id) ON DELETE CASCADE,
);

CREATE TABLE providers(
	provider_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	provider_name NVARCHAR(50) NOT NULL,
	phone VARCHAR(20) NOT NULL UNIQUE,
	address NVARCHAR(50) NOT NULL
);

CREATE TABLE import_invoices(
	invoice_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	staff_id INT NOT NULL,
	provider_id INT NOT NULL,
	accoutant_id INT NOT NULL,
	update_status_time DATETIME,
	import_time DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	note VARCHAR(255),
	FOREIGN KEY (staff_id)
	REFERENCES staffs(staff_id) ON DELETE CASCADE,
	FOREIGN KEY (provider_id)
	REFERENCES providers(provider_id) ON DELETE CASCADE,
	FOREIGN KEY (accoutant_id)
	REFERENCES staffs(staff_id)
);

CREATE TABLE invoice_detail(
	invoice_id INT NOT NULL,
	laptop_id INT NOT NULL,
	quantity INT NOT NULL DEFAULT 1,
	unit_price DECIMAL NOT NULL,
	PRIMARY KEY(invoice_id,laptop_id),
	FOREIGN KEY (invoice_id)
	REFERENCES import_invoices(invoice_id) ON DELETE CASCADE,
	FOREIGN KEY (laptop_id)
	REFERENCES laptops(laptop_id) ON DELETE CASCADE
);

CREATE TABLE service_requests(
	request_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	order_id INT NOT NULL,
	request_time DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	type INT NOT NULL,
	decription VARCHAR(255) NOT NULL,
	rating INT NOT NULL,
	status INT NOT NULL,
	update_status_time DATETIME,
	FOREIGN KEY (order_id)
	REFERENCES orders(order_id) ON DELETE CASCADE
);


