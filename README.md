# Developer Store Team - Sales API
Prerequisites
To run this project, ensure you have the following installed on your machine:

1. Docker: Install Docker from Docker's official website.

Getting Started
Follow these steps to set up and run the project:

1. Clone the Repository
Clone this repository to your local machine.
````
git clone <repository-url>
cd <repository-folder>
````

2. Start Docker Containers
Navigate to the root directory of the project and run the following command to start the required services using Docker Compose:
````
docker-compose up -d
````
3. Wait for the services to initialize completely.

4. Execute create tables script.
````
CREATE TABLE "Sales" (
	"Id" UUID NOT NULL DEFAULT gen_random_uuid(),
	"CustomerId" UUID NOT NULL,
	"Date" TIMESTAMPTZ NOT NULL DEFAULT '2025-02-14 11:44:29.396806+00',
	"Branch" VARCHAR(255) NULL DEFAULT 'NULL::character varying',
	"TotalAmount" NUMERIC(18,2) NOT NULL,
	"IsCancelled" BOOLEAN NOT NULL DEFAULT 'false',
	"Discount" NUMERIC(18,2) NOT NULL,
	PRIMARY KEY ("Id")
)
;
CREATE SEQUENCE sales_item_id_seq START 1;
CREATE TABLE "SalesItem" (
	"Id" INTEGER NOT NULL DEFAULT nextval('sales_item_id_seq'::regclass),
	"SaleId" UUID NOT NULL,
	"ProductId" INTEGER NOT NULL,
	"Quantity" INTEGER NOT NULL,
	"Price" NUMERIC(18,2) NOT NULL,
	PRIMARY KEY ("Id"),
	CONSTRAINT "fk_sale" FOREIGN KEY ("SaleId") REFERENCES "public"."Sales" ("Id") ON UPDATE NO ACTION ON DELETE NO ACTION
)
;
````

5. Access the Application Sales API
Then now you can follow the link:

* Backend API (Swagger UI): http://localhost:8081/swagger/index.html
