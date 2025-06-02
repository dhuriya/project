const menuButtons = document.querySelectorAll(".menu-button");
const screenOverlay = document.querySelector(".main-layout .screen-overlay");
const themeButton = document.querySelector(".navbar .theme-button i");
const searchButton = document.querySelector("#search-button");
const searchBackButton = document.querySelector("#search-back-button");
// Toggle sidebar visibility when menu buttons are clicked
menuButtons.forEach((button) => {
    button.addEventListener("click", () =>{
        document.body.classList.toggle("sidebar-hidden");
    });
});
// Toggle sidebar visibility when screen overlay is clicked
screenOverlay.addEventListener("click", () => {
    document.body.classList.toggle("sidebar-hidden");
  });
//Initialize dark mode based on localStorage
if(localStorage.getItem("darkmode") === "enabled"){
    document.body.classList.add("dark-mode");
    themeButton.classList.replace("uil-moon","uil-sun");
}else{
    themeButton.classList.replace("uil-sun","uil-moon");
}
// Toggle dark mode when theme button is clicked
themeButton.addEventListener("click", () => {
    document.body.classList.toggle("darkmode",isDarkMode ? "enabled":"disabled");
    themeButton.classList.toggle("uil-sun",isDarkMode);
    themeButton.classList.toggle("uil-moon",!isDarkMode);
});
//Show sidebar on large screens by default
if(window.innerWidth>=768){
    document.body.classList.remove("sidebar-hidden");
}
//Toggle search bar on click on mobile
const toggleSearchbar = () => {
    document.body.classList.toggle("show-mobile-search");
};
searchBackButton.addEventListener("click",toggleSearchbar);
searchBackButton.addEventListener("click", () => searchButton.click());