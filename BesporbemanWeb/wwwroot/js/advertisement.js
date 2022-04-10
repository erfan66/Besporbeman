var dataTable;
$(document).ready(function () {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/Advertise",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "title", "width": "25%" },
            { "data": "kind.type", "width": "15%" },
            { "data": "material.title", "width": "15%" },
            { "data": "weight", "width": "15%" },
            { "data": "dateOfAdvertise", "width": "15%" },
            { "data": "status", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="w-75 btn-group" >
                            <a href="/Admin/Advertisement/upsert?id=${data}"  class="btn btn-success text-white mx-2">
                            <i class="bi bi-pencil-square"></i>  </a>
                            <a onClick=Delete('/api/Advertisement/'+${data})  class="btn btn-danger text-white mx-2">
                             <i class="bi bi-trash-fill"></i>  </a>
                            </div>`
                },

                "width": "15%"
            }
        ],
        "width": "100%"
    });
});


function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })

}