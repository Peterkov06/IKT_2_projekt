import { GetListOfData } from "./apiCalls.js";

window.addEventListener("scroll",function () {
  let navBar = this.document.getElementsByClassName("navBar")[0];
  if (this.window.scrollY > 90)
  {
    navBar.classList.remove("hidden");
  }
  else
  {
    navBar.classList.add("hidden");
  }
})

let dropdownBtns = document.getElementsByClassName('dropdownBtn');
for (let ind = 0; ind < dropdownBtns.length; ind++) {
  dropdownBtns[ind].addEventListener('click', function (event) {
    OpenOverlaySelect(ind, event)
  });
}

function FilterSearch()
{
  console.log('WHY');
  let input = document.getElementsByClassName("myInput")[0];
  let filter = input.value.toUpperCase();
  let a = document.getElementsByClassName("componentName");
  for (let index = 0; index < a.length; index++) {
    let txtValue = a[index].innerText;
    if (txtValue.toUpperCase().indexOf(filter) > -1) {
      a[index].parentElement.parentElement.style.display = "block";
    } else {
      a[index].parentElement.parentElement.style.display = "none";
    }
  }

}

async function OpenOverlaySelect(x, event)
{
  let overlay = document.getElementsByClassName("overlaySelect")[0];
  overlay.style.display = "block";
  document.body.classList.add('stop-scrolling');
  document.getElementsByClassName("overlay")[0].style.display = "block";

  overlay.innerHTML = `<div class="toLeft closeOverlay"><a href="javascript:void(0)">&times;</a></div>
  <div class="container">
    <div class="row">
      <div class="col-3 filterDiv">
        <h2>Szűrők</h2>
        <input type="text" class="myInput" id="myInput">
      </div>
      <div class="verticalDivider"></div>
      <div class="col-9">
        <div class="choosable">
          <h2 class="selectType"></h2>
        </div>
        <div class="choosableOptions">
        </div>
      </div>
    </div>
  </div>`;

  let optionsDiv =  document.getElementsByClassName("choosableOptions")[0];
  let typeName =  document.getElementsByClassName("selectType")[0];
  document.getElementsByClassName("myInput")[0].onkeyup = function () {
    FilterSearch();};

  event.stopPropagation();
  

  let data = undefined;
  switch (x) {
    case 0:
      typeName.innerText = "CPU"
      data = await GetListOfData('CPU');
      GenerateCPUelements(data, optionsDiv, x);
      break;
    case 1:
      typeName.innerText = "Alaplap"
      data = await GetListOfData('MotherBoard');
      GenerateMotherboardElements(data, optionsDiv, x)
      break;
    case 2:
      typeName.innerText = "Memória"
      data = await GetListOfData('RAM');
      GenerateRAMElements(data, optionsDiv, x)
      break;
    case 3:
      typeName.innerText = "Háttértár"
      data = await GetListOfData('Storage');
      GenerateStorageElements(data, optionsDiv, x)
      break;
    case 4:
      typeName.innerText = "Videókártya"
      data = await GetListOfData('GPU');
      GenerateGPUElements(data, optionsDiv, x)
      break;
    case 5:
      typeName.innerText = "Monitor"
      data = await GetListOfData('Monitor');
      GenerateMonitorElements(data, optionsDiv, x)
      break;
    case 6:
      typeName.innerText = "Egér"
      data = await GetListOfData('Mouse');
      GenerateMouseElements(data, optionsDiv, x)
      break;
    case 7:
      typeName.innerText = "Billentyűzet"
      data = await GetListOfData('Keyboard');
      GenerateKeyboardElements(data, optionsDiv, x)
      break;
    default:
      break;
  }

  document.getElementsByClassName("closeOverlay")[0].addEventListener('click', function () {
    CloseOverlaySelect();
  })
}

async function CloseOverlaySelect(x, event)
{
  let overlay = document.getElementsByClassName("overlaySelect")[0];
  document.getElementsByClassName("overlay")[0].style.display = "none";
  overlay.style.display = "none";
  document.body.classList.remove('stop-scrolling');
}

async function GenerateCPUelements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisClocks = [];
  let thisTurboClocks = [];
  let cores = await GetListOfData("FrontendData/Cores");
  let threads = await GetListOfData("FrontendData/Threads");
  let sockets = await GetListOfData("FrontendData/Sockets");
  let ddrs = await GetListOfData("FrontendData/DDRtypes");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Magok: ${cores[list[index].coreNum - 1].coreNum} db`);
    currCardData.push(`Szálak: ${threads[list[index].threadCount - 1].threadNum} db`);
    currCardData.push(`Foglalat: ${sockets[list[index].socketType - 1].cpUsocketType}`);
    currCardData.push(`DDR típus: ${ddrs[list[index].ddRtype - 1].ddRtypeName}`);
    currCardData.push(`Órajel: ${list[index].clockSpeed} GHz`);
    thisClocks.push(list[index].clockSpeed);
    currCardData.push(`Turbó órajel: ${list[index].turboClockSpeed} GHz`);
    thisTurboClocks.push(list[index].turboClockSpeed);
    currCardData.push(`Max memória: ${list[index].maxRAM} GB`);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
  }
  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let coreOpts = "";
  cores.forEach(element => {
    coreOpts += `<div class="filterOpt"><label><input type="checkbox">${element.coreNum}</label></div>`;
  });
  let threadOpts = "";
  threads.forEach(element => {
    threadOpts += `<div class="filterOpt"><label><input type="checkbox">${element.threadNum}</label></div>`;
  });
  let socketOpts = "";
  sockets.forEach(element => {
    socketOpts += `<div class="filterOpt"><label><input type="checkbox">${element.cpUsocketType}</label></div>`;
  });
  let ddrOpts = "";
  ddrs.forEach(element => {
    ddrOpts += `<div class="filterOpt"><label><input type="checkbox">${element.ddRtypeName}</label></div>`;
  });
  let speedOpts = "";
  thisClocks.forEach(element => {
    speedOpts += `<div class="filterOpt"><label><input type="checkbox">${element} GHz</label></div>`;
  });
  let turboOpts = "";
  thisTurboClocks.forEach(element => {
    turboOpts += `<div class="filterOpt"><label><input type="checkbox">${element} GHz</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Magok száma:</h3> ${coreOpts} <h3>Szálak száma:</h3> ${threadOpts} <h3>Foglalat:</h3> ${socketOpts} <h3>DDR típus:</h3> ${ddrOpts} <h3>Alap órajel:</h3> ${speedOpts} <h3>Turbó órajel:</h3> ${turboOpts}`;
}

async function GenerateMotherboardElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisRAM = [];
  let thisSATA = [];
  let thisM2 = [];
  let thisPCIe = [];
  let sockets = await GetListOfData("FrontendData/Sockets");
  let ddrs = await GetListOfData("FrontendData/DDRtypes");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Foglalat: ${sockets[list[index].cpUsocket - 1].cpUsocketType}`);
    currCardData.push(`DDR típus: ${ddrs[list[index].ddRtype - 1].ddRtypeName}`);
    currCardData.push(`Memória foglalatok: ${list[index].ramSlots} db`);
    thisRAM.push(list[index].ramSlots);
    currCardData.push(`SATA foglalatok: ${list[index].sataNum} db`);
    thisSATA.push(list[index].sataNum);
    currCardData.push(`M.2 foglalatok: ${list[index].m2Num} db`);
    thisM2.push(list[index].m2Num);
    currCardData.push(`PCIe foglalatok: ${list[index].pcIeNum} db`);
    thisPCIe.push(list[index].pcIeNum);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let socketOpts = "";
  sockets.forEach(element => {
    socketOpts += `<div class="filterOpt"><label><input type="checkbox">${element.cpUsocketType}</label></div>`;
  });
  let ddrOpts = "";
  ddrs.forEach(element => {
    ddrOpts += `<div class="filterOpt"><label><input type="checkbox">${element.ddRtypeName}</label></div>`;
  });
  let ramOpts = "";
  thisRAM.forEach(element => {
    ramOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  let sataOpts = "";
  thisSATA.forEach(element => {
    sataOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  let m2Opts = "";
  thisM2.forEach(element => {
    m2Opts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  let pciOpts = "";
  thisPCIe.forEach(element => {
    pciOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Foglalat:</h3> ${socketOpts} <h3>DDR típus:</h3> ${ddrOpts} <h3>RAM foglalatok:</h3> ${ramOpts} <h3>SATA foglalatok:</h3> ${sataOpts} <h3>M.2 foglalatok:</h3> ${m2Opts} <h3>PCIe foglalatok:</h3> ${pciOpts}`;
}

async function GenerateRAMElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisRAM = [];
  let thisClock = [];
  let ddrs = await GetListOfData("FrontendData/DDRtypes");
  let overclocks = await GetListOfData("FrontendData/Overclock");
  let modules = await GetListOfData("FrontendData/RAMmodules");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`DDR típus: ${ddrs[list[index].ddRtype - 1].ddRtypeName}`);
    currCardData.push(`Kapacitás: ${list[index].amount} GB`);
    thisRAM.push(list[index].amount);
    currCardData.push(`Órajel: ${list[index].clockSpeed} MHz`);
    thisClock.push(list[index].clockSpeed);
    currCardData.push(`Modulok: ${modules[list[index].kitNum - 1].raMkitNum} db`);
    currCardData.push(`Overclock típusa: ${overclocks[list[index].overclockType - 1].name}`);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let ddrOpts = "";
  ddrs.forEach(element => {
    ddrOpts += `<div class="filterOpt"><label><input type="checkbox">${element.ddRtypeName}</label></div>`;
  });
  let ramOpts = "";
  thisRAM.forEach(element => {
    ramOpts += `<div class="filterOpt"><label><input type="checkbox">${element} GB</label></div>`;
  });
  let clockOpts = "";
  thisClock.forEach(element => {
    clockOpts += `<div class="filterOpt"><label><input type="checkbox">${element} MHz</label></div>`;
  });
  let moduleOpts = "";
  modules.forEach(element => {
    moduleOpts += `<div class="filterOpt"><label><input type="checkbox">${element.raMkitNum} db</label></div>`;
  });
  let overOpts = "";
  overclocks.forEach(element => {
    overOpts += `<div class="filterOpt"><label><input type="checkbox">${element.name}</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>DDR típus:</h3> ${ddrOpts} <h3>Kapacitás:</h3> ${ramOpts} <h3>Órajel:</h3> ${clockOpts} <h3>Modulok száma:</h3> ${moduleOpts} <h3>Overclok típus:</h3> ${overOpts}`;
}

async function GenerateStorageElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisRead = [];
  let thisWrite = [];
  let thisRPM = [];
  let thisSize = [];
  let types = await GetListOfData("FrontendData/StorageType");
  let storageconns = await GetListOfData("FrontendData/StorageConnection");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Típus: ${types[list[index].storageType - 1].storageTypeName}`);
    if (list[index].storageType == 1)
    {
      currCardData.push(`RPM (fordulatszám): ${list[index].readSpeed}`);
      thisRPM.push(list[index].readSpeed);
    }
    else
    {
      currCardData.push(`Olvasási sebesség: ${list[index].readSpeed} MB/s`);
      currCardData.push(`Írási sebesség: ${list[index].writeSpeed} MB/s`);
      thisRead.push(list[index].readSpeed);
      thisWrite.push(list[index].writeSpeed);
    }
    currCardData.push(`Csatlakozó: ${storageconns[list[index].connectionType - 1].storageConnectionName}`);
    currCardData.push(`Méret: ${list[index].space} GB`);
    thisSize.push(list[index].space);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let typeOpts = "";
  types.forEach(element => {
    typeOpts += `<div class="filterOpt"><label><input type="checkbox">${element.storageTypeName}</label></div>`;
  });
  let rpmOpts = "";
  thisRPM.forEach(element => {
    rpmOpts += `<div class="filterOpt"><label><input type="checkbox">${element} RPM</label></div>`;
  });
  let writeOpts = "";
  thisWrite.forEach(element => {
    writeOpts += `<div class="filterOpt"><label><input type="checkbox">${element} MB/s</label></div>`;
  });
  let readOpts = "";
  thisRead.forEach(element => {
    readOpts += `<div class="filterOpt"><label><input type="checkbox">${element} MB/s</label></div>`;
  });
  let connOpts = "";
  storageconns.forEach(element => {
    connOpts += `<div class="filterOpt"><label><input type="checkbox">${element.storageConnectionName}</label></div>`;
  });
  let sizeOpts = "";
  thisSize.forEach(element => {
    sizeOpts += `<div class="filterOpt"><label><input type="checkbox">${element} GB</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Típus:</h3> ${typeOpts} <h3>RPM:</h3> ${rpmOpts} <h3>Írási sebesség:</h3> ${writeOpts} <h3>Olvasási sebesség:</h3> ${readOpts} <h3>Csatlakozó:</h3> ${connOpts} <h3>Méret:</h3> ${sizeOpts}`;
}

async function GenerateGPUElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisVRAM = [];
  let thisClocks = [];
  let thisCores = [];
  let gddrs = await GetListOfData("FrontendData/GDDRtypes");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`VRAM: ${list[index].vraMamount} GB`);
    thisVRAM.push(list[index].vraMamount);
    currCardData.push(`GDDR típus: ${gddrs[list[index].gddRtype - 1].gddRtypeName}`);
    currCardData.push(`Órajel: ${list[index].clockSpeed} MHz`);
    thisClocks.push(list[index].clockSpeed);
    currCardData.push(`Magok száma: ${list[index].coreNum}`);
    thisCores.push(list[index].coreNum);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let vramOpts = "";
  thisVRAM.forEach(element => {
    vramOpts += `<div class="filterOpt"><label><input type="checkbox">${element} GB</label></div>`;
  });
  let gddrOpts = "";
  gddrs.forEach(element => {
    gddrOpts += `<div class="filterOpt"><label><input type="checkbox">${element.gddRtypeName}</label></div>`;
  });
  let clockOpts = "";
  thisClocks.forEach(element => {
    clockOpts += `<div class="filterOpt"><label><input type="checkbox">${element} MHz</label></div>`;
  });
  let coreOpts = "";
  thisCores.forEach(element => {
    coreOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>VRAM:</h3> ${vramOpts} <h3>GDDR típus:</h3> ${gddrOpts} <h3>Órajel:</h3> ${clockOpts} <h3>Magok száma:</h3> ${coreOpts}`;
}

async function GenerateMonitorElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisSize = [];
  let thisRes = [];
  let panels = await GetListOfData("FrontendData/PanelType");
  let refresh = await GetListOfData("FrontendData/RefreshRate");
  let refeshTech = await GetListOfData("FrontendData/RefreshTech");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Méret: ${list[index].size}"`);
    thisSize.push(list[index].size);
    currCardData.push(`Felbontás: ${list[index].xresolution} * ${list[index].yresolution} pixel`);
    thisRes.push(`${list[index].xresolution} * ${list[index].yresolution}`);
    currCardData.push(`Panel típus: ${panels[list[index].monitorType - 1].name}`);
    currCardData.push(`Színhelyesség (DCI-P3): ${list[index].colorAccuracy}%`);
    currCardData.push(`Fényerő: ${list[index].brightness} nit`);
    currCardData.push(`Dinamikus kontraszt: ${list[index].dynamicContrast} : 1`);
    currCardData.push(`Statikus kontraszt: ${list[index].staticContrast} : 1`);
    currCardData.push(`Frissítési ráta: ${refresh[list[index].refreshRate - 1].syncRate} Hz`);
    currCardData.push(`Frissítési technológia: ${refeshTech[list[index].refreshingTech - 1].name}`);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let sizeOpts = "";
  thisSize.forEach(element => {
    sizeOpts += `<div class="filterOpt"><label><input type="checkbox">${element}"</label></div>`;
  });
  let resOpts = "";
  thisRes.forEach(element => {
    resOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  let refreshOpts = "";
  refresh.forEach(element => {
    refreshOpts += `<div class="filterOpt"><label><input type="checkbox">${element.syncRate} Hz</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Méret:</h3> ${sizeOpts} <h3>Felbontás:</h3> ${resOpts} <h3>Képfrissítés:</h3> ${refreshOpts}`;
}

async function GenerateMouseElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let thisWireless = ["", "Igen", "Nem"];
  let thisDPI = [];
  let conns = await GetListOfData("FrontendData/PeriferialConnection");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Csatlakozás: ${conns[list[index].connectionType - 1].pConnectionName}`);
    let wireless = "";
    if (list[index].wireless == true)
    {
      wireless = "Igen";
    }
    else
    {
      wireless = "Nem";
    }
    currCardData.push(`Vezeték nélküli: ${wireless}`);
    currCardData.push(`DPI: ${list[index].dpi}`);
    thisDPI.push(list[index].dpi);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let connOpts = "";
  conns.forEach(element => {
    connOpts += `<div class="filterOpt"><label><input type="checkbox">${element.pConnectionName}</label></div>`;
  });
  let dpiOpts = "";
  thisDPI.forEach(element => {
    dpiOpts += `<div class="filterOpt"><label><input type="checkbox">${element}</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Csatlakozás:</h3> ${connOpts} <h3>DPI:</h3> ${dpiOpts}`;
}

async function GenerateKeyboardElements(list, currDropdown, x) 
{
  let manufacturers = await GetListOfData("FrontendData/Manufacturers");
  let thisManu = [];
  let conns = await GetListOfData("FrontendData/PeriferialConnection");
  let type = await GetListOfData("FrontendData/KeyboardType");
  let lang = await GetListOfData("FrontendData/KeyboardLanguage");
  let size = await GetListOfData("FrontendData/KeyboardSize");
  currDropdown.innerHTML = '';
  for (let index = 0; index < list.length; index++) {
    let currCardData = [];
    currCardData.push(`${list[index].name}`);
    currCardData.push(`${list[index].price}`);
    thisManu.push(manufacturers[list[index].manufacturer - 1]);
    currCardData.push(`Gyártó: ${manufacturers[list[index].manufacturer - 1].manufacturerName}`);
    currCardData.push(`Csatlakozás: ${conns[list[index].connectionType - 1].pConnectionName}`);
    let wireless = "";
    if (list[index].wireless == true)
    {
      wireless = "igen";
    }
    else
    {
      wireless = "nem";
    }
    currCardData.push(`Vezeték nélküli: ${wireless}`);
    currCardData.push(`Típus: ${type[list[index].keyboardType - 1].typeName}`);
    currCardData.push(`Nyelv: ${lang[list[index].layout - 1].layoutName}`);
    currCardData.push(`Méret: ${size[list[index].size - 1].sizeName}%`);
    currDropdown.innerHTML += await CreateSelectableCard(currCardData);
  }
  let a = currDropdown.getElementsByClassName("selectableOpt");
  for (let sg = 0; sg < a.length; sg++) {
    a[sg].addEventListener("click", function () {
      replaceButton(document.getElementsByClassName("selectOptions")[x], list[sg], x);
      CloseOverlaySelect();
    })
    
  }

  let filterDiv = document.getElementsByClassName("filterDiv")[0];
  let manufacturerOpts = "";
  thisManu.forEach(element => {
    manufacturerOpts += `<div class="filterOpt"><label><input type="checkbox">${element.manufacturerName}</label></div>`;
  });
  let connOpts = "";
  conns.forEach(element => {
    connOpts += `<div class="filterOpt"><label><input type="checkbox">${element.pConnectionName}</label></div>`;
  });
  let typeOpts = "";
  type.forEach(element => {
    typeOpts += `<div class="filterOpt"><label><input type="checkbox">${element.typeName}</label></div>`;
  });
  let langOpts = "";
  lang.forEach(element => {
    langOpts += `<div class="filterOpt"><label><input type="checkbox">${element.layoutName}</label></div>`;
  });
  let sizeOpts = "";
  size.forEach(element => {
    sizeOpts += `<div class="filterOpt"><label><input type="checkbox">${element.sizeName}%</label></div>`;
  });
  filterDiv.innerHTML += `<h3>Gyártók:</h3> ${manufacturerOpts} <h3>Csatlakozás:</h3> ${connOpts} <h3>Típus:</h3> ${typeOpts} <h3>Méret:</h3> ${sizeOpts}`;
}

async function CreateSelectableCard(dataList)
{
  let priceTxt = "";
  let count = 1;
  for (let index = dataList[1].length - 1; index >= 0; index--) {
    if (count % 3 == 0)
    {
      priceTxt += `${dataList[1][index]} `;
    }
    else
    {
      priceTxt += `${dataList[1][index]}`;
    }
    count++;
  }
  let newPriceTxt = [...priceTxt].reverse().join("");

  let attributes = ``;

  for (let attributeInd = 2; attributeInd < dataList.length; attributeInd++) {
    attributes += `<div class="anAttribute">${dataList[attributeInd]}</div>`;
  }

  let card = `<div class="selectableOpt">
    <div class="row">
      <h3 class="componentName">${dataList[0]}</h3>
      <p>${newPriceTxt} Ft</p>
    </div>
    <hr>
    <div class="attributesDiv row wrappable">${attributes}</div>
  </div>`;
  return card;
}

document.body.addEventListener('click', function( event ){
  event.stopPropagation();
  let myOverlay = document.getElementsByClassName("overlaySelect")[0];
  if( myOverlay.contains( event.target ) ){
  } 
  else {
    CloseOverlaySelect();
  }
});

function replaceButton(selectOpts, obj, x)
{
  selectOpts.style.display = "none";
  const selectedDiv = document.createElement("div");
  const text = document.createElement("p");
  text.appendChild(document.createTextNode(`${obj.name}`));
  const btnDiv = document.createElement("div");
  const txtDiv = document.createElement("div");
  const deleteBtn = document.createElement("input");
  deleteBtn.setAttribute("type", "button");
  deleteBtn.setAttribute("value", `Törlés`)
  btnDiv.setAttribute("class", "toLeftItem deleteItem");
  txtDiv.appendChild(text);
  txtDiv.setAttribute("class", "minWidthSet");
  btnDiv.appendChild(deleteBtn);
  selectedDiv.appendChild(txtDiv);
  selectedDiv.appendChild(btnDiv);
  selectedDiv.setAttribute("class", "rowDiv");
  selectOpts.parentElement.appendChild(selectedDiv);

  let cartElem = document.getElementsByClassName("cartElement")[x];

  cartElem.innerHTML = `<div class="minWidthSet">${obj.name}</div> <div class="toLeftItem">${obj.price} Ft</div>`;
  cartElem.style.display = "flex";

  deleteBtn.addEventListener("click", function () {
    ResetButton(x, selectOpts)
  })
}

function ResetButton(x, selectOpts)
{
  selectOpts.style.display = "block";
  let toRemove = selectOpts.parentElement.getElementsByClassName("rowDiv")[0];
  toRemove.remove();
  let cartElem = document.getElementsByClassName("cartElement")[x];
  cartElem.innerHTML = ``;
  cartElem.style.display = "none";
}