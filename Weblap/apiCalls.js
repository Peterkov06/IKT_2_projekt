const apiURL = 'http://peterdevserver.ddns.net:8080/api/';

let doc = location.pathname.split("/");
if (doc[doc.length - 1] == "adminsite.html")
{
  document.body.addEventListener("load", GetUploadTypes())
}

function GetUploadTypes()
{
  fetch(apiURL +'TableTypes')
  .then(response => {
    if (!response.ok)
    {
      console.log("Error in getting data");
    }
    return response.json();
  })
  .then(data => {
    let select = document.getElementById("productType");
    data.forEach(element => {
      select.innerHTML += `<option value="${element.typeName}">${element.typeName}</option>`;
    });
  })
  .catch(error => {console.error("Cant get data");})
}

function UploadCPU()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let socket = document.getElementById("socket").value;
  let maxram = document.getElementById("maxram").value;
  let ddrtype = document.getElementById("ddrtype").value;
  let corenum = document.getElementById("corenum").value;
  let threadnum = document.getElementById("threadnum").value;
  let clockspeed = document.getElementById("clockspeed").value;
  let turboclockspeed = document.getElementById("turboclockspeed").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 2,
      Manufacturer: manufacturer,
      Name: name,
      Price: Number(price),
      SocketType: socket,
      MaxRAM: Number(maxram),
      DDRtype: ddrtype,
      CoreNum: Number(corenum),
      ThreadCount: Number(threadnum),
      ClockSpeed: Number(clockspeed),
      TurboClockSpeed: Number(turboclockspeed),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'CPU', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}
async function GetListOfData(type)
{
  const response = await fetch(apiURL + type)

  if (!response.ok)
  {
    console.log("Error in getting data");
    return;
  }

  const data = await response.json()
  return data;

}

async function GetPreset(type)
{
  const response = await fetch(apiURL +'GetPresets?type=' + type)
  if (!response.ok)
  {
    console.log("Error in getting data");
    return;
  }

  const data = await response.json()
  return data;
}

function UploadMotherBoard()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let ramSlotNum = document.getElementById("ramSlotNum").value;
  let socket = document.getElementById("socket").value;
  let sataNum = document.getElementById("sataNum").value;
  let m2Num = document.getElementById("m2Num").value;
  let PCIeNum = document.getElementById("PCIeNum").value;
  let ddrtype = document.getElementById("ddrtype").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 1,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      RamSlots: Number(ramSlotNum),
      CPUsocket: socket,
      SataNum: Number(sataNum),
      M2Num: Number(m2Num),
      PCIeNum: Number(PCIeNum),
      DDRtype: ddrtype,
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'MotherBoard', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

async function GetMotherboards()
{
  const response = await fetch(apiURL +'MotherBoard')

  if (!response.ok)
  {
    console.log("Error in getting data");
    return;
  }

  const data = await response.json()
  return data;

}

function UploadRAM()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let ddrtype = document.getElementById("ddrtype").value;
  let ramsize = document.getElementById("size").value;
  let clockspeed = document.getElementById("clockspeed").value;
  let kitNum = document.getElementById("kitNum").value;
  let overclockType = document.getElementById("overclockType").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 3,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      DDRtype: ddrtype,
      Amount: Number(ramsize),
      ClockSpeed: Number(clockspeed),
      KitNum: Number(kitNum),
      OverclockType: Number(overclockType),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'RAM', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

function UploadGPU()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let gddrtype = document.getElementById("gddrtype").value;
  let vramSize = document.getElementById("size").value;
  let corenum = document.getElementById("corenum").value;
  let clockspeed = document.getElementById("clockspeed").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 4,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      GDDRtype: gddrtype,
      VRAMamount: Number(vramSize),
      CoreNum: Number(corenum),
      ClockSpeed: Number(clockspeed),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'GPU', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

function UploadStorage()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let storagetype = document.getElementById("storageType").value;
  let readSpeed = document.getElementById("readSpeed").value;
  let writeSpeed = document.getElementById("writeSpeed").value;
  let connectionType = document.getElementById("connectionType").value;
  let size = document.getElementById("size").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 5,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      StorageType: Number(storagetype),
      WriteSpeed: Number(writeSpeed),
      ReadSpeed: Number(readSpeed),
      ConnectionType: Number(connectionType),
      Space: Number(size),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'Storage', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

function UploadMonitor()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let size = document.getElementById("diagonalSize").value;
  let Xresolution = document.getElementById("Xsize").value;
  let Yresolution = document.getElementById("Ysize").value;
  let panelType = document.getElementById("panelType").value;
  let color = document.getElementById("color").value;
  let brightness = document.getElementById("brightness").value;
  let dynContrast = document.getElementById("dynContrast").value;
  let statContrast = document.getElementById("statContrast").value;
  let refreshRate = document.getElementById("refreshRate").value;
  let refreshType = document.getElementById("refreshType").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 6,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      Size: Number(size),
      Xresolution: Number(Xresolution),
      Yresolution: Number(Yresolution),
      MonitorType: panelType,
      ColorAccuracy: Number(color),
      Brightness: Number(brightness),
      DynamicContrast: Number(dynContrast),
      StaticContrast: Number(statContrast),
      RefreshRate: Number(refreshRate),
      RefreshingTech: refreshType,
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'Monitor', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

async function UploadMouse()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let connectionType = document.getElementById("connectionType").value;
  let isWireless = document.getElementById("isWireless").value;
  let dpi = document.getElementById("dpi").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 7,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      ConnectionType: connectionType,
      Wireless: await isWirelessFunc(Number(isWireless)),
      DPI: Number(dpi),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'Mouse', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

async function UploadKeyboard()
{
  let name = document.getElementById("name").value;
  let manufacturer = document.getElementById("manufacturer").value;
  let price = document.getElementById("price").value;
  let connectionType = document.getElementById("connectionType").value;
  let isWireless = document.getElementById("isWireless").value;
  let keyboardType = document.getElementById("keyboardType").value;
  let layout = document.getElementById("layout").value;
  let size = document.getElementById("size").value;
  let stock = document.getElementById("stock").value;

    let data = {
      Id: 0,
      Type: 8,
      Name: name,
      Manufacturer: manufacturer,
      Price: Number(price),
      ConnectionType: connectionType,
      Wireless: await isWirelessFunc(Number(isWireless)),
      KeyboardType: keyboardType,
      Layout: layout,
      Size: Number(size),
      StockNum: Number(stock)
    };
    console.log(JSON.stringify(data));
  fetch(apiURL + 'Keyboard', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )
  .then(response => response.json())
  alert("Sikeres feltöltés!");
  location.reload();
}

async function isWirelessFunc(num)
{
  switch (num) {
    case 1:
      return false
      break;
    case 2:
      return true
      break;
  }
}

function SendComment(data)
{
  fetch(apiURL + 'Reviews', 
    {
      method: "POST",
      body: JSON.stringify(data),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    })
    .then(response => response.json());
}

export {GetListOfData, UploadCPU, GetPreset, UploadMotherBoard, GetMotherboards, UploadRAM, UploadGPU, UploadStorage, UploadMonitor, UploadMouse, UploadKeyboard, SendComment};