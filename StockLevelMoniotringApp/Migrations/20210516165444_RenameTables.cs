using Microsoft.EntityFrameworkCore.Migrations;

namespace FormUI.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADRES",
                columns: table => new
                {
                    id_adres = table.Column<int>(type: "int", nullable: false),
                    town = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    street = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    street_number = table.Column<int>(type: "int", nullable: false),
                    local = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADRES", x => x.id_adres);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    id_category = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.id_category);
                });

            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    id_company = table.Column<int>(type: "int", nullable: false),
                    company_nape = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nip = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    compan_adres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.id_company);
                    table.ForeignKey(
                        name: "FK_COMPANY_ADRES",
                        column: x => x.compan_adres,
                        principalTable: "ADRES",
                        principalColumn: "id_adres",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    surename = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    pesel = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    job = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    email = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEOPLE", x => x.id_user);
                    table.ForeignKey(
                        name: "FK_PEOPLE_COMPANY",
                        column: x => x.job,
                        principalTable: "COMPANY",
                        principalColumn: "id_company",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WAREHOUSE",
                columns: table => new
                {
                    id_warehouse = table.Column<int>(type: "int", nullable: false),
                    warehouse_adres = table.Column<int>(type: "int", nullable: false),
                    warehouse_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    company = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WAREHOUSE", x => x.id_warehouse);
                    table.ForeignKey(
                        name: "FK_WAREHOUSE_ADRES",
                        column: x => x.warehouse_adres,
                        principalTable: "ADRES",
                        principalColumn: "id_adres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WAREHOUSE_COMPANY",
                        column: x => x.company,
                        principalTable: "COMPANY",
                        principalColumn: "id_company",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITEMS",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    height = table.Column<double>(type: "float", nullable: false),
                    width = table.Column<double>(type: "float", nullable: false),
                    depth = table.Column<double>(type: "float", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    location = table.Column<int>(type: "int", nullable: true),
                    category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMS", x => x.id_item);
                    table.ForeignKey(
                        name: "FK_ITEMS_CATEGORY",
                        column: x => x.category,
                        principalTable: "CATEGORY",
                        principalColumn: "id_category",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITEMS_WAREHOUSE",
                        column: x => x.location,
                        principalTable: "WAREHOUSE",
                        principalColumn: "id_warehouse",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_DETAIL",
                columns: table => new
                {
                    id_order_detail = table.Column<int>(type: "int", nullable: false),
                    product = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    discount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_DETAIL", x => x.id_order_detail);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAIL_ITEMS",
                        column: x => x.product,
                        principalTable: "ITEMS",
                        principalColumn: "id_item",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    id_order = table.Column<int>(type: "int", nullable: false),
                    sender = table.Column<int>(type: "int", nullable: false),
                    purchaser = table.Column<int>(type: "int", nullable: false),
                    from = table.Column<int>(type: "int", nullable: false),
                    to = table.Column<int>(type: "int", nullable: false),
                    order_item = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER", x => x.id_order);
                    table.ForeignKey(
                        name: "FK_ORDER_ADRES",
                        column: x => x.from,
                        principalTable: "ADRES",
                        principalColumn: "id_adres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_ADRES1",
                        column: x => x.to,
                        principalTable: "ADRES",
                        principalColumn: "id_adres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_ORDER_DETAIL",
                        column: x => x.order_item,
                        principalTable: "ORDER_DETAIL",
                        principalColumn: "id_order_detail",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_PEOPLE",
                        column: x => x.sender,
                        principalTable: "USER",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDER_PEOPLE1",
                        column: x => x.purchaser,
                        principalTable: "USER",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_compan_adres",
                table: "COMPANY",
                column: "compan_adres");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMS_category",
                table: "ITEMS",
                column: "category");

            migrationBuilder.CreateIndex(
                name: "IX_ITEMS_location",
                table: "ITEMS",
                column: "location");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_from",
                table: "ORDER",
                column: "from");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_order_item",
                table: "ORDER",
                column: "order_item");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_purchaser",
                table: "ORDER",
                column: "purchaser");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_sender",
                table: "ORDER",
                column: "sender");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_to",
                table: "ORDER",
                column: "to");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAIL_product",
                table: "ORDER_DETAIL",
                column: "product");

            migrationBuilder.CreateIndex(
                name: "IX_USER_job",
                table: "USER",
                column: "job");

            migrationBuilder.CreateIndex(
                name: "IX_WAREHOUSE_company",
                table: "WAREHOUSE",
                column: "company");

            migrationBuilder.CreateIndex(
                name: "IX_WAREHOUSE_warehouse_adres",
                table: "WAREHOUSE",
                column: "warehouse_adres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "ORDER_DETAIL");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "ITEMS");

            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "WAREHOUSE");

            migrationBuilder.DropTable(
                name: "COMPANY");

            migrationBuilder.DropTable(
                name: "ADRES");
        }
    }
}
