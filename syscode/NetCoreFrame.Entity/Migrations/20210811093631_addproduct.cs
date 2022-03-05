using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreFrame.Entity.Migrations
{
    public partial class addproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frame_Codes",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    CodeName = table.Column<string>(maxLength: 100, nullable: true),
                    CodeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Codes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_CodesValue",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    PID = table.Column<int>(nullable: false),
                    CodeValueID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(maxLength: 100, nullable: true),
                    ItemValue = table.Column<string>(maxLength: 100, nullable: true),
                    ItemEng = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_CodesValue", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_Dept",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    DeptName = table.Column<string>(maxLength: 50, nullable: true),
                    DeptCode = table.Column<string>(maxLength: 50, nullable: true),
                    DeptID = table.Column<int>(nullable: false),
                    PDeptID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Dept", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_FileUpload",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(maxLength: 100, nullable: true),
                    FilePath = table.Column<string>(maxLength: 200, nullable: true),
                    FileImgUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    FileType = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_FileUpload", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_InfoComments",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(maxLength: 200, nullable: true),
                    FileID = table.Column<string>(maxLength: 50, nullable: true),
                    Commenter = table.Column<string>(maxLength: 50, nullable: true),
                    CUserId = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_InfoComments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_InfoHistory",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    CUserId = table.Column<string>(maxLength: 50, nullable: true),
                    KeyWord = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_InfoHistory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_Information",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    AttachID = table.Column<string>(maxLength: 50, nullable: true),
                    FileType = table.Column<string>(maxLength: 50, nullable: true),
                    DownloadCount = table.Column<int>(nullable: false),
                    BoardCount = table.Column<int>(nullable: false),
                    FileContent = table.Column<string>(maxLength: 5000, nullable: true),
                    FileContentEn = table.Column<string>(maxLength: 5000, nullable: true),
                    FileTitle = table.Column<string>(maxLength: 100, nullable: true),
                    FileTitleEn = table.Column<string>(maxLength: 100, nullable: true),
                    ImgAttachID = table.Column<string>(maxLength: 50, nullable: true),
                    VideoLength = table.Column<int>(nullable: false),
                    VideoMinLength = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: true),
                    CategoryCode = table.Column<string>(maxLength: 50, nullable: true),
                    RegardCount = table.Column<int>(nullable: false),
                    RelayCount = table.Column<int>(nullable: false),
                    CommentCount = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Information", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_Module",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ModuleId = table.Column<int>(nullable: false),
                    PModuleId = table.Column<int>(nullable: false),
                    ModuleCode = table.Column<string>(maxLength: 50, nullable: true),
                    PModuleName = table.Column<string>(maxLength: 50, nullable: true),
                    Url = table.Column<string>(maxLength: 100, nullable: true),
                    IconName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Module", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_ModuleElement",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    DomId = table.Column<string>(maxLength: 50, nullable: true),
                    Script = table.Column<string>(maxLength: 50, nullable: true),
                    IconName = table.Column<string>(maxLength: 50, nullable: true),
                    BtnClass = table.Column<string>(maxLength: 50, nullable: true),
                    ModuleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_ModuleElement", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_Relations",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    RelationType = table.Column<int>(nullable: false),
                    FirstId = table.Column<string>(maxLength: 50, nullable: true),
                    SecondId = table.Column<string>(maxLength: 50, nullable: true),
                    ThirdId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Relations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_Role",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    RoleName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_TableField",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(maxLength: 50, nullable: true),
                    FieldType = table.Column<string>(maxLength: 50, nullable: true),
                    FieldLength = table.Column<int>(nullable: false),
                    DecimalLength = table.Column<int>(nullable: false),
                    FieldDisplayName = table.Column<string>(maxLength: 50, nullable: true),
                    FieldDisplayType = table.Column<string>(maxLength: 50, nullable: true),
                    DataSource_CodeName = table.Column<string>(maxLength: 50, nullable: true),
                    IsShowInAdd = table.Column<int>(nullable: false),
                    IsMustFill = table.Column<int>(nullable: false),
                    IsSearchCondition = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_TableField", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_TableInfo",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    TableId = table.Column<int>(nullable: false),
                    TableName = table.Column<string>(maxLength: 100, nullable: true),
                    PhysicalName = table.Column<string>(maxLength: 50, nullable: true),
                    ProjectName = table.Column<string>(maxLength: 50, nullable: true),
                    ControllerName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_TableInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Frame_User",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    LoginID = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(maxLength: 50, nullable: true),
                    RoleID = table.Column<string>(maxLength: 50, nullable: true),
                    IsOnline = table.Column<int>(nullable: false),
                    PictureUrl = table.Column<string>(maxLength: 200, nullable: true),
                    DeptName = table.Column<string>(maxLength: 50, nullable: true),
                    DeptID = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProductionStation",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(maxLength: 50, nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: true),
                    IsDeleted = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    IPNum = table.Column<string>(maxLength: 100, nullable: true),
                    IsStation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionStation", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frame_Codes");

            migrationBuilder.DropTable(
                name: "Frame_CodesValue");

            migrationBuilder.DropTable(
                name: "Frame_Dept");

            migrationBuilder.DropTable(
                name: "Frame_FileUpload");

            migrationBuilder.DropTable(
                name: "Frame_InfoComments");

            migrationBuilder.DropTable(
                name: "Frame_InfoHistory");

            migrationBuilder.DropTable(
                name: "Frame_Information");

            migrationBuilder.DropTable(
                name: "Frame_Module");

            migrationBuilder.DropTable(
                name: "Frame_ModuleElement");

            migrationBuilder.DropTable(
                name: "Frame_Relations");

            migrationBuilder.DropTable(
                name: "Frame_Role");

            migrationBuilder.DropTable(
                name: "Frame_TableField");

            migrationBuilder.DropTable(
                name: "Frame_TableInfo");

            migrationBuilder.DropTable(
                name: "Frame_User");

            migrationBuilder.DropTable(
                name: "ProductionStation");
        }
    }
}
