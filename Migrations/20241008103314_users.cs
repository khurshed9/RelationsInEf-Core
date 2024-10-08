using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relations.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Courses_GroupId",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Students_StudentId",
                table: "StudentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Profile_UserId",
                table: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "Profiles");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Group");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Group_GroupId",
                table: "StudentGroup",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Student_StudentId",
                table: "StudentGroup",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Users_UserId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Group_GroupId",
                table: "StudentGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroup_Student_StudentId",
                table: "StudentGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Profiles_UserId",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profile");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Profile_UserId",
                table: "Profile",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_User_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Courses_GroupId",
                table: "StudentGroup",
                column: "GroupId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroup_Students_StudentId",
                table: "StudentGroup",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
