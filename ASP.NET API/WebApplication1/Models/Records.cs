using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{

    public record Motherboard
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int RamSlots { get; set; }
        public int CPUsocket { get; set; }
        public int SataNum { get; set; }
        public int M2Num { get; set; }
        public int PCIeNum { get; set; }
        public int DDRtype { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(CPUsocket))] public CPUsocket cpusocketObj { get; set; }
        [ForeignKey(nameof(DDRtype))] public DDRtype ddrtypeObj { get; set; }

    }

    public record APIMotherboard
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int RamSlots { get; set; }
        public string CPUsocket { get; set; }
        public int SataNum { get; set; }
        public int M2Num { get; set; }
        public int PCIeNum { get; set; }
        public string DDRtype { get; set; }
        public int StockNum { get; set; }

    }

    public record CPU
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public int Manufacturer { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int SocketType { get; set; }
        public int MaxRAM { get; set; }
        public int DDRtype { get; set; }
        public int CoreNum { get; set; }
        public int ThreadCount { get; set; }
        public float ClockSpeed { get; set; }
        public float TurboClockSpeed { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(SocketType))] public CPUsocket cpusocketObj { get; set; }
        [ForeignKey(nameof(DDRtype))] public DDRtype ddrtypeObj { get; set; }
        [ForeignKey(nameof(CoreNum))] public CoreNumber corenumObj { get; set; }
        [ForeignKey(nameof(ThreadCount))] public ThreadNumber threadnumObj { get; set; }
    }

    public record APICPU
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string SocketType { get; set; }
        public int MaxRAM { get; set; }
        public string DDRtype { get; set; }
        public int CoreNum { get; set; }
        public int ThreadCount { get; set; }
        public float ClockSpeed { get; set; }
        public float TurboClockSpeed { get; set; }
        public int StockNum { get; set; }
    }

    public record RAM
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int DDRtype { get; set; }
        public int Amount { get; set; }
        public float ClockSpeed { get; set; }
        public int KitNum { get; set; }
        public int OverclockType { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(DDRtype))] public DDRtype ddrtypeObj { get; set; }
        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(KitNum))] public RAMkit RAMkitObj { get; set; }
        [ForeignKey(nameof(OverclockType))] public OverclockPreset overclockPresetObj { get; set; }
    }

    public record APIRAM
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string DDRtype { get; set; }
        public int Amount { get; set; }
        public float ClockSpeed { get; set; }
        public int KitNum { get; set; }
        public int OverclockType { get; set; }
        public int StockNum { get; set; }
    }

    public record GPU
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int GDDRtype { get; set; }
        public int VRAMamount { get; set; }
        public int CoreNum { get; set; }
        public float ClockSpeed { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(GDDRtype))] public GDDRtype ddrtypeObj { get; set; }
        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
    }

    public record APIGPU
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string GDDRtype { get; set; }
        public int VRAMamount { get; set; }
        public int CoreNum { get; set; }
        public float ClockSpeed { get; set; }
        public int StockNum { get; set; }
    }

    public record Storage
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int StorageType { get; set; }
        public int WriteSpeed { get; set; }
        public int ReadSpeed { get; set; }
        public int ConnectionType { get; set; }
        public int Space {  get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types types { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(StorageType))] public StorageType storageTypeObj { get; set; }
        [ForeignKey(nameof(ConnectionType))] public StorageConnectionType storageConnTypeObj { get; set; }
    }

    public record APIStorage
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int StorageType { get; set; }
        public int WriteSpeed { get; set; }
        public int ReadSpeed { get; set; }
        public int ConnectionType { get; set; }
        public int Space { get; set; }
        public int StockNum { get; set; }
    }

    public record Monitor
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public float Size { get; set; }
        public int Xresolution { get; set; }
        public int Yresolution { get; set; }
        public int MonitorType { get; set; }
        public float ColorAccuracy { get; set; }
        public float Brightness { get; set; }
        public int DynamicContrast { get; set; }
        public int StaticContrast { get; set; }
        public int RefreshRate { get; set; }
        public int RefreshingTech {  get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(RefreshRate))] public ScreenSync refreshRateObj { get; set; }
        [ForeignKey(nameof(RefreshingTech))] public ScreenSyncType refreshingTechObj { get; set; }
        [ForeignKey(nameof(MonitorType))] public MonitorType monitorTypeObj { get; set; }
    }

    public record APIMonitor
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public float Size { get; set; }
        public int Xresolution { get; set; }
        public int Yresolution { get; set; }
        public string MonitorType { get; set; }
        public float ColorAccuracy { get; set; }
        public float Brightness { get; set; }
        public int DynamicContrast { get; set; }
        public int StaticContrast { get; set; }
        public int RefreshRate { get; set; }
        public string RefreshingTech { get; set; }
        public int StockNum { get; set; }
    }

    public record Mouse
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int ConnectionType { get; set; }
        public bool Wireless { get; set; }
        public int DPI { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(ConnectionType))] public PeriferialConnectionType connectionTypeObj { get; set; }
    }

    public record APIMouse
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string ConnectionType { get; set; }
        public bool Wireless { get; set; }
        public int DPI { get; set; }
        public int StockNum { get; set; }
    }

    public record Keyboard
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public int Manufacturer { get; set; }
        public int Price { get; set; }
        public int ConnectionType { get; set; }
        public bool Wireless { get; set; }
        public int KeyboardType { get; set; }
        public int Layout {  get; set; }
        public int Size { get; set; }
        public int StockNum { get; set; }

        [ForeignKey(nameof(Type))] public Types typesObj { get; set; }
        [ForeignKey(nameof(Manufacturer))] public Manufacturer manufacturerObj { get; set; }
        [ForeignKey(nameof(ConnectionType))] public PeriferialConnectionType connectionTypeObj { get; set; }
        [ForeignKey(nameof(KeyboardType))] public KeyboardType keyboardTypeObj { get; set; }
        [ForeignKey(nameof(Layout))] public KeyboardLayout keyboardLayoutObj { get; set; }
        [ForeignKey(nameof(Size))] public KeyboardSize keyboardSizeObj { get; set; }
        
    }

    public record APIKeyboard
    {
        [Key] public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public string ConnectionType { get; set; }
        public bool Wireless { get; set; }
        public string KeyboardType { get; set; }
        public string Layout { get; set; }
        public int Size { get; set; }
        public int StockNum { get; set; }

    }

    public record Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        [Required]
        public string ManufacturerName { get; set; }
    }

    public record CPUsocket
    {
        [Key]
        public int CPUsocketId { get; set; }
        [Required]
        public string CPUsocketType { get; set; }
        public int ManufacturerID { get; set; }

        [ForeignKey(nameof(ManufacturerID))]
        public Manufacturer ManufacturerObj { get; set; }
    }

    public record DDRtype
    {
        [Key]
        public int DDRtypeId { get; set; }
        [Required]
        public string DDRtypeName { get; set; }
    }

    public record GDDRtype
    {
        [Key]
        public int GDDRtypeId { get; set; }
        [Required]
        public string GDDRtypeName { get; set; }
    }

    public record PeriferialConnectionType
    {
        [Key]
        public int PConnectionID { get; set; }
        [Required]
        public string PConnectionName { get; set; }
    }

    public record ScreenSync
    {
        [Key]
        public int ScreenSyncID { get; set; }
        [Required]
        public int SyncRate { get; set; }
    }

    public record ScreenSyncType
    {
        [Key]
        public int ScreenSyncTypeID { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public record StorageConnectionType
    {
        [Key]
        public int StorageConnectionID { get; set; }
        [Required]
        public string StorageConnectionName { get; set; }
    }

    public record StorageType
    {
        [Key]
        public int StorageTypeID { get; set; }
        [Required]
        public string StorageTypeName { get; set; }
    }

    public record CoreNumber
    {
        [Key]
        public int CoreNumberID { get; set; }
        [Required]
        public int CoreNum { get; set; }
    }

    public record ThreadNumber
    {
        [Key]
        public int ThreadNumberID { get; set; }
        [Required]
        public int ThreadNum { get; set; }
    }

    public record RAMkit
    {
        [Key]
        public int RAMkitID { get; set; }
        [Required]
        public int RAMkitNum { get; set; }
    }

    public record Types
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        public string TypeName { get; set; }
    }

    public record KeyboardType
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        public string TypeName { get; set; }
    }

    public record KeyboardLayout
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        public string LayoutName { get; set; }
    }

    public record KeyboardSize
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        public int SizeName { get; set; }
    }

    public record OverclockPreset
    {
        [Key] public int OverclockPresetID { get; set; }
        [Required] public string Name { get; set; }
    }

    public record MonitorType
    {
        [Key] public int MonitorTypeID { get; set; }
        [Required] public string Name { get; set; }
    }

    public record Comment
    {
        [Key]
        public int CommentTypeID { get; set; }
        public int Stars { get; set; }
        public string Name { get; set; }
        public string CommentStrg { get; set; }
    }
}
