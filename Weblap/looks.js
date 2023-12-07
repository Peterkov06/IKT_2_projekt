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


function OpenDropDown(x)
{
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

window.onclick = function (event) {
  let myBox = document.getElementsByClassName('myDropdown');
  let elementIndex;

  for (let index = 0; index < myBox.length; index++) {
    if (myBox[index].classList.contains('show'))
    {
      elementIndex = index;
    }
  }

  if (event.target.contains(myBox[elementIndex]) && event.target !== myBox[elementIndex]) {
      console.log('You clicked outside the box!');
      document.getElementsByClassName("myDropdown")[elementIndex].classList.toggle("show", false);
  }
}