using Microsoft.EntityFrameworkCore.Migrations;

namespace StrainEarsDB.Migrations
{
    public partial class AddUniqueConditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PlaylistTracks_TrackId",
                table: "PlaylistTracks");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlaylistName",
                table: "Playlists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArtistLogin",
                table: "Artists",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_TrackId_PlaylistId",
                table: "PlaylistTracks",
                columns: new[] { "TrackId", "PlaylistId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_PlaylistName_UserId",
                table: "Playlists",
                columns: new[] { "PlaylistName", "UserId" },
                unique: true,
                filter: "[PlaylistName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ArtistLogin",
                table: "Artists",
                column: "ArtistLogin",
                unique: true,
                filter: "[ArtistLogin] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Email",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_PlaylistTracks_TrackId_PlaylistId",
                table: "PlaylistTracks");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_PlaylistName_UserId",
                table: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Artists_ArtistLogin",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "ArtistLogin",
                table: "Artists");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlaylistName",
                table: "Playlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTracks_TrackId",
                table: "PlaylistTracks",
                column: "TrackId");
        }
    }
}
