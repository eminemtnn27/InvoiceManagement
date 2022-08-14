using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class updatedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "dues",
                columns: table => new
                {
                    DuesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DueAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    billingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dues", x => x.DuesId);
                    table.ForeignKey(
                        name: "FK_dues_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flats",
                columns: table => new
                {
                    FlatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FlatOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlatNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlatLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flats", x => x.FlatId);
                    table.ForeignKey(
                        name: "FK_flats_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    billingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_invoice_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceiveId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Messages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_messages_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingSum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    FlatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_flats_FlatId",
                        column: x => x.FlatId,
                        principalTable: "flats",
                        principalColumn: "FlatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dues_UserId",
                table: "dues",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_flats_UserId",
                table: "flats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_invoice_UserId",
                table: "invoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_UserId",
                table: "messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_FlatId",
                table: "Payments",
                column: "FlatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dues");

            migrationBuilder.DropTable(
                name: "invoice");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "flats");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
