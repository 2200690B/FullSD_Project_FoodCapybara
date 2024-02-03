
//adding table
function AddDataTable(table) {
    $(document).ready(function () {
        $(table).DataTable();
    })
}

//disposing table
function DataTablesDispose(table) {
    $(document).ready(function () {
        $(table).DataTable().destroy();
        var element = document.querySelector(table + '_wrapper');
        element.parentNode.removeChild(element);
    })
} 