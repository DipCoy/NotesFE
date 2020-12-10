function delete_input() {
    if (this.parentElement.parentElement.parentElement.childElementCount > 3){
        this.parentElement.parentElement.remove();
    } else {
        alert("Необходимо указать хотя бы одну технологию, если таких нет, то поставить знак '-'");
    }
}

function add_btn(){
    let btn = document.getElementById("add_input");
    let c =  btn.parentElement.childNodes.length;
    btn.onclick = function () {
        let div = document.createElement("div");
<<<<<<< Updated upstream:NotesFE/Views/Boards/script.js
        div.className = "input-group input_instrument";
        let new_input = document.createElement("input");
        new_input.type = "text";
        new_input.className = "form-control";
        new_input.placeholder = "Инструмент";
        div.append(new_input);
        let div_2 = document.createElement("div");
        div_2.className = "input-group-prepend";
=======
        div.className = "w-25 p-3";
        div.id = "#draggable";
        let div2 = document.createElement("div");
        div2.className = "form-group";

        let textarea = document.createElement("textarea");
        textarea.className = "form-control";
        textarea.rows = 3;
        textarea.name = "stickersText";

        div2.append(textarea);
        div.append(div2);

>>>>>>> Stashed changes:NotesFE/wwwroot/js/script.js
        let b = document.createElement("button");
        b.className = "btn btn-outline-secondary btn-danger";
        b.type = "button";
        b.id = "button-addon" + c;
        b.innerText = "-";
        b.setAttribute("onclick", "delete_input.apply(this)");
        div_2.append(b);
        div.append(div_2);
        btn.before(div);
    }
}