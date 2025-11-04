using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetWithVueAndAspire.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.Sql("INSERT INTO Images (Url, Description) VALUES ('https://i.etsystatic.com/33504850/r/il/a541d3/7210909158/il_1588xN.7210909158_484l.jpg', 'Pumpkin pattern')");
            migrationBuilder.Sql("INSERT INTO Images (Url, Description) VALUES ('https://i.etsystatic.com/21971696/r/il/492e61/3926048546/il_1588xN.3926048546_1n29.jpg', 'Bambi pattern')");
            migrationBuilder.Sql("INSERT INTO Images (Url, Description) VALUES ('https://i.etsystatic.com/52435180/r/il/8b046a/6230483443/il_1588xN.6230483443_cqqe.jpg', 'Ratón pattern')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
