using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicketsBooking.Migrations
{
    public partial class NameFixActors_Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_movie_Actors_ActorId",
                table: "Actors_movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_movie_Movies_MovieId",
                table: "Actors_movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_movie",
                table: "Actors_movie");

            migrationBuilder.RenameTable(
                name: "Actors_movie",
                newName: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "Moviecategory",
                table: "Movies",
                newName: "MovieCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_movie_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actors_movie");

            migrationBuilder.RenameColumn(
                name: "MovieCategory",
                table: "Movies",
                newName: "Moviecategory");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_movie",
                newName: "IX_Actors_movie_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_movie",
                table: "Actors_movie",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_movie_Actors_ActorId",
                table: "Actors_movie",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_movie_Movies_MovieId",
                table: "Actors_movie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
