//By using the children property
let res = document.querySelector("#result");

function gfg_F(){
    parent = document.getElementById('parent');
            children = parent.children[0];
            res.innerHTML = "Text of child node is - '" +
                children.innerHTML + "'";
}