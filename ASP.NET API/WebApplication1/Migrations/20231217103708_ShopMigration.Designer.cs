﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231217103708_ShopMigration")]
    partial class ShopMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("ClockSpeed")
                        .HasColumnType("float");

                    b.Property<int>("CoreNum")
                        .HasColumnType("int");

                    b.Property<int>("DDRtype")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<int>("MaxRAM")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SocketType")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("ThreadCount")
                        .HasColumnType("int");

                    b.Property<float>("TurboClockSpeed")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoreNum");

                    b.HasIndex("DDRtype");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("SocketType");

                    b.HasIndex("ThreadCount");

                    b.HasIndex("Type");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("WebApplication1.Models.CPUsocket", b =>
                {
                    b.Property<int>("CPUsocketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPUsocketType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.HasKey("CPUsocketId");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("CPUsockets");
                });

            modelBuilder.Entity("WebApplication1.Models.CoreNumber", b =>
                {
                    b.Property<int>("CoreNumberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoreNum")
                        .HasColumnType("int");

                    b.HasKey("CoreNumberID");

                    b.ToTable("CoreNumbers");
                });

            modelBuilder.Entity("WebApplication1.Models.DDRtype", b =>
                {
                    b.Property<int>("DDRtypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DDRtypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DDRtypeId");

                    b.ToTable("DDRtypes");
                });

            modelBuilder.Entity("WebApplication1.Models.GDDRtype", b =>
                {
                    b.Property<int>("GDDRtypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GDDRtypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GDDRtypeId");

                    b.ToTable("GDDRtypes");
                });

            modelBuilder.Entity("WebApplication1.Models.GPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("ClockSpeed")
                        .HasColumnType("float");

                    b.Property<int>("CoreNum")
                        .HasColumnType("int");

                    b.Property<int>("GDDRtype")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("VRAMamount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GDDRtype");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("Type");

                    b.ToTable("GPUs");
                });

            modelBuilder.Entity("WebApplication1.Models.Keyboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<int>("KeyboardType")
                        .HasColumnType("int");

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<bool>("Wireless")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ConnectionType");

                    b.HasIndex("KeyboardType");

                    b.HasIndex("Layout");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("Size");

                    b.HasIndex("Type");

                    b.ToTable("Keyboards");
                });

            modelBuilder.Entity("WebApplication1.Models.KeyboardLayout", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LayoutName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TypeID");

                    b.ToTable("KeyboardLayouts");
                });

            modelBuilder.Entity("WebApplication1.Models.KeyboardSize", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TypeID");

                    b.ToTable("KeyboardSizes");
                });

            modelBuilder.Entity("WebApplication1.Models.KeyboardType", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TypeID");

                    b.ToTable("KeyboardTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("WebApplication1.Models.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Brightness")
                        .HasColumnType("float");

                    b.Property<float>("ColorAccuracy")
                        .HasColumnType("float");

                    b.Property<int>("DynamicContrast")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<int>("MonitorType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RefreshRate")
                        .HasColumnType("int");

                    b.Property<int>("RefreshingTech")
                        .HasColumnType("int");

                    b.Property<float>("Size")
                        .HasColumnType("float");

                    b.Property<int>("StaticContrast")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Xresolution")
                        .HasColumnType("int");

                    b.Property<int>("Yresolution")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("RefreshRate");

                    b.HasIndex("RefreshingTech");

                    b.HasIndex("Type");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("WebApplication1.Models.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CPUsocket")
                        .HasColumnType("int");

                    b.Property<int>("DDRtype")
                        .HasColumnType("int");

                    b.Property<int>("M2Num")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PCIeNum")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RamSlots")
                        .HasColumnType("int");

                    b.Property<int>("SataNum")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CPUsocket");

                    b.HasIndex("DDRtype");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("Type");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("WebApplication1.Models.Mouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<int>("DPI")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<bool>("Wireless")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ConnectionType");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("Type");

                    b.ToTable("Mouses");
                });

            modelBuilder.Entity("WebApplication1.Models.OverclockPreset", b =>
                {
                    b.Property<int>("OverclockPresetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OverclockPresetID");

                    b.ToTable("OverclockPresets");
                });

            modelBuilder.Entity("WebApplication1.Models.PeriferialConnectionType", b =>
                {
                    b.Property<int>("PConnectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PConnectionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PConnectionID");

                    b.ToTable("PeriferialConnectionTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.RAM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<float>("ClockSpeed")
                        .HasColumnType("float");

                    b.Property<int>("DDRtype")
                        .HasColumnType("int");

                    b.Property<int>("KitNum")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OverclockType")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DDRtype");

                    b.HasIndex("KitNum");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("OverclockType");

                    b.HasIndex("Type");

                    b.ToTable("RAMs");
                });

            modelBuilder.Entity("WebApplication1.Models.RAMkit", b =>
                {
                    b.Property<int>("RAMkitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RAMkitNum")
                        .HasColumnType("int");

                    b.HasKey("RAMkitID");

                    b.ToTable("RamKits");
                });

            modelBuilder.Entity("WebApplication1.Models.ScreenSync", b =>
                {
                    b.Property<int>("ScreenSyncID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SyncRate")
                        .HasColumnType("int");

                    b.HasKey("ScreenSyncID");

                    b.ToTable("ScreenSyncs");
                });

            modelBuilder.Entity("WebApplication1.Models.ScreenSyncType", b =>
                {
                    b.Property<int>("ScreenSyncTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ScreenSyncTypeID");

                    b.ToTable("ScreenSyncTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ReadSpeed")
                        .HasColumnType("int");

                    b.Property<int>("Space")
                        .HasColumnType("int");

                    b.Property<int>("StockNum")
                        .HasColumnType("int");

                    b.Property<int>("StorageType")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("WriteSpeed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConnectionType");

                    b.HasIndex("Manufacturer");

                    b.HasIndex("StorageType");

                    b.HasIndex("Type");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("WebApplication1.Models.StorageConnectionType", b =>
                {
                    b.Property<int>("StorageConnectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("StorageConnectionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StorageConnectionID");

                    b.ToTable("StorageConnectionTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.StorageType", b =>
                {
                    b.Property<int>("StorageTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("StorageTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StorageTypeID");

                    b.ToTable("StorageTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.ThreadNumber", b =>
                {
                    b.Property<int>("ThreadNumberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ThreadNum")
                        .HasColumnType("int");

                    b.HasKey("ThreadNumberID");

                    b.ToTable("ThreadNumbers");
                });

            modelBuilder.Entity("WebApplication1.Models.Types", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TypeID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("WebApplication1.Models.CPU", b =>
                {
                    b.HasOne("WebApplication1.Models.CoreNumber", "corenum")
                        .WithMany()
                        .HasForeignKey("CoreNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.DDRtype", "ddrtype")
                        .WithMany()
                        .HasForeignKey("DDRtype")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.CPUsocket", "cpusocket")
                        .WithMany()
                        .HasForeignKey("SocketType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.ThreadNumber", "threadnum")
                        .WithMany()
                        .HasForeignKey("ThreadCount")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("corenum");

                    b.Navigation("cpusocket");

                    b.Navigation("ddrtype");

                    b.Navigation("manufacturer");

                    b.Navigation("threadnum");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.CPUsocket", b =>
                {
                    b.HasOne("WebApplication1.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("WebApplication1.Models.GPU", b =>
                {
                    b.HasOne("WebApplication1.Models.GDDRtype", "ddrtype")
                        .WithMany()
                        .HasForeignKey("GDDRtype")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ddrtype");

                    b.Navigation("manufacturer");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.Keyboard", b =>
                {
                    b.HasOne("WebApplication1.Models.PeriferialConnectionType", "connectionType")
                        .WithMany()
                        .HasForeignKey("ConnectionType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.KeyboardType", "keyboardType")
                        .WithMany()
                        .HasForeignKey("KeyboardType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.KeyboardLayout", "keyboardLayout")
                        .WithMany()
                        .HasForeignKey("Layout")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.KeyboardSize", "keyboardSize")
                        .WithMany()
                        .HasForeignKey("Size")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("connectionType");

                    b.Navigation("keyboardLayout");

                    b.Navigation("keyboardSize");

                    b.Navigation("keyboardType");

                    b.Navigation("manufacturer");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.Monitor", b =>
                {
                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.ScreenSync", "refreshRate")
                        .WithMany()
                        .HasForeignKey("RefreshRate")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.ScreenSyncType", "refreshingTech")
                        .WithMany()
                        .HasForeignKey("RefreshingTech")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("manufacturer");

                    b.Navigation("refreshRate");

                    b.Navigation("refreshingTech");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.Motherboard", b =>
                {
                    b.HasOne("WebApplication1.Models.CPUsocket", "cpusocket")
                        .WithMany()
                        .HasForeignKey("CPUsocket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.DDRtype", "ddrtype")
                        .WithMany()
                        .HasForeignKey("DDRtype")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cpusocket");

                    b.Navigation("ddrtype");

                    b.Navigation("manufacturer");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.Mouse", b =>
                {
                    b.HasOne("WebApplication1.Models.PeriferialConnectionType", "connectionType")
                        .WithMany()
                        .HasForeignKey("ConnectionType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("connectionType");

                    b.Navigation("manufacturer");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.RAM", b =>
                {
                    b.HasOne("WebApplication1.Models.DDRtype", "ddrtype")
                        .WithMany()
                        .HasForeignKey("DDRtype")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.RAMkit", "RAMkit")
                        .WithMany()
                        .HasForeignKey("KitNum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.OverclockPreset", "overclockPreset")
                        .WithMany()
                        .HasForeignKey("OverclockType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RAMkit");

                    b.Navigation("ddrtype");

                    b.Navigation("manufacturer");

                    b.Navigation("overclockPreset");

                    b.Navigation("types");
                });

            modelBuilder.Entity("WebApplication1.Models.Storage", b =>
                {
                    b.HasOne("WebApplication1.Models.StorageConnectionType", "storageConnType")
                        .WithMany()
                        .HasForeignKey("ConnectionType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Manufacturer", "manufacturer")
                        .WithMany()
                        .HasForeignKey("Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.StorageType", "storageType")
                        .WithMany()
                        .HasForeignKey("StorageType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Types", "types")
                        .WithMany()
                        .HasForeignKey("Type")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("manufacturer");

                    b.Navigation("storageConnType");

                    b.Navigation("storageType");

                    b.Navigation("types");
                });
#pragma warning restore 612, 618
        }
    }
}