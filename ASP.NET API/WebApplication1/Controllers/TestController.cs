using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpGet("{tableName}")]
        public async Task<IActionResult> ReadReicipts(string tableName)
        {
            switch (tableName.ToLower())
            {
                case "cpus":
                    var table = _context.CPUs.ToListAsync();
                    return Ok("geting CPUs");
                default:
                    return NotFound();
            }

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class TableTypes : ControllerBase
    {
        private readonly AppDbContext _context;

        public TableTypes(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateType([FromBody] Types type)
        {
            _context.Types.Add(type);
            await _context.SaveChangesAsync();
            return Created("", type);
        }

        [HttpGet]
        public async Task<IActionResult> ReadType()
        {
            var typeList = await _context.Types.ToListAsync();
            return Ok(typeList);

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CPUController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CPUController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateCPU([FromBody] APICPU data)
        {
            string manufacturerName = data.Manufacturer;
            string cpuSocketName = data.SocketType;
            string ddrTypeName = data.DDRtype;
            int coreNumName = data.CoreNum;
            int threadNumName = data.ThreadCount;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var cpuSocket = await _context.CPUsockets.FirstOrDefaultAsync(x => x.CPUsocketType == cpuSocketName);
            if (cpuSocket == null)
            {
                cpuSocket = new CPUsocket() { CPUsocketType = cpuSocketName, ManufacturerID = manufacturer.ManufacturerId, ManufacturerObj = manufacturer };
                _context.CPUsockets.Add(cpuSocket);
                await _context.SaveChangesAsync();
            }

            var ddrType = await _context.DDRtypes.FirstOrDefaultAsync(x => x.DDRtypeName == ddrTypeName);
            if (ddrType == null)
            {
                ddrType = new DDRtype() { DDRtypeName = ddrTypeName };
                _context.DDRtypes.Add(ddrType);
                await _context.SaveChangesAsync();
            }

            var coreNum = await _context.CoreNumbers.FirstOrDefaultAsync(x => x.CoreNum == coreNumName);
            if (coreNum == null)
            {
                coreNum = new CoreNumber() { CoreNum = coreNumName };
                _context.CoreNumbers.Add(coreNum);
                await _context.SaveChangesAsync();
            }

            var threadNum = await _context.ThreadNumbers.FirstOrDefaultAsync(x => x.ThreadNum == threadNumName);
            if (threadNum == null)
            {
                threadNum = new ThreadNumber() { ThreadNum = threadNumName };
                _context.ThreadNumbers.Add(threadNum);
                await _context.SaveChangesAsync();
            }

            var cpuData = new CPU() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, SocketType = cpuSocket.CPUsocketId, MaxRAM = data.MaxRAM, DDRtype = ddrType.DDRtypeId, CoreNum = coreNum.CoreNumberID, ThreadCount = threadNum.ThreadNumberID, ClockSpeed = data.ClockSpeed, TurboClockSpeed = data.TurboClockSpeed, StockNum = data.StockNum };

            _context.CPUs.Add(cpuData);
            await _context.SaveChangesAsync();
            return Created("", cpuData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadCPUs()
        {
            var cpuList = await _context.CPUs.ToListAsync();
            return Ok(cpuList);

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class GetPresets : ControllerBase
    {
        private readonly AppDbContext _context;

        public GetPresets(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost("addOverclockPreset")]
        public async Task<IActionResult> CratePreset([FromBody] OverclockPreset preset)
        {
            _context.OverclockPresets.Add(preset);
            await _context.SaveChangesAsync();
            return Created("", preset);
        }

        [HttpPost("addStorageType")]
        public async Task<IActionResult> AddStorageType([FromBody] StorageType preset)
        {
            _context.StorageTypes.Add(preset);
            await _context.SaveChangesAsync();
            return Created("", preset);
        }

        [HttpPost("addStorageConnectionType")]
        public async Task<IActionResult> AddStorageConnectionType([FromBody] StorageConnectionType preset)
        {
            _context.StorageConnectionTypes.Add(preset);
            await _context.SaveChangesAsync();
            return Created("", preset);
        }



        [HttpGet]
        public async Task<IActionResult> ReadPreset(string type)
        {
            switch (type)
            {
                case "overclockType":
                    var ovcList = await _context.OverclockPresets.ToListAsync();
                    return Ok(ovcList);
                case "storageType":
                    var stList = await _context.StorageTypes.ToListAsync();
                    return Ok(stList);
                case "storageConnectionType":
                    var stcList = await _context.StorageConnectionTypes.ToListAsync();
                    return Ok(stcList);
                default:
                    return NotFound($"No table was found named {type}");
            }

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MotherBoardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MotherBoardController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateMotherBoard([FromBody] APIMotherboard data)
        {
            string manufacturerName = data.Manufacturer;
            string cpuSocketName = data.CPUsocket;
            string ddrTypeName = data.DDRtype;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var cpuSocket = await _context.CPUsockets.FirstOrDefaultAsync(x => x.CPUsocketType == cpuSocketName);
            if (cpuSocket == null)
            {
                cpuSocket = new CPUsocket() { CPUsocketType = cpuSocketName, ManufacturerID = manufacturer.ManufacturerId, ManufacturerObj = manufacturer };
                _context.CPUsockets.Add(cpuSocket);
                await _context.SaveChangesAsync();
            }

            var ddrType = await _context.DDRtypes.FirstOrDefaultAsync(x => x.DDRtypeName == ddrTypeName);
            if (ddrType == null)
            {
                ddrType = new DDRtype() { DDRtypeName = ddrTypeName };
                _context.DDRtypes.Add(ddrType);
                await _context.SaveChangesAsync();
            }

            var mData = new Motherboard() { Type = data.Type, Name = data.Name, Manufacturer = manufacturer.ManufacturerId, Price = data.Price, RamSlots = data.RamSlots, CPUsocket = cpuSocket.CPUsocketId, SataNum = data.SataNum, DDRtype = ddrType.DDRtypeId, M2Num = data.M2Num, PCIeNum = data.PCIeNum, StockNum = data.StockNum };

            _context.Motherboards.Add(mData);
            await _context.SaveChangesAsync();
            return Created("", mData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadMotherboards()
        {
            var mList = await _context.Motherboards.ToListAsync();
            return Ok(mList);

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class RAMController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RAMController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateRAM([FromBody] APIRAM data)
        {
            string manufacturerName = data.Manufacturer;
            string ddrTypeName = data.DDRtype;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var ddrType = await _context.DDRtypes.FirstOrDefaultAsync(x => x.DDRtypeName == ddrTypeName);
            if (ddrType == null)
            {
                ddrType = new DDRtype() { DDRtypeName = ddrTypeName };
                _context.DDRtypes.Add(ddrType);
                await _context.SaveChangesAsync();
            }

            var RamKit = await _context.RamKits.FirstOrDefaultAsync(x => x.RAMkitNum == data.KitNum);
            if (RamKit == null)
            {
                RamKit = new RAMkit() { RAMkitNum = data.KitNum };
                _context.RamKits.Add(RamKit);
                await _context.SaveChangesAsync();
            }

            var ramData = new RAM() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, DDRtype = ddrType.DDRtypeId, Amount = data.Amount, ClockSpeed = data.ClockSpeed, KitNum = RamKit.RAMkitID, OverclockType = data.OverclockType, StockNum = data.StockNum };

            _context.RAMs.Add(ramData);
            await _context.SaveChangesAsync();
            return Created("", ramData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadRAMs()
        {
            var ramList = await _context.RAMs.ToListAsync();
            return Ok(ramList);

        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class GPUController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GPUController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateGPU([FromBody] APIGPU data)
        {
            string manufacturerName = data.Manufacturer;
            string gddrTypeName = data.GDDRtype;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var gddrType = await _context.GDDRtypes.FirstOrDefaultAsync(x => x.GDDRtypeName == gddrTypeName);
            if (gddrType == null)
            {
                gddrType = new GDDRtype() { GDDRtypeName = gddrTypeName };
                _context.GDDRtypes.Add(gddrType);
                await _context.SaveChangesAsync();
            }

            var gpuData = new GPU() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, GDDRtype = gddrType.GDDRtypeId, VRAMamount = data.VRAMamount, CoreNum = data.CoreNum, ClockSpeed = data.ClockSpeed, StockNum = data.StockNum };

            _context.GPUs.Add(gpuData);
            await _context.SaveChangesAsync();
            return Created("", gpuData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadGPUs()
        {
            var gpuList = await _context.GPUs.ToListAsync();
            return Ok(gpuList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StorageController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateStorage([FromBody] APIStorage data)
        {
            string manufacturerName = data.Manufacturer;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var storageData = new Storage() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, StorageType = data.StorageType, WriteSpeed = data.WriteSpeed, ReadSpeed = data.ReadSpeed, ConnectionType = data.ConnectionType, Space = data.Space, StockNum = data.StockNum };

            _context.Storages.Add(storageData);
            await _context.SaveChangesAsync();
            return Created("", storageData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadStorages()
        {
            var storageList = await _context.Storages.ToListAsync();
            return Ok(storageList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MonitorController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateMonitor([FromBody] APIMonitor data)
        {
            string manufacturerName = data.Manufacturer;
            string monitorTypeName = data.MonitorType;
            string refreshingTechName = data.RefreshingTech;
            int refreshRate = data.RefreshRate;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var monitorType = await _context.MonitorTypes.FirstOrDefaultAsync(x => x.Name == monitorTypeName);
            if (monitorType == null)
            {
                monitorType = new MonitorType() { Name = monitorTypeName };
                _context.MonitorTypes.Add(monitorType);
                await _context.SaveChangesAsync();
            }

            var refreshingRate = await _context.ScreenSyncs.FirstOrDefaultAsync(x => x.SyncRate == refreshRate);
            if (refreshingRate == null)
            {
                refreshingRate = new ScreenSync() { SyncRate = refreshRate };
                _context.ScreenSyncs.Add(refreshingRate);
                await _context.SaveChangesAsync();
            }

            var refreshingTech = await _context.ScreenSyncTypes.FirstOrDefaultAsync(x => x.Name == refreshingTechName);
            if (refreshingTech == null)
            {
                refreshingTech = new ScreenSyncType() { Name = refreshingTechName };
                _context.ScreenSyncTypes.Add(refreshingTech);
                await _context.SaveChangesAsync();
            }

            var monitorData = new Models.Monitor() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, Size = data.Size, Xresolution = data.Xresolution, Yresolution = data.Yresolution, MonitorType = monitorType.MonitorTypeID, ColorAccuracy = data.ColorAccuracy, Brightness = data.Brightness, DynamicContrast = data.DynamicContrast, StaticContrast = data.StaticContrast, RefreshRate = refreshingRate.ScreenSyncID, RefreshingTech = refreshingTech.ScreenSyncTypeID, StockNum = data.StockNum };

            _context.Monitors.Add(monitorData);
            await _context.SaveChangesAsync();
            return Created("", monitorData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadSMonitors()
        {
            var monitorList = await _context.Monitors.ToListAsync();
            return Ok(monitorList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MouseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MouseController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateMouse([FromBody] APIMouse data)
        {
            string manufacturerName = data.Manufacturer;
            string connectionTypeName = data.ConnectionType;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var connectionType = await _context.PeriferialConnectionTypes.FirstOrDefaultAsync(x => x.PConnectionName == connectionTypeName);
            if (connectionType == null)
            {
                connectionType = new PeriferialConnectionType() { PConnectionName = connectionTypeName };
                _context.PeriferialConnectionTypes.Add(connectionType);
                await _context.SaveChangesAsync();
            }

            var mouseData = new Mouse() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, ConnectionType = connectionType.PConnectionID, Wireless = data.Wireless, DPI = data.DPI, StockNum = data.StockNum };

            _context.Mouses.Add(mouseData);
            await _context.SaveChangesAsync();
            return Created("", mouseData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadMouses()
        {
            var mouseList = await _context.Mouses.ToListAsync();
            return Ok(mouseList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class KeyboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public KeyboardController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CrateKeyboard([FromBody] APIKeyboard data)
        {
            string manufacturerName = data.Manufacturer;
            string connectionTypeName = data.ConnectionType;
            string keyboardTypeName = data.KeyboardType;
            string layoutName = data.Layout;
            int size = data.Size;

            var manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(x => x.ManufacturerName == manufacturerName);
            if (manufacturer == null)
            {
                manufacturer = new Manufacturer() { ManufacturerName = manufacturerName };
                _context.Manufacturers.Add(manufacturer);
                await _context.SaveChangesAsync();
            }

            var connectionType = await _context.PeriferialConnectionTypes.FirstOrDefaultAsync(x => x.PConnectionName == connectionTypeName);
            if (connectionType == null)
            {
                connectionType = new PeriferialConnectionType() { PConnectionName = connectionTypeName };
                _context.PeriferialConnectionTypes.Add(connectionType);
                await _context.SaveChangesAsync();
            }

            var keyboardType = await _context.KeyboardTypes.FirstOrDefaultAsync(x => x.TypeName == keyboardTypeName);
            if (keyboardType == null)
            {
                keyboardType = new KeyboardType() { TypeName = keyboardTypeName };
                _context.KeyboardTypes.Add(keyboardType);
                await _context.SaveChangesAsync();
            }

            var keyboardLayout = await _context.KeyboardLayouts.FirstOrDefaultAsync(x => x.LayoutName == layoutName);
            if (keyboardLayout == null)
            {
                keyboardLayout = new KeyboardLayout() { LayoutName = layoutName };
                _context.KeyboardLayouts.Add(keyboardLayout);
                await _context.SaveChangesAsync();

            }

            var keyboardSize = await _context.KeyboardSizes.FirstOrDefaultAsync(x => x.SizeName == size);
            if (keyboardSize == null)
            {
                keyboardSize = new KeyboardSize() { SizeName = size };
                _context.KeyboardSizes.Add(keyboardSize);
                await _context.SaveChangesAsync();

            }
            var keyboardData = new Keyboard() { Type = data.Type, Manufacturer = manufacturer.ManufacturerId, Name = data.Name, Price = data.Price, ConnectionType = connectionType.PConnectionID, Wireless = data.Wireless, KeyboardType = keyboardType.TypeID, Layout = keyboardLayout.TypeID, Size = keyboardSize.TypeID, StockNum = data.StockNum };

            _context.Keyboards.Add(keyboardData);
            await _context.SaveChangesAsync();
            return Created("", keyboardData);
        }

        [HttpGet]
        public async Task<IActionResult> ReadMouses()
        {
            var keyboardList = await _context.Keyboards.ToListAsync();
            return Ok(keyboardList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class FrontendDataController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FrontendDataController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpGet("Manufacturers")]
        public async Task<IActionResult> Read()
        {
            var dataList = await _context.Manufacturers.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("Cores")]
        public async Task<IActionResult> ReadCores()
        {
            var dataList = await _context.CoreNumbers.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("Threads")]
        public async Task<IActionResult> ReadThreads()
        {
            var dataList = await _context.ThreadNumbers.ToListAsync();
            return Ok(dataList);
        }
        
        [HttpGet("Sockets")]
        public async Task<IActionResult> ReadSocket()
        {
            var dataList = await _context.CPUsockets.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("RAMmodules")]
        public async Task<IActionResult> ReadRamModules()
        {
            var dataList = await _context.RamKits.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("DDRtypes")]
        public async Task<IActionResult> ReadDDR()
        {
            var dataList = await _context.DDRtypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("Overclock")]
        public async Task<IActionResult> ReadOverclock()
        {
            var dataList = await _context.OverclockPresets.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("StorageType")]
        public async Task<IActionResult> ReadStorageType()
        {
            var dataList = await _context.StorageTypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("StorageConnection")]
        public async Task<IActionResult> ReadStorageConnection()
        {
            var dataList = await _context.StorageConnectionTypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("GDDRtypes")]
        public async Task<IActionResult> ReadGDDR()
        {
            var dataList = await _context.GDDRtypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("PanelType")]
        public async Task<IActionResult> ReadPanelType()
        {
            var dataList = await _context.MonitorTypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("RefreshRate")]
        public async Task<IActionResult> ReadRefreshRate()
        {
            var dataList = await _context.ScreenSyncs.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("RefreshTech")]
        public async Task<IActionResult> ReadRefreshTech()
        {
            var dataList = await _context.ScreenSyncTypes.ToListAsync();
            return Ok(dataList);
        }


        [HttpGet("PeriferialConnection")]
        public async Task<IActionResult> ReadPeriferialConnection()
        {
            var dataList = await _context.PeriferialConnectionTypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("KeyboardType")]
        public async Task<IActionResult> ReadKeyboardType()
        {
            var dataList = await _context.KeyboardTypes.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("KeyboardLanguage")]
        public async Task<IActionResult> ReadKeyboardLanguage()
        {
            var dataList = await _context.KeyboardLayouts.ToListAsync();
            return Ok(dataList);
        }

        [HttpGet("KeyboardSize")]
        public async Task<IActionResult> ReadKeyboardSize()
        {
            var dataList = await _context.KeyboardSizes.ToListAsync();
            return Ok(dataList);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReviewsController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return Created("", comment);

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var comments = await _context.Comments.ToListAsync();
            return Ok(comments);

        }
    }

}

