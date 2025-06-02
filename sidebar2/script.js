// Toggle the visibility of a dropdown menu
const toggleDropdown = (dropdown,menu,isOpen) =>{
    dropdown.classList.toggle("open",isOpen);
    menu.style.height = isOpen ? `${menu.scrollHeight}px` : 0;
};
// Close all open dropdwons
const closeAllDropdwons = () => {
    document.querySelectorAll(".dropdown-container .open").forEach((openDropdown) => {
        toggleDropdown(openDropdown,openDropdown.querySelector(".dropdown-menu"),false);
    });
};
//Attach click event to all dorpdown toggels
document.querySelectorAll(".dropdown-toggle").forEach((dropdownToggle) => {
    dropdownToggle.addEventListener("click", (e) => {
        e.preventDefault();
        const dropdown = dropdownToggle.closest(".dropdown-container");
        const menu = dropdown.querySelector(".dropdown-menu");
        const isOpen = dropdown.classList.contains("open");
        closeAllDropdwons();//close all open dropdowns
        toggleDropdown(dropdown,menu,!isOpen);// toggle current dropdown visibility
    });
});
//Attach click event to to sidebar toggle buttons
document.querySelectorAll(".sidebar-toggle, .sidebar-menu-button").forEach((buttons) => {
    console.log(buttons);
    buttons.addEventListener("click", () => {
        closeAllDropdwons();// close all open dropdown
        document.querySelector(".sidebar").classList.toggle("collapsed");
    });
});
/// Collapse sidebar by default or small screens
if(window.innerWidth <= 1024){
    document.querySelector(".sidebar").classList.add("collapsed");
}