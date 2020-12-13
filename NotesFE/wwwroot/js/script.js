window.onload = function(){
    add_btn();
}

function delete_input() {
    if (this.parentElement.parentElement.parentElement.childElementCount > 1){
        this.parentElement.parentElement.remove();
    } else {
        alert("Необходимо указать хотя бы одну технологию, если таких нет, то поставить знак '-'");
    }
}

function select_users_access(radio){
    if(radio.value === "Private") {
        let textarea = document.getElementById("AccessedUsers");
        if (textarea != null){
            return;
        }
        let rb = document.getElementById("privateRB");
        textarea = document.createElement("textarea");
        textarea.id = "AccessedUsers"
        textarea.className = "form-control";
        textarea.rows = 3;
        textarea.name = "AccessedUsers";
        rb.before(textarea);   
    }
    else {
        let textarea = document.getElementById("AccessedUsers");
        if (textarea != null) {
            textarea.remove();
        }
    }
}

function add_btn(){
    let btn = document.getElementById("add_input");
    let c =  btn.parentElement.childNodes.length;
    btn.onclick = function () {
        let div = document.createElement("div");
        div.className = "w-25 p-3";
        let div2 = document.createElement("div");
        div2.className = "form-group";

        let textarea = document.createElement("textarea");
        textarea.className = "form-control";
        textarea.rows = 3;
        textarea.name = "StickersText";
        alert(textarea.name);

        div2.append(textarea);
        div.append(div2);

        let b = document.createElement("button");
        b.className = "btn btn-outline-secondary btn-danger";
        b.type = "button";
        b.id = "button-addon" + c;
        b.innerText = "-";
        b.setAttribute("onclick", "delete_input.apply(this)");
        div2.append(b);
        btn.before(div);
    }
}