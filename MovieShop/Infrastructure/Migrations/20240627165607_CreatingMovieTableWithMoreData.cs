using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatingMovieTableWithMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "BackDropUrl",
                table: "Movies",
                type: "nvarchar(2084)",
                maxLength: 2084,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Budget",
                table: "Movies",
                type: "decimal(18,4)",
                nullable: true,
                defaultValue: 9.9m);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<string>(
                name: "ImbdUrl",
                table: "Movies",
                type: "nvarchar(2084)",
                maxLength: 2084,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalLanguage",
                table: "Movies",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Overview",
                table: "Movies",
                type: "nvarchar(max)",
                maxLength: 4096,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosterUrl",
                table: "Movies",
                type: "nvarchar(2084)",
                maxLength: 2084,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movies",
                type: "decimal(5,2)",
                nullable: true,
                defaultValue: 9.9m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Revenue",
                table: "Movies",
                type: "decimal(18,4)",
                nullable: true,
                defaultValue: 9.9m);

            migrationBuilder.AddColumn<int>(
                name: "Runtime",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tagline",
                table: "Movies",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TmdbUrl",
                table: "Movies",
                type: "nvarchar(2084)",
                maxLength: 2084,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Movies",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Budget",
                table: "Movies",
                column: "Budget");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Price",
                table: "Movies",
                column: "Price");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Revenue",
                table: "Movies",
                column: "Revenue");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Title",
                table: "Movies",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Budget",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Price",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Revenue",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Title",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "BackDropUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImbdUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "OriginalLanguage",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Overview",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PosterUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Revenue",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Runtime",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Tagline",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TmdbUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");
        }
    }
}
