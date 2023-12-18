const apiURL = 'http://peterdevserver.ddns.net:8080/api/';
const outpuEl = document.getElementById("testout");

function GetDataFromDB()
{
  fetch(apiURL)
.then(response => {
  if (!response.ok)
  {
    console.log("Error in getting data");
  }
  return response.json();
})
.then(data => {
  console.log(data);
  data.forEach(element => {
    outpuEl.innerHTML += `${element.id}. ${element.name}: ${element.description} <br>`;
  });
})
.catch(error => {console.error("Cant get data");})
}

function SendDataToDB()
{
  let name = document.getElementById("name").value;
  let description = document.getElementById("description").value;
  fetch(apiURL, 
    {
      method: "POST",
      body: JSON.stringify(
        {
          id: 0,
          name: name,
          description: description
        }),
        headers: {"Content-type": "application/json; charset=UTF-8"}
    }
  )

  .then(response => response.json())
  .then(json)
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
  .then(json)
}
async function GetCPU()
{
  const response = await fetch(apiURL +'CPU')

  if (!response.ok)
  {
    console.log("Error in getting data");
    return;
  }

  const data = await response.json()
  return data;

}

export {GetCPU};