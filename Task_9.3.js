select.addEventListener("click", selectItem);
selectAll.addEventListener("click", selectAllItems);
diselect.addEventListener("click", diselectItem);
diselectAll.addEventListener("click", diselectAllItems);
var available = document.getElementById("left");
var selected = document.getElementById("right");
function selectItem(){
    var chosen = available.selectedOptions;
    if (chosen.length===0) {
        window.alert("You must first select an item on the left side.")
    } 
    else {
        while (chosen.length!=0){
            for(var i=0; i<chosen.length;i++){
                var newOption = available.removeChild(chosen[i]);
                selected.appendChild(newOption);
            }
        }
    }
}
function selectAllItems(){
    var chosen = available.options;
    if (chosen.length===0) {
        window.alert("You must first select an item on the left side.")
    } 
    else {
        while (chosen.length!=0){
            for(var i=0; i<chosen.length;i++){
                var newOption = available.removeChild(chosen[i]);
                selected.appendChild(newOption);
            }
        }
    }
}
function diselectAllItems(){
    var chosen = selected.options;
    if (chosen == -1) {
        window.alert("You must first select an item on the right side.")
    } 
    else {
        while (chosen.length!=0){
            for(var i=0; i<chosen.length;i++){
                var newOption = selected.removeChild(chosen[i]);
                available.appendChild(newOption);
            }
        }
    }
}
function diselectItem(){
    var chosen = selected.selectedOptions;
    if (chosen == -1) {
        window.alert("You must first select an item on the right side.")
    } 
    else {
        while (chosen.length!=0){
            for(var i=0; i<chosen.length;i++){
                var newOption = selected.removeChild(chosen[i]);
                available.appendChild(newOption);
            }
        }
    }
}
