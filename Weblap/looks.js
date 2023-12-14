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

let filterTabOn = false;

function OpenDropDown(x, event)
{
  event.stopPropagation();
  document.getElementsByClassName("myDropdown")[x].classList.toggle("show");
}

function FilterSearch(x)
{
  div = document.getElementsByClassName("myDropdown")[x];
  let input = div.getElementsByClassName("myInput")[0];
  let filter = input.value.toUpperCase();
  let a = div.getElementsByTagName("a");
  for (let index = 0; index < a.length; index++) {
    txtValue = a[index].innerText;
    if (txtValue.toUpperCase().indexOf(filter) > -1) {
      a[index].style.display = "";
    } else {
      a[index].style.display = "none";
    }
  }
}

document.body.addEventListener('click', function( event ){
  if (filterTabOn == false)
  {
      let myBox = document.getElementsByClassName('myDropdown');  
    let elementIndex;

      for (let index = 0; index < myBox.length; index++) {
        if (myBox[index].classList.contains('show'))
        {
          elementIndex = index;
        }
      }
    if (elementIndex != undefined && myBox[elementIndex].classList.contains("show"))
    {
      if( myBox[elementIndex].contains( event.target ) ){
      } 
      else {
        document.getElementsByClassName("myDropdown")[elementIndex].classList.toggle("show", false);
      }
    }
  }
});

function openNav(event) {
  event.stopPropagation();
  filterTabOn = true;
  document.getElementsByClassName("filterTab")[0].style.width = "400px";
  document.getElementById("overlay").style.display = "block";
}

function closeNav(event) {
  event.stopPropagation();
  filterTabOn = false;
  document.getElementsByClassName("filterTab")[0].style.width = "0";
  document.getElementById("overlay").style.display = "none";
}