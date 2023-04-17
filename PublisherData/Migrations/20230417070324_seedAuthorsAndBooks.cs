using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class seedAuthorsAndBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "FirstName1", "LastName1" },
                    { 2, "FirstName2", "LastName2" },
                    { 3, "FirstName3", "LastName3" },
                    { 4, "FirstName4", "LastName4" },
                    { 5, "FirstName5", "LastName5" },
                    { 6, "FirstName6", "LastName6" },
                    { 7, "FirstName7", "LastName7" },
                    { 8, "FirstName8", "LastName8" },
                    { 9, "FirstName9", "LastName9" },
                    { 10, "FirstName10", "LastName10" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 100m, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_1" },
                    { 2, 1, 100m, new DateTime(2002, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_1" },
                    { 3, 1, 100m, new DateTime(2003, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_1" },
                    { 4, 1, 100m, new DateTime(2004, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_1" },
                    { 5, 1, 100m, new DateTime(2005, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_1" },
                    { 6, 2, 100m, new DateTime(2002, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_2" },
                    { 7, 2, 100m, new DateTime(2004, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_2" },
                    { 8, 2, 100m, new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_2" },
                    { 9, 2, 100m, new DateTime(2008, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_2" },
                    { 10, 2, 100m, new DateTime(2010, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_2" },
                    { 11, 3, 100m, new DateTime(2003, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_3" },
                    { 12, 3, 100m, new DateTime(2006, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_3" },
                    { 13, 3, 100m, new DateTime(2009, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_3" },
                    { 14, 3, 100m, new DateTime(2012, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_3" },
                    { 15, 3, 100m, new DateTime(2015, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_3" },
                    { 16, 4, 100m, new DateTime(2004, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_4" },
                    { 17, 4, 100m, new DateTime(2008, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_4" },
                    { 18, 4, 100m, new DateTime(2012, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_4" },
                    { 19, 4, 100m, new DateTime(2016, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_4" },
                    { 20, 4, 100m, new DateTime(2020, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_4" },
                    { 21, 5, 100m, new DateTime(2005, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_5" },
                    { 22, 5, 100m, new DateTime(2010, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_5" },
                    { 23, 5, 100m, new DateTime(2015, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_5" },
                    { 24, 5, 100m, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_5" },
                    { 25, 5, 100m, new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_5" },
                    { 26, 6, 100m, new DateTime(2006, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_6" },
                    { 27, 6, 100m, new DateTime(2012, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_6" },
                    { 28, 6, 100m, new DateTime(2018, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_6" },
                    { 29, 6, 100m, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_6" },
                    { 30, 6, 100m, new DateTime(2030, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_6" },
                    { 31, 7, 100m, new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_7" },
                    { 32, 7, 100m, new DateTime(2014, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_7" },
                    { 33, 7, 100m, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_7" },
                    { 34, 7, 100m, new DateTime(2028, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_7" },
                    { 35, 7, 100m, new DateTime(2035, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_7" },
                    { 36, 8, 100m, new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_8" },
                    { 37, 8, 100m, new DateTime(2016, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_8" },
                    { 38, 8, 100m, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_8" },
                    { 39, 8, 100m, new DateTime(2032, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_8" },
                    { 40, 8, 100m, new DateTime(2040, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_8" },
                    { 41, 9, 100m, new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_9" },
                    { 42, 9, 100m, new DateTime(2018, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_9" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 43, 9, 100m, new DateTime(2027, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_9" },
                    { 44, 9, 100m, new DateTime(2036, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_9" },
                    { 45, 9, 100m, new DateTime(2045, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_9" },
                    { 46, 10, 100m, new DateTime(2010, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_1_by_Author_10" },
                    { 47, 10, 100m, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_2_by_Author_10" },
                    { 48, 10, 100m, new DateTime(2030, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_3_by_Author_10" },
                    { 49, 10, 100m, new DateTime(2040, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_4_by_Author_10" },
                    { 50, 10, 100m, new DateTime(2050, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book_5_by_Author_10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
