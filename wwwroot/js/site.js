
function ShowHideSideBar() {
    let sideBar = document.getElementById("sideBar");
    if (sideBar.style.visibility === "visible") {
        sideBar.style.visibility = "hidden";
        sideBar.style.width = 0;
    } else  {
        sideBar.style.visibility = "visible";
        sideBar.style.width = "17%";
    }
}