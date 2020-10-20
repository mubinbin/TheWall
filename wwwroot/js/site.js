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
    $.ajax({
        type:"POST",
        url: form.action,
        data: new FormData(form),
        contentType: false,
        processData: false,
        success: function(response){
            if(!response.successful)
            {
                $("#form-modal .modal-body").html(response.renderPage);

            }else{
                $("#show-message").html(response.renderPage);
                $('#form-modal .modal-body').html('');
                $('#form-modal .modal-title').html('');
                $('#form-modal').modal('hide');
            }
        }
    });

    return false;
}

del = (form, title) =>
{
    if(confirm(`Are you sure to delete this ${title}?`))
    {
        // console.log(form);
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function(response){
                console.log(response);
                $("#show-message").html(response.renderPage);
            },
            error: function(err){
                console.log(err);
            }
        });
    }
    return false;
}