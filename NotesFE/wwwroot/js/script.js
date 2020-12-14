let count = 0

window.onload = function(){
    add_btn();
}

function delete_input() {
    if (this.parentElement.parentElement.parentElement.childElementCount > 1){
        this.parentElement.parentElement.remove();
        count -= 1
    } else {
        
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
        textarea.name = "boardModel.AccessedUsers";
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


function create_col(text){
    let th = document.createElement("th");
    th.scope="col";
    let text1 = document.createTextNode(text);
    th.appendChild(text1);
    return th;
}

function add_btn_table(){
    let btn = document.getElementById("add_table");
    let c = btn.parentElement.childNodes.length;
    btn.onclick = function () {
        let div = document.createElement("div");
        let div2 = document.createElement("div");
        div2.className = "w-50";
        let table = document.createElement("table");
        table.className = "table";
        let thead = document.createElement("thead");
        let tr = document.createElement("tr");
        tr.appendChild(create_col("#"));
        tr.appendChild(create_col("Время"));
        tr.appendChild(create_col("Предмет"));
        thead.appendChild(tr);
        table.appendChild(thead);
        //--------------------------------------------//
        let tbody = document.createElement("tbody");
        for (let i = 0; i < 6; i++){
            let tr1 = document.createElement("tr");
            let th = document.createElement("th");
            th.scope="row"
            let text = document.createTextNode(String(i + 1));
            th.appendChild(text);
            tr1.appendChild(th);
            for (let j = 0; j < 2; j++){
                let td = document.createElement('td');
                let input = document.createElement("input");
                input.type = "text";
                input.className = "form-control";
                input.name = "boardModel.Content.Stickers[" + count + "].Content.TimeTable[" + i + "][" + j + "]" ;
                td.appendChild(input);
                tr1.appendChild(td);
            }
            tbody.appendChild(tr1);
        }
        count += 1
        // alert(count)
        table.appendChild(tbody);
        div2.appendChild(table);
        div.append(div2);
        //-----------------------------------------------//
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