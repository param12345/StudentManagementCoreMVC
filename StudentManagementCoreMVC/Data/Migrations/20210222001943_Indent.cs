using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace StudentManagementCoreMVC.Data.Migrations
{
    public partial class Indent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
