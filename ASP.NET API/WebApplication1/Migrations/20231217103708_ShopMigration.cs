using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ShopMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CoreNumbers",
                columns: table => new
                {
                    CoreNumberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoreNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreNumbers", x => x.CoreNumberID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DDRtypes",
                columns: table => new
                {
                    DDRtypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DDRtypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDRtypes", x => x.DDRtypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GDDRtypes",
                columns: table => new
                {
                    GDDRtypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GDDRtypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GDDRtypes", x => x.GDDRtypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KeyboardLayouts",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LayoutName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyboardLayouts", x => x.TypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KeyboardSizes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SizeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyboardSizes", x => x.TypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KeyboardTypes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyboardTypes", x => x.TypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ManufacturerName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OverclockPresets",
                columns: table => new
                {
                    OverclockPresetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverclockPresets", x => x.OverclockPresetID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PeriferialConnectionTypes",
                columns: table => new
                {
                    PConnectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PConnectionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriferialConnectionTypes", x => x.PConnectionID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RamKits",
                columns: table => new
                {
                    RAMkitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RAMkitNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamKits", x => x.RAMkitID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScreenSyncTypes",
                columns: table => new
                {
                    ScreenSyncTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenSyncTypes", x => x.ScreenSyncTypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScreenSyncs",
                columns: table => new
                {
                    ScreenSyncID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SyncRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenSyncs", x => x.ScreenSyncID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StorageConnectionTypes",
                columns: table => new
                {
                    StorageConnectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StorageConnectionName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageConnectionTypes", x => x.StorageConnectionID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StorageTypes",
                columns: table => new
                {
                    StorageTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StorageTypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageTypes", x => x.StorageTypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThreadNumbers",
                columns: table => new
                {
                    ThreadNumberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ThreadNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThreadNumbers", x => x.ThreadNumberID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CPUsockets",
                columns: table => new
                {
                    CPUsocketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CPUsocketType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUsockets", x => x.CPUsocketId);
                    table.ForeignKey(
                        name: "FK_CPUsockets_Manufacturers_ManufacturerID",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    GDDRtype = table.Column<int>(type: "int", nullable: false),
                    VRAMamount = table.Column<int>(type: "int", nullable: false),
                    CoreNum = table.Column<int>(type: "int", nullable: false),
                    ClockSpeed = table.Column<float>(type: "float", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPUs_GDDRtypes_GDDRtype",
                        column: x => x.GDDRtype,
                        principalTable: "GDDRtypes",
                        principalColumn: "GDDRtypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPUs_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPUs_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ConnectionType = table.Column<int>(type: "int", nullable: false),
                    Wireless = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    KeyboardType = table.Column<int>(type: "int", nullable: false),
                    Layout = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keyboards_KeyboardLayouts_Layout",
                        column: x => x.Layout,
                        principalTable: "KeyboardLayouts",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Keyboards_KeyboardSizes_Size",
                        column: x => x.Size,
                        principalTable: "KeyboardSizes",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Keyboards_KeyboardTypes_KeyboardType",
                        column: x => x.KeyboardType,
                        principalTable: "KeyboardTypes",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Keyboards_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Keyboards_PeriferialConnectionTypes_ConnectionType",
                        column: x => x.ConnectionType,
                        principalTable: "PeriferialConnectionTypes",
                        principalColumn: "PConnectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Keyboards_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<float>(type: "float", nullable: false),
                    Xresolution = table.Column<int>(type: "int", nullable: false),
                    Yresolution = table.Column<int>(type: "int", nullable: false),
                    MonitorType = table.Column<int>(type: "int", nullable: false),
                    ColorAccuracy = table.Column<float>(type: "float", nullable: false),
                    Brightness = table.Column<float>(type: "float", nullable: false),
                    DynamicContrast = table.Column<int>(type: "int", nullable: false),
                    StaticContrast = table.Column<int>(type: "int", nullable: false),
                    RefreshRate = table.Column<int>(type: "int", nullable: false),
                    RefreshingTech = table.Column<int>(type: "int", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monitors_ScreenSyncTypes_RefreshingTech",
                        column: x => x.RefreshingTech,
                        principalTable: "ScreenSyncTypes",
                        principalColumn: "ScreenSyncTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monitors_ScreenSyncs_RefreshRate",
                        column: x => x.RefreshRate,
                        principalTable: "ScreenSyncs",
                        principalColumn: "ScreenSyncID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Monitors_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ConnectionType = table.Column<int>(type: "int", nullable: false),
                    Wireless = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DPI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mouses_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mouses_PeriferialConnectionTypes_ConnectionType",
                        column: x => x.ConnectionType,
                        principalTable: "PeriferialConnectionTypes",
                        principalColumn: "PConnectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mouses_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DDRtype = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ClockSpeed = table.Column<float>(type: "float", nullable: false),
                    KitNum = table.Column<int>(type: "int", nullable: false),
                    OverclockType = table.Column<int>(type: "int", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RAMs_DDRtypes_DDRtype",
                        column: x => x.DDRtype,
                        principalTable: "DDRtypes",
                        principalColumn: "DDRtypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMs_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMs_OverclockPresets_OverclockType",
                        column: x => x.OverclockType,
                        principalTable: "OverclockPresets",
                        principalColumn: "OverclockPresetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMs_RamKits_KitNum",
                        column: x => x.KitNum,
                        principalTable: "RamKits",
                        principalColumn: "RAMkitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RAMs_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    StorageType = table.Column<int>(type: "int", nullable: false),
                    WriteSpeed = table.Column<int>(type: "int", nullable: false),
                    ReadSpeed = table.Column<int>(type: "int", nullable: false),
                    ConnectionType = table.Column<int>(type: "int", nullable: false),
                    Space = table.Column<int>(type: "int", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storages_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storages_StorageConnectionTypes_ConnectionType",
                        column: x => x.ConnectionType,
                        principalTable: "StorageConnectionTypes",
                        principalColumn: "StorageConnectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storages_StorageTypes_StorageType",
                        column: x => x.StorageType,
                        principalTable: "StorageTypes",
                        principalColumn: "StorageTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storages_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SocketType = table.Column<int>(type: "int", nullable: false),
                    MaxRAM = table.Column<int>(type: "int", nullable: false),
                    DDRtype = table.Column<int>(type: "int", nullable: false),
                    CoreNum = table.Column<int>(type: "int", nullable: false),
                    ThreadCount = table.Column<int>(type: "int", nullable: false),
                    ClockSpeed = table.Column<float>(type: "float", nullable: false),
                    TurboClockSpeed = table.Column<float>(type: "float", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPUs_CPUsockets_SocketType",
                        column: x => x.SocketType,
                        principalTable: "CPUsockets",
                        principalColumn: "CPUsocketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_CoreNumbers_CoreNum",
                        column: x => x.CoreNum,
                        principalTable: "CoreNumbers",
                        principalColumn: "CoreNumberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_DDRtypes_DDRtype",
                        column: x => x.DDRtype,
                        principalTable: "DDRtypes",
                        principalColumn: "DDRtypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_ThreadNumbers_ThreadCount",
                        column: x => x.ThreadCount,
                        principalTable: "ThreadNumbers",
                        principalColumn: "ThreadNumberID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUs_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    RamSlots = table.Column<int>(type: "int", nullable: false),
                    CPUsocket = table.Column<int>(type: "int", nullable: false),
                    SataNum = table.Column<int>(type: "int", nullable: false),
                    M2Num = table.Column<int>(type: "int", nullable: false),
                    PCIeNum = table.Column<int>(type: "int", nullable: false),
                    DDRtype = table.Column<int>(type: "int", nullable: false),
                    StockNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherboards_CPUsockets_CPUsocket",
                        column: x => x.CPUsocket,
                        principalTable: "CPUsockets",
                        principalColumn: "CPUsocketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboards_DDRtypes_DDRtype",
                        column: x => x.DDRtype,
                        principalTable: "DDRtypes",
                        principalColumn: "DDRtypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboards_Manufacturers_Manufacturer",
                        column: x => x.Manufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboards_Types_Type",
                        column: x => x.Type,
                        principalTable: "Types",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_CoreNum",
                table: "CPUs",
                column: "CoreNum");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_DDRtype",
                table: "CPUs",
                column: "DDRtype");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_Manufacturer",
                table: "CPUs",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_SocketType",
                table: "CPUs",
                column: "SocketType");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_ThreadCount",
                table: "CPUs",
                column: "ThreadCount");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_Type",
                table: "CPUs",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_CPUsockets_ManufacturerID",
                table: "CPUsockets",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_GDDRtype",
                table: "GPUs",
                column: "GDDRtype");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_Manufacturer",
                table: "GPUs",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_GPUs_Type",
                table: "GPUs",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_ConnectionType",
                table: "Keyboards",
                column: "ConnectionType");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_KeyboardType",
                table: "Keyboards",
                column: "KeyboardType");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Layout",
                table: "Keyboards",
                column: "Layout");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Manufacturer",
                table: "Keyboards",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Size",
                table: "Keyboards",
                column: "Size");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Type",
                table: "Keyboards",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_Manufacturer",
                table: "Monitors",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_RefreshRate",
                table: "Monitors",
                column: "RefreshRate");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_RefreshingTech",
                table: "Monitors",
                column: "RefreshingTech");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_Type",
                table: "Monitors",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_CPUsocket",
                table: "Motherboards",
                column: "CPUsocket");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_DDRtype",
                table: "Motherboards",
                column: "DDRtype");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_Manufacturer",
                table: "Motherboards",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_Type",
                table: "Motherboards",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Mouses_ConnectionType",
                table: "Mouses",
                column: "ConnectionType");

            migrationBuilder.CreateIndex(
                name: "IX_Mouses_Manufacturer",
                table: "Mouses",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Mouses_Type",
                table: "Mouses",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_DDRtype",
                table: "RAMs",
                column: "DDRtype");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_KitNum",
                table: "RAMs",
                column: "KitNum");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_Manufacturer",
                table: "RAMs",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_OverclockType",
                table: "RAMs",
                column: "OverclockType");

            migrationBuilder.CreateIndex(
                name: "IX_RAMs_Type",
                table: "RAMs",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_ConnectionType",
                table: "Storages",
                column: "ConnectionType");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_Manufacturer",
                table: "Storages",
                column: "Manufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_StorageType",
                table: "Storages",
                column: "StorageType");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_Type",
                table: "Storages",
                column: "Type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "Mouses");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "CoreNumbers");

            migrationBuilder.DropTable(
                name: "ThreadNumbers");

            migrationBuilder.DropTable(
                name: "GDDRtypes");

            migrationBuilder.DropTable(
                name: "KeyboardLayouts");

            migrationBuilder.DropTable(
                name: "KeyboardSizes");

            migrationBuilder.DropTable(
                name: "KeyboardTypes");

            migrationBuilder.DropTable(
                name: "ScreenSyncTypes");

            migrationBuilder.DropTable(
                name: "ScreenSyncs");

            migrationBuilder.DropTable(
                name: "CPUsockets");

            migrationBuilder.DropTable(
                name: "PeriferialConnectionTypes");

            migrationBuilder.DropTable(
                name: "DDRtypes");

            migrationBuilder.DropTable(
                name: "OverclockPresets");

            migrationBuilder.DropTable(
                name: "RamKits");

            migrationBuilder.DropTable(
                name: "StorageConnectionTypes");

            migrationBuilder.DropTable(
                name: "StorageTypes");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
