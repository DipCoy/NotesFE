function add_btn_time(){
    let table = document.createElement("table");
    let thead = document.createElement("thead");
    let static_tr = document.createElement("tr");
    let static_th = document.createElement("th")
    static_th.scope="col"
    static_th = "#";
    static_th = "Lecture";
    static_th = "Time";
    static_tr.append(static_th);
    thead.append(static_tr);
    table.append(thead);
}