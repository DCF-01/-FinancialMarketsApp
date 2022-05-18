using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceMarketsApp.Infrastructure.SQL.Migrations
{
    [Migration(1)]
    public class M0001_CreateUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Name").AsString(50)
                .WithColumn("Email").AsString(100);
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }
}
