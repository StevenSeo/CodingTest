///<reference path="~/Scripts/jquery-1.10.2.js"/>

$('#addrow').click(function () {
    
    var table = document.getElementById("myTable");    
    var row = table.insertRow();    
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);    
    cell1.innerHTML = table.rows.length - 1;
    cell2.innerHTML = new Date().toString('dd-MMM-yyyy');

    
});