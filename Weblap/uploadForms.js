import { UploadCPU, GetPreset, UploadMotherBoard, UploadRAM, UploadGPU, UploadStorage, UploadMonitor, UploadMouse, UploadKeyboard } from "./apiCalls.js";

document.getElementById("productType").addEventListener("change", function() {ChosenType(this.value);})

async function ChosenType(type)
{
  let div = document.getElementById("formPlace");
  let btnDiv = document.getElementById("sendBtn");
  if(type != "choose")
  {
    div.innerHTML = '';
    btnDiv.innerHTML = `<input type="button" value="Feltöltés" id="uploadData">`;
    div.innerHTML += `<div class="uploadItem"><label for="name">Termék neve: </label> <input type="text" name="name" id="name"></div> <div class="uploadItem"><label for="manufacturer">Gyártó: </label> <input type="text" name="manufacturer" id="manufacturer"></div> <div class="uploadItem"><label for="price">Termék ára: </label> <input type="number" name="price" id="price"></div>`;
    switch (type) {
      case "CPU":
        div.innerHTML += `<div class="uploadItem"><label for="socket">CPU foglalat: </label> <input type="text" name="socket" id="socket"></div> <div class="uploadItem"><label for="maxram">Maximális támogatott memória: </label> <input type="number" name="maxram" id="maxram"></div> <div class="uploadItem"><label for="ddrtype">Támogatott DDR típus: </label> <input type="text" name="ddrtype" id="ddrtype"></div> <div class="uploadItem"><label for="corenum">Magok száma: </label> <input type="number" name="corenum" id="corenum"></div> <div class="uploadItem"><label for="threadnum">Szálak száma: </label> <input type="number" name="threadnum" id="threadnum"></div> <div class="uploadItem"><label for="clockspeed">Alap órajel: </label> <input type="number" name="clockspeed" id="clockspeed"></div> <div class="uploadItem"><label for="turboclockspeed">Turbo órajel: </label> <input type="number" name="turboclockspeed" id="turboclockspeed"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadCPU);
        break;
      case "Motherboard":
        div.innerHTML += `<div class="uploadItem"><label for="ramSlotNum">Memóriafoglalatok száma: </label> <input type="number" name="ramSlotNum" id="ramSlotNum"></div> <div class="uploadItem"><label for="socket">CPU foglalat: </label> <input type="text" name="socket" id="socket"></div> <div class="uploadItem"><label for="sataNum">SATA csatlakozók száma: </label> <input type="number" name="sataNum" id="sataNum"></div> <div class="uploadItem"><label for="m2Num">M.2 csatlakozók száma száma: </label> <input type="number" name="m2Num" id="m2Num"></div> <div class="uploadItem"><label for="PCIeNum">PCIe foglalatok száma: </label> <input type="number" name="PCIeNum" id="PCIeNum"></div> <div class="uploadItem"><label for="ddrtype">Támogatott DDR típus: </label> <input type="text" name="ddrtype" id="ddrtype"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadMotherBoard);
        break;
      case "RAM":
        let overclockTypeList = await GetPreset('overclockType');
        let optionsGen = ``;
        overclockTypeList.forEach(element => {
          optionsGen += `<option value="${element.overclockPresetID}">${element.name}</option>`;
        });
        div.innerHTML += `<div class="uploadItem"><label for="ddrtype">Támogatott DDR típus: </label> <input type="text" name="ddrtype" id="ddrtype"></div> <div class="uploadItem"><label for="size">RAM mérete (GB): </label> <input type="number" name="size" id="size"></div> <div class="uploadItem"><label for="clockspeed">Memória órajel: </label> <input type="number" name="clockspeed" id="clockspeed"></div> <div class="uploadItem"><label for="kitNum">Memória káryták száma: </label> <input type="number" name="kitNum" id="kitNum"></div> <div class="uploadItem"><label for="overclockType">Overclock típus: </label><select name="overclockType" id="overclockType">`+ optionsGen +`</select> </div>`;
        document.getElementById("uploadData").addEventListener("click", UploadRAM);
        break;
      case "GPU":
        div.innerHTML += `<div class="uploadItem"><label for="gddrtype">GDDR típus: </label> <input type="text" name="gddrtype" id="gddrtype"></div> <div class="uploadItem"><label for="size">VRAM mérete (GB): </label> <input type="number" name="size" id="size"></div> <div class="uploadItem"><label for="corenum">Magok száma: </label> <input type="number" name="corenum" id="corenum"></div> <div class="uploadItem"><label for="clockspeed">GPU alap órajel: </label> <input type="number" name="clockspeed" id="clockspeed"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadGPU);
        break;
      case "Storage":
        let storageTypeList = await GetPreset('storageType');
        let storageTypeGen = ``;
        storageTypeList.forEach(element => {
          storageTypeGen += `<option value="${element.storageTypeID}">${element.storageTypeName}</option>`;
        });

        let storageConnectionTypeList = await GetPreset('storageConnectionType');
        let storageConnectionTypeGen = ``;
        storageConnectionTypeList.forEach(element => {
          storageConnectionTypeGen += `<option value="${element.storageConnectionID}">${element.storageConnectionName}</option>`;
        });
        div.innerHTML += `<div class="uploadItem"><label for="storageType">Háttértár típusa: </label><select name="storageType" id="storageType">`+ storageTypeGen +`</select> </div> <div class="uploadItem"><label for="readSpeed">Olvasási sebesség: (MB/s): </label> <input type="number" name="readSpeed" id="readSpeed"></div> <div class="uploadItem"><label for="writeSpeed">Írási sebesség: (MB/s): </label> <input type="number" name="writeSpeed" id="writeSpeed"></div><div class="uploadItem"><label for="connectionType">Csatlakozó típusa: </label><select name="connectionType" id="connectionType">`+ storageConnectionTypeGen +`</select> </div> <div class="uploadItem"><label for="size">Háttértár mérete (GB): </label> <input type="number" name="size" id="size"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadStorage);
        break;
      case "Monitor":
        div.innerHTML += `<div class="uploadItem"><label for="diagonalSize">Átlós méret (inch): </label> <input type="text" name="diagonalSize" id="diagonalSize"></div> <div class="uploadItem"><label for="Xsize">Horizontális pixelszám (px): </label> <input type="number" name="Xsize" id="Xsize"></div> <div class="uploadItem"><label for="Ysize">Vertikális pixepszám (px): </label> <input type="number" name="Ysize" id="Ysize"></div> <div class="uploadItem"><label for="panelType">Panel típusa: </label><input type="text" name="panelType" id="panelType"></div></div> <div class="uploadItem"><label for="color">Színhelyesség (DCI-P3): </label> <input type="number" name="color" id="color"></div> <div class="uploadItem"><label for="brightness">Fényerősség (nit): </label> <input type="number" name="brightness" id="brightness"></div> <div class="uploadItem"><label for="dynContrast">Dinamikus kontraszt (x:1): </label> <input type="number" name="dynContrast" id="dynContrast"></div> <div class="uploadItem"><label for="statContrast">Statikus kontraszt (x:1): </label> <input type="number" name="statContrast" id="statContrast"></div> <div class="uploadItem"><label for="refreshRate">Frisssítési ráta (hz): </label> <input type="number" name="refreshRate" id="refreshRate"></div> <div class="uploadItem"><label for="refreshType">Frissítési technológia típusa: </label> <input type="text" name="refreshType" id="refreshType"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadMonitor);
        break;
      case "Mouse":
        div.innerHTML += `<div class="uploadItem"><label for="connectionType">Csatlakozási típus: </label> <input type="text" name="connectionType" id="connectionType"></div> <div class="uploadItem"><label for="isWireless">Vezeték nélküli-e (1-nem, 2-igen): </label><input type="number" name="isWireless" id="isWireless"></div> <div class="uploadItem"><label for="dpi">DPI: </label> <input type="number" name="dpi" id="dpi"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadMouse);
        break;
      case "Keyboard":
        div.innerHTML += `<div class="uploadItem"><label for="connectionType">Csatlakozási típus: </label> <input type="text" name="connectionType" id="connectionType"></div> <div class="uploadItem"><label for="isWireless">Vezeték nélküli-e (1-nem, 2-igen): </label><input type="number" name="isWireless" id="isWireless"></div> <div class="uploadItem"><label for="keyboardType">Típusa (membrán vagy mechanikus): </label> <input type="text" name="keyboardType" id="keyboardType"></div> <div class="uploadItem"><label for="layout">Nyelv: </label> <input type="text" name="layout" id="layout"></div> <div class="uploadItem"><label for="size">Méret (%): </label> <input type="number" name="size" id="size"></div>`;
        document.getElementById("uploadData").addEventListener("click", UploadKeyboard);
        break;
      default:
        break;
    }
    div.innerHTML += `<div class="uploadItem"><label for="stock">Készlet: </label> <input type="number" name="stock" id="stock"></div>`;
  }
  else
  {
    div.innerHTML = '';
    btnDiv.innerHTML  = '';
  }
  
}