$(() => {
    LoadData();

    const connection = new signalR.HubConnectionBuilder().withUrl("/signalrServer").build();
    connection.start();

    connection.on("LoadProducts", function () {
        LoadData();
    });

    LoadData();

    function LoadData() {
        let tr = "";

        $.ajax({
            url: "/Products/GetProducts",
            method: "GET",
            success: (result) => {
                $.each(result, (k, v) => {
                    tr += `<tr>
                               <td>${v.prodName}</td>
                               <td>${v.category}</td>
                               <td>${v.unitPrice}</td>
                               <td>${v.stockQty}</td>
                    
                               <td>
                                   <a href='../Products/Edit?id=${v.id}'>Edit</a> | 
                                   <a href='../Products/Details?id=${v.id}'>Details</a> | 
                                   <a href='../Products/Delete?id=${v.id}'>Delete</a>
                               </td>
                           </tr>`;
                });
                $("#tableBody").html(tr);
            },
            error: (err) => {
                console.log(err);
            },
        });
    }
});
