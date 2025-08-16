const copyButton = document.querySelector(".copy-button");
const copyText = document.querySelector(".copy-text");
copyButton.addEventListener("click",()=>{
    debugger;
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
    copyButton.classList.toggle("success");
    copyButton.innerHTML = "Copied!";
    setTimeout(() => {
        copyButton.classList.toggle("success");
        copyButton.innerHTML="Copy";
    }, 2000);
});