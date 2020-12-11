let count = 0

window.onload = function(){
    add_btn();
}

function delete_input() {
    if (this.parentElement.parentElement.parentElement.childElementCount > 1){
        this.parentElement.parentElement.remove();
        count -= 1
    } else {
        alert("Необходимо указать хотя бы одну технологию, если таких нет, то поставить знак '-'");
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
        textarea.name = "boardModel.Content.Stickers[" + count + "].Content.Text";
        count += 1
        // alert(count)

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