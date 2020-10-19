// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showModal(url, title)
{
    $.ajax({
        type:"GET",
        url: url,
        success: function(response){
            $("#form-modal .modal-title").html(title);
            $("#form-modal .modal-body").html(response);
            $("#form-modal").modal();
        }
    });
}

mespost = form =>
{
    console.log(form.action);
    $.ajax({
        type:"POST",
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function(response){
            console.log(response);
            if(!response.successful)
            {
                $("#form-modal .modal-body").html(response.renderPage);

            }else{
                $("#show-message").html(response.html);
                $('#form-modal .modal-body').html('');
                $('#form-modal .modal-title').html('');
                $('#form-modal').modal('hide');
                // location.reload();
            }
        }
    });

    return false;
}