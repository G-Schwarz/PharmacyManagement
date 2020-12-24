CREATE DATABASE DB_DRUGSTORE
USE DB_DRUGSTORE

SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

CREATE TABLE PRODUCT_TYPE
(
	ProductTypeID char(4) Primary key,
	ProductTypeName varchar(30),
	ProductTypeDesc varchar(200),
)
GO

INSERT INTO PRODUCT_TYPE VALUES ('MEDS', 'Medicine', '')
INSERT INTO PRODUCT_TYPE VALUES ('PROD', 'General Products', 'Includes supplements, functional foods and medical gear/apparel.')
INSERT INTO PRODUCT_TYPE VALUES ('SERV', 'Services', '')
GO

CREATE TABLE PRODUCT_GROUP
(
	ProductGroupID char(5) Primary key,
	ProductGroupName varchar(50),
	ProductTypeDef varchar(200),
)
GO

CREATE TABLE PRODUCT
(
	ProductID char(10) Primary key,
	ProductName varchar(100),
	ProductTypeID char(4) NOT NULL,
	ProductGroupID char(5),
	BasePrice money,
	SellingPrice money,
	CONSTRAINT FK_PRODUCT_PRODUCT_TYPE FOREIGN KEY (ProductTypeID) REFERENCES PRODUCT_TYPE(ProductTypeID),
	CONSTRAINT FK_PRODUCT_PRODUCT_GROUP FOREIGN KEY (ProductGroupID) REFERENCES PRODUCT_GROUP(ProductGroupID)
)
GO

CREATE TABLE LOT
(
	LotID char(5) Primary key,
	ProductID char(10) NOT NULL,
	ExpirationDate smalldatetime NOT NULL,
	Inv int,
	CONSTRAINT FK_PRODUCT_LOT FOREIGN KEY (ProductID) REFERENCES PRODUCT (ProductID)
)
GO

/* since each product type has varying attributes, we're "recycling" the core concept of OOP programming: one table for each product type that "inherits"
all base attributes from the base table, yet each has its own attributes and constraint */

/* producer, country and unit tables are for indexing their respecting columns in the product list */
CREATE TABLE PRODUCER /* NOT supplier! */
(
	ProducerID char(10) Primary key,
	ProducerName varchar(100),
)
GO

CREATE TABLE COUNTRY
(
	CountryID char(5) Primary key,
	CountryName varchar(60),
)
GO

CREATE TABLE UNIT
(
	UnitID char(4) Primary key,
	UnitName varchar(20),
)
GO

CREATE TABLE NON_SERVICES
(
	ProductID char(10) Primary key,
	PackagingMethod varchar(30),
	ProducerID char(10),
	Origin char(5),
	UnitID char(4),
	ProductWeight float,
	InvMin int NULL, /* only import product if <= InvMin */
	InvMax int NULL, /* reject imports if the resulting inv exceeds max */
	CONSTRAINT FK_NON_SERVICES_PRODUCT FOREIGN KEY (ProductID) REFERENCES PRODUCT(ProductID),
	CONSTRAINT FK_NON_SERVICES_PRODUCER FOREIGN KEY (ProducerID) REFERENCES PRODUCER(ProducerID),
	CONSTRAINT FK_NON_SERVICES_ORIGIN FOREIGN KEY (Origin) REFERENCES COUNTRY(CountryID),
	CONSTRAINT FK_NON_SERVICES_UNIT FOREIGN KEY (UnitID) REFERENCES UNIT(UnitID),
	CONSTRAINT CHECK_InvMin_InvMax CHECK (InvMin < InvMax)
)
GO

CREATE TABLE MEDICINE
(
	ProductID char(10) Primary key,
	Usage varchar(200),
	ActiveIngredient varchar(60),
	Amount float, /* measured in grams */
	CONSTRAINT FK_MEDICINE_NON_SERVICES FOREIGN KEY (ProductID) REFERENCES NON_SERVICES(ProductID)
)

CREATE TABLE GEN_PRODUCT
(
	ProductID char(10) Primary key,
	IsLotBased bit NOT NULL,
	CONSTRAINT FK_GEN_PRODUCT_NON_SERVICES FOREIGN KEY (ProductID) REFERENCES NON_SERVICES(ProductID),
)
GO

CREATE TABLE INV_BASED_GEN_PRODUCT
(
	ProductID char(10) Primary key,
	Inv int,
	CONSTRAINT FK_IBGP_GEN_PRODUCT FOREIGN KEY (ProductID) REFERENCES GEN_PRODUCT(ProductID),
)
GO

/* actors that may participate in drugstore activities
negative debt indicates the amount of money the drugstore owes said entity
positive debt is the amount said entity is expected to pay back to the store */

CREATE TABLE CUSTOMER
(
	CustomerID char(10) Primary key,
	CustomerType bit, /* 0 = individual, 1 = corporate; this determines whether customer has to pay VAT via a TIN */
	CustomerName varchar(100),
	Gender bit,
	Phone varchar(20),
	Addr varchar(75), /* address */
	DoB smalldatetime,
	Company varchar(50), /* should only be used if CustomerType = 1 */
	TIN varchar(30), /* Taxpayer Identification Number */
	Email varchar(30),
	Facebook varchar(30),
	Debts money,
	CONSTRAINT CHK_Phone_CUSTOMER CHECK (Phone NOT LIKE '%[^0-9]%'), /* ensures following fields are digit only */
	CONSTRAINT CHK_TIN_CUSTOMER CHECK (TIN NOT LIKE '%[^0-9]%'),
)
GO

CREATE TABLE SUPPLIER
(
	SupplierID char(10) Primary key,
	SupplierName varchar(50),
	Phone varchar(20),
	Addr varchar(75),
	Email varchar(30),
	TIN varchar(30),
	Debts money,
	CONSTRAINT CHK_PHONE_SUPPLIER CHECK (PHONE NOT LIKE '%[^0-9]%'),
	CONSTRAINT CHK_TIN_SUPPLIER CHECK (TIN NOT LIKE '%[^0-9]%'),
)
GO

CREATE TABLE EMPLOYEE_TYPE
(
	EmployeeTypeID char(4) Primary key,
	EmployeeTypeName varchar(40),
	EmployeeTypeDesc varchar(100),
)
GO

CREATE TABLE EMPLOYEE
(
	EmployeeID char(10) Primary key,
	EmployeeName varchar(50),
	DoB smalldatetime,
	Gender bit,
	NatID char(12),
	EmployeeTypeID char(4) NOT NULL, /* decides privileges */
	Phone varchar(20),
	Email varchar(30),
	Facebook varchar(30),
	Addr varchar(75),
	CONSTRAINT FK_EMPLOYEE_EMPLOYEE_TYPE FOREIGN KEY (EmployeeTypeID) REFERENCES EMPLOYEE_TYPE(EmployeeTypeID),
	CONSTRAINT CHK_Phone_EMPLOYEE CHECK (Phone NOT LIKE '%[^0-9]%'),
	CONSTRAINT CHK_NatID_EMPLOYEE CHECK (NatID NOT LIKE '%[^0-9]%'),
)
GO

CREATE TABLE USERNAME
(
	UserID char(12),
	EmployeeID char(10) NOT NULL,
	Username varchar(20),
	Pword varchar(30),
	Primary key (UserID, Username),
	CONSTRAINT FK_USERNAME_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID)
)
GO

CREATE TABLE PAYMENT_METHOD
(
	MethodID char(4) Primary key,
	MethodName varchar(20),
)
GO

INSERT INTO PAYMENT_METHOD VALUES ('CASH', 'Cash')
INSERT INTO PAYMENT_METHOD VALUES ('CRED', 'Credit card')
INSERT INTO PAYMENT_METHOD VALUES ('TRAN', 'Transfer')
GO

CREATE TABLE INVOICE_TYPE
(
	InvoiceTypeID char(4) Primary key,
	InvoiceTypeName varchar(50),
)
GO

INSERT INTO INVOICE_TYPE VALUES ('PRSC', 'By prescription')
INSERT INTO INVOICE_TYPE VALUES ('PRDT', 'By product')
INSERT INTO INVOICE_TYPE VALUES ('DOSG', 'By dosage')
GO

CREATE TABLE INVOICE
(
	InvoiceID char(10) Primary key,
	CustomerID char(10) NOT NULL,
	EmployeeID char(10) NOT NULL,
	InvoiceDate smalldatetime,
	MethodID char(4) NOT NULL,
	InvoiceTypeID char(4) NOT NULL,
	VAT money,
	Discount money,
	Total money,
	CONSTRAINT FK_INVOICE_CUSTOMER FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID),
	CONSTRAINT FK_INVOICE_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID),
	CONSTRAINT FK_INVOICE_PAYMENT_METHOD FOREIGN KEY (MethodID) REFERENCES PAYMENT_METHOD(MethodID),
	CONSTRAINT FK_INVOICE_INVOICE_TYPE FOREIGN KEY (InvoiceTypeID) REFERENCES INVOICE_TYPE(InvoiceTypeID),
)
GO

CREATE TABLE INVOICE_DETAILS
(
	InvoiceID char(10) NOT NULL,
	ProductID char(10) NOT NULL,
	LotID char(5) NULL,
	Quantity int,
	UnitPrice money,
	VAT money,
	Discount money,
	Total money,
	Primary key(InvoiceID, ProductID),
	CONSTRAINT FK_INVOICE_DETAILS_INVOICE FOREIGN KEY (InvoiceID) REFERENCES INVOICE(InvoiceID),
	CONSTRAINT FK_INVOICE_DETAILS_PRODUCT FOREIGN KEY (ProductID) REFERENCES PRODUCT(ProductID),
	CONSTRAINT FK_INVOICE_DETAILS_LOT FOREIGN KEY (LotID) REFERENCES LOT(LotID),
)
GO

CREATE TABLE IMPORT
(
	ImportID char(10) Primary key,
	EmployeeID char(10) NOT NULL,
	SupplierID char(10) NOT NULL,
	ImportDate smalldatetime,
	MethodID char(4) NOT NULL,
	VAT money,
	Discount money,
	Total money,
	CONSTRAINT FK_IMPORT_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID),
	CONSTRAINT FK_IMPORT_SUPPLIER FOREIGN KEY (SupplierID) REFERENCES SUPPLIER(SupplierID),
	CONSTRAINT FK_IMPORT_PAYMENT_METHOD FOREIGN KEY (MethodID) REFERENCES PAYMENT_METHOD(MethodID),
)
GO

CREATE TABLE IMPORT_DETAILS
(
	ImportID char(10) NOT NULL,
	ProductID char(10) NOT NULL,
	LotID char(5) NULL,
	Unit varchar(15),
	Amount int,
	UnitPrice money, /* this UnitPrice is NOT the SellingPrice in the PRODUCT TABLE! it is instead the import fee of the product */
	VAT money,
	Discount money,
	Total money,
	Primary key (ImportID, ProductID),
	CONSTRAINT FK_IMPORT_DETAILS_IMPORT FOREIGN KEY (ImportID) REFERENCES IMPORT(ImportID),
	CONSTRAINT FK_IMPORT_DETAILS_PRODUCT FOREIGN KEY (ProductID) REFERENCES PRODUCT(ProductID),
	CONSTRAINT FK_IMPORT_DETAILS_LOT FOREIGN KEY (LotID) REFERENCES LOT(LotID)
)
GO

CREATE TABLE DISCARD
(
	DiscardID char(10) Primary key,
	EmployeeID char(10) NOT NULL,
	DiscardDate smalldatetime,
	TotalValue money,
	CONSTRAINT FK_DISCARD_EMPLOYEE FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID),
)
GO

CREATE TABLE DISCARD_DETAILS
(
	DiscardID char(10) NOT NULL,
	ProductID char(10) NOT NULL,
	LotID char(5) NULL,
	Quantity int,
	BasePrice money,
	TotalValue money,
	Primary key (DiscardID, ProductID),
	CONSTRAINT FK_DISCARD_DETAILS_DISCARD FOREIGN KEY (DiscardID) REFERENCES DISCARD(DiscardID),
	CONSTRAINT FK_DISCARD_DETAILS_PRODUCT FOREIGN KEY (ProductID) REFERENCES PRODUCT(ProductID)
)
GO

CREATE TABLE TRANSACT
(
	TransactID char(10) Primary key,
	TransactType bit NOT NULL, /* 0 = receipt, 1 = payment */
	TransactDate smalldatetime,
	TransactReason varchar(50),
	TransactValue money,
	CustomerID char(10) NULL,
	SupplierID char(10) NULL,
	CONSTRAINT FK_TRANSACT_CUSTOMER FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(CustomerID),
	CONSTRAINT FK_TRANSACT_SUPPLIER FOREIGN KEY (SupplierID) REFERENCES SUPPLIER(SupplierID),
	CONSTRAINT CHK_ID_RECEIPT CHECK (
		CASE WHEN CustomerID IS NULL THEN 0 ELSE 1 END +
		CASE WHEN SupplierID IS NULL THEN 0 ELSE 1 END = 1	
	)
)
GO

CREATE TRIGGER ON_LOT_INSERT
ON LOT
FOR INSERT
AS
	DECLARE @ProductID char(10), @ProductTypeID char(4), @ExpirationDate smalldatetime, @LotID char(5)

	SELECT @ProductID = ProductID, @ExpirationDate = ExpirationDate, @LotID = LotID FROM INSERTED
	SELECT @ProductTypeID = ProductTypeID FROM PRODUCT WHERE PRODUCT.ProductID = @ProductID

	/* ensures new lots are for medicine or lot-reliant products only */
	IF (@ProductTypeID = 'SERV')
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Services cannot be lot-based!', 16, 1)
		RETURN
	END
	ELSE
	BEGIN
		IF (@ProductTypeID = 'PROD')
		BEGIN
			DECLARE @IsLotBased bit
			SELECT @IsLotBased = IsLotBased FROM GEN_PRODUCT WHERE GEN_PRODUCT.ProductID = @ProductID
			IF (@IsLotBased = 0)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('Product declared being unreliant on lots, therefore cannot be lot-based!', 16, 1)
				RETURN
			END
		END
	END

	/* ensures new lots are usable for at least 6 months */
	IF (DATEDIFF(month, GETDATE(), @ExpirationDate) <= 6)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Lot rejected due to being close to expiration.', 16, 1)
		RETURN
	END

	/* ensures new lots always start with 0 in stock - required for data integrity when creating invoices or imports */
	UPDATE LOT SET Inv = 0 WHERE LotID = @LotID
	RETURN
GO

CREATE TRIGGER ON_INVOICE_INSERT
ON INVOICE
FOR INSERT
AS
	DECLARE @InvoiceID char(10)
	SELECT @InvoiceID = InvoiceID FROM INSERTED
	UPDATE INVOICE SET Total = 0 , VAT = 0, Discount = 0 WHERE InvoiceID = @InvoiceID
	RETURN
GO

CREATE TRIGGER ON_INVOICE_DETAILS_INSERT
ON INVOICE_DETAILS
FOR INSERT
AS
	DECLARE @ProductID char(10), @LotID char(5), @ProductTypeID char(4), @InvoiceID char(10), @Quantity int, @Inv int, @CustomerID char(10), @UnitPrice money, @VAT money, @Discount money, @Total money
	SELECT @ProductID = ProductID, @LotID = LotID, @InvoiceID = InvoiceID, @Quantity = Quantity, @Discount = Discount, @VAT = VAT FROM INSERTED
	SELECT @ProductTypeID = ProductTypeID, @UnitPrice = SellingPrice FROM PRODUCT WHERE PRODUCT.ProductID = @ProductID
	SELECT @CustomerID = CustomerID FROM INVOICE WHERE INVOICE.InvoiceID = @InvoiceID
	SET @Total = @Quantity * @UnitPrice

	IF (@ProductTypeID = 'SERV') /* services are not expected to be distributed via lots */
	BEGIN
		IF (@LotID IS NOT NULL)
		BEGIN
			ROLLBACK TRAN
			RAISERROR ('Product declared being unreliant on lots, therefore cannot be lot-based!', 16, 1)
			RETURN
		END
	END
	ELSE
	BEGIN
		IF (@ProductTypeID = 'PROD')
		BEGIN
			DECLARE @IsLotBased bit
			SELECT @IsLotBased = IsLotBased FROM GEN_PRODUCT WHERE GEN_PRODUCT.ProductID = @ProductID

			IF (@IsLotBased = 0)
			BEGIN
				UPDATE INVOICE_DETAILS
				SET @LotID = NULL WHERE INVOICE_DETAILS.InvoiceID = @InvoiceID /* remove LotID if product being unreliant on lots */

				SELECT @Inv = Inv FROM INV_BASED_GEN_PRODUCT WHERE INV_BASED_GEN_PRODUCT.ProductID = @ProductID
				IF (@Quantity > @Inv)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Demands exceeded current inventory!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					UPDATE INV_BASED_GEN_PRODUCT
					SET Inv = Inv - @Quantity WHERE INV_BASED_GEN_PRODUCT.ProductID = @ProductID
				END
			END
			ELSE /* if product is lot-reliant, remove entry if LotID turns up null */
			BEGIN
				IF (@LotID IS NULL)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Product declared being reliant on lots, theremore must be associated with one!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					SELECT @Inv = Inv FROM LOT WHERE LOT.LotID = @LotID

					IF (@Quantity > @Inv)
					BEGIN
						ROLLBACK TRAN
						RAISERROR ('Demands exceeded current inventory!', 16, 1)
						RETURN
					END
					ELSE
					BEGIN
						UPDATE LOT
						SET Inv = Inv - @Quantity WHERE LOT.LotID = @LotID
					END
				END
			END
		END
		ELSE
		BEGIN /* since medicine is always lot-based, reject all entires without a LotID */
			IF (@LotID IS NULL)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('A medicine must always be associated with a lot!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				SELECT @Inv = Inv FROM LOT WHERE LOT.LotID = @LotID

				IF (@Quantity > @Inv)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Demands exceeded current inventory!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					UPDATE LOT
					SET Inv = Inv - @Quantity WHERE LOT.LotID = @LotID
				END
			END
		END
	END

	IF (@VAT >= @Total)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Exorbitant VAT rates detected!', 16, 1)
		RETURN
	END

	IF (@Discount >= @Total)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Invalid discount rate!', 16, 1)
		RETURN
	END

	SET @Total = @Total - @Discount + @VAT

	UPDATE INVOICE_DETAILS /* corrects UnitPrice column so it matches PRODUCT.SellingPrice, and Total if there's a miscalculation */
	SET INVOICE_DETAILS.UnitPrice = @UnitPrice, INVOICE_DETAILS.Total = @Total, INVOICE_DETAILS.Discount = @Discount, INVOICE_DETAILS.VAT = @VAT WHERE (INVOICE_DETAILS.InvoiceID = @InvoiceID) AND (INVOICE_DETAILS.ProductID = @ProductID)
	UPDATE INVOICE /* updates the total value of the invoice */
	SET INVOICE.Total = INVOICE.Total + @Total, INVOICE.VAT = INVOICE.VAT + @VAT, INVOICE.Discount = INVOICE.Discount + @Discount WHERE INVOICE.InvoiceID = @InvoiceID
	UPDATE CUSTOMER /* indicates that the customer now owes the store money */
	SET CUSTOMER.Debts = CUSTOMER.Debts + @Total WHERE CUSTOMER.CustomerID = @CustomerID
	RETURN
GO

CREATE TRIGGER ON_IMPORT_INSERT
ON IMPORT
FOR INSERT
AS
	DECLARE @ImportID char(10)
	SELECT @ImportID = ImportID FROM INSERTED
	UPDATE IMPORT
	SET Total = 0, VAT = 0, Discount = 0 WHERE ImportID = @ImportID
GO

CREATE TRIGGER ON_IMPORT_DETAILS_INSERT
ON IMPORT_DETAILS
FOR INSERT
AS
	DECLARE @ProductID char(10), @ProductTypeID char(4), @LotID char(5), @ImportID char(10), @Amount int, @Inv int, @InvMax int, @InvMin int, @UnitPrice money, @BasePrice money, @VAT money, @Discount money, @Total money, @SupplierID char(10)
	SELECT @ProductID = ProductID, @LotID = LotID, @ImportID = ImportID, @Amount = Amount, @UnitPrice = UnitPrice, @VAT = VAT, @Discount = Discount FROM INSERTED
	SELECT @SupplierID = SupplierID FROM IMPORT WHERE IMPORT.ImportID = @ImportID
	SELECT @ProductTypeID = ProductTypeID, @BasePrice = BasePrice FROM PRODUCT WHERE ProductID = @ProductID
	SET @Total = @Amount * @UnitPrice

	IF (@ProductTypeID = 'SERV')
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Cannot import a service!', 16, 1)
		RETURN
	END
	ELSE
	BEGIN
		IF (@ProductTypeID = 'PROD')
		BEGIN
			DECLARE @IsLotBased bit
			SELECT @IsLotBased = IsLotBased FROM GEN_PRODUCT WHERE GEN_PRODUCT.ProductID = @ProductID
			IF (@IsLotBased = 0)
			BEGIN
				UPDATE IMPORT_DETAILS
				SET @LotID = NULL WHERE IMPORT_DETAILS.ImportID = @ImportID /* if product is declared not reliant on lots, simply remove the LotID */

				/* ensures inventory stays within set boundaries, before and after import */
				/* if about to exceed boundaries, import anyway if the price is right (get it?) */
				/* otherwise, rollback (will result in profit loss) */
				SELECT @Inv = Inv FROM INV_BASED_GEN_PRODUCT WHERE ProductID = @ProductID
				IF ((@Inv > @InvMin) OR (@Inv + @Amount > @InvMax))
				BEGIN
					IF (@UnitPrice >= @BasePrice)
					BEGIN
						ROLLBACK TRAN
						RAISERROR ('Cannot import product: would exceed pre-determined limits!', 16, 1)
						RETURN
					END
				END

				UPDATE INV_BASED_GEN_PRODUCT
				SET Inv = Inv + @Amount WHERE ProductID = @ProductID
			END
			ELSE /* if product is lot-reliant, remove entry if LotID turns up null */
			BEGIN
				IF (@LotID IS NULL)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Product declared being reliant on lots, theremore must be associated with one!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					SELECT @InvMax = InvMax, @InvMin = InvMin FROM NON_SERVICES WHERE ProductID = @ProductID
					SELECT @Inv = SUM(Inv) FROM LOT WHERE ProductID = @ProductID

					IF ((@Inv > @InvMin) OR (@Inv + @Amount > @InvMax))
					BEGIN
						IF (@UnitPrice >= @BasePrice)
						BEGIN
							ROLLBACK TRAN
							RAISERROR ('Cannot import product: would exceed pre-determined limits!', 16, 1)
							RETURN
						END
					END

					UPDATE LOT
					SET Inv = Inv + @Amount WHERE LOT.LotID = @LotID
				END
			END
		END
		ELSE
		BEGIN /* since medicine is always lot-based, reject all entires without a LotID */
			IF (@LotID IS NULL)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('A medicine must always be associated with a lot!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				SELECT @InvMax = InvMax, @InvMin = InvMin FROM NON_SERVICES WHERE ProductID = @ProductID
				SELECT @Inv = SUM(Inv) FROM LOT WHERE ProductID = @ProductID

				IF ((@Inv > @InvMin) OR (@Inv + @Amount > @InvMax))
				BEGIN
					IF (@UnitPrice >= @BasePrice)
					BEGIN
						ROLLBACK TRAN
						RAISERROR ('Cannot import product: would exceed pre-determined limits!', 16, 1)
						RETURN
					END
				END

				UPDATE LOT
				SET Inv = Inv + @Amount WHERE LOT.LotID = @LotID
			END
		END
	END

	IF (@VAT >= @Total)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Exorbitant VAT rates detected!', 16, 1)
		RETURN
	END

	IF (@Discount >= @Total)
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Invalid discount rate!', 16, 1)
		RETURN
	END

	SET @Total = @Total - @Discount + @VAT

	UPDATE IMPORT_DETAILS
	SET Total = @Total, Discount = @Discount, VAT = @VAT WHERE (IMPORT_DETAILS.ProductID = @ProductID) AND (IMPORT_DETAILS.ImportID = @ImportID)
	UPDATE IMPORT
	SET Total = Total + @Total, Discount = Discount + @Discount, VAT = VAT + @VAT WHERE ImportID = @ImportID
	UPDATE SUPPLIER
	SET Debts = Debts - @Total WHERE SupplierID = @SupplierID
	RETURN
GO

CREATE TRIGGER ON_DISCARD_INSERT
ON DISCARD
FOR INSERT
AS
	DECLARE @DiscardID char(10)
	SELECT @DiscardID = DiscardID FROM INSERTED
	UPDATE DISCARD
	SET TotalValue = 0 WHERE DiscardID = @DiscardID
	RETURN
GO

CREATE TRIGGER ON_DISCARD_DETAILS_INSERT
ON DISCARD_DETAILS
FOR INSERT
AS
	DECLARE @ProductID char(10), @LotID char(5), @ProductTypeID char(4), @DiscardID char(10), @Quantity int, @Inv int, @BasePrice money, @Total money
	SELECT @ProductID = ProductID, @LotID = LotID, @DiscardID = DiscardID, @Quantity = Quantity FROM INSERTED
	SELECT @ProductTypeID = ProductTypeID, @BasePrice = BasePrice FROM PRODUCT WHERE PRODUCT.ProductID = @ProductID
	SET @Total = @Quantity * @BasePrice

	IF (@ProductTypeID = 'SERV')
	BEGIN
		ROLLBACK TRAN
		RAISERROR ('Cannot discard a service!', 16, 1)
		RETURN
	END
	ELSE
	BEGIN
		IF (@ProductTypeID = 'PROD')
		BEGIN
			DECLARE @IsLotBased bit
			SELECT @IsLotBased = IsLotBased FROM GEN_PRODUCT WHERE GEN_PRODUCT.ProductID = @ProductID

			IF (@IsLotBased = 0) /* if product is declared not reliant on lots, simply remove the LotID */
			BEGIN
				UPDATE DISCARD_DETAILS
				SET @LotID = NULL WHERE DISCARD_DETAILS.DiscardID = @DiscardID

				SELECT @Inv = Inv FROM INV_BASED_GEN_PRODUCT WHERE INV_BASED_GEN_PRODUCT.ProductID = @ProductID

				IF (@Inv < @Quantity)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Cannot discard more than the current inventory!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					UPDATE INV_BASED_GEN_PRODUCT
					SET Inv = Inv - @Quantity WHERE INV_BASED_GEN_PRODUCT.ProductID = @ProductID
				END
			END
			ELSE /* if product is lot-reliant, remove entry if LotID turns up null */
			BEGIN
				IF (@LotID IS NULL)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Product declared being reliant on lots, theremore must be associated with one!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					SELECT @Inv = Inv FROM LOT WHERE LOT.LotID = @LotID

					IF (@Inv < @Quantity)
					BEGIN
						ROLLBACK TRAN
						RAISERROR ('Cannot discard more than the current inventory!', 16, 1)
						RETURN
					END
					ELSE
					BEGIN
						UPDATE LOT
						SET Inv = Inv - @Quantity WHERE LOT.LotID = @LotID
					END
				END
			END
		END
		ELSE
		BEGIN /* since medicine is always lot-based, reject all entires without a LotID */
			IF (@LotID IS NULL)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('A medicine must always be associated with a lot!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				SELECT @Inv = Inv FROM LOT WHERE LOT.LotID = @LotID

				IF (@Inv < @Quantity)
				BEGIN
					ROLLBACK TRAN
					RAISERROR ('Cannot discard more than the current inventory!', 16, 1)
					RETURN
				END
				ELSE
				BEGIN
					UPDATE LOT
					SET Inv = Inv - @Quantity WHERE LOT.LotID = @LotID
				END
			END
		END
	END

	UPDATE DISCARD_DETAILS
	SET DISCARD_DETAILS.BasePrice = @BasePrice, DISCARD_DETAILS.TotalValue = @Total WHERE (DISCARD_DETAILS.ProductID = @ProductID) AND (DISCARD_DETAILS.DiscardID = @DiscardID)
	UPDATE DISCARD
	SET DISCARD.TotalValue = DISCARD.TotalValue + @Total WHERE DISCARD.DiscardID = @DiscardID
	RETURN
GO

CREATE TRIGGER ON_TRANSACT_INSERT
ON TRANSACT
FOR INSERT
AS
	DECLARE @TransactValue money, @CustomerID char(10), @SupplierID char(10), @Debts money, @TransactType bit
	SELECT @TransactValue = TransactValue, @CustomerID = CustomerID, @SupplierID = SupplierID, @TransactType = TransactType FROM INSERTED

	IF (@CustomerID IS NOT NULL)
	BEGIN
		IF (@TransactType = 0)
		BEGIN
			SELECT @Debts = Debts FROM CUSTOMER WHERE CustomerID = @CustomerID
			IF (@TransactValue > @Debts)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('Receipt value cannot exceed debt!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				UPDATE CUSTOMER
				SET Debts = Debts - @TransactValue WHERE CUSTOMER.CustomerID = @CustomerID
				RETURN
			END
		END
		ELSE
		BEGIN
			SELECT @Debts = -(Debts) FROM CUSTOMER WHERE CustomerID = @CustomerID
			IF (@TransactValue > @Debts)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('Payment value cannot exceed debt!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				UPDATE CUSTOMER
				SET Debts = Debts + @TransactValue WHERE CustomerID = @CustomerID
				RETURN
			END
		END
	END
	ELSE
	BEGIN
		IF (@TransactType = 0)
		BEGIN
			SELECT @Debts = Debts FROM SUPPLIER WHERE SupplierID = @SupplierID
			IF (@TransactValue > @Debts)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('Receipt value cannot exceed debt!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				UPDATE SUPPLIER
				SET Debts = Debts - @TransactValue WHERE SupplierID = @SupplierID
				RETURN
			END
		END
		ELSE
		BEGIN
			SELECT @Debts = -(Debts) FROM SUPPLIER WHERE SupplierID = @SupplierID
			IF (@TransactValue > @Debts)
			BEGIN
				ROLLBACK TRAN
				RAISERROR ('Payment value cannot exceed debt!', 16, 1)
				RETURN
			END
			ELSE
			BEGIN
				UPDATE SUPPLIER
				SET Debts = Debts + @TransactValue WHERE SupplierID = @SupplierID
				RETURN
			END
		END
	END
GO

/*hard reset commands, only used in case of screwups*/

/*EXEC sp_msforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

DECLARE @sql NVARCHAR(max)=''

SELECT @sql += ' Drop table ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'

Exec Sp_executesql @sql

DECLARE @TriggerName AS VARCHAR(500)

DECLARE DropTrigger CURSOR FOR
  SELECT TRG.name AS TriggerName
  FROM   sys.triggers TRG
         INNER JOIN sys.tables TBL
                 ON TBL.OBJECT_ID = TRG.parent_id 
OPEN DropTrigger
 FETCH Next FROM DropTrigger INTO @TriggerName 
WHILE @@FETCH_STATUS = 0
  BEGIN
      DECLARE @DropTrigger VARCHAR(MAX)=NULL
      SET @DropTrigger='Drop Trigger ' + @TriggerName
      PRINT 'Trigger ::' + @TriggerName
            + ' Droped Successfully'
      EXEC (@DropTrigger)
      PRINT @DropTrigger
      FETCH Next FROM DropTrigger INTO @TriggerName
  END
CLOSE DropTrigger 
DEALLOCATE DropTrigger*/

