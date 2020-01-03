using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Data.Migrations
{
    public partial class addingStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                schema: "thamco.events",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StaffSurname = table.Column<string>(nullable: false),
                    StaffFirstName = table.Column<string>(nullable: false),
                    StaffEmail = table.Column<string>(nullable: false),
                    FirstAider = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "Staffings",
                schema: "thamco.events",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false),
                    StaffID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffings", x => new { x.StaffID, x.EventID });
                    table.ForeignKey(
                        name: "FK_Staffings_Events_EventID",
                        column: x => x.EventID,
                        principalSchema: "thamco.events",
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staffings_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalSchema: "thamco.events",
                        principalTable: "Staffs",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffs",
                columns: new[] { "StaffID", "FirstAider", "StaffEmail", "StaffFirstName", "StaffSurname" },
                values: new object[] { 1, true, "BSouch@email.com", "Ben", "Souch" });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffs",
                columns: new[] { "StaffID", "FirstAider", "StaffEmail", "StaffFirstName", "StaffSurname" },
                values: new object[] { 2, false, "JJardine@email.com", "Jacob", "Jardine" });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffings",
                columns: new[] { "StaffID", "EventID" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffings",
                columns: new[] { "StaffID", "EventID" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                schema: "thamco.events",
                table: "Staffings",
                columns: new[] { "StaffID", "EventID" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Staffings_EventID",
                schema: "thamco.events",
                table: "Staffings",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffings",
                schema: "thamco.events");

            migrationBuilder.DropTable(
                name: "Staffs",
                schema: "thamco.events");
        }
    }
}
