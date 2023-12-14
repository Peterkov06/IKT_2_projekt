const apiURL = 'http://192.168.1.123:8080/api/Test';
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