function setSearchDescription(text, list) {
    var elemetsByClass = document.getElementsByClassName(text);
    if (elemetsByClass.length > 0) {
        var firstElementChildren = elemetsByClass[0].children; 

        for (let i = 0; i < firstElementChildren.length; i++) {

            let childChildren = firstElementChildren[i].children; 

            if (childChildren.length > 1) {
                firstElementChildren[i].removeChild(childChildren[1]);
            }

            let textnode = document.createElement("h6");
            textnode.appendChild(document.createTextNode(list[i]));
            textnode.style.fontStyle = "italic";
            textnode.style.color = "gray";

            firstElementChildren[i].appendChild(textnode);
        }
    }
}